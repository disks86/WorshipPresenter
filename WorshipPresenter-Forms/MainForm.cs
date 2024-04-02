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

        private void videoFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                MediaForm.MediaPlayer.Media = new Media(MediaForm.LibVLC, new Uri(openFileDialog1.FileName));
                CurrentMediaFilename = openFileDialog1.FileName;
                toolStripStatusLabel1.Text = $"Currently opened '{CurrentMediaFilename}'";
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
                        toolStripStatusLabel1.Text = $"Currently opened '{CurrentMediaFilename}'";
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
            toolStripStatusLabel1.Text = $"Currently playing '{CurrentMediaFilename}'";
        }

        private void pauseButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MediaForm.MediaPlayer.Pause();
            toolStripStatusLabel1.Text = $"Currently paused '{CurrentMediaFilename}'";
        }

        private void stopButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MediaForm.MediaPlayer.Stop();
            toolStripStatusLabel1.Text = $"Currently stopped '{CurrentMediaFilename}'";
        }
    }
}
