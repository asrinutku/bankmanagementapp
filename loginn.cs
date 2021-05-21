using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace bankmanagementapp
{
    public partial class loginn : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        

        public loginn()
        {
            con.ConnectionString = @"Data Source";
            InitializeComponent();
           
            this.TopMost = true;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            textBox1.Text = DateTime.Now.ToLongDateString();

            textBox2.Text = DateTime.Now.ToLongTimeString();


            getcaptcha();
        }

        public void kontrol()
        {
        if(lblcaptc.Text == txtcaptc.Text)
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "SELECT * FROM loginn";
                SqlDataReader dr = com.ExecuteReader();
                int x = 0;
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (txtAccountno.Text.Equals(dr["accountno"].ToString()) && txtPassword.Text.Equals(dr["password"].ToString()))
                        {
                            if (dr["type"].ToString() == "admin" || dr["type"].ToString() == "Admin")
                            {
                                MessageBox.Show("admin girisi basarili", "tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                x = 1;
                                break;
                            }

                            if (dr["type"].ToString() == "user" || dr["type"].ToString() == "User")
                            {
                                MessageBox.Show("kullanici girisi basarili", "tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                x = 2;
                                break;
                            }

                        }
                    }
                    if (x == 0)
                    {
                        MessageBox.Show("giris basarisiz", "tekrar deneyin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (x == 1)
                    {
                        this.Hide();
                        adminpanel adminpanel = new adminpanel();
                        adminpanel.Show();
                    }
                    else if (x == 2)
                    {
                        this.Hide();
                        kullanicipanel kullanicipanel = new kullanicipanel(txtAccountno.Text, txtPassword.Text);
                        kullanicipanel.Show();
                    }

                }

                con.Close();
            }
            else
            {
                MessageBox.Show("dogrulama kodu yanlis", "tekrar deneyin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                    
        }

        public void getcaptcha()
        {
            Random rand = new Random();
            int num = rand.Next(6, 8);
            string captcha = "";
            int totl = 0;
            do
            {
                int chr = rand.Next(48, 123);
                if ((chr >= 48 && chr <= 57) || (chr >= 65 && chr <= 90) || (chr >= 97 && chr <= 122))
                {
                    captcha = captcha + (char)chr;
                    totl++;
                    if (totl == num)
                        break;
                    {

                    }
                }
            } while (true);
            lblcaptc.Text = captcha;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kontrol();
        }

        private void txtUserEnter(object sender, EventArgs e)
        {
            if (txtAccountno.Text.Equals(@"HESAP NUMARASI"))
            {
                txtAccountno.Text = "";
            }
        }

        private void txtUserLeave(object sender, EventArgs e)
        {
            if (txtAccountno.Text.Equals(""))
            {
                txtAccountno.Text = @"HESAP NUMARASI";
            }
        }

        private void txtPassEnter(object sender, EventArgs e)
        {
            if(txtPassword.Text.Equals(@"PASSWORD"))
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.Text = "PASSWORD";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kontrol();
            }
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            kontrol();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            textBox2.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getcaptcha();
        }

        private void txtcaptc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kontrol();
            }
        }

        private void txtcaptc_Enter(object sender, EventArgs e)
        {
            if (txtcaptc.Text.Equals(@"DOGRULAMA KODU"))
            {
                txtcaptc.Text = "";
            }
        }
    }
}
