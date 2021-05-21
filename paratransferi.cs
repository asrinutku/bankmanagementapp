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
    public partial class paratransferi : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        

        SqlDataAdapter adapter = new SqlDataAdapter();
        public paratransferi(String value)
        {
            InitializeComponent();
            this.TopMost = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            txtHesapnumara.Text = value;
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

            com5 = new SqlCommand("SELECT balance FROM balances where customerno=@customerno", con);
            com5.Parameters.AddWithValue("@customerno", txtHesapnumara.Text);

            SqlDataReader da = com5.ExecuteReader();

            while (da.Read())
            {
                txtbakiye.Text = da.GetValue(0).ToString();
            }

            da.Close();


            con.Close();
        }

        private void paratransferiyap_Click(object sender, EventArgs e)
        {
            
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            string gonderenno = txtHesapnumara.Text;
            string bakiye = txtbakiye.Text;
            string alicino = txtAlıcınumara.Text;
            string gonderilecekmikar = txtGonderılecekmıktar.Text;
            string transfernot = txtTransfernotu.Text;
            long kalanpara = Convert.ToInt64(bakiye) - Convert.ToInt64(gonderilecekmikar);

            string now = DateTime.Now.ToString("MM/dd/yyyy");
            string gelenislemadi = "gelen para transferi";
            string gidenislemadi = "giden para transferi";


            con = new SqlConnection(@"Data Source");
            con.Open();

            com2 = new SqlCommand("SELECT balance FROM balances where customerno=@customerno", con);
            com2.Parameters.AddWithValue("@customerno", txtAlıcınumara.Text);

            SqlDataReader da = com2.ExecuteReader();
            string[] alicininparasi = new string[1];
            while (da.Read())
            {

                alicininparasi[0] = Convert.ToString(da.GetValue(0).ToString());
            }

            long alicinintoplamparasi = Convert.ToInt64(alicininparasi[0]) + Convert.ToInt64(gonderilecekmikar);

            da.Close();

            com = new SqlCommand("UPDATE balances SET balance=@balance WHERE customerno=@customerno", con);
            com1 = new SqlCommand("UPDATE balances SET balance=@balance WHERE customerno=@alicino", con);
            com3 = new SqlCommand("INSERT INTO transactions (senderno,receiverno,amount,notes) VALUES(@senderno,@receiverno,@amount,@notes)", con);

            com.Parameters.AddWithValue("@balance", kalanpara);
            com.Parameters.AddWithValue("@customerno", gonderenno);

            com1.Parameters.AddWithValue("@alicino", alicino);
            com1.Parameters.AddWithValue("@balance", alicinintoplamparasi);

            com3.Parameters.AddWithValue("@senderno", gonderenno);
            com3.Parameters.AddWithValue("@receiverno", alicino);
            com3.Parameters.AddWithValue("@amount", gonderilecekmikar);
            com3.Parameters.AddWithValue("@notes", transfernot);


            int result2 = com.ExecuteNonQuery();
            int result3 = com1.ExecuteNonQuery();
            int result4 = com3.ExecuteNonQuery();

            if (result2 < 0 || result3 < 0 || result4 < 0)
            {
                MessageBox.Show("PARA TRANSFERİ YAPILAMADI", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("PARA TRANSFERİ BASARIYLA GERCEKLESTIRILDI");
                com6 = new SqlCommand("INSERT INTO accountactions (customerno,actionname,actionamount,actiondate) VALUES(@customerno,@actionname,@amount,@date)", con);
                com7 = new SqlCommand("INSERT INTO accountactions (customerno,actionname,actionamount,actiondate) VALUES(@customerno,@actionname,@amount,@date)", con);

                com6.Parameters.AddWithValue("@customerno", gonderenno);
                com6.Parameters.AddWithValue("@actionname", gidenislemadi);
                com6.Parameters.AddWithValue("@amount", Convert.ToInt64(gonderilecekmikar));
                com6.Parameters.AddWithValue("@date", now);

                com7.Parameters.AddWithValue("@customerno", txtAlıcınumara.Text);
                com7.Parameters.AddWithValue("@actionname", gelenislemadi);
                com7.Parameters.AddWithValue("@amount", Convert.ToInt64(gonderilecekmikar));
                com7.Parameters.AddWithValue("@date", now);

                com6.ExecuteNonQuery();
                com7.ExecuteNonQuery();


            }




            con.Close();
        }
    }
}
