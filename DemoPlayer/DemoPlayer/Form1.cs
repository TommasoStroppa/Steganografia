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

namespace DemoPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void progressBar1_Click(object sender, EventArgs e)
        {

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

//private void button2_Click(object sender, EventArgs e)
//{
//    string FileToCopy = null;
//    string NewCopy = null;

//    FileToCopy = @"C:\Users\zacca\Desktop\Thescotts.mp3";
//    NewCopy = System.IO.Path.Combine(Application.StartupPath, System.IO.Path.GetFileName(FileToCopy));


//    if (System.IO.File.Exists(FileToCopy) == true)
//    {
//        System.IO.File.Delete(NewCopy);
//        System.IO.File.Copy(FileToCopy, NewCopy);
//        MessageBox.Show("fatto");
//    }
//}
