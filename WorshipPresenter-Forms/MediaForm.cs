using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorshipPresenter_Forms
{
    public partial class MediaForm : Form
    {
        public MediaForm()
        {
            Core.Initialize();
            //VLC documentation is backwards dvdsub-transparency disables transparency.
            //LibVLC = new LibVLC("--no-dvdsub-transparency");
            LibVLC = new LibVLC("--dvdsub-transparency");
            MediaPlayer = new MediaPlayer(LibVLC);
            MediaPlayer.EnableHardwareDecoding = true;
            MediaPlayer.Volume = 100;
            DefaultFileCache = MediaPlayer.FileCaching;
            InitializeComponent();
            this.videoView1.MediaPlayer = MediaPlayer;
        }

        public MediaPlayer MediaPlayer { get; set; }
        public LibVLC LibVLC { get; set; }
        public uint DefaultFileCache { get; private set; }
    }
}
