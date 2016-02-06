using System;
using System.IO;
using System.Windows.Forms;

namespace InsultViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = "Hurry the fuck up, time is precious you useless fuckwit.";
            timer1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                File.OpenWrite(textBox1.Text);
                label3.Text = "Fucks sake. That is not a valid Insult file.";
            }
            catch (Exception ex)
            {
                label3.Text = "Fucks sake. " + ex.Message;
            }
            resetTimer();
        }

        private void resetTimer()
        {
            timer1.Stop();
            timer1.Start();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                label3.Text = "Are you fucking blind, I said click open, not press enter.";
                resetTimer();
            }
        }
    }
}
