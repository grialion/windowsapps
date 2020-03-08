using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DBL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string f = "";
        private void button1_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                f = folderBrowserDialog1.SelectedPath;
                string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\dbl\path.txt";
                using (FileStream fs = File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(folderBrowserDialog1.SelectedPath);
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkEmptySelected();
            
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\dbl\build.bat";
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                // Create the file, or overwrite if the file exists.
                using (FileStream fs = File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("tsc -p " + f + @"\tsconfig.json");
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }
                //MessageBox.Show("tsc -p " + f + @"\tsconfig.json");
                StartProcess(path);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkEmptySelected();

            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\dbl\start.bat";
            using (FileStream fs = File.Create(path))
            {
                byte[] info = new UTF8Encoding(true).GetBytes("@echo off" + "\n" + "node " + f + @"\dist");
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
            StartProcess(path);
        }
        private void checkEmptySelected()
        {
            if (f == "")
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\dbl\path.txt";
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        f = s;
                       // MessageBox.Show(s + f);
                    }
                }

            }
        }
        int processnumber = 0;
        int prprocessnumber;
        int prprocessnumber2;
        private void StartProcess(string path)
        {
            processnumber++;
            if (processnumber == 0)
            {
                prprocessnumber = Process.Start(path).Id;
            }
            else
            {
                prprocessnumber2 = Process.Start(path).Id;
            }
           // MessageBox.Show("Process Started!");
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            if (processnumber > 0)
            {
                // if (processnumber == 1)
                //if(!Process.GetProcessById(prprocessnumber)) 
                Process pname = Process.GetProcessById(prprocessnumber);
                Process pname2 = Process.GetProcessById(prprocessnumber2);
                if (pname.ProcessName == "cmd.exe")
                {
                    if (MessageBox.Show(processnumber + " process is possibly running. Are you sure you want to close?", "Process running", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
                if (pname2.ProcessName == "cmd.exe")
                {
                    if (MessageBox.Show(processnumber + " processes are possibly running. Are you sure you want to close?", "Processes running", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
                

            }*/
            Process thisProc = Process.GetCurrentProcess();
            if(IsProcessOpen("cmd") == true)
            {
                if(MessageBox.Show(Process.GetProcessesByName("cmd").Length.ToString() + " process(es) are possibly running! Are you sure you want to exit?", "Exitting...", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            
        }
        public bool IsProcessOpen(string name)
        {
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (clsProcess.ProcessName.Contains(name))
                {
                    return true;
                }
            }

            return false;
        }
        public string dcpath = @"C:\Users\grial\AppData\Local\Discord\app-0.0.306\Discord.exe";
        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(dcpath);
        }

        private void killdcbutton_Click(object sender, EventArgs e)
        {
            Process[] dcs = Process.GetProcessesByName("Discord");
            foreach(Process dc in dcs)
            {
                dc.Kill();
            }
        }
    }
}
