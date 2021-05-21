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
using System.Data.Sql;

namespace bankmanagementapp
{
    public partial class adminkullaniciekle : Form
            

        
    {
            SqlConnection con = new SqlConnection();
            SqlCommand com = new SqlCommand();
            

            SqlDataAdapter adapter = new SqlDataAdapter();

            int Move;
            int Mouse_X;
            int Mouse_Y;


        public adminkullaniciekle()

            {
                InitializeComponent();
                this.TopMost = true;
                this.StartPosition = FormStartPosition.CenterScreen;
            }

            private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
            {

            }

            private void txtHesapnumaraenter(object sender, EventArgs e)
            {
                if (txtHesapnumara.Text.Equals(@"HESAP NUMARA"))
                {
                    txtHesapnumara.Text = "";
                }
            }

      
            private void txtİsimenter(object sender, EventArgs e)
            {
                if (txtİsim.Text.Equals(@"İSİM"))
                {
                    txtİsim.Text = "";
                }
            }

      

            private void tse(object sender, EventArgs e)
            {
                if (txtSoyad.Text.Equals(@"SOYAD"))
                {
                    txtSoyad.Text = "";
                }
            }


            private void ttne(object sender, EventArgs e)
            {
                if (txtTelefonnumara.Text.Equals(@"TELEFON NUMARA"))
                {
                    txtTelefonnumara.Text = "";
                }
            }


            private void tae(object sender, EventArgs e)
            {
                if (txtAdres.Text.Equals(@"ADRES"))
                {
                    txtAdres.Text = "";
                }
            }

            private void thse(object sender, EventArgs e)
            {
                if (txtHesapsifre.Text.Equals(@"HESAP SİFRE"))
                {
                    txtHesapsifre.Text = "";
                }
            }


            private void tmbe(object sender, EventArgs e)
            {
                if (txtMevcutbakiye.Text.Equals(@"MEVCUT BAKİYE"))
                {
                    txtMevcutbakiye.Text =  "";
                }
            }

            private void txtMaas_Enter(object sender, EventArgs e)
            {
                if (txtMaas.Text.Equals(@"AYLIK MAAS"))
                {
                    txtMaas.Text = "";
                }
            }

        private void btnLogin_Click(object sender, EventArgs e)
            {
                string customerno = txtHesapnumara.Text;
                string password = txtHesapsifre.Text;
                string firstname = txtİsim.Text;
                string lastname = txtSoyad.Text;
                string address = txtAdres.Text;
                long maas = Convert.ToInt64(txtMaas.Text);
                string phone = txtTelefonnumara.Text;
                DateTime birthdate = dateTimePicker1.Value;
                long balance = Convert.ToInt64(txtMevcutbakiye.Text);
                bool iserror = false;

                if (String.IsNullOrEmpty(txtHesapnumara.Text) || txtHesapnumara.Text == "HESAP NUMARA")
                {
                    MessageBox.Show("HESAP NUMARA ALANI BOS BIRAKILAMAZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    iserror = true;
                }
                if (String.IsNullOrEmpty(txtMaas.Text) || txtHesapnumara.Text == "AYLIK MAAS")
                {
                    MessageBox.Show("MAAS ALANI BOS BIRAKILAMAZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    iserror = true;
                }
                if (String.IsNullOrEmpty(txtHesapsifre.Text) || txtHesapsifre.Text == "HESAP SİFRE")
                {
                    MessageBox.Show("HESAP SİFRE ALANI BOS BIRAKILAMAZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    iserror = true;
                }
                if (String.IsNullOrEmpty(txtİsim.Text) || txtİsim.Text == "İSİM")
                {
                    MessageBox.Show("İSİM ALANI BOS BIRAKILAMAZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    iserror = true;
                }
                if (String.IsNullOrEmpty(txtSoyad.Text) || txtSoyad.Text == "SOYAD")
                {
                    MessageBox.Show("SOYAD ALANI BOS BIRAKILAMAZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    iserror = true;
                }
                if (String.IsNullOrEmpty(txtAdres.Text) || txtAdres.Text == "ADRES")
                {
                    MessageBox.Show("ADRES ALANI BOS BIRAKILAMAZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    iserror = true;
                }
                if (String.IsNullOrEmpty(txtTelefonnumara.Text) || txtTelefonnumara.Text == "TELEFON NUMARA")
                {
                    MessageBox.Show("TELEFON NUMARA ALANI BOS BIRAKILAMAZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    iserror = true;
                }
                if (String.IsNullOrEmpty(txtTelefonnumara.Text) || txtTelefonnumara.Text == "TELEFON NUMARA")
                {
                    MessageBox.Show("TELEFON NUMARA ALANI BOS BIRAKILAMAZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    iserror = true;
                }
                if (String.IsNullOrEmpty(txtTelefonnumara.Text) || txtTelefonnumara.Text == "TELEFON NUMARA")
                {
                    MessageBox.Show("TELEFON NUMARA ALANI BOS BIRAKILAMAZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    iserror = true;
                }


                if(!iserror)
                {
                    con  = new SqlConnection( @"Data Source");
                    con.Open();


                    com = new SqlCommand("INSERT INTO customerinfo (customerno,firstname,lastname,address,phone,birth,salary) VALUES(@customerno,@firstname,@lastname,@address,@phone,@birth,@maas)",con);
                    com2 = new SqlCommand("INSERT INTO loginn (accountno,password,type) VALUES(@customerno,@password,@type)", con);
                    com3 = new SqlCommand("INSERT INTO balances (customerno,balance) VALUES(@customerno,@balance)", con);



                    com.Parameters.AddWithValue("@customerno", customerno);            
                    com.Parameters.AddWithValue("@firstname", firstname);
                    com.Parameters.AddWithValue("@lastname", lastname);
                    com.Parameters.AddWithValue("@address", address);
                    com.Parameters.AddWithValue("@phone", phone);
                    com.Parameters.AddWithValue("@birth", birthdate);
                    com.Parameters.AddWithValue("@maas", maas);


                    com2.Parameters.AddWithValue("@customerno", customerno);
                    com2.Parameters.AddWithValue("@password", password);
                    com2.Parameters.AddWithValue("@type", "user");

                    com3.Parameters.AddWithValue("@customerno", customerno);
                    com3.Parameters.AddWithValue("@balance", balance);

                    int result = com.ExecuteNonQuery();
                    int result2 = com2.ExecuteNonQuery();
                    int result3 = com3.ExecuteNonQuery();


                    if (result < 0 || result2<0 || result3 < 0)
                    {
                    MessageBox.Show("YENİ KULLANICI OLUSTURULAMADI", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                    MessageBox.Show("YENİ KULLANICI BASARIYLA EKLENDİ");
                    }
                      
                } 
            
             

            }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtHesapnumara_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void adminkullaniciekle_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void adminkullaniciekle_MouseDown(object sender, MouseEventArgs e)
        {

            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void adminkullaniciekle_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
