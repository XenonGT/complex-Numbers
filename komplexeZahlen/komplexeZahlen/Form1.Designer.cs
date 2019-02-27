namespace komplexeZahlen
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_formulaZ2 = new System.Windows.Forms.Label();
            this.lbl_formulaZ1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lv_calc = new System.Windows.Forms.ListView();
            this.cb_operator = new System.Windows.Forms.ComboBox();
            this.pnl_z2 = new System.Windows.Forms.Panel();
            this.rb_polarZ2 = new System.Windows.Forms.RadioButton();
            this.rb_kartZ2 = new System.Windows.Forms.RadioButton();
            this.pnl_z1 = new System.Windows.Forms.Panel();
            this.rb_polarZ1 = new System.Windows.Forms.RadioButton();
            this.rb_kartZ1 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_solution = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_calc = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_exec = new System.Windows.Forms.Button();
            this.tb_z2value2 = new System.Windows.Forms.TextBox();
            this.lbl_z2i = new System.Windows.Forms.Label();
            this.lbl_z2ad = new System.Windows.Forms.Label();
            this.tb_z2value1 = new System.Windows.Forms.TextBox();
            this.lbl_z2 = new System.Windows.Forms.Label();
            this.tb_z1value2 = new System.Windows.Forms.TextBox();
            this.lbl_z1i = new System.Windows.Forms.Label();
            this.lbl_z1ad = new System.Windows.Forms.Label();
            this.tb_z1value1 = new System.Windows.Forms.TextBox();
            this.lbl_z1 = new System.Windows.Forms.Label();
            this.btn_information = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnl_z2.SuspendLayout();
            this.pnl_z1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_information);
            this.panel1.Controls.Add(this.lbl_formulaZ2);
            this.panel1.Controls.Add(this.lbl_formulaZ1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lv_calc);
            this.panel1.Controls.Add(this.cb_operator);
            this.panel1.Controls.Add(this.pnl_z2);
            this.panel1.Controls.Add(this.pnl_z1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbl_solution);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lbl_calc);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btn_exec);
            this.panel1.Controls.Add(this.tb_z2value2);
            this.panel1.Controls.Add(this.lbl_z2i);
            this.panel1.Controls.Add(this.lbl_z2ad);
            this.panel1.Controls.Add(this.tb_z2value1);
            this.panel1.Controls.Add(this.lbl_z2);
            this.panel1.Controls.Add(this.tb_z1value2);
            this.panel1.Controls.Add(this.lbl_z1i);
            this.panel1.Controls.Add(this.lbl_z1ad);
            this.panel1.Controls.Add(this.tb_z1value1);
            this.panel1.Controls.Add(this.lbl_z1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 561);
            this.panel1.TabIndex = 39;
            // 
            // lbl_formulaZ2
            // 
            this.lbl_formulaZ2.AutoSize = true;
            this.lbl_formulaZ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_formulaZ2.Location = new System.Drawing.Point(613, 23);
            this.lbl_formulaZ2.Name = "lbl_formulaZ2";
            this.lbl_formulaZ2.Size = new System.Drawing.Size(245, 24);
            this.lbl_formulaZ2.TabIndex = 53;
            this.lbl_formulaZ2.Text = "Z2 = r * (cos(Phi) + sin(Phi)i)";
            this.lbl_formulaZ2.Visible = false;
            // 
            // lbl_formulaZ1
            // 
            this.lbl_formulaZ1.AutoSize = true;
            this.lbl_formulaZ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_formulaZ1.Location = new System.Drawing.Point(125, 23);
            this.lbl_formulaZ1.Name = "lbl_formulaZ1";
            this.lbl_formulaZ1.Size = new System.Drawing.Size(245, 24);
            this.lbl_formulaZ1.TabIndex = 52;
            this.lbl_formulaZ1.Text = "Z1 = r * (cos(Phi) + sin(Phi)i)";
            this.lbl_formulaZ1.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panel4.Location = new System.Drawing.Point(0, 400);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(460, 10);
            this.panel4.TabIndex = 51;
            // 
            // lv_calc
            // 
            this.lv_calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_calc.Location = new System.Drawing.Point(471, 255);
            this.lv_calc.Name = "lv_calc";
            this.lv_calc.Size = new System.Drawing.Size(448, 294);
            this.lv_calc.TabIndex = 50;
            this.lv_calc.TileSize = new System.Drawing.Size(425, 20);
            this.lv_calc.UseCompatibleStateImageBehavior = false;
            this.lv_calc.View = System.Windows.Forms.View.Tile;
            // 
            // cb_operator
            // 
            this.cb_operator.BackColor = System.Drawing.Color.White;
            this.cb_operator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_operator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_operator.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_operator.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_operator.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.cb_operator.FormattingEnabled = true;
            this.cb_operator.Items.AddRange(new object[] {
            "Addition",
            "Subtraktion",
            "Multiplikation",
            "Division"});
            this.cb_operator.Location = new System.Drawing.Point(85, 309);
            this.cb_operator.Name = "cb_operator";
            this.cb_operator.Size = new System.Drawing.Size(168, 39);
            this.cb_operator.TabIndex = 49;
            this.cb_operator.SelectedIndexChanged += new System.EventHandler(this.cb_operator_SelectedIndexChanged);
            // 
            // pnl_z2
            // 
            this.pnl_z2.Controls.Add(this.rb_polarZ2);
            this.pnl_z2.Controls.Add(this.rb_kartZ2);
            this.pnl_z2.Location = new System.Drawing.Point(509, 148);
            this.pnl_z2.Name = "pnl_z2";
            this.pnl_z2.Size = new System.Drawing.Size(382, 85);
            this.pnl_z2.TabIndex = 47;
            // 
            // rb_polarZ2
            // 
            this.rb_polarZ2.AutoSize = true;
            this.rb_polarZ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_polarZ2.Location = new System.Drawing.Point(252, 31);
            this.rb_polarZ2.Name = "rb_polarZ2";
            this.rb_polarZ2.Size = new System.Drawing.Size(108, 28);
            this.rb_polarZ2.TabIndex = 1;
            this.rb_polarZ2.Text = "Polarform";
            this.rb_polarZ2.UseVisualStyleBackColor = true;
            this.rb_polarZ2.CheckedChanged += new System.EventHandler(this.rb_polarZ2_CheckedChanged);
            // 
            // rb_kartZ2
            // 
            this.rb_kartZ2.AutoSize = true;
            this.rb_kartZ2.Checked = true;
            this.rb_kartZ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_kartZ2.Location = new System.Drawing.Point(31, 31);
            this.rb_kartZ2.Name = "rb_kartZ2";
            this.rb_kartZ2.Size = new System.Drawing.Size(175, 28);
            this.rb_kartZ2.TabIndex = 0;
            this.rb_kartZ2.TabStop = true;
            this.rb_kartZ2.Text = "Kartesische Form";
            this.rb_kartZ2.UseVisualStyleBackColor = true;
            // 
            // pnl_z1
            // 
            this.pnl_z1.Controls.Add(this.rb_polarZ1);
            this.pnl_z1.Controls.Add(this.rb_kartZ1);
            this.pnl_z1.Location = new System.Drawing.Point(37, 148);
            this.pnl_z1.Name = "pnl_z1";
            this.pnl_z1.Size = new System.Drawing.Size(382, 85);
            this.pnl_z1.TabIndex = 46;
            // 
            // rb_polarZ1
            // 
            this.rb_polarZ1.AutoSize = true;
            this.rb_polarZ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_polarZ1.Location = new System.Drawing.Point(246, 31);
            this.rb_polarZ1.Name = "rb_polarZ1";
            this.rb_polarZ1.Size = new System.Drawing.Size(108, 28);
            this.rb_polarZ1.TabIndex = 1;
            this.rb_polarZ1.Text = "Polarform";
            this.rb_polarZ1.UseVisualStyleBackColor = true;
            this.rb_polarZ1.CheckedChanged += new System.EventHandler(this.rb_polarZ1_CheckedChanged);
            // 
            // rb_kartZ1
            // 
            this.rb_kartZ1.AutoSize = true;
            this.rb_kartZ1.Checked = true;
            this.rb_kartZ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_kartZ1.Location = new System.Drawing.Point(20, 31);
            this.rb_kartZ1.Name = "rb_kartZ1";
            this.rb_kartZ1.Size = new System.Drawing.Size(175, 28);
            this.rb_kartZ1.TabIndex = 0;
            this.rb_kartZ1.TabStop = true;
            this.rb_kartZ1.Text = "Kartesische Form";
            this.rb_kartZ1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panel3.Location = new System.Drawing.Point(0, 239);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(950, 10);
            this.panel3.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panel2.Location = new System.Drawing.Point(456, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 240);
            this.panel2.TabIndex = 38;
            // 
            // lbl_solution
            // 
            this.lbl_solution.AutoSize = true;
            this.lbl_solution.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_solution.Location = new System.Drawing.Point(221, 446);
            this.lbl_solution.Name = "lbl_solution";
            this.lbl_solution.Size = new System.Drawing.Size(133, 37);
            this.lbl_solution.TabIndex = 37;
            this.lbl_solution.Text = "Solution";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(121, 446);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 37);
            this.label9.TabIndex = 36;
            this.label9.Text = "Z2 =";
            // 
            // lbl_calc
            // 
            this.lbl_calc.AutoSize = true;
            this.lbl_calc.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calc.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_calc.Location = new System.Drawing.Point(75, 446);
            this.lbl_calc.Name = "lbl_calc";
            this.lbl_calc.Size = new System.Drawing.Size(36, 37);
            this.lbl_calc.TabIndex = 35;
            this.lbl_calc.Text = "+";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 37);
            this.label7.TabIndex = 34;
            this.label7.Text = "Z1";
            // 
            // btn_exec
            // 
            this.btn_exec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btn_exec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exec.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_exec.FlatAppearance.BorderSize = 0;
            this.btn_exec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btn_exec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exec.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_exec.Location = new System.Drawing.Point(299, 298);
            this.btn_exec.Name = "btn_exec";
            this.btn_exec.Size = new System.Drawing.Size(120, 50);
            this.btn_exec.TabIndex = 32;
            this.btn_exec.Text = "Ausführen";
            this.btn_exec.UseVisualStyleBackColor = false;
            this.btn_exec.Click += new System.EventHandler(this.btn_exec_Click);
            // 
            // tb_z2value2
            // 
            this.tb_z2value2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_z2value2.Location = new System.Drawing.Point(791, 83);
            this.tb_z2value2.Name = "tb_z2value2";
            this.tb_z2value2.Size = new System.Drawing.Size(100, 40);
            this.tb_z2value2.TabIndex = 31;
            // 
            // lbl_z2i
            // 
            this.lbl_z2i.AutoSize = true;
            this.lbl_z2i.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_z2i.Location = new System.Drawing.Point(897, 86);
            this.lbl_z2i.Name = "lbl_z2i";
            this.lbl_z2i.Size = new System.Drawing.Size(25, 39);
            this.lbl_z2i.TabIndex = 30;
            this.lbl_z2i.Text = "i";
            // 
            // lbl_z2ad
            // 
            this.lbl_z2ad.AutoSize = true;
            this.lbl_z2ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_z2ad.Location = new System.Drawing.Point(691, 86);
            this.lbl_z2ad.Name = "lbl_z2ad";
            this.lbl_z2ad.Size = new System.Drawing.Size(37, 39);
            this.lbl_z2ad.TabIndex = 29;
            this.lbl_z2ad.Text = "+";
            // 
            // tb_z2value1
            // 
            this.tb_z2value1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_z2value1.Location = new System.Drawing.Point(567, 80);
            this.tb_z2value1.Name = "tb_z2value1";
            this.tb_z2value1.Size = new System.Drawing.Size(100, 40);
            this.tb_z2value1.TabIndex = 28;
            // 
            // lbl_z2
            // 
            this.lbl_z2.AutoSize = true;
            this.lbl_z2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_z2.Location = new System.Drawing.Point(484, 81);
            this.lbl_z2.Name = "lbl_z2";
            this.lbl_z2.Size = new System.Drawing.Size(77, 39);
            this.lbl_z2.TabIndex = 27;
            this.lbl_z2.Text = "Z2=";
            // 
            // tb_z1value2
            // 
            this.tb_z1value2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_z1value2.Location = new System.Drawing.Point(319, 80);
            this.tb_z1value2.Name = "tb_z1value2";
            this.tb_z1value2.Size = new System.Drawing.Size(100, 40);
            this.tb_z1value2.TabIndex = 26;
            // 
            // lbl_z1i
            // 
            this.lbl_z1i.AutoSize = true;
            this.lbl_z1i.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_z1i.Location = new System.Drawing.Point(425, 86);
            this.lbl_z1i.Name = "lbl_z1i";
            this.lbl_z1i.Size = new System.Drawing.Size(25, 39);
            this.lbl_z1i.TabIndex = 25;
            this.lbl_z1i.Text = "i";
            // 
            // lbl_z1ad
            // 
            this.lbl_z1ad.AutoSize = true;
            this.lbl_z1ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_z1ad.Location = new System.Drawing.Point(221, 86);
            this.lbl_z1ad.Name = "lbl_z1ad";
            this.lbl_z1ad.Size = new System.Drawing.Size(37, 39);
            this.lbl_z1ad.TabIndex = 24;
            this.lbl_z1ad.Text = "+";
            // 
            // tb_z1value1
            // 
            this.tb_z1value1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_z1value1.Location = new System.Drawing.Point(97, 80);
            this.tb_z1value1.Name = "tb_z1value1";
            this.tb_z1value1.Size = new System.Drawing.Size(100, 40);
            this.tb_z1value1.TabIndex = 23;
            // 
            // lbl_z1
            // 
            this.lbl_z1.AutoSize = true;
            this.lbl_z1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_z1.Location = new System.Drawing.Point(14, 81);
            this.lbl_z1.Name = "lbl_z1";
            this.lbl_z1.Size = new System.Drawing.Size(77, 39);
            this.lbl_z1.TabIndex = 22;
            this.lbl_z1.Text = "Z1=";
            // 
            // btn_information
            // 
            this.btn_information.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btn_information.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_information.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_information.FlatAppearance.BorderSize = 0;
            this.btn_information.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btn_information.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_information.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_information.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_information.Location = new System.Drawing.Point(369, 499);
            this.btn_information.Name = "btn_information";
            this.btn_information.Size = new System.Drawing.Size(50, 50);
            this.btn_information.TabIndex = 54;
            this.btn_information.Text = "?";
            this.btn_information.UseVisualStyleBackColor = false;
            this.btn_information.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_z2.ResumeLayout(false);
            this.pnl_z2.PerformLayout();
            this.pnl_z1.ResumeLayout(false);
            this.pnl_z1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_z2;
        private System.Windows.Forms.RadioButton rb_polarZ2;
        private System.Windows.Forms.RadioButton rb_kartZ2;
        private System.Windows.Forms.Panel pnl_z1;
        private System.Windows.Forms.RadioButton rb_polarZ1;
        private System.Windows.Forms.RadioButton rb_kartZ1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_solution;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_calc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_exec;
        private System.Windows.Forms.TextBox tb_z2value2;
        private System.Windows.Forms.Label lbl_z2i;
        private System.Windows.Forms.Label lbl_z2ad;
        private System.Windows.Forms.TextBox tb_z2value1;
        private System.Windows.Forms.Label lbl_z2;
        private System.Windows.Forms.TextBox tb_z1value2;
        private System.Windows.Forms.Label lbl_z1i;
        private System.Windows.Forms.Label lbl_z1ad;
        private System.Windows.Forms.TextBox tb_z1value1;
        private System.Windows.Forms.Label lbl_z1;
        private System.Windows.Forms.ComboBox cb_operator;
        private System.Windows.Forms.ListView lv_calc;
        private System.Windows.Forms.Label lbl_formulaZ2;
        private System.Windows.Forms.Label lbl_formulaZ1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_information;
    }
}

