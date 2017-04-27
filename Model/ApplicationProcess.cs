using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Collections;

namespace WhatAmIDoing.Model
{
    class ApplicationProcess
    {
        private long activeTimeLifeTime;
        
        private Process process;

        
        //TODO need to catch the exception. Process can throw exception. True for all places where process is accessed.
        public bool IsAlive
        {
            get
            {
                bool ret = false;
                try
                {
                    ret = !process.HasExited;
                }
                //TODO, OMG do somthing. dont leave this empty !
                catch (Exception ex)
                {
                }
                finally
                {
                }

                return ret;
            }
        }

        public String ApplicationName
        {
            get
            {
                return process.ProcessName;
            }
        }

      

        public string VirtualMemoryMB
        {
            get
            {
                return (Math.Floor((double)process.VirtualMemorySize64 / (1024 * 1024))).ToString();
            }
        }

        //TODO, should be using TimeSpan or DateTime for calculations. This is dirty !!
        public String ActiveTime
        {
            get
            {
                return StringHelper.FormatTime(activeTimeLifeTime) ;
            }
        }

        public long ActiveTimeLifeTimeLong
        {
            get 
            { 
                return activeTimeLifeTime;
            }
            set
            {
                activeTimeLifeTime = value;
            }
        }

       
        public void Increment(int milliseconds)
        {
            activeTimeLifeTime += milliseconds;
        }

        public ApplicationProcess(Process process)
        {
            this.process = process;
        }
        
        public Process Process
        {
            get { return process; }
            set { process = value; }
        }
    }
}
