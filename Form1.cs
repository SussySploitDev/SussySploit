using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEY_SYSTEM
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        Point lastPoint;
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

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://pastebin.com/raw/JgZtRL6X");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/ZFZAWfTSqV");
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://pastebin.com/raw/cDh06891");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string gettext = siticoneTextBox1.Text;
            int gettext_amount = gettext.Length;

            if (gettext_amount > 29)
            { }
            WebClient nc = new WebClient();
            string ks = WebClient downloadstring("")
        }
    }
    }

