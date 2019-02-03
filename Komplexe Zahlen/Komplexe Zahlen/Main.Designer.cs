namespace Komplexe_Zahlen
{
    partial class Main
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
            this.pnl_DaD = new System.Windows.Forms.Panel();
            this.lbl_Exit = new System.Windows.Forms.Label();
            this.lbl_minimize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Action = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.pnl_SelectSolution = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Random = new System.Windows.Forms.Button();
            this.btn_Input = new System.Windows.Forms.Button();
            this.pnl_DaD.SuspendLayout();
            this.pnl_SelectSolution.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_DaD
            // 
            this.pnl_DaD.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnl_DaD.Controls.Add(this.label1);
            this.pnl_DaD.Controls.Add(this.lbl_minimize);
            this.pnl_DaD.Controls.Add(this.lbl_Exit);
            this.pnl_DaD.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_DaD.Location = new System.Drawing.Point(0, 0);
            this.pnl_DaD.Name = "pnl_DaD";
            this.pnl_DaD.Size = new System.Drawing.Size(1000, 70);
            this.pnl_DaD.TabIndex = 0;
            // 
            // lbl_Exit
            // 
            this.lbl_Exit.AutoSize = true;
            this.lbl_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Exit.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Exit.ForeColor = System.Drawing.Color.White;
            this.lbl_Exit.Location = new System.Drawing.Point(966, 0);
            this.lbl_Exit.Name = "lbl_Exit";
            this.lbl_Exit.Size = new System.Drawing.Size(35, 35);
            this.lbl_Exit.TabIndex = 0;
            this.lbl_Exit.Text = "X";
            this.lbl_Exit.Click += new System.EventHandler(this.lbl_Exit_Click);
            // 
            // lbl_minimize
            // 
            this.lbl_minimize.AutoSize = true;
            this.lbl_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_minimize.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_minimize.ForeColor = System.Drawing.Color.White;
            this.lbl_minimize.Location = new System.Drawing.Point(930, 0);
            this.lbl_minimize.Name = "lbl_minimize";
            this.lbl_minimize.Size = new System.Drawing.Size(30, 29);
            this.lbl_minimize.TabIndex = 1;
            this.lbl_minimize.Text = "_";
            this.lbl_minimize.Click += new System.EventHandler(this.lbl_minimize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(274, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Komplexe Zahlen berechnen";
            // 
            // pnl_Action
            // 
            this.pnl_Action.Location = new System.Drawing.Point(23, 539);
            this.pnl_Action.Name = "pnl_Action";
            this.pnl_Action.Size = new System.Drawing.Size(950, 237);
            this.pnl_Action.TabIndex = 1;
            // 
            // btn_Back
            // 
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn_Back.FlatAppearance.BorderSize = 2;
            this.btn_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(23, 102);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(100, 50);
            this.btn_Back.TabIndex = 2;
            this.btn_Back.Text = "Zurück";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Visible = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // pnl_SelectSolution
            // 
            this.pnl_SelectSolution.Controls.Add(this.btn_Input);
            this.pnl_SelectSolution.Controls.Add(this.btn_Random);
            this.pnl_SelectSolution.Controls.Add(this.label2);
            this.pnl_SelectSolution.Location = new System.Drawing.Point(87, 197);
            this.pnl_SelectSolution.Name = "pnl_SelectSolution";
            this.pnl_SelectSolution.Size = new System.Drawing.Size(797, 303);
            this.pnl_SelectSolution.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(34, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(712, 62);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wählen Sie aus, ob sie mit Zufallszahlen oder mit manuell \r\neingegebenen Zahlen r" +
    "echnen wollen";
            // 
            // btn_Random
            // 
            this.btn_Random.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Random.Enabled = false;
            this.btn_Random.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn_Random.FlatAppearance.BorderSize = 2;
            this.btn_Random.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Random.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Random.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Random.Location = new System.Drawing.Point(29, 179);
            this.btn_Random.Name = "btn_Random";
            this.btn_Random.Size = new System.Drawing.Size(200, 100);
            this.btn_Random.TabIndex = 4;
            this.btn_Random.Text = "Zufallszahlen";
            this.btn_Random.UseVisualStyleBackColor = true;
            // 
            // btn_Input
            // 
            this.btn_Input.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Input.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn_Input.FlatAppearance.BorderSize = 2;
            this.btn_Input.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Input.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Input.Location = new System.Drawing.Point(567, 179);
            this.btn_Input.Name = "btn_Input";
            this.btn_Input.Size = new System.Drawing.Size(200, 100);
            this.btn_Input.TabIndex = 5;
            this.btn_Input.Text = "Manuell eingegebene Zahlen";
            this.btn_Input.UseVisualStyleBackColor = true;
            this.btn_Input.Click += new System.EventHandler(this.btn_Input_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.pnl_SelectSolution);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.pnl_Action);
            this.Controls.Add(this.pnl_DaD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.pnl_DaD.ResumeLayout(false);
            this.pnl_DaD.PerformLayout();
            this.pnl_SelectSolution.ResumeLayout(false);
            this.pnl_SelectSolution.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_DaD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_minimize;
        private System.Windows.Forms.Label lbl_Exit;
        private System.Windows.Forms.Panel pnl_Action;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel pnl_SelectSolution;
        private System.Windows.Forms.Button btn_Input;
        private System.Windows.Forms.Button btn_Random;
        private System.Windows.Forms.Label label2;
    }
}

