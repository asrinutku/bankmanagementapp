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
    public partial class kredicek : Form
    {
        string accno;
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlCommand com1 = new SqlCommand();
        

        SqlDataAdapter adapter = new SqlDataAdapter();
        public kredicek(string value)
        {
            
            InitializeComponent();
            this.TopMost = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            labelonay.Visible = false;
            labelret.Visible = false;
            button_WOC5.Visible = false;
            accno = value;
            maas();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void txtKredimiktari_Enter(object sender, EventArgs e)
        {
            if (txtKredimiktari.Text.Equals(@"KREDİ TUTARI"))
            {
                txtKredimiktari.Text = "";
            }
        }

        public void maas()
        {
            

            con = new SqlConnection(@"Data Source");
            con.Open();

            com = new SqlCommand("SELECT salary FROM customerinfo where customerno=@customerno", con);
            com.Parameters.AddWithValue("@customerno", accno);

            SqlDataReader da = com.ExecuteReader();

            while (da.Read())
            {
                txtMaas.Text = da.GetValue(0).ToString();
            }


            con.Close();
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (txtKredimiktari.Text.Equals(@""))
            {
                 MessageBox.Show("KREDİ MİKTARİ ALANI BOS BIRAKILAMAZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 
            }
            else
            {
                int kredimiktari = Convert.ToInt32(txtKredimiktari.Text);
                int aysayisi = Convert.ToInt32(comboBox1.SelectedItem);
                int aylikodeme = kredimiktari / aysayisi;
                txtAylikodeme.Text = aylikodeme.ToString();

                if (aylikodeme*2 < Convert.ToInt32(txtMaas.Text))
                {
                    labelonay.Visible = true;
                    labelret.Visible = false;
                    button_WOC5.Visible = true;
                }
                else
                {
                    labelret.Visible = true;
                    labelonay.Visible = false;
                    button_WOC5.Visible = false;
                }

            }
            
        }

        private void txtKredimiktari_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnonayla_Click(object sender, EventArgs e)
        {
            
        }

        private void button_WOC5_Click(object sender, EventArgs e)
        {
            string islemadi = "kredi cekme";
            string now = DateTime.Now.ToString("MM/dd/yyyy");
            con = new SqlConnection(@"Data Source");
            con.Open();

            com = new SqlCommand("SELECT balance FROM balances where customerno=@customerno", con);
            com.Parameters.AddWithValue("@customerno", accno);

            SqlDataReader da = com.ExecuteReader();
            string[] bakiye = new string[1];

            while (da.Read())
            {
                bakiye[0] = da.GetValue(0).ToString();
            }
            da.Close();
            long kredimiktari = Convert.ToInt64(txtKredimiktari.Text);
            long totalmoney = Convert.ToInt64(bakiye[0]) + kredimiktari;


            con = new SqlConnection(@"Data Source");
            con.Open();
            com1 = new SqlCommand("UPDATE balances SET balance=@balance  WHERE customerno=@customerno", con);


            com1.Parameters.AddWithValue("@balance", totalmoney);
            com1.Parameters.AddWithValue("@customerno", accno);

            int result1 = com1.ExecuteNonQuery();

            if (result1 < 0)
            {
                MessageBox.Show("KREDİ CEKME İSLEMİ GERCEKLESTİRİLEMEDİ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("KREDİ CEKME İSLEMİ BASARIYLA GERCEKLESTIRILDI");
                com2 = new SqlCommand("INSERT INTO accountactions (customerno,actionname,actionamount,actiondate) VALUES(@customerno,@actionname,@amount,@date)", con);

                com2.Parameters.AddWithValue("@customerno", accno);
                com2.Parameters.AddWithValue("@actionname", islemadi);
                com2.Parameters.AddWithValue("@amount", kredimiktari);
                com2.Parameters.AddWithValue("@date", now);

                com2.ExecuteNonQuery();

                com3 = new SqlCommand("INSERT INTO creditinfos (customerno,creditamount,monthlypayment,date) VALUES(@customerno,@amount,@payment,@date)", con);

                com3.Parameters.AddWithValue("@customerno", accno);
                com3.Parameters.AddWithValue("@amount", kredimiktari);
                com3.Parameters.AddWithValue("@payment", Convert.ToInt64(txtAylikodeme.Text));
                com3.Parameters.AddWithValue("@date", now);

                com3.ExecuteNonQuery();
            }

            con.Close();
        }
    }
}
