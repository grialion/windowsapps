using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompleteCupheadCsharp
{
    public partial class follow : Form
    {
        public follow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/hgDnPZJ");
        }

        private void twitterbutton_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/grialion");
        }

        private void ytbutton_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCi-C-JNMVZNpX9kOs2ZLwxw/");
        }

        private void twitchbutton_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.twitch.tv/grialion");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Easter egg", "lol");
        }
    }
}
