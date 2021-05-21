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
    public partial class kullanicipanel : Form
    {
        
        public kullanicipanel(String value, string pass)
        {
            
            InitializeComponent();
            this.TopMost = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            txtAccountno.Text = value;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            kullaniciparayatırcek kullaniciparayatırcek = new kullaniciparayatırcek(txtAccountno.Text);
            kullaniciparayatırcek.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            paratransferi paratransferi = new paratransferi(txtAccountno.Text);
            paratransferi.Show();
        }

        private void btnsifredegis_Click(object sender, EventArgs e)
        {
            
            sifredegistir sifredegistir = new sifredegistir(txtAccountno.Text);
            sifredegistir.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            kullanicihesaphareketleri kullanicihesaphareketleri = new kullanicihesaphareketleri(txtAccountno.Text);
            kullanicihesaphareketleri.Show();
        }

        private void btnKredicek_Click(object sender, EventArgs e)
        {
            kredicek kredicek = new kredicek(txtAccountno.Text);
            kredicek.Show();
        }

        private void btnbilgilerimigoruntule_Click(object sender, EventArgs e)
        {
            bilgilerimigoruntule bilgilerimigoruntule = new bilgilerimigoruntule(txtAccountno.Text);
            bilgilerimigoruntule.Show();
        }

        private void button_WOC6_Click(object sender, EventArgs e)
        {
            kullaniciparayatırcek kullaniciparayatırcek = new kullaniciparayatırcek(txtAccountno.Text);
            kullaniciparayatırcek.Show();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            paratransferi paratransferi = new paratransferi(txtAccountno.Text);
            paratransferi.Show();
        }

        private void button_WOC5_Click(object sender, EventArgs e)
        {
            kredicek kredicek = new kredicek(txtAccountno.Text);
            kredicek.Show();
        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {
            kullanicihesaphareketleri kullanicihesaphareketleri = new kullanicihesaphareketleri(txtAccountno.Text);
            kullanicihesaphareketleri.Show();
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            bilgilerimigoruntule bilgilerimigoruntule = new bilgilerimigoruntule(txtAccountno.Text);
            bilgilerimigoruntule.Show();
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            sifredegistir sifredegistir = new sifredegistir(txtAccountno.Text);
            sifredegistir.Show();
        }
    }
}
