using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                panel2.Visible = true;
            }
        }

        private void scrivi_Click(object sender, EventArgs e)
        {
            img = new Bitmap(immagine.Image);

            int larghezza = img.Width;
            int altezza = img.Height;

            for (int y = 0; y < larghezza; y++)
            {
                for (int x = 0; x < altezza; x++)
                {
                    Color colore = img.GetPixel(y, x);
                    if (y < 1 && x < testo.TextLength)
                    {
                        Console.WriteLine("R = [" + y + "][" + x + "] = " + colore.R);
                        Console.WriteLine("G = [" + y + "][" + x + "] = " + colore.G);
                        Console.WriteLine("B = [" + y + "][" + x + "] = " + colore.B);

                        char letter = Convert.ToChar(testo.Text.Substring(x, 1));
                        int valore = Convert.ToInt32(letter);

                        Console.WriteLine("lettera: " + letter + " valore: " + valore);

                        img.SetPixel(y, x, Color.FromArgb(colore.R, colore.G, valore));
                    }
                }
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

       
    

