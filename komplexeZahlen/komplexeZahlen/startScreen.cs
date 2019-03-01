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
    public partial class startScreen : Form
    {
        int finProgress = 400;
        public startScreen()
        {
            InitializeComponent();
            progress.Width = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progress.Width += 10;
            if(progress.Width >= finProgress)
            {
                timer1.Stop();
                this.Hide();
                new Main().Show();
            }
        }
    }
}
