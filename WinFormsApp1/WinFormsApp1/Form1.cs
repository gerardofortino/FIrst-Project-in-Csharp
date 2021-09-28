using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Questo è un testo di prova!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rectangle r = new Rectangle(500, 200, 300, 250);
            int x;
            int y;
            for(int i=0; i<1000; i++)
            {
                var random = new Random();
                x = random.Next(500, 800);
                y = random.Next(200, 450);
                Rectangle rcerchio = new Rectangle(x, y, 20, 20);
                Graphics g;
                g = this.CreateGraphics();
                g.Clear(BackColor);
                g.DrawRectangle(new Pen(Brushes.Red, 6), r);
                g.DrawEllipse(new Pen(Brushes.Blue, 2), rcerchio);
                g.FillEllipse(Brushes.Blue,rcerchio);
                wait(1000);
            }
        }
    }
}
