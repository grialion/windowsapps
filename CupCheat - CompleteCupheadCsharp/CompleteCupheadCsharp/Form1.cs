using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompleteCupheadCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string CupheadSaveFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Cuphead\cuphead_player_data_v1_slot_0.sav";
        string CupheadSaveDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Cuphead";
        string BackUpState = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\CupheadBackup\completed";

        private void button1_Click(object sender, EventArgs e)
        {
            string BackUpSettings = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\CupheadBackup\settings.ini";
            if(Completed() == true)
            {
                if(DialogResult.No == MessageBox.Show("Game already completed!\nDo you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    return;
                }
                else
                {
                    if(DialogResult.Yes == MessageBox.Show("Okay, you can't back up your earlier progress with this app, but you can do it manually.\nDo you want to open the backup folder?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Cuphead");
                        Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\CupheadBackup");
                    }
                }
            }
            if (!File.Exists(CupheadSaveFile))
            {
                if (!Directory.Exists(CupheadSaveDir))
                {
                    MessageBox.Show("There is no save, do you have Cuphead? ;)", "Press ok");
                    Directory.CreateDirectory(CupheadSaveDir);
                }
            }
            else
            {
                BackUp(CupheadSaveFile);
            }

            string BackUpFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\CupheadBackup\";
            File.WriteAllBytes(CupheadSaveFile, CompleteCupheadCsharp.Properties.Resources.cuphead_player_data_v1_slot_0);
            if (!File.Exists(BackUpState))
            {
                File.CreateText(BackUpState);
            }
        }
        private bool Completed()
        {
            if (!File.Exists(BackUpState))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void BackUp(string sourceFile)
        {
            int count = 1;
            string BackUpFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\CupheadBackup\";
            string BackUpFile = BackUpFolder + "Save " + count + ".sav";
            while(File.Exists(BackUpFile))
            {
                count++;
                BackUpFile = BackUpFolder + "Save " + count + ".sav";
            }
            if (!Directory.Exists(BackUpFolder))
            {
                Directory.CreateDirectory(BackUpFolder);
            }
            
            File.Move(sourceFile, BackUpFile);
        }
        string BackUpFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\CupheadBackup\";

        private void button2_Click(object sender, EventArgs e)
        {
            int count = 1;
            string BackUpFile = BackUpFolder + "Save " + count + ".sav";
            if (!Directory.Exists(BackUpFolder))
            {
                MessageBox.Show("Restore what?", "There is no other save file", MessageBoxButtons.OKCancel);
                return;
            }
            while (File.Exists(BackUpFile))
            {
                count++;
                BackUpFile = BackUpFolder + "Save " + count + ".sav";
            }
            count += -1;
            BackUpFile = BackUpFolder + "Save " + count + ".sav";
            MessageBox.Show("Backupfile: " + BackUpFile);
            if(!File.Exists(BackUpFile))
            {
                MessageBox.Show("Can't found any save file", "Error");
            }

            File.Copy(BackUpFile, CupheadSaveFile, true);
            if(Completed())
            {
                File.Delete(BackUpState);
            }
        }
        Process[] CupheadProcesses;
        private void WarnUser()
        {
            Process[] pname = Process.GetProcessesByName("Cuphead");
            if (pname.Length == 0)
                return;
            else
                CupheadProcesses = pname;
                button4.Enabled = true;
                MessageBox.Show("Cuphead detected!\nClose Cuphead to take an affect!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WarnUser();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Cupheadl = "";
            string path = BackUpFolder + "Cuphead.txt";
            if (Cupheadl == "")
            {
                if (File.Exists(path))
                {
                    using (StreamReader sr = File.OpenText(path))
                    {
                        string s = "";
                        Cupheadl = sr.ReadLine();
                        MessageBox.Show(Cupheadl);
                        while((s = sr.ReadLine()) != null)
                        {

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select the Cuphead executable!");
                    var browserDialog = new OpenFileDialog();
                    if(browserDialog.ShowDialog() == DialogResult.OK)
                    {
                        Cupheadl = browserDialog.FileName;
                        MessageBox.Show(browserDialog.FileName);
                        using (FileStream fs = File.Create(path))
                        {
                            byte[] info = new UTF8Encoding(true).GetBytes(browserDialog.FileName);
                            fs.Write(info, 0, info.Length);
                        }
                    }
                }
            }
            var p = new Process();
            p.StartInfo.FileName = Cupheadl;
            p.Start();
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process[] proc = Process.GetProcessesByName("Cuphead");
            foreach (Process Cuphead in proc)
            {
                Cuphead.Kill();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            follow follow = new follow();
            follow.ShowDialog();
        }
    }
}
