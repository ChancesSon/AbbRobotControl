using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace RobotControl
{
    public partial class Form1 : Form
    {
        RobotController robot;
        List<string> errLog = new List<string>();

        public Form1()
        {
            InitializeComponent();
            robot = new RobotController();
            this.lvControllers.Items.Clear();
            robot.Scan();
            ListViewItem item = null;
            if (robot.controllers == null) return;
            for (int i = 0; i < robot.controllers.Count(); i++)

            {
                item = new ListViewItem(robot.controllers[i].IPAddress.ToString());
                item.SubItems.Add(robot.controllers[i].Id);
                item.SubItems.Add(robot.controllers[i].Availability.ToString());
                item.SubItems.Add(robot.controllers[i].IsVirtual.ToString());

                item.SubItems.Add(robot.controllers[i].SystemName);
                item.SubItems.Add(robot.controllers[i].Version.ToString());
                item.SubItems.Add(robot.controllers[i].ControllerName);
                item.SubItems.Add(robot.GetController(i).OperatingMode.ToString());
                item.SubItems.Add(robot.controllers[i].SystemId.ToString());
                this.lvControllers.Items.Add(item);
                item.Tag = robot.controllers[i];
            }
            errLog = robot.errLogger(errLog, "[Scan]             " + robot.controllers.Count().ToString() + "  controllers");
            rtbLog.Lines = errLog.ToArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errLog = robot.errLogger(errLog, "[Scan]             " +  "  controllers");
            rtbLog.Lines = errLog.ToArray();
        }

        private void btnMotorOn_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> result = new List<string>();
                if (this.lvControllers.SelectedIndices.Count < 1)
                {
                    MessageBox.Show("Please select at least 1 controller to send command.");
                    return;
                }
                for (int i = 0; i < this.lvControllers.SelectedIndices.Count; i++)
                {
                    robot.SetMotorsOn(robot.GetController(i), out result);
                    errLog = robot.errLogger(errLog, "[Motors_ON]" + result[0]);

                    errLog = robot.errLogger(errLog, "[Motors_ON]       :  " + robot.controllers[i].ControllerName + " Done.");
                    rtbLog.Lines = errLog.ToArray();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            errLog = robot.errLogger(errLog, "[Motors_ON]        all set done.");
            rtbLog.Lines = errLog.ToArray();
        }

        private void btnMotorOff_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> result = new List<string>();
                if (this.lvControllers.SelectedIndices.Count < 1)
                {
                    MessageBox.Show("Please select at least 1 controller to send command.");
                    return;
                }
                for (int i = 0; i < this.lvControllers.SelectedIndices.Count; i++)
                {
                    robot.SetMotorsOff(robot.GetController(i), out result);
                    errLog = robot.errLogger(errLog, "[Motors_OFF]" + result[0]);

                    errLog = robot.errLogger(errLog, "[Motors_OFF]:     " + robot.controllers[i].ControllerName + " Done.");
                    rtbLog.Lines = errLog.ToArray();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            errLog = robot.errLogger(errLog, "[Motors_OFF]       all set done.");
            rtbLog.Lines = errLog.ToArray();
        }

        private void btnPPtoMain_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> result = new List<string>();
                if (this.lvControllers.SelectedIndices.Count < 1)
                {
                    MessageBox.Show("Please select at least 1 controller to send command.");
                    return;
                }
                for (int i = 0; i < this.lvControllers.SelectedIndices.Count; i++)
                {
                    robot.PPtoMain(robot.GetController(i), out result);
                    errLog = robot.errLogger(errLog, "[PP_To_Main]" + result[0]);
                    errLog = robot.errLogger(errLog, "[PP_To_Main]:       " + robot.controllers[i].ControllerName + " Done.");
                    rtbLog.Lines = errLog.ToArray();

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

            errLog = robot.errLogger(errLog, "[PP_To_Main]       all set done.");
            rtbLog.Lines = errLog.ToArray();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> result = new List<string>();
                if (this.lvControllers.SelectedIndices.Count < 1)
                {
                    MessageBox.Show("Please select at least 1 controller to send command.");
                    return;
                }
                for (int i = 0; i < this.lvControllers.SelectedIndices.Count; i++)
                {
                    robot.Start(robot.GetController(i), out result);
                    errLog = robot.errLogger(errLog, "[Program_Start]" + result[0]);

                    errLog = robot.errLogger(errLog, "[Program_Start]:  " + robot.controllers[i].ControllerName + " Done.");
                    rtbLog.Lines = errLog.ToArray();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            errLog = robot.errLogger(errLog, "[Program_Start]    all set done.");
            rtbLog.Lines = errLog.ToArray();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> result = new List<string>();
                if (this.lvControllers.SelectedIndices.Count < 1)
                {
                    MessageBox.Show("Please select at least 1 controller to send command.");
                    return;
                }
                for (int i = 0; i < this.lvControllers.SelectedIndices.Count; i++)
                {
                    robot.Stop(robot.GetController(i), out result);
                    errLog = robot.errLogger(errLog, "[Program_Stop]" + result[0]);

                    errLog = robot.errLogger(errLog, "[Program_Stop]:   " + robot.controllers[i].ControllerName + " Done.");
                    rtbLog.Lines = errLog.ToArray();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            errLog = robot.errLogger(errLog, "[Program_Stop]     all set done.");
            rtbLog.Lines = errLog.ToArray();
        }

        private void rtbLog_TextChanged(object sender, EventArgs e)
        {
            rtbLog.SelectionStart = rtbLog.Text.Length;
            //move to cursor position
            rtbLog.ScrollToCaret();

            this.CheckKeyword("[Scan]", Color.Purple, 0);
            this.CheckKeyword("[Motors_ON]", Color.Green, 0);
            this.CheckKeyword("Motors_OFF", Color.Green, 0);
            this.CheckKeyword("[PP_To_Main]", Color.Green, 0);
            this.CheckKeyword("[Program_Start]", Color.Green, 0);
            this.CheckKeyword("[Program_Stop]", Color.Green, 0);
            this.CheckKeyword("[error", Color.DarkRed, 0);
            this.CheckKeyword("[msg]", Color.Green, 0);
            this.CheckKeyword("[warning]", Color.Tomato, 0);
        }

        private void CheckKeyword(string word, Color color, int startIndex)
        {
            if (this.rtbLog.Text.Contains(word))
            {
                int index = -1;
                int selectStart = this.rtbLog.SelectionStart;

                while ((index = this.rtbLog.Text.IndexOf(word, (index + 1))) != -1)
                {
                    this.rtbLog.Select((index + startIndex), word.Length);
                    this.rtbLog.SelectionColor = color;
                    this.rtbLog.Select(selectStart, 0);
                    this.rtbLog.SelectionColor = Color.Black;
                }
            }
        }

        private void btnBackupSys_Click(object sender, EventArgs e)
        {
            string backupDir = @"";
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "备份文件(*.bak)|*.bak";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                backupDir = sfd.FileName.ToString();   //get file path
            }

            try
            {
                List<string> result = new List<string>();
                if (this.lvControllers.SelectedIndices.Count < 1)
                {
                    MessageBox.Show("Please select at least 1 controller to send command.");
                    return;
                }
                for (int i = 0; i < this.lvControllers.SelectedIndices.Count; i++)
                {
                    robot.BackUpSys(robot.GetController(i), out result, backupDir);
                    errLog = robot.errLogger(errLog, "[System_Backup]" + result[0]);

                    errLog = robot.errLogger(errLog, "[System_Backup]:   " + robot.controllers[i].ControllerName + " Done.");
                    rtbLog.Lines = errLog.ToArray();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            errLog = robot.errLogger(errLog, "[System_Backup]     all set done.");
            rtbLog.Lines = errLog.ToArray();
        }


        private void btnRestoreSys_Click(object sender, EventArgs e)
        {
            string restoreDir = @"";
            FolderBrowserDialog fdb = new FolderBrowserDialog();
            if (fdb.ShowDialog() == DialogResult.OK)
            {
                restoreDir = fdb.SelectedPath;
            }

            try
            {
                List<string> result = new List<string>();
                if (this.lvControllers.SelectedIndices.Count < 1)
                {
                    MessageBox.Show("Please select at least 1 controller to send command.");
                    return;
                }
                for (int i = 0; i < this.lvControllers.SelectedIndices.Count; i++)
                {
                    robot.RestoreSys(robot.GetController(i), out result, restoreDir);
                    errLog = robot.errLogger(errLog, "[System_Restore]" + result[0]);

                    errLog = robot.errLogger(errLog, "[System_Restore]:   " + robot.controllers[i].ControllerName + " Done.");
                    rtbLog.Lines = errLog.ToArray();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            errLog = robot.errLogger(errLog, "[System_Restore]     all set done.");
            rtbLog.Lines = errLog.ToArray();
        }

        private void btnLogSave_Click(object sender, EventArgs e)
        {
            string logPath = @"";
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "log文件(*.txt)|*.txt";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                logPath = sfd.FileName.ToString();   //get file path
            }
            File.WriteAllLines(logPath, this.errLog);
            errLog = robot.errLogger(errLog, "Log Save done.");
            rtbLog.Lines = errLog.ToArray();
        }
    }
}
