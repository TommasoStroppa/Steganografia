using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CifraturaDLL;

namespace Steganografia
{
    public partial class Form1 : Form
    {
        string percorso = string.Empty;
        Bitmap img;

        public Form1()
        {
            InitializeComponent();
        }

        private void seleziona_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "Bitmap Image (.bmp)|*.bmp";
            openFileDialog1.InitialDirectory = @"C:\Users\computer\Desktop\";
            openFileDialog1.Title = "Seleziona immagine BMP";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                percorso = openFileDialog1.FileName;
                immagine.ImageLocation = percorso;
                panel1.Visible = true;
            }
        }

        private void scrivi_Click(object sender, EventArgs e)
        {
            string messaggio = string.Empty;
            string da_inserire0 = testo.Text;
            if(string.IsNullOrEmpty(da_inserire0) || string.IsNullOrEmpty(password.Text))
            {
                MessageBox.Show("Inserire sia il testo che la password...");
                return;
            }
            string da_inserire = default(string);
            da_inserire=Crypto.AESEncryption(da_inserire0, password.Text) + "@@";

            foreach (char c in da_inserire)
            {
                string ottetto = Convert.ToString(c, 2);

                while (ottetto.Length < 8)
                {
                    ottetto = "0" + ottetto;
                }
                messaggio = messaggio + ottetto;
            }

            img = new Bitmap(immagine.Image);

            int larghezza = img.Width;
            int altezza = img.Height;
            int ncaratteri = (larghezza * altezza);
            if (ncaratteri >= messaggio.Length)
            {
                for (int y = 0; y < altezza; y++)
                {
                    for (int x = 0; x < larghezza; x++)
                    {
                        int posizione = larghezza * y + x;

                        if (posizione < messaggio.Length)
                        {
                            Color colore = img.GetPixel(x, y);
                            int n = colore.R;
                            int[] a = new int[8];

                            for (int i = 0; n > 0; i++)
                            {
                                a[i] = n % 2;
                                n = n / 2;
                            }

                            string test = string.Empty;

                            for (int i = a.Length - 1; i > 0; i--)
                            {
                                test = test + a[i].ToString();
                            }

                            test = test + messaggio[posizione];

                            int R = Convert.ToInt32(test, 2);

                            int A = colore.A;
                            int G = colore.G;
                            int B = colore.B;
                            img.SetPixel(x, y, Color.FromArgb(A, R, G, B));
                        }
                    }
                }
                immagine.Image = img;
                testo.Text = "";
            }
            else
            {
                MessageBox.Show("stringa troppo lunga, la massima lunghezza è " + (ncaratteri / 8 - 1).ToString() + " caratteri");
            }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\Users\computer\Desktop\";
            saveFileDialog1.Title = "Salva";
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "bmp";
            saveFileDialog1.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png|Tiff Image (.tiff)|*.tiff|Wmf Image (.wmf)|*.wmf";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img.Save(saveFileDialog1.FileName);
            }
        }

        
    }
}

