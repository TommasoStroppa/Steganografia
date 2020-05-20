using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using NAudio.Wave;
using WatsonWebserver;
using System.IO;
using System.Text.RegularExpressions;
using System.Net;
using CifraturaDLL;

namespace DemoPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Server s = new Server("127.0.0.1", 50000, false, DefaultRoute);

            s.DynamicRoutes.Add(HttpMethod.GET, new Regex("^/audio/(.*?)/?$"), audioRoute);
        }

        string percorso = string.Empty;
        Bitmap img;

        static async Task DefaultRoute(HttpContext ctx)
        {
            ctx.Response.StatusCode = 200;
            var audio = System.IO.File.ReadAllBytes("Scegli file");
            await ctx.Response.Send(audio);
        }

        static async Task audioRoute(HttpContext ctx)
        {
            var audioName = (ctx.Request.RawUrlEntries[1] ?? "noaudio") + ".mp3";

            if (!System.IO.File.Exists(audioName))
            {
                using (var audioFile = new MediaFoundationReader("noAudio.mp3")) 
                using (var outputDevice = new WaveOutEvent())
                {
                    outputDevice.Init(audioFile);
                    outputDevice.Play();
                    while (outputDevice.PlaybackState == PlaybackState.Playing)
                    {
                        Thread.Sleep(1000);
                    }
                }
                return;
            }

            ctx.Response.StatusCode = 200;
            var audio = System.IO.File.ReadAllBytes(audioName);
            await ctx.Response.Send(audio);
        }
       
        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "Bitmap Image (.bmp)|*.bmp";
            openFileDialog1.InitialDirectory = @"C:\Users\computer\Desktop\";
            openFileDialog1.Title = "Seleziona immagine BMP";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                percorso = openFileDialog1.FileName;
                immagine.ImageLocation = percorso;
            }
            textBox1.Visible = true;
            textBox2.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            checkBox1.Visible = true;
        }

        private void btnLeggi_Click(object sender, EventArgs e)
        {
            img = new Bitmap(immagine.Image);
            string carattere = string.Empty;
            int larghezza = img.Width;
            int altezza = img.Height;
            string tutto = string.Empty;

            for (int y = 0; y < altezza; y++)
            {
                for (int x = 0; x < larghezza; x++)
                {

                    int posizione = larghezza * y + x;

                    if (carattere != "00000000")
                    {

                        if (posizione % 8 == 0)
                        {
                            carattere = "";
                        }

                        Color colore = img.GetPixel(x, y);
                        int n = colore.R;

                        int[] a = new int[8];

                        for (int z = 0; n > 0; z++)
                        {
                            a[z] = n % 2;
                            n = n / 2;
                        }

                        carattere = carattere + a[0].ToString();
                        tutto = tutto + a[0].ToString();
                    }
                }
            }

            string risultato0 = "";
            int l = default(int);

            while (tutto.Length > 0)
            {
                var first8 = tutto.Substring(0, 8);
                tutto = tutto.Substring(8);
                var num = Convert.ToInt32(first8, 2);
                risultato0 = risultato0 + (char)num;
                string k = default(string);
                k = k + (char)num;
                if (k == "@")
                {
                    l = l + 1;
                }
                if (l == 2)
                    break;
            }
            int o = 0;
            string acaso = default(string);
            while (o < risultato0.Length - 2)
            {
                acaso = acaso + risultato0.Substring(o, 1);
                o++;
            }
            risultato0 = acaso;
            string risultato = default(string);
            risultato = Crypto.DecifraturaAES(risultato0, textBox2.Text);
            
            if(risultato==null)
            {
                MessageBox.Show("Password errata");
                return;
            }


            textBox1.Text = risultato;

            string phrase = textBox1.Text;
            string[] words = phrase.Split('/');

            foreach (var word in words)
            {
                label4.Text = ($"{word}");
            }
            textBox3.Visible = true;
            label5.Visible = true;
        }
        

        public void Audio()
        {
            var link = label4.Text;
            var nomeF = textBox3.Text;
            using (var client = new WebClient())
            {
                client.DownloadFile("http://127.0.0.1:50000/audio/" + link, nomeF + ".mp3");
            }
            string fileName = nomeF + ".mp3";
            using (var audioFile = new MediaFoundationReader(fileName))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(1000);
                }
            }
        }
        Thread t;

        bool avviato = false;
        private void play_Click(object sender, EventArgs e)
        {
            t = new Thread(Audio);

            t.Start();
            avviato = true;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            checkBox1.Visible = false;

            textBox2.UseSystemPasswordChar = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (avviato)
            {
                t.Abort();
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
            }
        }
    }
        
}


