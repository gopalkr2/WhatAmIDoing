using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;

namespace WhatAmIDoing.Model
{
    public partial class Form1 : Form
    {

        private BindingSource bs = new BindingSource();
        
        public Form1()
        {
            InitializeComponent();
        }

        delegate void ApplicationProcessVoidDelegate(List<ApplicationProcess> processes);

        private ApplicationTracker tracker = new ApplicationTracker(1);

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_startTime.Text = tracker.ApplicationStartTime;
            new Thread(new ThreadStart(update)).Start();
        }

        
        private void update()
        {
            //Note we have 2 threads created successfully, not useful yet but the idea is that in the future the tracker thread and the update thread will run at different speeds
            new Thread(new ThreadStart(tracker.Run)).Start();

            AutoResetEvent e = new AutoResetEvent(false);

            while (true)
            {
              List<ApplicationProcess> processes = tracker.GetApplications();
                if (this.dataGridView1.InvokeRequired)
                {
                    ApplicationProcessVoidDelegate appDelegate = new ApplicationProcessVoidDelegate(bindGrid);

                    try
                    {
                        this.Invoke(appDelegate, new object[] { tracker.GetApplications() });
                    }
                    finally { ;}

                }
                else
                {
                    bindGrid(processes);
                }  

                e.WaitOne(1000);
            }
        }

        private void bindGrid(List<ApplicationProcess> processes)
        {
            bs.Clear();
            bs.DataSource = processes;
            dataGridView1.DataSource = bs;

            lbl_totalTime.Text = tracker.ApplicationTotalTime;
            lbl_ActiveTime.Text = StringHelper.FormatTime(tracker.SessionActiveTime);
            lbl_lockedTime.Text = StringHelper.FormatTime(tracker.SessionLockedTime);

        }
    }
}
