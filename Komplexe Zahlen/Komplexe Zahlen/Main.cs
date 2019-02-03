using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komplexe_Zahlen
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            btn_Back.Visible = false;

            pnl_Action.Controls.Clear();
            pnl_Action.Size = new Size(950, 200);
        }

        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lbl_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Input_Click(object sender, EventArgs e)
        {
            btn_Back.Visible = true;
            pnl_SelectSolution.Visible = false;

            pnl_Action.Size = new Size(950, 600);
            pnl_Action.Location = new Point(23, 176);
            var myControl = new Komplexe_Zahlen.UCs.uc_ManualInput();
            pnl_Action.Controls.Add(myControl);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            pnl_Action.Controls.Clear();
            pnl_Action.Size = new Size(950, 200);

            pnl_SelectSolution.Visible = true;
            btn_Back.Visible = false;
        }

        //Location: 23; 176
        //Size: 950; 600
    }
}
