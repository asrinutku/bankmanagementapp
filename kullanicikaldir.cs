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
    public partial class kullanicikaldir : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        

        SqlDataAdapter adapter = new SqlDataAdapter();
        public kullanicikaldir()
        {
            InitializeComponent();
            this.TopMost = true;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enter(object sender, EventArgs e)
        {
            if (txtHesapnumara.Text.Equals(@"HESAP NUMARA"))
            {
                txtHesapnumara.Text = "";
            }
        }


        private void txtHesapnumara_Enter(object sender, EventArgs e)
        {
            if (txtHesapnumara.Text.Equals(@"HESAP NUMARA"))
            {
                txtHesapnumara.Text = "";
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source");
            con.Open();
            string accountno = txtHesapnumara.Text;
            com = new SqlCommand("DELETE FROM customerinfo WHERE customerno ='" + accountno + "'", con);
            


            DialogResult dialogResult = MessageBox.Show("Kullanıcıyı banka sisteminden kaldırmak istediğinize emin misiniz ?", "KULLANICI KALDIR", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
              

                if (result < 0)
                {
                    MessageBox.Show("KULLANICI KALDIRILAMADI", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("KULLANICI BASARIYLA KALDIRILDI");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("ISLEM BASARISIZ ");
            }

        }
    }
}
