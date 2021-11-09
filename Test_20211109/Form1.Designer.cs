namespace Test_20211109
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.jmeno = new System.Windows.Forms.Label();
            this.stav = new System.Windows.Forms.Label();
            this.jmenolbl = new System.Windows.Forms.Label();
            this.stavlbl = new System.Windows.Forms.Label();
            this.vlozitNN = new System.Windows.Forms.Button();
            this.vybratNN = new System.Windows.Forms.Button();
            this.vlozitN = new System.Windows.Forms.NumericUpDown();
            this.vybratN = new System.Windows.Forms.NumericUpDown();
            this.zaplatitNN = new System.Windows.Forms.Button();
            this.zaplatitN = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.limit1 = new System.Windows.Forms.Button();
            this.limitN = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.vlozitN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vybratN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaplatitN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitN)).BeginInit();
            this.SuspendLayout();
            // 
            // jmeno
            // 
            this.jmeno.AutoSize = true;
            this.jmeno.Location = new System.Drawing.Point(21, 9);
            this.jmeno.Name = "jmeno";
            this.jmeno.Size = new System.Drawing.Size(38, 13);
            this.jmeno.TabIndex = 0;
            this.jmeno.Text = "Jméno";
            // 
            // stav
            // 
            this.stav.AutoSize = true;
            this.stav.Location = new System.Drawing.Point(21, 38);
            this.stav.Name = "stav";
            this.stav.Size = new System.Drawing.Size(29, 13);
            this.stav.TabIndex = 1;
            this.stav.Text = "Stav";
            // 
            // jmenolbl
            // 
            this.jmenolbl.AutoSize = true;
            this.jmenolbl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.jmenolbl.Location = new System.Drawing.Point(126, 9);
            this.jmenolbl.Name = "jmenolbl";
            this.jmenolbl.Size = new System.Drawing.Size(10, 13);
            this.jmenolbl.TabIndex = 3;
            this.jmenolbl.Text = "-";
            // 
            // stavlbl
            // 
            this.stavlbl.AutoSize = true;
            this.stavlbl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.stavlbl.Location = new System.Drawing.Point(126, 38);
            this.stavlbl.Name = "stavlbl";
            this.stavlbl.Size = new System.Drawing.Size(10, 13);
            this.stavlbl.TabIndex = 4;
            this.stavlbl.Text = "-";
            // 
            // vlozitNN
            // 
            this.vlozitNN.AutoSize = true;
            this.vlozitNN.Location = new System.Drawing.Point(24, 84);
            this.vlozitNN.Name = "vlozitNN";
            this.vlozitNN.Size = new System.Drawing.Size(102, 34);
            this.vlozitNN.TabIndex = 5;
            this.vlozitNN.Text = "Vložit částku";
            this.vlozitNN.UseVisualStyleBackColor = true;
            // 
            // vybratNN
            // 
            this.vybratNN.AutoSize = true;
            this.vybratNN.Location = new System.Drawing.Point(24, 124);
            this.vybratNN.Name = "vybratNN";
            this.vybratNN.Size = new System.Drawing.Size(102, 34);
            this.vybratNN.TabIndex = 6;
            this.vybratNN.Text = "Vybrat částku";
            this.vybratNN.UseVisualStyleBackColor = true;
            // 
            // vlozitN
            // 
            this.vlozitN.Location = new System.Drawing.Point(132, 84);
            this.vlozitN.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.vlozitN.Name = "vlozitN";
            this.vlozitN.Size = new System.Drawing.Size(99, 20);
            this.vlozitN.TabIndex = 7;
            // 
            // vybratN
            // 
            this.vybratN.Location = new System.Drawing.Point(132, 124);
            this.vybratN.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.vybratN.Name = "vybratN";
            this.vybratN.Size = new System.Drawing.Size(99, 20);
            this.vybratN.TabIndex = 8;
            // 
            // zaplatitNN
            // 
            this.zaplatitNN.AutoSize = true;
            this.zaplatitNN.Location = new System.Drawing.Point(24, 164);
            this.zaplatitNN.Name = "zaplatitNN";
            this.zaplatitNN.Size = new System.Drawing.Size(102, 34);
            this.zaplatitNN.TabIndex = 9;
            this.zaplatitNN.Text = "Zaplatit";
            this.zaplatitNN.UseVisualStyleBackColor = true;
            // 
            // zaplatitN
            // 
            this.zaplatitN.Location = new System.Drawing.Point(132, 164);
            this.zaplatitN.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.zaplatitN.Name = "zaplatitN";
            this.zaplatitN.Size = new System.Drawing.Size(99, 20);
            this.zaplatitN.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(473, 9);
            this.label1.MaximumSize = new System.Drawing.Size(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Osobní účet";
            // 
            // limit1
            // 
            this.limit1.Location = new System.Drawing.Point(277, 84);
            this.limit1.Name = "limit1";
            this.limit1.Size = new System.Drawing.Size(102, 34);
            this.limit1.TabIndex = 12;
            this.limit1.Text = "Limit";
            this.limit1.UseVisualStyleBackColor = true;
            // 
            // limitN
            // 
            this.limitN.Location = new System.Drawing.Point(385, 84);
            this.limitN.Name = "limitN";
            this.limitN.Size = new System.Drawing.Size(102, 20);
            this.limitN.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.limitN);
            this.Controls.Add(this.limit1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zaplatitN);
            this.Controls.Add(this.zaplatitNN);
            this.Controls.Add(this.vybratN);
            this.Controls.Add(this.vlozitN);
            this.Controls.Add(this.vybratNN);
            this.Controls.Add(this.vlozitNN);
            this.Controls.Add(this.stavlbl);
            this.Controls.Add(this.jmenolbl);
            this.Controls.Add(this.stav);
            this.Controls.Add(this.jmeno);
            this.Name = "Form1";
            this.Text = "Form1";

            ((System.ComponentModel.ISupportInitialize)(this.vlozitN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vybratN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaplatitN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label jmeno;
        private System.Windows.Forms.Label stav;
        private System.Windows.Forms.Label jmenolbl;
        private System.Windows.Forms.Label stavlbl;
        private System.Windows.Forms.Button vlozitNN;
        private System.Windows.Forms.Button vybratNN;
        private System.Windows.Forms.NumericUpDown vlozitN;
        private System.Windows.Forms.NumericUpDown vybratN;
        private System.Windows.Forms.Button zaplatitNN;
        private System.Windows.Forms.NumericUpDown zaplatitN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button limit1;
        private System.Windows.Forms.NumericUpDown limitN;
    }
}

