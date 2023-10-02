using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace net_hesaplamma__combo_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesaplama_Click(object sender, EventArgs e)
        {
            int dogru, yanlis;
            double net;
            dogru = Convert.ToInt32(cmbDogru.Text);
            yanlis = Convert.ToInt32(cmbYanlis.Text);
            net = dogru - yanlis / 4.0;
            lblNet.Text = "Netiniz: " + net.ToString();
        }
    }
}
