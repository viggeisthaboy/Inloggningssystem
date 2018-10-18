using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loggin_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            Width = this.BackgroundImage.Width;
            Height = this.BackgroundImage.Height;
            Location = new Point(600, 250);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Stop();
            Form2 Myform = new Form2();
            this.Hide();
            Myform.ShowDialog();
            this.Close();
        }
    }
}
