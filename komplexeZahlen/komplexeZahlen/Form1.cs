using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace komplexeZahlen
{
    public partial class Form1 : Form
    {
        double z1Real, z1Imag, z2Real, z2Imag;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_exec_Click(object sender, EventArgs e)
        {
            
        }

        private void rb_polarZ1_CheckedChanged(object sender, EventArgs e)
        {
            lbl_z1.Text = "P=";
            lbl_z1ad.Text = ", Phi=";
            lbl_z1i.Text = "°";
            if (rb_polarZ1.Checked == true && checkZ1())
            {
                tb_real1.Text = returnP(z1Real, z1Imag).ToString();
                tb_imaginary1.Text = returnPhi(z1Real, z1Imag).ToString();
            }
            else
            {
                return;
            }
        }

        private void rb_polarZ2_CheckedChanged(object sender, EventArgs e)
        {
            lbl_z2.Text = "P=";
            lbl_z2ad.Text = ", Phi=";
            lbl_z2i.Text = "°";
            if (rb_polarZ2.Checked == true && checkZ2())
            {
                tb_real2.Text = returnP(z2Real, z2Imag).ToString();
                tb_imaginary2.Text = returnPhi(z2Real, z2Imag).ToString();

            }
            else
            {
                return;
            }
        }

        private void rb_kartZ1_CheckedChanged(object sender, EventArgs e)
        {
            lbl_z1.Text = "Z1=";
            lbl_z1ad.Text = "+";
            lbl_z1i.Text = "i";
            if (rb_kartZ1.Checked == true && checkZ1())
            {
                tb_real1.Text = returnReal(z1Real, z1Imag).ToString();
                tb_imaginary1.Text = returnImag(z1Real, z1Imag).ToString();
            }
            else
            {
                return;
            }
        }

        private void rb_kartZ2_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_kartZ2.Checked == true && checkZ2())
            {
                tb_real2.Text = returnReal(z2Real, z2Imag).ToString();

            }
            else
            {
                return;
            }
        }

        //------------------------------ Rechnungen ------------------------------

        double returnPhi (double real, double imag)
        {         
            return Math.Atan(imag / real); ;
        }

        double returnP (double real, double imag)
        {
            return Math.Sqrt(real * real + imag * imag); ;
        }

        double returnReal(double P, double Phi)
        {
            return P * Math.Cos(Phi);
        }

        double returnImag(double P, double Phi)
        {
            return P * Math.Sin(Phi);
        }

        //------------------------------ Überprüfungen ------------------------------

        bool checkZ1()
        {
            try
            {
                z1Real = Convert.ToDouble(tb_real1.Text);
                z1Imag = Convert.ToDouble(tb_imaginary1.Text);
            }
            catch
            {
                MessageBox.Show("Es gibt ein Konvertierungsfehler!");
                return false;
            }
            return true;
        }

        bool checkZ2()
        {
            try
            {
                z2Real = Convert.ToDouble(tb_real2.Text);
                z2Imag = Convert.ToDouble(tb_imaginary2.Text);
            }
            catch
            {
                MessageBox.Show("Es gibt ein Konvertierungsfehler!");
                return false;
            }
            return true;
        }
    }
}
