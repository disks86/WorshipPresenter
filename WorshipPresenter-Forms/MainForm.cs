using LibVLCSharp.Shared;

namespace WorshipPresenter_Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public enum MediaType
        {
            Video,
            Browser
        }

        private readonly string[] mDrives = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        public MediaForm MediaForm { get; set; } = new MediaForm();
        public BrowserForm BrowserForm { get; set; } = new BrowserForm();
        public string CurrentMediaFilename { get; set; } = string.Empty;
        public string CurrentMediaStatus { get; set; } = string.Empty;
        public MediaType CurrentMediaType { get; set; } = MediaType.Video;

        private void videoFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                CurrentMediaFilename = openFileDialog1.FileName;
                MediaForm.MediaPlayer.Media = new Media(MediaForm.LibVLC, new Uri(CurrentMediaFilename));

                try
                {
                    CurrentMediaFilename = Path.GetFileName(CurrentMediaFilename);
                    CurrentMediaType = MediaType.Video;
                }
                catch (Exception)
                {

                }
                toolStripStatusLabel1.Text = $@"Currently {CurrentMediaStatus} '{CurrentMediaFilename}'";
            }
        }

        private void dVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var drive in mDrives)
            {
                {
                    var filename1 = $"{drive}:\\VIDEO_TS\\VIDEO_TS.VOB";
                    var filename2 = $"{drive}:\\VIDEO_TS\\VIDEO_TS.IFO";
                    if (File.Exists(filename1) || File.Exists(filename2))
                    {
                        CurrentMediaFilename = $"dvd:///{drive}:";
                        MediaForm.MediaPlayer.Media = new Media(MediaForm.LibVLC, new Uri(CurrentMediaFilename));
                        toolStripStatusLabel1.Text = $@"Currently {CurrentMediaStatus} '{CurrentMediaFilename}'";
                        CurrentMediaType = MediaType.Video;
                        return;
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startProjectingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Screen? secondScreen = null;
            foreach (var screen in Screen.AllScreens)
            {
                if (!screen.Primary)
                {
                    secondScreen = screen;
                    break;
                }
            }

            if (secondScreen != null)
            {
                switch (CurrentMediaType)
                {
                    case MediaType.Video:
                        MediaForm.StartPosition = FormStartPosition.Manual;
                        MediaForm.Location = secondScreen.WorkingArea.Location;
                        MediaForm.Show();
                        break;
                    case MediaType.Browser:
                        BrowserForm.StartPosition = FormStartPosition.Manual;
                        BrowserForm.Location = secondScreen.WorkingArea.Location;
                        BrowserForm.Show();
                        break;
                    default:
                        break;
                }
            }
        }

        private void stopProjectingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MediaForm.Hide();
            BrowserForm.Hide();
        }

        private void playButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MediaForm.MediaPlayer.Play();
        }

        private void pauseButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MediaForm.MediaPlayer.Pause();
        }

        private void stopButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MediaForm.MediaPlayer.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            MediaForm.MediaPlayer.LengthChanged += MediaPlayer_LengthChanged;
            MediaForm.MediaPlayer.MediaChanged += MediaPlayer_MediaChanged;
            MediaForm.MediaPlayer.Playing += MediaPlayer_Playing;
            MediaForm.MediaPlayer.Paused += MediaPlayer_Paused;
            MediaForm.MediaPlayer.Stopped += MediaPlayer_Stopped;
            MediaForm.MediaPlayer.Opening += MediaPlayer_Opening;
            //MediaForm.MediaPlayer.TimeChanged += MediaPlayer_TimeChanged;
            MediaForm.MediaPlayer.TitleChanged += MediaPlayer_TitleChanged;
        }

        private void MediaPlayer_TitleChanged(object? sender, MediaPlayerTitleChangedEventArgs e)
        {
            titleLabel.Text = $@"Title:{e.Title}";
        }

        private void MediaPlayer_TimeChanged(object? sender, MediaPlayerTimeChangedEventArgs e)
        {
            timeLabel.Text = $@"Time:{e.Time}";
        }

        private void MediaPlayer_Opening(object? sender, EventArgs e)
        {
            CurrentMediaStatus = "opened";
            toolStripStatusLabel1.Text = $@"Currently {CurrentMediaStatus} '{CurrentMediaFilename}'";
        }

        private void MediaPlayer_Stopped(object? sender, EventArgs e)
        {
            CurrentMediaStatus = "stopped";
            toolStripStatusLabel1.Text = $@"Currently {CurrentMediaStatus} '{CurrentMediaFilename}'";
        }

        private void MediaPlayer_Paused(object? sender, EventArgs e)
        {
            CurrentMediaStatus = "paused";
            toolStripStatusLabel1.Text = $@"Currently {CurrentMediaStatus} '{CurrentMediaFilename}'";
        }

        private void MediaPlayer_Playing(object? sender, EventArgs e)
        {
            CurrentMediaStatus = "playing";
            toolStripStatusLabel1.Text = $@"Currently {CurrentMediaStatus} '{CurrentMediaFilename}'";
        }

        private void MediaPlayer_MediaChanged(object? sender, MediaPlayerMediaChangedEventArgs e)
        {
            CurrentMediaStatus = "opened";
            try
            {
                CurrentMediaFilename = Path.GetFileName(e.Media.Mrl);
            }
            catch (Exception)
            {

            }
            toolStripStatusLabel1.Text = $@"Currently {CurrentMediaStatus} '{CurrentMediaFilename}'";
        }

        private void MediaPlayer_LengthChanged(object? sender, MediaPlayerLengthChangedEventArgs e)
        {
            lengthLabel.Text = $@"Length:{e.Length}";
        }

        private void enableHardwareDecodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MediaForm.MediaPlayer.EnableHardwareDecoding = enableHardwareDecodeToolStripMenuItem.Checked;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = true;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;
            toolStripMenuItem5.Checked = false;
            toolStripMenuItem6.Checked = false;
            toolStripMenuItem7.Checked = false;
            toolStripMenuItem8.Checked = false;
            toolStripMenuItem9.Checked = false;
            toolStripMenuItem10.Checked = false;
            toolStripMenuItem11.Checked = false;

            MediaForm.MediaPlayer.Volume = 10;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = true;
            toolStripMenuItem4.Checked = false;
            toolStripMenuItem5.Checked = false;
            toolStripMenuItem6.Checked = false;
            toolStripMenuItem7.Checked = false;
            toolStripMenuItem8.Checked = false;
            toolStripMenuItem9.Checked = false;
            toolStripMenuItem10.Checked = false;
            toolStripMenuItem11.Checked = false;

            MediaForm.MediaPlayer.Volume = 20;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = true;
            toolStripMenuItem5.Checked = false;
            toolStripMenuItem6.Checked = false;
            toolStripMenuItem7.Checked = false;
            toolStripMenuItem8.Checked = false;
            toolStripMenuItem9.Checked = false;
            toolStripMenuItem10.Checked = false;
            toolStripMenuItem11.Checked = false;

            MediaForm.MediaPlayer.Volume = 30;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;
            toolStripMenuItem5.Checked = true;
            toolStripMenuItem6.Checked = false;
            toolStripMenuItem7.Checked = false;
            toolStripMenuItem8.Checked = false;
            toolStripMenuItem9.Checked = false;
            toolStripMenuItem10.Checked = false;
            toolStripMenuItem11.Checked = false;

            MediaForm.MediaPlayer.Volume = 40;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;
            toolStripMenuItem5.Checked = false;
            toolStripMenuItem6.Checked = true;
            toolStripMenuItem7.Checked = false;
            toolStripMenuItem8.Checked = false;
            toolStripMenuItem9.Checked = false;
            toolStripMenuItem10.Checked = false;
            toolStripMenuItem11.Checked = false;

            MediaForm.MediaPlayer.Volume = 50;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;
            toolStripMenuItem5.Checked = false;
            toolStripMenuItem6.Checked = false;
            toolStripMenuItem7.Checked = true;
            toolStripMenuItem8.Checked = false;
            toolStripMenuItem9.Checked = false;
            toolStripMenuItem10.Checked = false;
            toolStripMenuItem11.Checked = false;

            MediaForm.MediaPlayer.Volume = 60;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;
            toolStripMenuItem5.Checked = false;
            toolStripMenuItem6.Checked = false;
            toolStripMenuItem7.Checked = false;
            toolStripMenuItem8.Checked = true;
            toolStripMenuItem9.Checked = false;
            toolStripMenuItem10.Checked = false;
            toolStripMenuItem11.Checked = false;

            MediaForm.MediaPlayer.Volume = 70;
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;
            toolStripMenuItem5.Checked = false;
            toolStripMenuItem6.Checked = false;
            toolStripMenuItem7.Checked = false;
            toolStripMenuItem8.Checked = false;
            toolStripMenuItem9.Checked = true;
            toolStripMenuItem10.Checked = false;
            toolStripMenuItem11.Checked = false;

            MediaForm.MediaPlayer.Volume = 80;
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;
            toolStripMenuItem5.Checked = false;
            toolStripMenuItem6.Checked = false;
            toolStripMenuItem7.Checked = false;
            toolStripMenuItem8.Checked = false;
            toolStripMenuItem9.Checked = false;
            toolStripMenuItem10.Checked = true;
            toolStripMenuItem11.Checked = false;

            MediaForm.MediaPlayer.Volume = 90;
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;
            toolStripMenuItem5.Checked = false;
            toolStripMenuItem6.Checked = false;
            toolStripMenuItem7.Checked = false;
            toolStripMenuItem8.Checked = false;
            toolStripMenuItem9.Checked = false;
            toolStripMenuItem10.Checked = false;
            toolStripMenuItem11.Checked = true;

            MediaForm.MediaPlayer.Volume = 100;
        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            offToolStripMenuItem.Checked = true;
            defaultToolStripMenuItem.Checked = false;
            maxToolStripMenuItem.Checked = false;

            MediaForm.MediaPlayer.FileCaching = 0;
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            offToolStripMenuItem.Checked = false;
            defaultToolStripMenuItem.Checked = true;
            maxToolStripMenuItem.Checked = false;

            MediaForm.MediaPlayer.FileCaching = MediaForm.DefaultFileCache;
        }

        private void maxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            offToolStripMenuItem.Checked = false;
            defaultToolStripMenuItem.Checked = false;
            maxToolStripMenuItem.Checked = true;

            MediaForm.MediaPlayer.FileCaching = 60000;
        }

        private void browserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var url = Microsoft.VisualBasic.Interaction.InputBox("Enter Url.");
            if (!url.StartsWith("http"))
            {
                url = "https://" + url;
            }
            BrowserForm.BrowserView.Source = new Uri(url);
            CurrentMediaStatus = "Viewing";
            CurrentMediaType = MediaType.Browser;  
            CurrentMediaFilename = BrowserForm.BrowserView.Source.ToString();
            toolStripStatusLabel1.Text = $@"Currently {CurrentMediaStatus} '{CurrentMediaFilename}'";        
        }
    }
}
