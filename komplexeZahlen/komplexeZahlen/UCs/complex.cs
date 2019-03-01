using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace komplexeZahlen.UCs
{
    public partial class complex : UserControl
    {
        string pattern =
            // Match any float, negative or positive, group it
            @"([-+]?\d+\.?\d*|[-+]?\d*\.?\d+)" +
            // ... possibly following that with whitespace
            @"\s*" +
            // ... followed by a plus
            @"\+" +
            // and possibly more whitespace:
            @"\s*" +
            // Match any other float, and save it
            @"([-+]?\d+\.?\d*|[-+]?\d*\.?\d+)" +
            // ... followed by 'i'
            @"i";

        Regex rgx;
        public complex()
        {
            rgx = new Regex(pattern);
            InitializeComponent();
        }

        private void btn_exec_Click(object sender, EventArgs e)
        {
            Match match = rgx.Match(tb_input.Text);
            double real = double.Parse(match.Groups[1].Value);
            double img = double.Parse(match.Groups[2].Value);

            lbl_input.Text = real.ToString() + " + " + img.ToString();
        }
    }
}
