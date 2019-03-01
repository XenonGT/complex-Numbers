namespace komplexeZahlen.UCs
{
    partial class simple
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_formulaZ1 = new System.Windows.Forms.Label();
            this.pnl_z1 = new System.Windows.Forms.Panel();
            this.rb_polarZ1 = new System.Windows.Forms.RadioButton();
            this.rb_kartZ1 = new System.Windows.Forms.RadioButton();
            this.tb_z1value2 = new System.Windows.Forms.TextBox();
            this.lbl_z1i = new System.Windows.Forms.Label();
            this.lbl_z1ad = new System.Windows.Forms.Label();
            this.tb_z1value1 = new System.Windows.Forms.TextBox();
            this.lbl_z1 = new System.Windows.Forms.Label();
            this.lbl_formulaZ2 = new System.Windows.Forms.Label();
            this.pnl_z2 = new System.Windows.Forms.Panel();
            this.rb_polarZ2 = new System.Windows.Forms.RadioButton();
            this.rb_kartZ2 = new System.Windows.Forms.RadioButton();
            this.tb_z2value2 = new System.Windows.Forms.TextBox();
            this.lbl_z2i = new System.Windows.Forms.Label();
            this.lbl_z2ad = new System.Windows.Forms.Label();
            this.tb_z2value1 = new System.Windows.Forms.TextBox();
            this.lbl_z2 = new System.Windows.Forms.Label();
            this.cb_operator = new System.Windows.Forms.ComboBox();
            this.btn_exec = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_solution = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_calc = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lv_calc = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_z1.SuspendLayout();
            this.pnl_z2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_formulaZ1
            // 
            this.lbl_formulaZ1.AutoSize = true;
            this.lbl_formulaZ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_formulaZ1.Location = new System.Drawing.Point(88, 15);
            this.lbl_formulaZ1.Name = "lbl_formulaZ1";
            this.lbl_formulaZ1.Size = new System.Drawing.Size(245, 24);
            this.lbl_formulaZ1.TabIndex = 59;
            this.lbl_formulaZ1.Text = "Z1 = r * (cos(Phi) + sin(Phi)i)";
            this.lbl_formulaZ1.Visible = false;
            // 
            // pnl_z1
            // 
            this.pnl_z1.Controls.Add(this.rb_polarZ1);
            this.pnl_z1.Controls.Add(this.rb_kartZ1);
            this.pnl_z1.Location = new System.Drawing.Point(449, 15);
            this.pnl_z1.Name = "pnl_z1";
            this.pnl_z1.Size = new System.Drawing.Size(382, 85);
            this.pnl_z1.TabIndex = 58;
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
            // tb_z1value2
            // 
            this.tb_z1value2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_z1value2.Location = new System.Drawing.Point(233, 60);
            this.tb_z1value2.Name = "tb_z1value2";
            this.tb_z1value2.Size = new System.Drawing.Size(100, 38);
            this.tb_z1value2.TabIndex = 57;
            // 
            // lbl_z1i
            // 
            this.lbl_z1i.AutoSize = true;
            this.lbl_z1i.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_z1i.Location = new System.Drawing.Point(339, 63);
            this.lbl_z1i.Name = "lbl_z1i";
            this.lbl_z1i.Size = new System.Drawing.Size(20, 31);
            this.lbl_z1i.TabIndex = 56;
            this.lbl_z1i.Text = "i";
            // 
            // lbl_z1ad
            // 
            this.lbl_z1ad.AutoSize = true;
            this.lbl_z1ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_z1ad.Location = new System.Drawing.Point(197, 63);
            this.lbl_z1ad.Name = "lbl_z1ad";
            this.lbl_z1ad.Size = new System.Drawing.Size(30, 31);
            this.lbl_z1ad.TabIndex = 55;
            this.lbl_z1ad.Text = "+";
            // 
            // tb_z1value1
            // 
            this.tb_z1value1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_z1value1.Location = new System.Drawing.Point(91, 60);
            this.tb_z1value1.Name = "tb_z1value1";
            this.tb_z1value1.Size = new System.Drawing.Size(100, 38);
            this.tb_z1value1.TabIndex = 54;
            // 
            // lbl_z1
            // 
            this.lbl_z1.AutoSize = true;
            this.lbl_z1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_z1.Location = new System.Drawing.Point(23, 63);
            this.lbl_z1.Name = "lbl_z1";
            this.lbl_z1.Size = new System.Drawing.Size(62, 31);
            this.lbl_z1.TabIndex = 53;
            this.lbl_z1.Text = "Z1=";
            // 
            // lbl_formulaZ2
            // 
            this.lbl_formulaZ2.AutoSize = true;
            this.lbl_formulaZ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_formulaZ2.Location = new System.Drawing.Point(87, 142);
            this.lbl_formulaZ2.Name = "lbl_formulaZ2";
            this.lbl_formulaZ2.Size = new System.Drawing.Size(245, 24);
            this.lbl_formulaZ2.TabIndex = 66;
            this.lbl_formulaZ2.Text = "Z2 = r * (cos(Phi) + sin(Phi)i)";
            this.lbl_formulaZ2.Visible = false;
            // 
            // pnl_z2
            // 
            this.pnl_z2.Controls.Add(this.rb_polarZ2);
            this.pnl_z2.Controls.Add(this.rb_kartZ2);
            this.pnl_z2.Location = new System.Drawing.Point(449, 142);
            this.pnl_z2.Name = "pnl_z2";
            this.pnl_z2.Size = new System.Drawing.Size(382, 85);
            this.pnl_z2.TabIndex = 65;
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
            // tb_z2value2
            // 
            this.tb_z2value2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_z2value2.Location = new System.Drawing.Point(233, 187);
            this.tb_z2value2.Name = "tb_z2value2";
            this.tb_z2value2.Size = new System.Drawing.Size(100, 38);
            this.tb_z2value2.TabIndex = 64;
            // 
            // lbl_z2i
            // 
            this.lbl_z2i.AutoSize = true;
            this.lbl_z2i.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_z2i.Location = new System.Drawing.Point(339, 190);
            this.lbl_z2i.Name = "lbl_z2i";
            this.lbl_z2i.Size = new System.Drawing.Size(20, 31);
            this.lbl_z2i.TabIndex = 63;
            this.lbl_z2i.Text = "i";
            // 
            // lbl_z2ad
            // 
            this.lbl_z2ad.AutoSize = true;
            this.lbl_z2ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_z2ad.Location = new System.Drawing.Point(197, 190);
            this.lbl_z2ad.Name = "lbl_z2ad";
            this.lbl_z2ad.Size = new System.Drawing.Size(30, 31);
            this.lbl_z2ad.TabIndex = 62;
            this.lbl_z2ad.Text = "+";
            // 
            // tb_z2value1
            // 
            this.tb_z2value1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_z2value1.Location = new System.Drawing.Point(91, 187);
            this.tb_z2value1.Name = "tb_z2value1";
            this.tb_z2value1.Size = new System.Drawing.Size(100, 38);
            this.tb_z2value1.TabIndex = 61;
            // 
            // lbl_z2
            // 
            this.lbl_z2.AutoSize = true;
            this.lbl_z2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_z2.Location = new System.Drawing.Point(23, 190);
            this.lbl_z2.Name = "lbl_z2";
            this.lbl_z2.Size = new System.Drawing.Size(62, 31);
            this.lbl_z2.TabIndex = 60;
            this.lbl_z2.Text = "Z2=";
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
            this.cb_operator.Location = new System.Drawing.Point(29, 307);
            this.cb_operator.Name = "cb_operator";
            this.cb_operator.Size = new System.Drawing.Size(168, 39);
            this.cb_operator.TabIndex = 68;
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
            this.btn_exec.Location = new System.Drawing.Point(239, 296);
            this.btn_exec.Name = "btn_exec";
            this.btn_exec.Size = new System.Drawing.Size(120, 50);
            this.btn_exec.TabIndex = 67;
            this.btn_exec.Text = "Ausführen";
            this.btn_exec.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panel2.Location = new System.Drawing.Point(0, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 10);
            this.panel2.TabIndex = 69;
            // 
            // lbl_solution
            // 
            this.lbl_solution.AutoSize = true;
            this.lbl_solution.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_solution.Location = new System.Drawing.Point(226, 444);
            this.lbl_solution.Name = "lbl_solution";
            this.lbl_solution.Size = new System.Drawing.Size(133, 37);
            this.lbl_solution.TabIndex = 73;
            this.lbl_solution.Text = "Solution";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(126, 444);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 37);
            this.label9.TabIndex = 72;
            this.label9.Text = "Z2 =";
            // 
            // lbl_calc
            // 
            this.lbl_calc.AutoSize = true;
            this.lbl_calc.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calc.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_calc.Location = new System.Drawing.Point(80, 444);
            this.lbl_calc.Name = "lbl_calc";
            this.lbl_calc.Size = new System.Drawing.Size(36, 37);
            this.lbl_calc.TabIndex = 71;
            this.lbl_calc.Text = "+";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 37);
            this.label7.TabIndex = 70;
            this.label7.Text = "Z1";
            // 
            // lv_calc
            // 
            this.lv_calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_calc.Location = new System.Drawing.Point(406, 243);
            this.lv_calc.Name = "lv_calc";
            this.lv_calc.Size = new System.Drawing.Size(441, 304);
            this.lv_calc.TabIndex = 74;
            this.lv_calc.TileSize = new System.Drawing.Size(425, 20);
            this.lv_calc.UseCompatibleStateImageBehavior = false;
            this.lv_calc.View = System.Windows.Forms.View.Tile;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panel1.Location = new System.Drawing.Point(0, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 10);
            this.panel1.TabIndex = 75;
            // 
            // simple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lv_calc);
            this.Controls.Add(this.lbl_solution);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_calc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cb_operator);
            this.Controls.Add(this.btn_exec);
            this.Controls.Add(this.lbl_formulaZ2);
            this.Controls.Add(this.pnl_z2);
            this.Controls.Add(this.tb_z2value2);
            this.Controls.Add(this.lbl_z2i);
            this.Controls.Add(this.lbl_z2ad);
            this.Controls.Add(this.tb_z2value1);
            this.Controls.Add(this.lbl_z2);
            this.Controls.Add(this.lbl_formulaZ1);
            this.Controls.Add(this.pnl_z1);
            this.Controls.Add(this.tb_z1value2);
            this.Controls.Add(this.lbl_z1i);
            this.Controls.Add(this.lbl_z1ad);
            this.Controls.Add(this.tb_z1value1);
            this.Controls.Add(this.lbl_z1);
            this.Name = "simple";
            this.Size = new System.Drawing.Size(850, 550);
            this.pnl_z1.ResumeLayout(false);
            this.pnl_z1.PerformLayout();
            this.pnl_z2.ResumeLayout(false);
            this.pnl_z2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_formulaZ1;
        private System.Windows.Forms.Panel pnl_z1;
        private System.Windows.Forms.RadioButton rb_polarZ1;
        private System.Windows.Forms.RadioButton rb_kartZ1;
        private System.Windows.Forms.TextBox tb_z1value2;
        private System.Windows.Forms.Label lbl_z1i;
        private System.Windows.Forms.Label lbl_z1ad;
        private System.Windows.Forms.TextBox tb_z1value1;
        private System.Windows.Forms.Label lbl_z1;
        private System.Windows.Forms.Label lbl_formulaZ2;
        private System.Windows.Forms.Panel pnl_z2;
        private System.Windows.Forms.RadioButton rb_polarZ2;
        private System.Windows.Forms.RadioButton rb_kartZ2;
        private System.Windows.Forms.TextBox tb_z2value2;
        private System.Windows.Forms.Label lbl_z2i;
        private System.Windows.Forms.Label lbl_z2ad;
        private System.Windows.Forms.TextBox tb_z2value1;
        private System.Windows.Forms.Label lbl_z2;
        private System.Windows.Forms.ComboBox cb_operator;
        private System.Windows.Forms.Button btn_exec;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_solution;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_calc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lv_calc;
        private System.Windows.Forms.Panel panel1;
    }
}
