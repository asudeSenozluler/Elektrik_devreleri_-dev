using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elektrik_devreleri_ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtV.Text = "";
            txtR.Text = "";
            txtL.Text = "";
            txtR.Text = "";
            txtHz.Text = "";
            txtC.Text = "";
        }

        private void btntem2_Click(object sender, EventArgs e)
        {
            txtır.Text = "";
            txtıc.Text = "";
            txtıl.Text = "";
            txtxc.Text = "";
            txtxl.Text = "";
            txtq.Text = "";
            txtI.Text = "";
        }

        private void btnxlxc_Click(object sender, EventArgs e)
        {
            if (txtR.Text == "" || txtV.Text == "" || txtC.Text == "" || txtL.Text == "" || txtHz.Text == "")
            {
                MessageBox.Show("Lütfen istenilen yerleri eksiksiz doldurunuz!");
            }
            double xl, xc,frekans, l,c;
            const double pi=3.14159;
            l = Convert.ToDouble(txtL.Text);
            frekans = Convert.ToDouble(txtHz.Text);
            xl = 2 * l * frekans * pi;
            txtxl.Text = xl.ToString();
            c = Convert.ToDouble(txtC.Text);
            xc = 1 / (2 * pi * frekans * c);
            txtxc.Text = xc.ToString();

        }

        private void btnakım_Click(object sender, EventArgs e)
        {
            if(txtR.Text==""|| txtV.Text==""||txtC.Text==""||txtL.Text==""|| txtHz.Text=="")
            {
                MessageBox.Show("Lütfen istenilen yerleri eksiksiz doldurunuz!");
            }
            double xl, xc, v, Ir, Ic, Il,R,bileske,islem,fazacısı,Q;
            xl = Convert.ToDouble(txtxl.Text);
            xc = Convert.ToDouble(txtxc.Text);
            v = Convert.ToDouble(txtV.Text);
            R=Convert.ToDouble(txtR.Text);
            Ir = v / R;
            txtır.Text = Ir.ToString();
            Il = v / xl;
            txtıl.Text = Il.ToString();
            Ic = v / xc;
            txtıc.Text = Ic.ToString();
            islem =( Ir * Ir) +( (Il - Ic) * (Il - Ic));
            bileske = Math.Sqrt(islem);
            txtI.Text = bileske.ToString();
            fazacısı = (Il - Ic) / Ir;
            Q = Math.Atan(fazacısı);
            txtq.Text = Q.ToString();




        }
    }
}
