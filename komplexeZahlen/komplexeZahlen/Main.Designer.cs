namespace komplexeZahlen
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnl_simple = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_exit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_slide = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnl_complex = new System.Windows.Forms.Panel();
            this.slidebar = new System.Windows.Forms.Panel();
            this.btn_complex = new System.Windows.Forms.Button();
            this.btn_simple = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_slide.SuspendLayout();
            this.slidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_simple
            // 
            this.pnl_simple.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_simple.Location = new System.Drawing.Point(567, 77);
            this.pnl_simple.Name = "pnl_simple";
            this.pnl_simple.Size = new System.Drawing.Size(139, 550);
            this.pnl_simple.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 50);
            this.panel1.TabIndex = 0;
            // 
            // lbl_exit
            // 
            this.lbl_exit.AutoSize = true;
            this.lbl_exit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_exit.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exit.ForeColor = System.Drawing.Color.Turquoise;
            this.lbl_exit.Location = new System.Drawing.Point(958, 0);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(42, 42);
            this.lbl_exit.TabIndex = 3;
            this.lbl_exit.Text = "X";
            this.lbl_exit.Click += new System.EventHandler(this.lbl_exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.pnl_slide);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(75, 600);
            this.panel2.TabIndex = 1;
            // 
            // pnl_slide
            // 
            this.pnl_slide.Controls.Add(this.panel7);
            this.pnl_slide.Controls.Add(this.panel6);
            this.pnl_slide.Controls.Add(this.panel5);
            this.pnl_slide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_slide.Location = new System.Drawing.Point(12, 6);
            this.pnl_slide.Name = "pnl_slide";
            this.pnl_slide.Size = new System.Drawing.Size(50, 50);
            this.pnl_slide.TabIndex = 3;
            this.pnl_slide.Click += new System.EventHandler(this.pnl_slide_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Turquoise;
            this.panel7.Location = new System.Drawing.Point(0, 40);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(50, 10);
            this.panel7.TabIndex = 6;
            this.panel7.Click += new System.EventHandler(this.pnl_slide_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Turquoise;
            this.panel6.Location = new System.Drawing.Point(0, 20);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(50, 10);
            this.panel6.TabIndex = 5;
            this.panel6.Click += new System.EventHandler(this.pnl_slide_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Turquoise;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(50, 10);
            this.panel5.TabIndex = 4;
            this.panel5.Click += new System.EventHandler(this.pnl_slide_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnl_complex
            // 
            this.pnl_complex.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnl_complex.Location = new System.Drawing.Point(763, 77);
            this.pnl_complex.Name = "pnl_complex";
            this.pnl_complex.Size = new System.Drawing.Size(127, 548);
            this.pnl_complex.TabIndex = 3;
            // 
            // slidebar
            // 
            this.slidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.slidebar.Controls.Add(this.btn_complex);
            this.slidebar.Controls.Add(this.btn_simple);
            this.slidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidebar.Location = new System.Drawing.Point(75, 50);
            this.slidebar.Name = "slidebar";
            this.slidebar.Size = new System.Drawing.Size(74, 600);
            this.slidebar.TabIndex = 5;
            // 
            // btn_complex
            // 
            this.btn_complex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btn_complex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_complex.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_complex.FlatAppearance.BorderSize = 0;
            this.btn_complex.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btn_complex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_complex.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_complex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btn_complex.Location = new System.Drawing.Point(0, 50);
            this.btn_complex.Name = "btn_complex";
            this.btn_complex.Size = new System.Drawing.Size(74, 50);
            this.btn_complex.TabIndex = 1;
            this.btn_complex.Text = "Komplex";
            this.btn_complex.UseVisualStyleBackColor = false;
            this.btn_complex.Click += new System.EventHandler(this.btn_complex_Click);
            // 
            // btn_simple
            // 
            this.btn_simple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btn_simple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_simple.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_simple.FlatAppearance.BorderSize = 0;
            this.btn_simple.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btn_simple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_simple.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simple.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btn_simple.Location = new System.Drawing.Point(0, 0);
            this.btn_simple.Name = "btn_simple";
            this.btn_simple.Size = new System.Drawing.Size(74, 50);
            this.btn_simple.TabIndex = 0;
            this.btn_simple.Text = "Einfach";
            this.btn_simple.UseVisualStyleBackColor = false;
            this.btn_simple.Click += new System.EventHandler(this.btn_simple_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Komplexer Taschenrechner";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.slidebar);
            this.Controls.Add(this.pnl_complex);
            this.Controls.Add(this.pnl_simple);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnl_slide.ResumeLayout(false);
            this.slidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_simple;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_slide;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_exit;
        private System.Windows.Forms.Panel pnl_complex;
        private System.Windows.Forms.Panel slidebar;
        private System.Windows.Forms.Button btn_complex;
        private System.Windows.Forms.Button btn_simple;
        private System.Windows.Forms.Label label1;
    }
}