using LibVLCSharp.Shared;

namespace WorshipPresenter_Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private readonly string[] mDrives = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        public MediaForm MediaForm { get; set; } = new MediaForm();
        public string CurrentMediaFilename { get; set; } = string.Empty;
        public string CurrentMediaStatus { get; set; } = string.Empty;

        private void videoFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                CurrentMediaFilename = openFileDialog1.FileName;
                MediaForm.MediaPlayer.Media = new Media(MediaForm.LibVLC, new Uri(CurrentMediaFilename));
                
                try
                {
                    CurrentMediaFilename = Path.GetFileName(CurrentMediaFilename);
                }
                catch (Exception)
                {

                }
                toolStripStatusLabel1.Text = $"Currently {CurrentMediaStatus} '{CurrentMediaFilename}'";
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
                        toolStripStatusLabel1.Text = $"Currently {CurrentMediaStatus} '{CurrentMediaFilename}'";
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
                MediaForm.StartPosition = FormStartPosition.Manual;
                MediaForm.Location = secondScreen.WorkingArea.Location;
                MediaForm.Show();
            }
        }

        private void stopProjectingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MediaForm.Hide();
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
            MediaForm.MediaPlayer.TimeChanged += MediaPlayer_TimeChanged;
            MediaForm.MediaPlayer.TitleChanged += MediaPlayer_TitleChanged;
        }

        private void MediaPlayer_TitleChanged(object? sender, MediaPlayerTitleChangedEventArgs e)
        {
            titleLabel.Text = $"Title:{e.Title}";
        }

        private void MediaPlayer_TimeChanged(object? sender, MediaPlayerTimeChangedEventArgs e)
        {
            timeLabel.Text = $"Time:{e.Time}";
        }

        private void MediaPlayer_Opening(object? sender, EventArgs e)
        {
            CurrentMediaStatus = "opened";
            toolStripStatusLabel1.Text = $"Currently {CurrentMediaStatus} '{CurrentMediaFilename}'";
        }

        private void MediaPlayer_Stopped(object? sender, EventArgs e)
        {
            CurrentMediaStatus = "stopped";
            toolStripStatusLabel1.Text = $"Currently {CurrentMediaStatus} '{CurrentMediaFilename}'";
        }

        private void MediaPlayer_Paused(object? sender, EventArgs e)
        {
            CurrentMediaStatus = "paused";
            toolStripStatusLabel1.Text = $"Currently {CurrentMediaStatus} '{CurrentMediaFilename}'";
        }

        private void MediaPlayer_Playing(object? sender, EventArgs e)
        {
            CurrentMediaStatus = "playing";
            toolStripStatusLabel1.Text = $"Currently {CurrentMediaStatus} '{CurrentMediaFilename}'";
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
            toolStripStatusLabel1.Text = $"Currently {CurrentMediaStatus} '{CurrentMediaFilename}'";
        }

        private void MediaPlayer_LengthChanged(object? sender, MediaPlayerLengthChangedEventArgs e)
        {
            lengthLabel.Text = $"Length:{e.Length}";
        }
    }
}
