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
    public partial class paratransferlerinigoruntule : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source");
        SqlCommand com = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt;
        public paratransferlerinigoruntule()
        {
            InitializeComponent();
            this.TopMost = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            showdata();
        }


        public void showdata()
        {
            adapter = new SqlDataAdapter("SELECT * FROM transactions", con);
            dt = new DataTable();
            adapter.Fill(dt);
            transferlerdataGridView.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
