using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komplexe_Zahlen.UCs
{
    public partial class uc_ManualInput : UserControl
    {
        
        public uc_ManualInput()
        {
            InitializeComponent();
            lbl_Solution.Visible = false;
        }

        private void btn_Exec_Click(object sender, EventArgs e)
        {
            complexNumber cn1 = new complexNumber();
            complexNumber cn2 = new complexNumber();

            cn1.real = Convert.ToDouble(tb_Real1.Text);
            cn1.imaginary = Convert.ToDouble(tb_Imaginary1.Text);

            cn2.real = Convert.ToDouble(tb_Real2.Text);
            cn2.imaginary = Convert.ToDouble(tb_Imaginary2.Text);

            if(rb_Addition.Checked == true)
            {
                lbl_Solution.Visible = true;
                addition(cn1.real, cn2.real, cn1.imaginary, cn2.imaginary);
            }

            if(rb_Subtraction.Checked == true)
            {
                lbl_Solution.Visible = true;
                subtraction(cn1.real, cn2.real, cn1.imaginary, cn2.imaginary);
            }
        }

        private void addition(double r1, double r2, double i1, double i2)
        {
            double solutionR = r1 + r2;
            double solutionI = i1 + i2;

            lbl_Solution.Text = solutionR.ToString() + " + " + solutionI.ToString() + "i";
        }

        private void subtraction(double r1, double r2, double i1, double i2)
        {
            double solutionR = r1 - r2;
            double solutionI = i1 - i2;

            lbl_Solution.Text = solutionR.ToString() + " + " + solutionI.ToString() + "i";
        }

        private void rb_Subtraction_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_Subtraction.Checked == true)
            {
                lbl_calc.Text = "-";
            }
        }

        private void rb_Addition_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_Addition.Checked == true)
            {
                lbl_calc.Text = "+";
            }
        }
    }
}
