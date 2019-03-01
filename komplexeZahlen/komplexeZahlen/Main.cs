using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using komplexeZahlen.UCs;

namespace komplexeZahlen
{
    public partial class Main : Form
    {
        int slidebarWidth = 150;
        bool hide;
        public Main()
        {
            InitializeComponent();
            slidebar.Width = 0;
            hide = true;
            resetPanel();
            //120; 75
            //850; 550
            //^(?<real>-?\d+([,]\d+)?)((?<imag>[-+]\d+([,]\d+)?)i)$
        }

        private void pnl_slide_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(hide)
            {
                slidebar.Width += 10;
                if (slidebar.Width >= slidebarWidth)
                {
                    timer1.Stop();
                    hide = false;
                    this.Refresh();
                }
            }
            else
            {
                slidebar.Width -= 10;
                if (slidebar.Width <= 0)
                {
                    timer1.Stop();
                    hide = true;
                    this.Refresh();
                }
            }
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        void resetPanel()
        {
            pnl_simple.Size = new Size(850, 550);
            pnl_simple.Location = new Point(120, 75);
            pnl_simple.Visible = false;
            pnl_simple.Controls.Add(new simple());

            pnl_complex.Size = new Size(850, 550);
            pnl_complex.Location = new Point(120, 75);
            pnl_complex.Visible = false;
            pnl_complex.Controls.Add(new complex());
        }

        private void btn_simple_Click(object sender, EventArgs e)
        {
            if(pnl_simple.Visible)
            {
                return;
            }
            else
            {
                pnl_complex.Visible = false;
                pnl_simple.Visible = true;
                timer1.Start();
            }
        }

        private void btn_complex_Click(object sender, EventArgs e)
        {
            if(pnl_complex.Visible)
            {
                return;
            }
            else
            {
                pnl_simple.Visible = false;
                pnl_complex.Visible = true;
                timer1.Start();
            }
        }
    }
}
