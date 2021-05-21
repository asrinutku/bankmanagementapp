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
    public partial class kullanicihesaphareketleri : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source");
        SqlCommand com = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt;
        string accno;
        public kullanicihesaphareketleri(string value)
        {
            accno = value;
            InitializeComponent();
            this.TopMost = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            showdata();

        }


        public void showdata()
        {
            adapter = new SqlDataAdapter("SELECT * FROM accountactions WHERE customerno=@accno", con);
            adapter.SelectCommand.Parameters.AddWithValue("@accno", accno);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
