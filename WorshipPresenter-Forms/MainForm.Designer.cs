namespace WorshipPresenter_Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            videoFileToolStripMenuItem = new ToolStripMenuItem();
            dVDToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            playbackToolStripMenuItem = new ToolStripMenuItem();
            startProjectingToolStripMenuItem = new ToolStripMenuItem();
            stopProjectingToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            playButtonToolStripMenuItem = new ToolStripMenuItem();
            pauseButtonToolStripMenuItem = new ToolStripMenuItem();
            stopButtonToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            timeLabel = new ToolStripStatusLabel();
            lengthLabel = new ToolStripStatusLabel();
            titleLabel = new ToolStripStatusLabel();
            openFileDialog1 = new OpenFileDialog();
            instructionLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, playbackToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(799, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { videoFileToolStripMenuItem, dVDToolStripMenuItem });
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "Open";
            // 
            // videoFileToolStripMenuItem
            // 
            videoFileToolStripMenuItem.Name = "videoFileToolStripMenuItem";
            videoFileToolStripMenuItem.Size = new Size(125, 22);
            videoFileToolStripMenuItem.Text = "Video File";
            videoFileToolStripMenuItem.Click += videoFileToolStripMenuItem_Click;
            // 
            // dVDToolStripMenuItem
            // 
            dVDToolStripMenuItem.Name = "dVDToolStripMenuItem";
            dVDToolStripMenuItem.Size = new Size(125, 22);
            dVDToolStripMenuItem.Text = "DVD";
            dVDToolStripMenuItem.Click += dVDToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(103, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // playbackToolStripMenuItem
            // 
            playbackToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { startProjectingToolStripMenuItem, stopProjectingToolStripMenuItem, toolStripSeparator1, playButtonToolStripMenuItem, pauseButtonToolStripMenuItem, stopButtonToolStripMenuItem });
            playbackToolStripMenuItem.Name = "playbackToolStripMenuItem";
            playbackToolStripMenuItem.Size = new Size(66, 20);
            playbackToolStripMenuItem.Text = "Playback";
            // 
            // startProjectingToolStripMenuItem
            // 
            startProjectingToolStripMenuItem.Name = "startProjectingToolStripMenuItem";
            startProjectingToolStripMenuItem.Size = new Size(152, 22);
            startProjectingToolStripMenuItem.Text = "StartProjecting";
            startProjectingToolStripMenuItem.Click += startProjectingToolStripMenuItem_Click;
            // 
            // stopProjectingToolStripMenuItem
            // 
            stopProjectingToolStripMenuItem.Name = "stopProjectingToolStripMenuItem";
            stopProjectingToolStripMenuItem.Size = new Size(152, 22);
            stopProjectingToolStripMenuItem.Text = "StopProjecting";
            stopProjectingToolStripMenuItem.Click += stopProjectingToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(149, 6);
            // 
            // playButtonToolStripMenuItem
            // 
            playButtonToolStripMenuItem.Name = "playButtonToolStripMenuItem";
            playButtonToolStripMenuItem.Size = new Size(152, 22);
            playButtonToolStripMenuItem.Text = "PlayButton";
            playButtonToolStripMenuItem.Click += playButtonToolStripMenuItem_Click;
            // 
            // pauseButtonToolStripMenuItem
            // 
            pauseButtonToolStripMenuItem.Name = "pauseButtonToolStripMenuItem";
            pauseButtonToolStripMenuItem.Size = new Size(152, 22);
            pauseButtonToolStripMenuItem.Text = "PauseButton";
            pauseButtonToolStripMenuItem.Click += pauseButtonToolStripMenuItem_Click;
            // 
            // stopButtonToolStripMenuItem
            // 
            stopButtonToolStripMenuItem.Name = "stopButtonToolStripMenuItem";
            stopButtonToolStripMenuItem.Size = new Size(152, 22);
            stopButtonToolStripMenuItem.Text = "StopButton";
            stopButtonToolStripMenuItem.Click += stopButtonToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, timeLabel, lengthLabel, titleLabel });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(799, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(39, 17);
            toolStripStatusLabel1.Text = "Ready";
            // 
            // timeLabel
            // 
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(0, 17);
            // 
            // lengthLabel
            // 
            lengthLabel.Name = "lengthLabel";
            lengthLabel.Size = new Size(0, 17);
            // 
            // titleLabel
            // 
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(0, 17);
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "All Files|*.*";
            // 
            // instructionLabel
            // 
            instructionLabel.AutoSize = true;
            instructionLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            instructionLabel.Location = new Point(12, 40);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new Size(770, 80);
            instructionLabel.TabIndex = 2;
            instructionLabel.Text = resources.GetString("instructionLabel.Text");
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 450);
            Controls.Add(instructionLabel);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            Shown += MainForm_Shown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem videoFileToolStripMenuItem;
        private ToolStripMenuItem dVDToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem playbackToolStripMenuItem;
        private ToolStripMenuItem startProjectingToolStripMenuItem;
        private ToolStripMenuItem stopProjectingToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem playButtonToolStripMenuItem;
        private ToolStripMenuItem pauseButtonToolStripMenuItem;
        private ToolStripMenuItem stopButtonToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private OpenFileDialog openFileDialog1;
        private Label instructionLabel;
        private System.Windows.Forms.Timer timer1;
        private ToolStripStatusLabel lengthLabel;
        private ToolStripStatusLabel timeLabel;
        private ToolStripStatusLabel titleLabel;
    }
}
