using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankmanagementapp
{
    public partial class adminpanel : Form
    {
        public adminpanel()
        {
            InitializeComponent();
            
            this.TopMost = true;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void adminpanel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            adminkullaniciekle ake = new adminkullaniciekle();
            ake.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            kullanicikaldir ake = new kullanicikaldir();
            ake.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            kullaniciguncelle ake = new kullaniciguncelle();
            ake.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            kullanicilarigoruntule ake = new kullanicilarigoruntule();
            ake.Show();
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            paratransferlerinigoruntule ake = new paratransferlerinigoruntule();
            ake.Show();
        }

        private void btnKrediler_Click(object sender, EventArgs e)
        {
            verilenkredilerigoruntule ake = new verilenkredilerigoruntule();
            ake.Show();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            adminkullaniciekle ake = new adminkullaniciekle();
            ake.Show();
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            kullanicikaldir ake = new kullanicikaldir();
            ake.Show();
        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {
            kullaniciguncelle ake = new kullaniciguncelle();
            ake.Show();
        }

        private void button_WOC7_Click(object sender, EventArgs e)
        {
            kullanicilarigoruntule ake = new kullanicilarigoruntule();
            ake.Show();
        }

        private void button_WOC6_Click(object sender, EventArgs e)
        {
            paratransferlerinigoruntule ake = new paratransferlerinigoruntule();
            ake.Show();
        }

        private void button_WOC5_Click(object sender, EventArgs e)
        {
            verilenkredilerigoruntule ake = new verilenkredilerigoruntule();
            ake.Show();
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            sistemistatistikleri ake = new sistemistatistikleri();
            ake.Show();
        }
    }
}
