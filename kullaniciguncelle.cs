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
    public partial class kullaniciguncelle : Form
    {
        SqlConnection con = new SqlConnection();
        

        public kullaniciguncelle()
        {
            InitializeComponent();
            this.TopMost = true;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtHesapnumara_Enter(object sender, EventArgs e)
        {
            if (txtHesapnumara.Text.Equals(@"HESAP NUMARA"))
            {
                txtHesapnumara.Text = "";
            }
        }

        private void txtİsim_Enter(object sender, EventArgs e)
        {
            if (txtİsim.Text.Equals(@"İSİM"))
            {
                txtİsim.Text = "";
            }
        }

        private void txtTelefonnumara_Enter(object sender, EventArgs e)
        {
            if (txtTelefonnumara.Text.Equals(@"TELEFON NUMARA"))
            {
                txtTelefonnumara.Text = "";
            }
        }

        private void txtDogumtarih_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDogumtarih_Enter(object sender, EventArgs e)
        {
            if (txtDogumtarih.Text.Equals(@"DOGUM TARİH"))
            {
                txtDogumtarih.Text = "";
            }
        }

        private void txtAdres_Enter(object sender, EventArgs e)
        {
            if (txtAdres.Text.Equals(@"ADRES"))
            {
                txtAdres.Text = "";
            }
        }

        private void txtMevcutbakiye_Enter(object sender, EventArgs e)
        {
            if (txtMevcutbakiye.Text.Equals(@"MEVCUT BAKİYE"))
            {
                txtMevcutbakiye.Text = "";
            }
        }

        private void txtHesapsifre_Enter(object sender, EventArgs e)
        {
            if (txtHesapsifre.Text.Equals(@"HESAP SİFRE"))
            {
                txtHesapsifre.Text = "";
            }
        }

        private void txtSoyad_Enter(object sender, EventArgs e)
        {
            if (txtSoyad.Text.Equals(@"SOYAD"))
            {
                txtSoyad.Text = "";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string customerno = txtHesapnumara.Text;
            string password = txtHesapsifre.Text;
            string firstname = txtİsim.Text;
            string lastname = txtSoyad.Text;
            string address = txtAdres.Text;
            string phone = txtTelefonnumara.Text;
            DateTime birthdate = Convert.ToDateTime(txtDogumtarih.Text);
            int balance = Convert.ToInt32(txtMevcutbakiye.Text);
            long salary = Convert.ToInt64(txtmaas.Text);
            bool iserror = false;

            if (String.IsNullOrEmpty(txtHesapnumara.Text) || txtHesapnumara.Text == "HESAP NUMARA")
            {
                MessageBox.Show("HESAP NUMARA ALANI BOS BIRAKILAMAZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (!iserror)
            {
                con = new SqlConnection(@"Data Source");
                con.Open();
                com = new SqlCommand("UPDATE customerinfo SET firstname=@firstname , lastname=@lastname , address=@address , phone=@phone , birth=@birth , salary=@salary  WHERE customerno=@customerno", con);
                com2 = new SqlCommand("UPDATE loginn SET password=@password , type=@type WHERE accountno=@customerno", con);
                com3 = new SqlCommand("UPDATE balances SET balance=@balance WHERE customerno=@customerno", con);


                com.Parameters.AddWithValue("@customerno", customerno);
                com.Parameters.AddWithValue("@firstname", firstname);
                com.Parameters.AddWithValue("@lastname", lastname);
                com.Parameters.AddWithValue("@address", address);
                com.Parameters.AddWithValue("@phone", phone);
                com.Parameters.AddWithValue("@birth", birthdate);
                com.Parameters.AddWithValue("@salary", salary);


                com2.Parameters.AddWithValue("@customerno", customerno);
                com2.Parameters.AddWithValue("@password", password);
                com2.Parameters.AddWithValue("@type", "user");

                com3.Parameters.AddWithValue("@balance", balance);
                com3.Parameters.AddWithValue("@customerno", customerno);


                int result = com.ExecuteNonQuery();
                int result2 = com2.ExecuteNonQuery();
                int result3 = com3.ExecuteNonQuery();


                if (result < 0 || result2 < 0 || result3 < 0)
                {
                    MessageBox.Show("KULLANICI BILGILERI GUNCELLENEMEDI", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("KULLANICI BILGILERI BASARIYLA GUNCELLENDI");
                }

            }


        }

        private void txtmaas_Enter(object sender, EventArgs e)
        {
            if (txtSoyad.Text.Equals(@"MAAS"))
            {
                txtSoyad.Text = "";
            }
        }
    }
}
