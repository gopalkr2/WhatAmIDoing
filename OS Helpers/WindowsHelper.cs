using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;


namespace WhatAmIDoing.Model
{

   //TODO Singleton implementation is incorrect and messed up, to be fixed. 
   public class WindowsHelper
    {
       private static Boolean isSessionLocked = false;
       private static WindowsSessionTracker session;
       private static WindowsHelper instance = new WindowsHelper();
       

       private static long sessionLockTimeInSeconds = 0;
       private static long sessionActiveTimeInSeconds = 0;
       
       [DllImport("user32.dll")]
       public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);

       [DllImport("user32.dll")]
       private static extern IntPtr GetForegroundWindow();

       public static long SessionActiveTime
       {
           get
           {
               return sessionActiveTimeInSeconds;
           }
       }

       public static long SessionLockedTime
       {
           get
           {
               return sessionLockTimeInSeconds;
           }
       }
       
       public static WindowsHelper Instance
       {
           get{ return instance;}

       }

       private WindowsHelper()
       {
           session = new WindowsSessionTracker();

           Thread sessionThread = new Thread(new ThreadStart(session.Run));
           sessionThread.Start();
       }

       public static bool IsSessionLocked()
       {
           return isSessionLocked;
       }


       public Process GetActiveProcess()
       {
           IntPtr hwnd = GetForegroundWindow();
           uint pid;
           GetWindowThreadProcessId(hwnd, out pid);
           Process p = Process.GetProcessById((int)pid);
           return p;
       }

       public string GetActiveProcessName()
       {
           IntPtr hwnd = GetForegroundWindow();
           uint pid;
           GetWindowThreadProcessId(hwnd, out pid);
           Process p = Process.GetProcessById((int)pid);
           return p.ProcessName;
       }
       

       private class WindowsSessionTracker: IDisposable
       {
           private  SessionSwitchEventHandler sessionStateChangedHandler;
           //timer per second. Perhaps this should be configurable. Do we really need this every second ?
           private System.Timers.Timer sessionLockTimer = new System.Timers.Timer(1000);
           private System.Timers.Timer sessionActiveTimer = new System.Timers.Timer(1000);

           void OnStatusChanged(object sender, SessionSwitchEventArgs e)
           {
               switch (e.Reason)
               {
                   case SessionSwitchReason.SessionLock: 
                       isSessionLocked = true;
                       sessionActiveTimer.Stop();
                       sessionLockTimer.Start();
                       break;
                   case SessionSwitchReason.SessionUnlock: 
                       isSessionLocked = false; 
                       sessionActiveTimer.Start();
                       sessionLockTimer.Stop();
                       break;
               }
           }

           public void CheckStatus(Object stateInfo) { }

           public void Run()
           {

               sessionActiveTimer.Elapsed += new System.Timers.ElapsedEventHandler(sessionActiveTime_Elapsed);
               sessionLockTimer.Elapsed += new System.Timers.ElapsedEventHandler(sessionLockTime_Elapsed);

               sessionActiveTimer.Start();

               
               sessionStateChangedHandler = new SessionSwitchEventHandler(OnStatusChanged);
               SystemEvents.SessionSwitch += sessionStateChangedHandler;
           }

           void sessionLockTime_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
           {
               sessionLockTimeInSeconds += 1;
           }

           void sessionActiveTime_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
           {
               sessionActiveTimeInSeconds += 1;
           }

           public void Dispose()
           {
               SystemEvents.SessionSwitch -= sessionStateChangedHandler;
           }
       }      
    }
}
