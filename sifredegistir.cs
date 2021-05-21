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
    public partial class sifredegistir : Form
    {

        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlCommand com1 = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        string accno;
        public sifredegistir(string value)
        {
            InitializeComponent();
            this.TopMost = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            accno = value;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEskisifre_Enter(object sender, EventArgs e)
        {
            if (txtEskisifre.Text.Equals(@"ESKİ SİFRE"))
            {
                txtEskisifre.Text = "";
            }
        }

        private void txtYenisifre_Enter(object sender, EventArgs e)
        {
            if (txtYenisifre.Text.Equals(@"YENİ SİFRE"))
            {
                txtYenisifre.Text = "";
            }
        }

        private void txtYenisifretekrar_Enter(object sender, EventArgs e)
        {
            if (txtYenisifretekrar.Text.Equals(@"YENİ SİFRE TEKRAR"))
            {
                txtYenisifretekrar.Text = "";
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source");
            con.Open();



            com = new SqlCommand("SELECT * FROM loginn", con);


            Console.WriteLine(accno);
            SqlDataReader dr = com.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if (accno.Equals(dr["accountno"].ToString()) && txtEskisifre.Text.Equals(dr["password"].ToString()))
                    {
                        if (txtYenisifre.Text == txtYenisifretekrar.Text)
                        {
                            dr.Close();
                            com1 = new SqlCommand("UPDATE loginn SET password=@password  WHERE accountno=@customerno", con);
                            com1.Parameters.AddWithValue("@password", txtYenisifre.Text);
                            com1.Parameters.AddWithValue("@customerno", accno);


                            int result = com1.ExecuteNonQuery();

                            if (result < 0)
                            {
                                MessageBox.Show("SİFRE DEGİSTİRİLEMEDİ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                MessageBox.Show("SİFRE BASARIYLA DEGİSTİRİLDİ ! LUTFEN TEKRAR GİRİS YAPIN");
                                Application.Exit();
                            }
                        }
                    }

                }

            }
            con.Close();
        }
    }
}
