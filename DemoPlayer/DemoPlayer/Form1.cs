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

namespace DemoPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Server s = new Server("127.0.0.1", 50000, false, DefaultRoute);

            s.DynamicRoutes.Add(HttpMethod.GET, new Regex("^/audio/(.*?)/?$"), audioRoute);       }

        static async Task DefaultRoute(HttpContext ctx)
        {
            ctx.Response.StatusCode = 200;
            var audio = System.IO.File.ReadAllBytes("ehi.mp3");
            await ctx.Response.Send(audio);
        }

        static async Task audioRoute(HttpContext ctx)
        {
            var audioName = (ctx.Request.RawUrlEntries[1] ?? "noaudio") + ".mp3";

            if (!System.IO.File.Exists(audioName))
                audioName = "noaudio.mp3";

            ctx.Response.StatusCode = 200;
            var audio = System.IO.File.ReadAllBytes(audioName);
            await ctx.Response.Send(audio);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = "YouTube.mp3";
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

        //private async void button1_Click(object sender, EventArgs e)
        //{
        //    using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "select your path" })
        //    {
        //        if (fbd.ShowDialog() == DialogResult.OK)
        //        {
        //            var youtube = YouTube.Default;
        //            var video = await youtube.GetVideoAsync(textBox1.Text);
        //            var path = fbd.SelectedPath + @"\" + "Thescotts" + ".mp3";
        //            File.WriteAllBytes(path, await video.GetBytesAsync());
        //            button1.Text = "complete";
        //            var nVideo = video.FullName + "mp3";


        //        }

        //    }
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            string FileToCopy = null;
            string NewCopy = null;

            FileToCopy = @"C:\Users\zacca\Desktop\Thescotts.mp3";
            NewCopy = System.IO.Path.Combine(Application.StartupPath, System.IO.Path.GetFileName(FileToCopy));


            if (System.IO.File.Exists(FileToCopy) == true)
            {
                System.IO.File.Delete(NewCopy);
                System.IO.File.Copy(FileToCopy, NewCopy);
                MessageBox.Show("fatto");
            }
        }


    }
        
}


