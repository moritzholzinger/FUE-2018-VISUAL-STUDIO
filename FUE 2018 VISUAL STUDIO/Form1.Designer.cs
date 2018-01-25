namespace FUE_2018_VISUAL_STUDIO
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupFunktionen = new System.Windows.Forms.GroupBox();
            this.groupAnfangswerte = new System.Windows.Forms.GroupBox();
            this.groupIntervall = new System.Windows.Forms.GroupBox();
            this.groupAnzahlSchritte = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.numericX0 = new System.Windows.Forms.NumericUpDown();
            this.numericY0 = new System.Windows.Forms.NumericUpDown();
            this.numericObereGrenze = new System.Windows.Forms.NumericUpDown();
            this.numericAnzahlSchritte = new System.Windows.Forms.NumericUpDown();
            this.btnGO = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupFunktionen.SuspendLayout();
            this.groupAnfangswerte.SuspendLayout();
            this.groupIntervall.SuspendLayout();
            this.groupAnzahlSchritte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericX0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericObereGrenze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAnzahlSchritte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIFFERENTIALGLEICHUNGEN BERECHNEN";
            // 
            // groupFunktionen
            // 
            this.groupFunktionen.Controls.Add(this.radioButton3);
            this.groupFunktionen.Controls.Add(this.radioButton2);
            this.groupFunktionen.Controls.Add(this.radioButton1);
            this.groupFunktionen.Location = new System.Drawing.Point(79, 78);
            this.groupFunktionen.Name = "groupFunktionen";
            this.groupFunktionen.Size = new System.Drawing.Size(437, 92);
            this.groupFunktionen.TabIndex = 1;
            this.groupFunktionen.TabStop = false;
            this.groupFunktionen.Text = "Funktionen";
            // 
            // groupAnfangswerte
            // 
            this.groupAnfangswerte.Controls.Add(this.numericY0);
            this.groupAnfangswerte.Controls.Add(this.numericX0);
            this.groupAnfangswerte.Location = new System.Drawing.Point(79, 176);
            this.groupAnfangswerte.Name = "groupAnfangswerte";
            this.groupAnfangswerte.Size = new System.Drawing.Size(437, 53);
            this.groupAnfangswerte.TabIndex = 1;
            this.groupAnfangswerte.TabStop = false;
            this.groupAnfangswerte.Text = "Anfangswerte";
            // 
            // groupIntervall
            // 
            this.groupIntervall.Controls.Add(this.numericObereGrenze);
            this.groupIntervall.Location = new System.Drawing.Point(79, 235);
            this.groupIntervall.Name = "groupIntervall";
            this.groupIntervall.Size = new System.Drawing.Size(226, 56);
            this.groupIntervall.TabIndex = 1;
            this.groupIntervall.TabStop = false;
            this.groupIntervall.Text = "Intervall";
            // 
            // groupAnzahlSchritte
            // 
            this.groupAnzahlSchritte.Controls.Add(this.numericAnzahlSchritte);
            this.groupAnzahlSchritte.Location = new System.Drawing.Point(311, 235);
            this.groupAnzahlSchritte.Name = "groupAnzahlSchritte";
            this.groupAnzahlSchritte.Size = new System.Drawing.Size(205, 56);
            this.groupAnzahlSchritte.TabIndex = 1;
            this.groupAnzahlSchritte.TabStop = false;
            this.groupAnzahlSchritte.Text = "Anzahl Schritte";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // numericX0
            // 
            this.numericX0.Location = new System.Drawing.Point(29, 19);
            this.numericX0.Name = "numericX0";
            this.numericX0.Size = new System.Drawing.Size(120, 20);
            this.numericX0.TabIndex = 0;
            // 
            // numericY0
            // 
            this.numericY0.Location = new System.Drawing.Point(261, 19);
            this.numericY0.Name = "numericY0";
            this.numericY0.Size = new System.Drawing.Size(120, 20);
            this.numericY0.TabIndex = 0;
            // 
            // numericObereGrenze
            // 
            this.numericObereGrenze.Location = new System.Drawing.Point(9, 22);
            this.numericObereGrenze.Name = "numericObereGrenze";
            this.numericObereGrenze.Size = new System.Drawing.Size(120, 20);
            this.numericObereGrenze.TabIndex = 0;
            // 
            // numericAnzahlSchritte
            // 
            this.numericAnzahlSchritte.Location = new System.Drawing.Point(9, 22);
            this.numericAnzahlSchritte.Name = "numericAnzahlSchritte";
            this.numericAnzahlSchritte.Size = new System.Drawing.Size(120, 20);
            this.numericAnzahlSchritte.TabIndex = 0;
            // 
            // btnGO
            // 
            this.btnGO.Location = new System.Drawing.Point(79, 297);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(437, 39);
            this.btnGO.TabIndex = 2;
            this.btnGO.Text = "START";
            this.btnGO.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(79, 342);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(437, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(599, 737);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.groupAnzahlSchritte);
            this.Controls.Add(this.groupIntervall);
            this.Controls.Add(this.groupAnfangswerte);
            this.Controls.Add(this.groupFunktionen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "DIFFERENTIALGLEICHUNGSMEGARECHNER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupFunktionen.ResumeLayout(false);
            this.groupFunktionen.PerformLayout();
            this.groupAnfangswerte.ResumeLayout(false);
            this.groupIntervall.ResumeLayout(false);
            this.groupAnzahlSchritte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericX0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericObereGrenze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAnzahlSchritte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupFunktionen;
        private System.Windows.Forms.GroupBox groupAnfangswerte;
        private System.Windows.Forms.GroupBox groupIntervall;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.NumericUpDown numericY0;
        private System.Windows.Forms.NumericUpDown numericX0;
        private System.Windows.Forms.NumericUpDown numericObereGrenze;
        private System.Windows.Forms.GroupBox groupAnzahlSchritte;
        private System.Windows.Forms.NumericUpDown numericAnzahlSchritte;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

