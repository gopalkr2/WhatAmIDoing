using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Outlook; 


namespace WhatAmIDoing.Model.OS_Helpers
{
    class OutlookHelper
    {
        public static void getCalendarList()
        {
            Application app = null;
            _NameSpace ns = null;
            MAPIFolder calendarFolder = null;
            
            try 
            {
              app = new Microsoft.Office.Interop.Outlook.Application();
              ns = app.GetNamespace("MAPI");
             // ns.Logon(null,null,false, false);

              calendarFolder = ns.GetDefaultFolder(Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderCalendar);

              DateTime today = DateTime.Today, tomorrow = today.AddDays(1);
              const string DateFormat = "dd/MM/yyyy HH:mm";
               string filter = string.Format("[Start] >= '{0}' AND [Start] < '{1}'", today.ToString(DateFormat), tomorrow.ToString(DateFormat));
               var todaysAppointments = calendarFolder.Items.Restrict(filter);
               todaysAppointments.IncludeRecurrences = true;
               todaysAppointments.Sort("[Start]");
    
              int TotalDurationInMinutes = 0;
                int acceptedDurationInMinutes = 0;
                int tentativeDurationInMinutes = 0;
                int numberOfInvites = todaysAppointments.Count;
                int acceptedInvites = 0;
                int tentativeInvites = 0;
              foreach (Microsoft.Office.Interop.Outlook.AppointmentItem item in todaysAppointments)
              {
                  TotalDurationInMinutes += item.Duration;

                  int responsestatus = 0;
                  if (int.TryParse(item.ResponseStatus.ToString(), out responsestatus))
                  {
                      if (responsestatus == 1 || responsestatus == 3)
                      {
                          acceptedInvites++;
                          acceptedDurationInMinutes += item.Duration;

                      }
                      else if (responsestatus == 2)
                      {
                          tentativeInvites++;
                          tentativeDurationInMinutes += item.Duration;
                      }
                  }
              }
             
            } 
            catch (System.Runtime.InteropServices.COMException ex) 
            {
              Console.WriteLine(ex.ToString());
            }
            finally
            {
              ns = null;
              app = null;
              calendarFolder = null;
            }

         }
      }
}
