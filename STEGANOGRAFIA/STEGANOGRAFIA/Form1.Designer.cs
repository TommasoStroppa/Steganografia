namespace Steganografia
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
            this.immagine = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.scrivi = new System.Windows.Forms.Button();
            this.testo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.testo_letto = new System.Windows.Forms.TextBox();
            this.seleziona_file = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.immagine)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // immagine
            // 
            this.immagine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.immagine.BackColor = System.Drawing.Color.Lime;
            this.immagine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.immagine.Location = new System.Drawing.Point(12, 12);
            this.immagine.Name = "immagine";
            this.immagine.Size = new System.Drawing.Size(773, 308);
            this.immagine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.immagine.TabIndex = 0;
            this.immagine.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.scrivi);
            this.panel1.Controls.Add(this.testo);
            this.panel1.Location = new System.Drawing.Point(12, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 114);
            this.panel1.TabIndex = 9;
            this.panel1.Visible = false;
            // 
            // scrivi
            // 
            this.scrivi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scrivi.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold);
            this.scrivi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.scrivi.Location = new System.Drawing.Point(50, 20);
            this.scrivi.Name = "scrivi";
            this.scrivi.Size = new System.Drawing.Size(147, 50);
            this.scrivi.TabIndex = 4;
            this.scrivi.Text = "SCRIVI";
            this.scrivi.UseVisualStyleBackColor = true;
            this.scrivi.Click += new System.EventHandler(this.scrivi_Click);
            // 
            // testo
            // 
            this.testo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.testo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.testo.Location = new System.Drawing.Point(3, 82);
            this.testo.Name = "testo";
            this.testo.Size = new System.Drawing.Size(232, 29);
            this.testo.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.testo_letto);
            this.panel2.Location = new System.Drawing.Point(546, 329);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 114);
            this.panel2.TabIndex = 10;
            this.panel2.Visible = false;
            // 
            // testo_letto
            // 
            this.testo_letto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.testo_letto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.testo_letto.Location = new System.Drawing.Point(7, 82);
            this.testo_letto.Name = "testo_letto";
            this.testo_letto.ReadOnly = true;
            this.testo_letto.Size = new System.Drawing.Size(232, 29);
            this.testo_letto.TabIndex = 2;
            // 
            // seleziona_file
            // 
            this.seleziona_file.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.seleziona_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seleziona_file.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold);
            this.seleziona_file.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.seleziona_file.Location = new System.Drawing.Point(296, 329);
            this.seleziona_file.Name = "seleziona_file";
            this.seleziona_file.Size = new System.Drawing.Size(208, 52);
            this.seleziona_file.TabIndex = 13;
            this.seleziona_file.Text = "SCEGLI FILE";
            this.seleziona_file.UseVisualStyleBackColor = true;
            this.seleziona_file.Click += new System.EventHandler(this.seleziona_file_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 76);
            this.button1.TabIndex = 14;
            this.button1.Text = "CIFRATURA";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 76);
            this.button2.TabIndex = 15;
            this.button2.Text = "DECIFRATURA";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.seleziona_file);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.immagine);
            this.Name = "Form1";
            this.Text = "HIDE YOUR DATA";
            ((System.ComponentModel.ISupportInitialize)(this.immagine)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox immagine;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button scrivi;
        private System.Windows.Forms.TextBox testo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox testo_letto;
        private System.Windows.Forms.Button seleziona_file;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

