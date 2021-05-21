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
    public partial class sistemistatistikleri : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public sistemistatistikleri()
        {
            InitializeComponent();
            this.TopMost = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            musterisayisi();
            maasortalamasi();
            transfersayisi();
            cekilenpara();
            yatirilanpara();
            cekilenkredi();
            aylikgeriodeme();
            toplampara();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }


        public void musterisayisi()
        {

            con = new SqlConnection(@"Data Source");
            con.Open();

            com = new SqlCommand("SELECT COUNT(customerno) FROM customerinfo", con);
            

            Int32 rows = Convert.ToInt32(com.ExecuteScalar())-1;

            txtmusterisayi.Text = rows.ToString();

            
            con.Close();
        }

        public void maasortalamasi()
        {

            con = new SqlConnection(@"Data Source");
            con.Open();

            com = new SqlCommand("SELECT AVG(balance) FROM balances", con);


            Int32 rows = Convert.ToInt32(com.ExecuteScalar());

            txtmaasortalaması.Text = rows.ToString();


            con.Close();
        }

        public void transfersayisi()
        {

            con = new SqlConnection(@"Data Source");
            con.Open();

            com = new SqlCommand("SELECT COUNT(transactionid) FROM transactions", con);


            Int32 rows = Convert.ToInt32(com.ExecuteScalar());

            txttransfersayisi.Text = rows.ToString();


            con.Close();
        }

        public void cekilenpara()
        {
            string islemadi = "para cekme";
            con = new SqlConnection(@"Data Source");
            con.Open();

            com = new SqlCommand("SELECT SUM(actionamount) FROM accountactions WHERE actionname=@an", con);
            com.Parameters.AddWithValue("@an",islemadi);


            Int32 rows = Convert.ToInt32(com.ExecuteScalar());

            txtcekilenpara.Text = rows.ToString();


            con.Close();
        }

        public void yatirilanpara()
        {
            string islemadi = "para yatirma";
            con = new SqlConnection(@"Data Source");
            con.Open();

            com = new SqlCommand("SELECT SUM(actionamount) FROM accountactions WHERE actionname=@an", con);
            com.Parameters.AddWithValue("@an", islemadi);


            Int32 rows = Convert.ToInt32(com.ExecuteScalar());

            txtyatirilanpara.Text = rows.ToString();


            con.Close();
        }

        public void cekilenkredi()
        {
            
            con = new SqlConnection(@"Data Source");
            con.Open();

            com = new SqlCommand("SELECT SUM(creditamount) FROM creditinfos", con);
            
            Int32 rows = Convert.ToInt32(com.ExecuteScalar());

            txtcekilenkredi.Text = rows.ToString();

            con.Close();
        }

        public void aylikgeriodeme()
        {

            con = new SqlConnection(@"Data Source");
            con.Open();

            com = new SqlCommand("SELECT SUM(monthlypayment) FROM creditinfos", con);

            Int32 rows = Convert.ToInt32(com.ExecuteScalar());

            txtageriodeme.Text = rows.ToString();

            con.Close();
        }

        public void toplampara()
        {

            con = new SqlConnection(@"Data Source");
            con.Open();

            com = new SqlCommand("SELECT SUM(balance) FROM balances", con);

            Int32 rows = Convert.ToInt32(com.ExecuteScalar());

            txttoplampara.Text = rows.ToString();

            con.Close();
        }

    }
}
