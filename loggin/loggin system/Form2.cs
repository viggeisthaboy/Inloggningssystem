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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Location = new Point(600, 250);
        }
    

        private void tbx1_TextChanged(object sender, EventArgs e)
        {
            string oldText = string.Empty;
                if (tbx1.Text.All(chr => char.IsLetter(chr)))
                {
                    oldText = tbx1.Text;
                    tbx1.Text = oldText;

                    tbx1.BackColor = System.Drawing.Color.White;
                    tbx1.ForeColor = System.Drawing.Color.Black;
                }
                else
                {
                    tbx1.Text = oldText;
                    tbx1.BackColor = System.Drawing.Color.Red;
                    tbx1.ForeColor = System.Drawing.Color.Black;
                }
                tbx1.SelectionStart = tbx1.Text.Length;
        }

        private void tbx2_TextChanged(object sender, EventArgs e)
        {
            string oldText = string.Empty;

            if (tbx2.Text.All(chr => char.IsLetter(chr)))
            {
                oldText = tbx2.Text;
                tbx2.Text = oldText;

                tbx2.BackColor = System.Drawing.Color.White;
                tbx2.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                tbx2.Text = oldText;
                tbx2.BackColor = System.Drawing.Color.Red;
                tbx2.ForeColor = System.Drawing.Color.Black;
            }

            tbx2.SelectionStart = tbx2.Text.Length;
        }

        private void lbl4_Click(object sender, EventArgs e)
        {
            lbl4.Enabled = false;

            if (lbl4.Text == "Sign up")
            {
                DialogResult dialogResult = MessageBox.Show("We have not allowed new users to create their own accounts. But if you want the username and password, press yes","Read", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Username = Stefan, Password = Teacher", "Read", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Well then try to figure it out on your own ( ;");
                }
            }
            else if (lbl4.Text == "Skapa ett")
            {
                DialogResult dialogResult = MessageBox.Show("Vi har inte tillåtit nya användare skapa egna konton. Men om du vill ha användarnamnet och lösenorder, klicka ja", "Läs", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Användarnamn = Stefan, Lösenord = Läraren", "Läs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Okej försök lista ut det själv ( ;");
                }
            }

            lbl4.Enabled = true;

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            // Vet inte vad som är fel... Hade varit roligt om de funkade );
            /*
            if (btn3.Text == "Close")
            {
                pb4.Location = new Point(0,0);
                pb5.Location = new Point(752,11);
                pb7.Location = new Point(-1000, -1000);
                Environment.Exit(1);
            }
            else if (btn3.Text == "Stäng")
            {
                pb4.Location = new Point(0,0);
                

                pb5.Location = new Point(-1000, -1000);
                

                pb6.Location = new Point(37, 114);
                

                pb7.Location = new Point(752, 8);
                

                tbx3.Location = new Point(12, 17);
                

                tbx4.Location = new Point(0, 0);
                

                tbx5.Location = new Point(0, 60);
                

                tbx7.Location = new Point(153, 114);
               

                rtbx1.Location = new Point(140, 395);
                

                tbx6.Location = new Point(153, 319);
                System.Threading.Thread.Sleep(1000);
                tbx6.Location = new Point(-1000, -1000);
                tbx8.Location = new Point(153, 319);
                System.Threading.Thread.Sleep(1000);
                tbx8.Location = new Point(-1000, -1000);
                tbx9.Location = new Point(153, 319);
                System.Threading.Thread.Sleep(1000);
                tbx9.Location = new Point(-1000, -1000);
                tbx10.Location = new Point(153, 319);
                System.Threading.Thread.Sleep(1000);
                */
            Environment.Exit(0);
        
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            lbl1.Text = "Sign in";
            lbl1.Location = new Point(381, 217);
            lbl2.Text = "Get news, updates, deals and more";
            lbl2.Location = new Point(296, 255);
            lbl3.Text = "I don't have an account";
            lbl3.Location = new Point(296, 501);
            lbl4.Text = "Sign up";
            lbl4.Location = new Point(438, 501);
            btn1.Text = "Sign in";
            btn2.Text = "Skip >";
            btn3.Text = "Close";
            tbx1.Text = "Username";
            tbx2.Text = "Password";
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            lbl1.Text = "Logga in";
            lbl1.Location = new Point(372, 217);
            lbl2.Text = "Få nyheter, updateringar, rabatter och mer";
            lbl2.Location = new Point(280, 255);
            lbl3.Text = "Jag har inget konto";
            lbl3.Location = new Point(306, 501);
            lbl4.Text = "Skapa ett";
            lbl4.Location = new Point(423, 501);
            btn1.Text = "Logga in";
            btn2.Text = "Skippa >";
            btn3.Text = "Stäng";
            tbx1.Text = "Användarnamn";
            tbx2.Text = "Lösenord";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn2.Enabled = false;
            prb1.Visible = true;
            prb1.Value = 10;
            System.Threading.Thread.Sleep(100);
            prb1.Value = 20;
            System.Threading.Thread.Sleep(100);
            prb1.Value = 30;
            System.Threading.Thread.Sleep(100);
            prb1.Value = 40;
            System.Threading.Thread.Sleep(100);
            prb1.Value = 50;
            System.Threading.Thread.Sleep(100);
            prb1.Value = 60;
            System.Threading.Thread.Sleep(100);
            prb1.Value = 70;
            System.Threading.Thread.Sleep(100);
            prb1.Value = 80;
            System.Threading.Thread.Sleep(100);
            prb1.Value = 90;
            System.Threading.Thread.Sleep(100);
            prb1.Value = 100;
            prb1.Visible = false;
            btn2.Enabled = true;

            if (btn2.Text == "Skip >")
            {
                MessageBox.Show("Username = Stefan, Password = Teacher", "Read", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (btn2.Text == "Skippa >")
            {
                MessageBox.Show("Användarnamn = Stefan, Lösenord = Läraren", "Läs", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
            private void btn1_Click(object sender, EventArgs e)
            {
                
                if (tbx1.Text == "" || tbx2.Text == "" || tbx1.Text == "Username" || tbx1.Text == "Användarnamn" || tbx2.Text == "Password" || tbx2.Text == "Lösenord")
                {
                    MessageBox.Show("You need to imput your username and/or Password");
                }
                else if (tbx1.Text == "Stefan" && tbx2.Text == "Läraren")
                {
                    Form3 Myform = new Form3();
                    this.Hide();
                    Myform.ShowDialog();
                    this.Close();
                }
                else if (tbx1.Text == "Stefan" && tbx2.Text == "Teacher")
            {
                Form4 Myform = new Form4();
                this.Hide();
                Myform.ShowDialog();
                this.Close();
            }
                else
            {
                MessageBox.Show("Wrong username and/or passowrd");
            }
        }

        private void tbx1_MouseClick(object sender, MouseEventArgs e)
        {
            tbx1.Text = "";
        }

        private void tbx2_MouseClick(object sender, MouseEventArgs e)
        {
            tbx2.UseSystemPasswordChar = false;
            tbx2.Text = "";
        }



        // Dessa två har ingen betydelse p.g.a en sak längre upp
        private void pb5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HAH it's too late!");
            pb5.Enabled = false;
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HAH det är försent!");
            pb7.Enabled = false;
        } 
    }
}

