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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.immagine = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scrivi = new System.Windows.Forms.Button();
            this.seleziona_file = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.testo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.immagine)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // immagine
            // 
            this.immagine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.immagine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.immagine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.immagine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.immagine.Location = new System.Drawing.Point(38, 72);
            this.immagine.Name = "immagine";
            this.immagine.Size = new System.Drawing.Size(841, 380);
            this.immagine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.immagine.TabIndex = 0;
            this.immagine.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.testo);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.scrivi);
            this.panel1.Location = new System.Drawing.Point(238, 458);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 172);
            this.panel1.TabIndex = 9;
            this.panel1.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox1.Location = new System.Drawing.Point(397, 84);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(167, 28);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Mostra password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(397, 46);
            this.password.Margin = new System.Windows.Forms.Padding(2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(233, 29);
            this.password.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(35, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome della canzone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(478, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Password";
            // 
            // scrivi
            // 
            this.scrivi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.scrivi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scrivi.Font = new System.Drawing.Font("Source Sans Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrivi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.scrivi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.scrivi.Location = new System.Drawing.Point(256, 120);
            this.scrivi.Name = "scrivi";
            this.scrivi.Size = new System.Drawing.Size(127, 39);
            this.scrivi.TabIndex = 4;
            this.scrivi.Text = "SCRIVI";
            this.scrivi.UseVisualStyleBackColor = true;
            this.scrivi.Click += new System.EventHandler(this.scrivi_Click);
            // 
            // seleziona_file
            // 
            this.seleziona_file.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.seleziona_file.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.seleziona_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seleziona_file.Font = new System.Drawing.Font("Source Sans Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seleziona_file.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.seleziona_file.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.seleziona_file.Location = new System.Drawing.Point(36, 458);
            this.seleziona_file.Name = "seleziona_file";
            this.seleziona_file.Size = new System.Drawing.Size(187, 121);
            this.seleziona_file.TabIndex = 13;
            this.seleziona_file.Text = "CARICA IMMAGINE";
            this.seleziona_file.UseVisualStyleBackColor = true;
            this.seleziona_file.Click += new System.EventHandler(this.seleziona_file_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Source Sans Pro", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(312, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 60);
            this.label3.TabIndex = 14;
            this.label3.Text = "HideYourData";
            // 
            // testo
            // 
            this.testo.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testo.FormattingEnabled = true;
            this.testo.Items.AddRange(new object[] {
            "YouTube",
            "canzone1"});
            this.testo.Location = new System.Drawing.Point(14, 46);
            this.testo.Name = "testo";
            this.testo.Size = new System.Drawing.Size(219, 32);
            this.testo.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(915, 642);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.seleziona_file);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.immagine);
            this.Font = new System.Drawing.Font("Source Sans Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "HIDE YOUR DATA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.immagine)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox immagine;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button scrivi;
        private System.Windows.Forms.Button seleziona_file;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox testo;
    }
}

