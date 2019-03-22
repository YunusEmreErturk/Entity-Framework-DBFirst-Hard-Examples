using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//@Author Yunus Emre Ertürk ===> yemrerturk@gmail.com / www.muhendiserturk.com 
namespace DBFirst_FaturaIslemlerii
{
    
    public partial class FormSiparisSecenekleri : Form
    {
        public FormSiparisSecenekleri()
        {
            InitializeComponent();
        }

        

        private void siparişEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSiparisEkle frm = new FormSiparisEkle();
            frm.Show();
        }

        private void siparişGösterVeyaDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form2 frm = new Form2();
            //frm.Show();
            panel.Visible = true;
        }

        private void txtAra_Click(object sender, EventArgs e)
        {
            FormSiparisDetaylari frm = new FormSiparisDetaylari(Convert.ToInt32(txtOrderID.Text));
            frm.Show();
        }

        private void FormSiparisSecenekleri_Load(object sender, EventArgs e)
        {
            //@Author Yunus Emre Ertürk ===> yemrerturk@gmail.com / www.muhendiserturk.com 
        }
    }
}
//@Author Yunus Emre Ertürk ===> yemrerturk@gmail.com / www.muhendiserturk.com 