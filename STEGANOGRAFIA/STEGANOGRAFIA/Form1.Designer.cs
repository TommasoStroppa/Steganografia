namespace steganografia
{
    partial class Steganografia
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
            this.immagine = new System.Windows.Forms.PictureBox();
            this.seleziona_file = new System.Windows.Forms.Button();
            this.scrivi = new System.Windows.Forms.Button();
            this.leggi = new System.Windows.Forms.Button();
            this.testo = new System.Windows.Forms.TextBox();
            this.testo_letto = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.salva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.immagine)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // immagine
            // 
            this.immagine.BackColor = System.Drawing.Color.Lime;
            this.immagine.Location = new System.Drawing.Point(12, 12);
            this.immagine.Name = "immagine";
            this.immagine.Size = new System.Drawing.Size(776, 301);
            this.immagine.TabIndex = 0;
            this.immagine.TabStop = false;
            // 
            // seleziona_file
            // 
            this.seleziona_file.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.seleziona_file.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seleziona_file.Location = new System.Drawing.Point(324, 319);
            this.seleziona_file.Name = "seleziona_file";
            this.seleziona_file.Size = new System.Drawing.Size(181, 55);
            this.seleziona_file.TabIndex = 1;
            this.seleziona_file.Text = "SCEGLI FILE";
            this.seleziona_file.UseVisualStyleBackColor = true;
            // 
            // scrivi
            // 
            this.scrivi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.scrivi.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrivi.Location = new System.Drawing.Point(44, 18);
            this.scrivi.Name = "scrivi";
            this.scrivi.Size = new System.Drawing.Size(173, 55);
            this.scrivi.TabIndex = 2;
            this.scrivi.Text = "SCRIVI";
            this.scrivi.UseVisualStyleBackColor = true;
            // 
            // leggi
            // 
            this.leggi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.leggi.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leggi.Location = new System.Drawing.Point(48, 18);
            this.leggi.Name = "leggi";
            this.leggi.Size = new System.Drawing.Size(173, 55);
            this.leggi.TabIndex = 3;
            this.leggi.Text = "LEGGI";
            this.leggi.UseVisualStyleBackColor = true;
            // 
            // testo
            // 
            this.testo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.testo.Location = new System.Drawing.Point(3, 93);
            this.testo.Name = "testo";
            this.testo.Size = new System.Drawing.Size(255, 26);
            this.testo.TabIndex = 4;
            // 
            // testo_letto
            // 
            this.testo_letto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.testo_letto.Location = new System.Drawing.Point(3, 93);
            this.testo_letto.Name = "testo_letto";
            this.testo_letto.Size = new System.Drawing.Size(240, 26);
            this.testo_letto.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.scrivi);
            this.panel1.Controls.Add(this.testo);
            this.panel1.Location = new System.Drawing.Point(12, 319);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 125);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.leggi);
            this.panel2.Controls.Add(this.testo_letto);
            this.panel2.Location = new System.Drawing.Point(542, 319);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 125);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.salva);
            this.panel3.Location = new System.Drawing.Point(341, 380);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(142, 58);
            this.panel3.TabIndex = 8;
            // 
            // salva
            // 
            this.salva.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.salva.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.salva.Location = new System.Drawing.Point(3, 3);
            this.salva.Name = "salva";
            this.salva.Size = new System.Drawing.Size(136, 52);
            this.salva.TabIndex = 0;
            this.salva.Text = "SALVA";
            this.salva.UseVisualStyleBackColor = true;
            // 
            // Steganografia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.seleziona_file);
            this.Controls.Add(this.immagine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Steganografia";
            this.Text = "STEGANOGRAFIA";
            ((System.ComponentModel.ISupportInitialize)(this.immagine)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox immagine;
        private System.Windows.Forms.Button seleziona_file;
        private System.Windows.Forms.Button scrivi;
        private System.Windows.Forms.Button leggi;
        private System.Windows.Forms.TextBox testo;
        private System.Windows.Forms.TextBox testo_letto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button salva;
    }
}

