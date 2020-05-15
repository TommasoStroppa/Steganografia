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
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scrivi = new System.Windows.Forms.Button();
            this.testo = new System.Windows.Forms.TextBox();
            this.seleziona_file = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.immagine)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // immagine
            // 
            this.immagine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.immagine.BackColor = System.Drawing.Color.Lime;
            this.immagine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.immagine.Location = new System.Drawing.Point(18, 18);
            this.immagine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.immagine.Name = "immagine";
            this.immagine.Size = new System.Drawing.Size(1160, 475);
            this.immagine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.immagine.TabIndex = 0;
            this.immagine.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.scrivi);
            this.panel1.Controls.Add(this.testo);
            this.panel1.Location = new System.Drawing.Point(357, 503);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 175);
            this.panel1.TabIndex = 9;
            this.panel1.Visible = false;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(471, 67);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(347, 39);
            this.password.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "Testo da inserire";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(574, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Password";
            // 
            // scrivi
            // 
            this.scrivi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scrivi.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold);
            this.scrivi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.scrivi.Location = new System.Drawing.Point(314, 122);
            this.scrivi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scrivi.Name = "scrivi";
            this.scrivi.Size = new System.Drawing.Size(190, 40);
            this.scrivi.TabIndex = 4;
            this.scrivi.Text = "SCRIVI";
            this.scrivi.UseVisualStyleBackColor = true;
            this.scrivi.Click += new System.EventHandler(this.scrivi_Click);
            // 
            // testo
            // 
            this.testo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.testo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.testo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.testo.Location = new System.Drawing.Point(4, 66);
            this.testo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.testo.Name = "testo";
            this.testo.Size = new System.Drawing.Size(347, 40);
            this.testo.TabIndex = 6;
            // 
            // seleziona_file
            // 
            this.seleziona_file.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.seleziona_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seleziona_file.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold);
            this.seleziona_file.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.seleziona_file.Location = new System.Drawing.Point(18, 503);
            this.seleziona_file.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seleziona_file.Name = "seleziona_file";
            this.seleziona_file.Size = new System.Drawing.Size(312, 80);
            this.seleziona_file.TabIndex = 13;
            this.seleziona_file.Text = "SCEGLI FILE";
            this.seleziona_file.UseVisualStyleBackColor = true;
            this.seleziona_file.Click += new System.EventHandler(this.seleziona_file_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.seleziona_file);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.immagine);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "HIDE YOUR DATA";
            ((System.ComponentModel.ISupportInitialize)(this.immagine)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox immagine;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button scrivi;
        private System.Windows.Forms.TextBox testo;
        private System.Windows.Forms.Button seleziona_file;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password;
    }
}

