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
using System.Timers;


namespace bankmanagementapp
{
    public partial class kullaniciparayatırcek : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
      
        long maas;

        SqlDataAdapter adapter = new SqlDataAdapter();
        public kullaniciparayatırcek(String value)
        {
            InitializeComponent();
            this.TopMost = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            txtHesapnumara.Text = value;
            maasgetir();
            paramiktari();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        public void paramiktari()
        {           
            
            con = new SqlConnection(@"Data Source");
            con.Open();

            com = new SqlCommand("SELECT balance FROM balances where customerno=@customerno", con);
            com.Parameters.AddWithValue("@customerno", txtHesapnumara.Text);

            SqlDataReader da = com.ExecuteReader();

            while (da.Read())
            {
                txtbakiye.Text = da.GetValue(0).ToString();
            }
           
            con.Close();
        }

        public void maasgetir()
        {


            con = new SqlConnection(@"Data Source");
            con.Open();

            com = new SqlCommand("SELECT salary FROM customerinfo where customerno=@customerno", con);
            com.Parameters.AddWithValue("@customerno", txtHesapnumara.Text);

            SqlDataReader da = com.ExecuteReader();
            string[] x = new string[1];
            while (da.Read())
            {
                x[0] = da.GetValue(0).ToString();
            }
            maas = Convert.ToInt64(x[0]);

            con.Close();

            
        }


        private void button_WOC1_Click(object sender, EventArgs e)
        {
            
            string money1 = txtParayatır.Text;
            if (maas > Convert.ToInt64(money1))
            {
                    string money2 = txtbakiye.Text;
                    long totalmoney = Convert.ToInt64(money1) + Convert.ToInt64(money2);
                    string now = DateTime.Now.ToString("MM/dd/yyyy");
                    string islemadi = "para yatirma";

                    con = new SqlConnection(@"Data Source");
                    con.Open();
                    com = new SqlCommand("UPDATE balances SET balance=@balance  WHERE customerno=@customerno", con);
                

                    com.Parameters.AddWithValue("@balance", totalmoney);
                    com.Parameters.AddWithValue("@customerno", txtHesapnumara.Text);

                    int result = com.ExecuteNonQuery();
                    int result2 = com3.ExecuteNonQuery();

                    if (result < 0)
                    {
                        MessageBox.Show("HESABINIZA PARA EKLENEMEDİ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("HESABINIZA BASARIYLA PARA EKLENDİ");
                    }

                    con.Close();
            }
            else
            {
                MessageBox.Show("PARA EKLEME LİMİTİNİZİ AŞTINIZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            string money1 = txtParacek.Text;
            string money2 = txtbakiye.Text;
            long totalmoney = Convert.ToInt64(money2) - Convert.ToInt64(money1);
            string now = DateTime.Now.ToString("MM/dd/yyyy");
            string islemadi = "para cekme";

            if (totalmoney < 0)
            {
                MessageBox.Show("YETERLI PARANIZ BULUNMAMAKTADIR SİSTEM KAPATILIYOR", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
            else
            {
                con = new SqlConnection(@"Data Source");
                con.Open();
                com = new SqlCommand("UPDATE balances SET balance=@balance  WHERE customerno=@customerno", con);
                com2 = new SqlCommand("INSERT INTO accountactions (customerno,actionname,actionamount,actiondate) VALUES(@customerno,@actionname,@amount,@date)", con);



                com.Parameters.AddWithValue("@balance", totalmoney);
                com.Parameters.AddWithValue("@customerno", txtHesapnumara.Text);

                com2.Parameters.AddWithValue("@customerno", txtHesapnumara.Text);
                com2.Parameters.AddWithValue("@actionname", islemadi);
                com2.Parameters.AddWithValue("@amount", Convert.ToInt64(money1));
                com2.Parameters.AddWithValue("@date", now);



                int result = com.ExecuteNonQuery();
                int result2 = com2.ExecuteNonQuery();

                if (result < 0)
                {
                    MessageBox.Show("HESABINIZDAN PARA ÇEKİLEMEDİ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("PARA CEKME İŞLEMİNİZ BAŞARIYLA GERÇEKLEŞTİ TEŞEKKÜR EDERİZ");
                }

                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source");
            con.Open();

            com = new SqlCommand("SELECT balance FROM balances where customerno=@customerno", con);
            com.Parameters.AddWithValue("@customerno", txtHesapnumara.Text);

            SqlDataReader da = com.ExecuteReader();

            while (da.Read())
            {
                txtbakiye.Text = da.GetValue(0).ToString();
            }


            con.Close();
        }
    }
}
