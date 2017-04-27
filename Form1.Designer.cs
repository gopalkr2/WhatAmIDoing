namespace WhatAmIDoing.Model
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_startTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_totalTime = new System.Windows.Forms.Label();
            this.lbl_ActiveTime = new System.Windows.Forms.Label();
            this.lbl_lockedTime = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ActiveTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VirtualMemoryMB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAlive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationProcessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applicationProcessBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicationProcessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationProcessBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tracking Since:";
            // 
            // lbl_startTime
            // 
            this.lbl_startTime.AutoSize = true;
            this.lbl_startTime.Location = new System.Drawing.Point(109, 27);
            this.lbl_startTime.Name = "lbl_startTime";
            this.lbl_startTime.Size = new System.Drawing.Size(61, 13);
            this.lbl_startTime.TabIndex = 4;
            this.lbl_startTime.Text = "labelStart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "My Top Applications: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(500, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Active";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(509, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(493, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Session Lock";
            // 
            // lbl_totalTime
            // 
            this.lbl_totalTime.AutoSize = true;
            this.lbl_totalTime.Location = new System.Drawing.Point(582, 16);
            this.lbl_totalTime.Name = "lbl_totalTime";
            this.lbl_totalTime.Size = new System.Drawing.Size(41, 13);
            this.lbl_totalTime.TabIndex = 9;
            this.lbl_totalTime.Text = "label6";
            // 
            // lbl_ActiveTime
            // 
            this.lbl_ActiveTime.AutoSize = true;
            this.lbl_ActiveTime.Location = new System.Drawing.Point(582, 66);
            this.lbl_ActiveTime.Name = "lbl_ActiveTime";
            this.lbl_ActiveTime.Size = new System.Drawing.Size(41, 13);
            this.lbl_ActiveTime.TabIndex = 10;
            this.lbl_ActiveTime.Text = "label6";
            // 
            // lbl_lockedTime
            // 
            this.lbl_lockedTime.AutoSize = true;
            this.lbl_lockedTime.Location = new System.Drawing.Point(582, 42);
            this.lbl_lockedTime.Name = "lbl_lockedTime";
            this.lbl_lockedTime.Size = new System.Drawing.Size(41, 13);
            this.lbl_lockedTime.TabIndex = 11;
            this.lbl_lockedTime.Text = "label6";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.ActiveTime,
            this.VirtualMemoryMB,
            this.IsAlive});
            this.dataGridView1.DataSource = this.applicationProcessBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(639, 287);
            this.dataGridView1.TabIndex = 12;
            // 
            // ActiveTime
            // 
            this.ActiveTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ActiveTime.DataPropertyName = "ActiveTime";
            this.ActiveTime.HeaderText = "ActiveTime";
            this.ActiveTime.Name = "ActiveTime";
            this.ActiveTime.ReadOnly = true;
            // 
            // VirtualMemoryMB
            // 
            this.VirtualMemoryMB.DataPropertyName = "VirtualMemoryMB";
            this.VirtualMemoryMB.HeaderText = "VirtualMemoryMB";
            this.VirtualMemoryMB.Name = "VirtualMemoryMB";
            this.VirtualMemoryMB.ReadOnly = true;
            // 
            // IsAlive
            // 
            this.IsAlive.DataPropertyName = "IsAlive";
            this.IsAlive.HeaderText = "IsAlive";
            this.IsAlive.Name = "IsAlive";
            this.IsAlive.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_ActiveTime);
            this.groupBox1.Controls.Add(this.lbl_startTime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_lockedTime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_totalTime);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 86);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Activity";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ApplicationName";
            this.dataGridViewTextBoxColumn9.HeaderText = "ApplicationName";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // applicationProcessBindingSource
            // 
            this.applicationProcessBindingSource.DataSource = typeof(WhatAmIDoing.Model.ApplicationProcess);
            // 
            // applicationProcessBindingSource4
            // 
            this.applicationProcessBindingSource4.DataSource = typeof(WhatAmIDoing.Model.ApplicationProcess);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 401);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "What Am I Doing today ?";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicationProcessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationProcessBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_startTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_totalTime;
        private System.Windows.Forms.Label lbl_ActiveTime;
        private System.Windows.Forms.Label lbl_lockedTime;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn activeTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn processDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aliveTimeInSecondsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activeTimeStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn processIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource applicationProcessBindingSource4;
        private System.Windows.Forms.BindingSource applicationProcessBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn VirtualMemoryMB;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsAlive;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

