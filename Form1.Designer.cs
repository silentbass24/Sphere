
namespace PaoloCiolaProvaFinale
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtRaggio = new System.Windows.Forms.TextBox();
            this.labelRaggio = new System.Windows.Forms.Label();
            this.btnCalcola = new System.Windows.Forms.Button();
            this.labelArea = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.labelVolume = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.btnSalvaSuFile = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnVolume = new System.Windows.Forms.RadioButton();
            this.radioBtnArea = new System.Windows.Forms.RadioButton();
            this.radioBtnRaggio = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRaggio
            // 
            this.txtRaggio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaggio.Location = new System.Drawing.Point(226, 64);
            this.txtRaggio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRaggio.Name = "txtRaggio";
            this.txtRaggio.Size = new System.Drawing.Size(148, 30);
            this.txtRaggio.TabIndex = 0;
            // 
            // labelRaggio
            // 
            this.labelRaggio.AutoSize = true;
            this.labelRaggio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRaggio.Location = new System.Drawing.Point(78, 64);
            this.labelRaggio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRaggio.Name = "labelRaggio";
            this.labelRaggio.Size = new System.Drawing.Size(108, 25);
            this.labelRaggio.TabIndex = 1;
            this.labelRaggio.Text = "Raggio (m)";
            // 
            // btnCalcola
            // 
            this.btnCalcola.Location = new System.Drawing.Point(61, 277);
            this.btnCalcola.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(149, 51);
            this.btnCalcola.TabIndex = 2;
            this.btnCalcola.Text = "Calcola";
            this.btnCalcola.UseVisualStyleBackColor = true;
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click);
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArea.Location = new System.Drawing.Point(78, 136);
            this.labelArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(107, 25);
            this.labelArea.TabIndex = 4;
            this.labelArea.Text = "Area (m^2)";
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(226, 136);
            this.txtArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(148, 30);
            this.txtArea.TabIndex = 3;
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolume.Location = new System.Drawing.Point(78, 203);
            this.labelVolume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(132, 25);
            this.labelVolume.TabIndex = 6;
            this.labelVolume.Text = "Volume (m^3)";
            // 
            // txtVolume
            // 
            this.txtVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolume.Location = new System.Drawing.Point(226, 203);
            this.txtVolume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(148, 30);
            this.txtVolume.TabIndex = 5;
            // 
            // btnSalvaSuFile
            // 
            this.btnSalvaSuFile.Location = new System.Drawing.Point(299, 307);
            this.btnSalvaSuFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalvaSuFile.Name = "btnSalvaSuFile";
            this.btnSalvaSuFile.Size = new System.Drawing.Size(117, 79);
            this.btnSalvaSuFile.TabIndex = 7;
            this.btnSalvaSuFile.Text = "Salva su File";
            this.btnSalvaSuFile.UseVisualStyleBackColor = true;
            this.btnSalvaSuFile.Click += new System.EventHandler(this.btnSalvaSuFile_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.Location = new System.Drawing.Point(567, 370);
            this.btnEsci.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(112, 50);
            this.btnEsci.TabIndex = 8;
            this.btnEsci.Text = "Esci";
            this.btnEsci.UseVisualStyleBackColor = true;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnVolume);
            this.groupBox1.Controls.Add(this.radioBtnArea);
            this.groupBox1.Controls.Add(this.radioBtnRaggio);
            this.groupBox1.Location = new System.Drawing.Point(457, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 151);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valore Noto";
            // 
            // radioBtnVolume
            // 
            this.radioBtnVolume.AutoSize = true;
            this.radioBtnVolume.Location = new System.Drawing.Point(29, 106);
            this.radioBtnVolume.Name = "radioBtnVolume";
            this.radioBtnVolume.Size = new System.Drawing.Size(100, 29);
            this.radioBtnVolume.TabIndex = 2;
            this.radioBtnVolume.Text = "Volume";
            this.radioBtnVolume.UseVisualStyleBackColor = true;
            // 
            // radioBtnArea
            // 
            this.radioBtnArea.AutoSize = true;
            this.radioBtnArea.Location = new System.Drawing.Point(29, 68);
            this.radioBtnArea.Name = "radioBtnArea";
            this.radioBtnArea.Size = new System.Drawing.Size(75, 29);
            this.radioBtnArea.TabIndex = 1;
            this.radioBtnArea.Text = "Area";
            this.radioBtnArea.UseVisualStyleBackColor = true;
            // 
            // radioBtnRaggio
            // 
            this.radioBtnRaggio.AutoSize = true;
            this.radioBtnRaggio.Checked = true;
            this.radioBtnRaggio.Location = new System.Drawing.Point(28, 33);
            this.radioBtnRaggio.Name = "radioBtnRaggio";
            this.radioBtnRaggio.Size = new System.Drawing.Size(94, 29);
            this.radioBtnRaggio.TabIndex = 0;
            this.radioBtnRaggio.TabStop = true;
            this.radioBtnRaggio.Text = "Raggio";
            this.radioBtnRaggio.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(61, 359);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(149, 51);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(705, 454);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEsci);
            this.Controls.Add(this.btnSalvaSuFile);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.btnCalcola);
            this.Controls.Add(this.labelRaggio);
            this.Controls.Add(this.txtRaggio);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Calcolo Sfera";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRaggio;
        private System.Windows.Forms.Label labelRaggio;
        private System.Windows.Forms.Button btnCalcola;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Button btnSalvaSuFile;
        private System.Windows.Forms.Button btnEsci;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnVolume;
        private System.Windows.Forms.RadioButton radioBtnArea;
        private System.Windows.Forms.RadioButton radioBtnRaggio;
        private System.Windows.Forms.Button btnReset;
    }
}

