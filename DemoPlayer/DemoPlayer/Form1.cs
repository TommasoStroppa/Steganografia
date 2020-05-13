using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using System.IO;
using System.Text.RegularExpressions;
using WatsonWebserver;



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
            //this.timer1.Start();

            //using (var audioFile = new AudioFileReader("Canzone2.mp3"))
            //using (var outputDevice = new WaveOutEvent())
            //{
            //    outputDevice.Init(audioFile);
            //    outputDevice.Play();
            //    while (outputDevice.PlaybackState == PlaybackState.Playing)
            //    {
            //        //Thread.Sleep(1000);
            //    }
            //}
        }        
    }
}
