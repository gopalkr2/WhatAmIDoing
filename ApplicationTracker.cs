using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Collections;
using WhatAmIDoing.Model.OS_Helpers;

namespace WhatAmIDoing.Model
{
    class ApplicationTracker: IDisposable
    {
        private int intervalSeconds;
        private String foregroundApplicationName = String.Empty;
        private DateTime applicationStartTime = DateTime.Now;

        private SortedDictionary<String, ApplicationProcess> applications = new SortedDictionary<string, ApplicationProcess>();
        
        public long SessionLockedTime
        {
            get
            {
                return WindowsHelper.SessionLockedTime;
            }
        }

        public long SessionActiveTime
        {
            get
            {
                return WindowsHelper.SessionActiveTime;
            }
        }


        public String ApplicationStartTime
        {
            get
            {
                return applicationStartTime.ToShortDateString() + "      " + applicationStartTime.ToShortTimeString();
            }
        }

        public String ApplicationTotalTime
        {
            get
            {
                TimeSpan difference = DateTime.Now - applicationStartTime;
                return String.Format("{0}:{1}:{2}", difference.Hours, difference.Minutes, difference.Seconds);
            }
        }


        public List<ApplicationProcess> GetApplications()
        {
            lock (this)
            {
                //using -ve to sort in descending order
                //TODO, need to check mode and then sort by that column (daily vs lifetime)
                return applications.Values.ToList<ApplicationProcess>().OrderBy(temp => -temp.ActiveTimeLifeTimeLong).ToList<ApplicationProcess>();
            }
        }

        public ApplicationTracker (int intervalSeconds)
        {
            this.intervalSeconds = intervalSeconds;
        }

        public void Run()
        {
           while(true)
           {
               AutoResetEvent timer = new AutoResetEvent(false);
               updateApplications();
               Thread.Sleep(intervalSeconds * 1000);
           }
        }
        
        private void updateApplications()
        {
            lock (this)
            {
                if (!WindowsHelper.IsSessionLocked())
                {
                    Process process = WindowsHelper.Instance.GetActiveProcess();
                    if (applications.ContainsKey(process.ProcessName))
                    {
                        ApplicationProcess appProcess = applications[process.ProcessName];
                        appProcess.ActiveTimeLifeTimeLong = applications[process.ProcessName].ActiveTimeLifeTimeLong;
                        appProcess.Increment(intervalSeconds);
                        appProcess.Process = process;
                    }
                    else
                    {
                        ApplicationProcess appProcess = new ApplicationProcess(process);
                        appProcess.Increment(intervalSeconds);
                        //add the process
                        applications.Add(process.ProcessName, appProcess);
                    }
                }
            }
        }

        private void getActiveProcessName()
        {
            String activeProcess = WindowsHelper.Instance.GetActiveProcessName();
            
        }

        public void Dispose()
        {
        }
    }
}
