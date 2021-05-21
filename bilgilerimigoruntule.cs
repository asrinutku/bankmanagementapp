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
        
    public partial class bilgilerimigoruntule : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source");
        SqlCommand com = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt;
        int Move;
        int Mouse_X;
        int Mouse_Y;
        public bilgilerimigoruntule(string value)
        {
            string accno = value;
            InitializeComponent();
            this.TopMost = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            showdata(accno);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }


        public void showdata(string accno)
        {
            con = new SqlConnection(@"Data Source");
            con.Open();

            com = new SqlCommand("SELECT customerinfo.customerno,customerinfo.firstname," +
                "customerinfo.lastname,customerinfo.address,customerinfo.phone,customerinfo.birth," +
                "customerinfo.salary,balances.balance " +
                "FROM customerinfo FULL OUTER JOIN balances " +
                "ON customerinfo.customerno = balances.customerno" +
                " WHERE customerinfo.customerno=@customerno", con);

            com.Parameters.AddWithValue("@customerno", accno);


            SqlDataReader da = com.ExecuteReader();

            while (da.Read())
            {
                txtHesapnumara.Text = da.GetValue(0).ToString();
                txtİsim.Text = da.GetValue(1).ToString();
                txtSoyad.Text = da.GetValue(2).ToString();
                txtAdres.Text = da.GetValue(3).ToString();
                txtDogumtarih.Text = da.GetValue(5).ToString();
                txtTelefonnumara.Text = da.GetValue(4).ToString();
                txtMaas.Text = da.GetValue(6).ToString();
                txtMevcutbakiye.Text = da.GetValue(7).ToString();
            }

            da.Close();
            con.Close();

        }


        private void bilgilerimigoruntule_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void bilgilerimigoruntule_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void bilgilerimigoruntule_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }
    }
}
