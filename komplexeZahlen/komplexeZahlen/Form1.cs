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
        complexNumber _z1, _z2, solution;
        public Form1()
        {
            InitializeComponent();
            cb_operator.SelectedIndex = 0;
        }
        
        private void btn_exec_Click(object sender, EventArgs e)
        {
            try
            {
                string z1Safe = "", z2Safe = "";
                if (rb_polarZ1.Checked)
                {
                    _z1 = new complexNumber(Amount: Convert.ToDouble(tb_z1value1.Text), Angle: Convert.ToDouble(tb_z1value2.Text));
                    z1Safe = _z1.amount.ToString() + "*(cos(" + _z1.angle.ToString() + ") + sin(" + _z1.angle.ToString() + ")i)";
                }
                if (rb_polarZ2.Checked)
                {
                    _z2 = new complexNumber(Amount: Convert.ToDouble(tb_z2value1.Text), Angle: Convert.ToDouble(tb_z2value2.Text));
                    z2Safe = _z2.amount.ToString() + "*(cos(" + _z2.angle.ToString() + ") + sin(" + _z2.angle.ToString() + ")i)";
                }
                if (rb_kartZ1.Checked)
                {
                    _z1 = new complexNumber(Real: Convert.ToDouble(tb_z1value1.Text), Imag: Convert.ToDouble(tb_z1value2.Text));
                    z1Safe = _z1.real.ToString() + "+" + _z1.imaginary.ToString() + "i";
                }
                if (rb_kartZ2.Checked)
                {
                    _z2 = new complexNumber(Real: Convert.ToDouble(tb_z2value1.Text), Imag: Convert.ToDouble(tb_z2value2.Text));
                    z2Safe = _z2.real.ToString() + "+" + _z2.imaginary.ToString() + "i";
                }
                if(executeCalc())
                {
                    btn_information.Visible = true;
                    lv_calc.Items.Add(z1Safe);
                    lv_calc.Items.Add(lbl_calc.Text);
                    lv_calc.Items.Add(z2Safe);
                    lv_calc.Items.Add("=");
                    lv_calc.Items.Add(lbl_solution.Text);
                    lv_calc.Items.Add("-----------------");
                    lv_calc.Items[lv_calc.Items.Count - 1].EnsureVisible();
                }
            }
            catch
            {
                MessageBox.Show("Bitte geben sie gültige Zahlen ein!", "Error");
            }
            
        }

        private void rb_polarZ1_CheckedChanged(object sender, EventArgs e)
        {
            if(tb_z1value1.Text != "" && tb_z1value2.Text != "" && rb_polarZ1.Checked)
            {
                try
                {
                    _z1 = new complexNumber(Real: Convert.ToDouble(tb_z1value1.Text), Imag: Convert.ToDouble(tb_z1value2.Text));
                    tb_z1value1.Text = _z1.amount.ToString();
                    tb_z1value2.Text = _z1.angle.ToString();
                }
                catch
                {
                    MessageBox.Show("Fehler bei Konvertierung!", "Error");
                    tb_z1value1.Text = "";
                    tb_z1value2.Text = "";
                }
            }
            if(rb_polarZ1.Checked)
            {
                lbl_z1.Text = "R= ";
                lbl_z1ad.Text = ", Phi= ";
                lbl_z1i.Text = "°";
                lbl_formulaZ1.Visible = true;
            }

            if(tb_z1value1.Text != "" && tb_z1value2.Text != "" && rb_kartZ1.Checked)
            {
                try
                {
                    _z1 = new complexNumber(Amount: Convert.ToDouble(tb_z1value1.Text), Angle: Convert.ToDouble(tb_z1value2.Text));
                    tb_z1value1.Text = _z1.real.ToString();
                    tb_z1value2.Text = _z1.imaginary.ToString();
                }
                catch
                {
                    MessageBox.Show("Fehler bei Konvertierung!", "Error");
                    tb_z1value1.Text = "";
                    tb_z1value2.Text = "";
                }
            }
            if(rb_kartZ1.Checked)
            {
                lbl_z1.Text = "Z1= ";
                lbl_z1ad.Text = " + ";
                lbl_z1i.Text = "i";
                lbl_formulaZ1.Visible = false;
            }
        }

        private void rb_polarZ2_CheckedChanged(object sender, EventArgs e)
        {
            if (tb_z2value1.Text != "" && tb_z2value2.Text != "" && rb_polarZ2.Checked)
            {
                try
                {
                    _z2 = new complexNumber(Real: Convert.ToDouble(tb_z2value1.Text), Imag: Convert.ToDouble(tb_z2value2.Text));
                    tb_z2value1.Text = _z2.amount.ToString();
                    tb_z2value2.Text = _z2.angle.ToString();
                }
                catch
                {
                    MessageBox.Show("Fehler bei Konvertierung!", "Error");
                    tb_z2value1.Text = "";
                    tb_z2value2.Text = "";
                }
            }
            if (rb_polarZ2.Checked)
            {
                lbl_z2.Text = "R= ";
                lbl_z2ad.Text = ", Phi= ";
                lbl_z2i.Text = "°";
                lbl_formulaZ2.Visible = true;
            }

            if (tb_z2value1.Text != "" && tb_z2value2.Text != "" && rb_kartZ2.Checked)
            {
                try
                {
                    _z2 = new complexNumber(Amount: Convert.ToDouble(tb_z2value1.Text), Angle: Convert.ToDouble(tb_z2value2.Text));
                    tb_z2value1.Text = _z2.real.ToString();
                    tb_z2value2.Text = _z2.imaginary.ToString();
                }
                catch
                {
                    MessageBox.Show("Fehler bei Konvertierung!", "Error");
                    tb_z2value1.Text = "";
                    tb_z2value2.Text = "";
                }
            }
            if (rb_kartZ2.Checked)
            {
                lbl_z2.Text = "Z1= ";
                lbl_z2ad.Text = " + ";
                lbl_z2i.Text = "i";
                lbl_formulaZ2.Visible = false;
            }
        }

        bool executeCalc()
        {
            if(lbl_calc.Text == "+")
            {
                solution = _z1.addition(_z2);
                lbl_solution.Text = solution.real.ToString() + " + " + solution.imaginary.ToString() + "i";
                return true;
            }
            else if(lbl_calc.Text == "-")
            {
                solution = _z1.subtraction(_z2);
                lbl_solution.Text = solution.real.ToString() + " + " + solution.imaginary.ToString() + "i";
                return true;
            }
            else if(lbl_calc.Text == "*")
            {
                solution = _z1.multiplication(_z2);
                lbl_solution.Text = solution.real.ToString() + " + " + solution.imaginary.ToString() + "i";
                return true;
            }
            else if(lbl_calc.Text == "/")
            {
                solution = _z1.division(_z2);
                lbl_solution.Text = solution.real.ToString() + " + " + solution.imaginary.ToString() + "i";
                return true;
            }
            return false;
        }

        private void cb_operator_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_operator.SelectedIndex == cb_operator.FindStringExact("Addition"))
            {
                lbl_calc.Text = "+";
            }
            else if(cb_operator.SelectedIndex == cb_operator.FindStringExact("Subtraktion"))
            {
                lbl_calc.Text = "-";
            }
            else if(cb_operator.SelectedIndex == cb_operator.FindStringExact("Multiplikation"))
            {
                lbl_calc.Text = "*";
            }
            else if(cb_operator.SelectedIndex == cb_operator.FindStringExact("Division"))
            {
                lbl_calc.Text = "/";
            }
        }
    }
}
