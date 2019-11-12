namespace RobotControl
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
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("");
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.lvControllers = new System.Windows.Forms.ListView();
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader29 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader30 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader31 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader32 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnMotorOn = new System.Windows.Forms.Button();
            this.btnPPtoMain = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnMotorOff = new System.Windows.Forms.Button();
            this.btnLogSave = new System.Windows.Forms.Button();
            this.btnBackupSys = new System.Windows.Forms.Button();
            this.btnRestoreSys = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(14, 231);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(1021, 292);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            this.rtbLog.TextChanged += new System.EventHandler(this.rtbLog_TextChanged);
            // 
            // lvControllers
            // 
            this.lvControllers.AutoArrange = false;
            this.lvControllers.BackColor = System.Drawing.SystemColors.Window;
            this.lvControllers.CheckBoxes = true;
            this.lvControllers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader25,
            this.columnHeader26,
            this.columnHeader27,
            this.columnHeader28,
            this.columnHeader29,
            this.columnHeader30,
            this.columnHeader31,
            this.columnHeader32,
            this.columnHeader1});
            this.lvControllers.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lvControllers.FullRowSelect = true;
            this.lvControllers.GridLines = true;
            this.lvControllers.HideSelection = false;
            listViewItem11.StateImageIndex = 0;
            this.lvControllers.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem11});
            this.lvControllers.Location = new System.Drawing.Point(14, 15);
            this.lvControllers.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lvControllers.Name = "lvControllers";
            this.lvControllers.Size = new System.Drawing.Size(1021, 207);
            this.lvControllers.TabIndex = 1;
            this.lvControllers.UseCompatibleStateImageBehavior = false;
            this.lvControllers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "IP Address";
            this.columnHeader25.Width = 130;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "ID";
            this.columnHeader26.Width = 80;
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "Availability";
            this.columnHeader27.Width = 100;
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "Virtual";
            this.columnHeader28.Width = 70;
            // 
            // columnHeader29
            // 
            this.columnHeader29.Text = "System name";
            this.columnHeader29.Width = 120;
            // 
            // columnHeader30
            // 
            this.columnHeader30.Text = "Version";
            this.columnHeader30.Width = 80;
            // 
            // columnHeader31
            // 
            this.columnHeader31.Text = "Name";
            this.columnHeader31.Width = 110;
            // 
            // columnHeader32
            // 
            this.columnHeader32.Text = "Mode";
            this.columnHeader32.Width = 80;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Guid SystemId";
            this.columnHeader1.Width = 250;
            // 
            // btnMotorOn
            // 
            this.btnMotorOn.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMotorOn.Font = new System.Drawing.Font("KaiTi", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMotorOn.Location = new System.Drawing.Point(1051, 15);
            this.btnMotorOn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnMotorOn.Name = "btnMotorOn";
            this.btnMotorOn.Size = new System.Drawing.Size(190, 61);
            this.btnMotorOn.TabIndex = 6;
            this.btnMotorOn.Text = "上电使能";
            this.btnMotorOn.UseVisualStyleBackColor = false;
            this.btnMotorOn.Click += new System.EventHandler(this.btnMotorOn_Click);
            // 
            // btnPPtoMain
            // 
            this.btnPPtoMain.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPPtoMain.Font = new System.Drawing.Font("KaiTi", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPPtoMain.Location = new System.Drawing.Point(1051, 88);
            this.btnPPtoMain.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnPPtoMain.Name = "btnPPtoMain";
            this.btnPPtoMain.Size = new System.Drawing.Size(190, 58);
            this.btnPPtoMain.TabIndex = 7;
            this.btnPPtoMain.Text = "PP to Main";
            this.btnPPtoMain.UseVisualStyleBackColor = false;
            this.btnPPtoMain.Click += new System.EventHandler(this.btnPPtoMain_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnStart.Font = new System.Drawing.Font("KaiTi", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(1051, 148);
            this.btnStart.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(190, 64);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "运行";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStop.Font = new System.Drawing.Font("KaiTi", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStop.Location = new System.Drawing.Point(1051, 224);
            this.btnStop.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(190, 56);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnMotorOff
            // 
            this.btnMotorOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMotorOff.Font = new System.Drawing.Font("KaiTi", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMotorOff.Location = new System.Drawing.Point(1051, 292);
            this.btnMotorOff.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnMotorOff.Name = "btnMotorOff";
            this.btnMotorOff.Size = new System.Drawing.Size(190, 51);
            this.btnMotorOff.TabIndex = 10;
            this.btnMotorOff.Text = "下电";
            this.btnMotorOff.UseVisualStyleBackColor = false;
            this.btnMotorOff.Click += new System.EventHandler(this.btnMotorOff_Click);
            // 
            // btnLogSave
            // 
            this.btnLogSave.Font = new System.Drawing.Font("KaiTi", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogSave.Location = new System.Drawing.Point(1051, 352);
            this.btnLogSave.Name = "btnLogSave";
            this.btnLogSave.Size = new System.Drawing.Size(190, 53);
            this.btnLogSave.TabIndex = 18;
            this.btnLogSave.Text = "参数保存";
            this.btnLogSave.UseVisualStyleBackColor = true;
            this.btnLogSave.Click += new System.EventHandler(this.btnLogSave_Click);
            // 
            // btnBackupSys
            // 
            this.btnBackupSys.Font = new System.Drawing.Font("KaiTi", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBackupSys.Location = new System.Drawing.Point(1051, 411);
            this.btnBackupSys.Name = "btnBackupSys";
            this.btnBackupSys.Size = new System.Drawing.Size(190, 53);
            this.btnBackupSys.TabIndex = 19;
            this.btnBackupSys.Text = "系统备份";
            this.btnBackupSys.UseVisualStyleBackColor = true;
            this.btnBackupSys.Click += new System.EventHandler(this.btnBackupSys_Click);
            // 
            // btnRestoreSys
            // 
            this.btnRestoreSys.Font = new System.Drawing.Font("KaiTi", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRestoreSys.Location = new System.Drawing.Point(1051, 470);
            this.btnRestoreSys.Name = "btnRestoreSys";
            this.btnRestoreSys.Size = new System.Drawing.Size(190, 53);
            this.btnRestoreSys.TabIndex = 20;
            this.btnRestoreSys.Text = "系统恢复";
            this.btnRestoreSys.UseVisualStyleBackColor = true;
            this.btnRestoreSys.Click += new System.EventHandler(this.btnRestoreSys_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 559);
            this.Controls.Add(this.btnRestoreSys);
            this.Controls.Add(this.btnBackupSys);
            this.Controls.Add(this.btnLogSave);
            this.Controls.Add(this.btnMotorOff);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnPPtoMain);
            this.Controls.Add(this.btnMotorOn);
            this.Controls.Add(this.lvControllers);
            this.Controls.Add(this.rtbLog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.ListView lvControllers;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.ColumnHeader columnHeader28;
        private System.Windows.Forms.ColumnHeader columnHeader29;
        private System.Windows.Forms.ColumnHeader columnHeader30;
        private System.Windows.Forms.ColumnHeader columnHeader31;
        private System.Windows.Forms.ColumnHeader columnHeader32;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnMotorOn;
        private System.Windows.Forms.Button btnPPtoMain;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnMotorOff;
        private System.Windows.Forms.Button btnLogSave;
        private System.Windows.Forms.Button btnBackupSys;
        private System.Windows.Forms.Button btnRestoreSys;
    }
}

