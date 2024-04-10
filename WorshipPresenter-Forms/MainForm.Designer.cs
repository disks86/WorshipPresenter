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
            optionsToolStripMenuItem = new ToolStripMenuItem();
            enableHardwareDecodeToolStripMenuItem = new ToolStripMenuItem();
            volumeToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            toolStripMenuItem8 = new ToolStripMenuItem();
            toolStripMenuItem9 = new ToolStripMenuItem();
            toolStripMenuItem10 = new ToolStripMenuItem();
            toolStripMenuItem11 = new ToolStripMenuItem();
            fileCachingToolStripMenuItem = new ToolStripMenuItem();
            offToolStripMenuItem = new ToolStripMenuItem();
            defaultToolStripMenuItem = new ToolStripMenuItem();
            maxToolStripMenuItem = new ToolStripMenuItem();
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, playbackToolStripMenuItem, optionsToolStripMenuItem });
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
            playButtonToolStripMenuItem.Text = "Play";
            playButtonToolStripMenuItem.Click += playButtonToolStripMenuItem_Click;
            // 
            // pauseButtonToolStripMenuItem
            // 
            pauseButtonToolStripMenuItem.Name = "pauseButtonToolStripMenuItem";
            pauseButtonToolStripMenuItem.Size = new Size(152, 22);
            pauseButtonToolStripMenuItem.Text = "Pause";
            pauseButtonToolStripMenuItem.Click += pauseButtonToolStripMenuItem_Click;
            // 
            // stopButtonToolStripMenuItem
            // 
            stopButtonToolStripMenuItem.Name = "stopButtonToolStripMenuItem";
            stopButtonToolStripMenuItem.Size = new Size(152, 22);
            stopButtonToolStripMenuItem.Text = "Stop";
            stopButtonToolStripMenuItem.Click += stopButtonToolStripMenuItem_Click;
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { enableHardwareDecodeToolStripMenuItem, volumeToolStripMenuItem, fileCachingToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(61, 20);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // enableHardwareDecodeToolStripMenuItem
            // 
            enableHardwareDecodeToolStripMenuItem.Checked = true;
            enableHardwareDecodeToolStripMenuItem.CheckOnClick = true;
            enableHardwareDecodeToolStripMenuItem.CheckState = CheckState.Checked;
            enableHardwareDecodeToolStripMenuItem.Name = "enableHardwareDecodeToolStripMenuItem";
            enableHardwareDecodeToolStripMenuItem.Size = new Size(206, 22);
            enableHardwareDecodeToolStripMenuItem.Text = "Enable Hardware Decode";
            enableHardwareDecodeToolStripMenuItem.Click += enableHardwareDecodeToolStripMenuItem_Click;
            // 
            // volumeToolStripMenuItem
            // 
            volumeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5, toolStripMenuItem6, toolStripMenuItem7, toolStripMenuItem8, toolStripMenuItem9, toolStripMenuItem10, toolStripMenuItem11 });
            volumeToolStripMenuItem.Name = "volumeToolStripMenuItem";
            volumeToolStripMenuItem.Size = new Size(206, 22);
            volumeToolStripMenuItem.Text = "Volume";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(180, 22);
            toolStripMenuItem2.Text = "10%";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(180, 22);
            toolStripMenuItem3.Text = "20%";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(180, 22);
            toolStripMenuItem4.Text = "30%";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(180, 22);
            toolStripMenuItem5.Text = "40%";
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(180, 22);
            toolStripMenuItem6.Text = "50%";
            toolStripMenuItem6.Click += toolStripMenuItem6_Click;
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(180, 22);
            toolStripMenuItem7.Text = "60%";
            toolStripMenuItem7.Click += toolStripMenuItem7_Click;
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new Size(180, 22);
            toolStripMenuItem8.Text = "70%";
            toolStripMenuItem8.Click += toolStripMenuItem8_Click;
            // 
            // toolStripMenuItem9
            // 
            toolStripMenuItem9.Name = "toolStripMenuItem9";
            toolStripMenuItem9.Size = new Size(180, 22);
            toolStripMenuItem9.Text = "80%";
            toolStripMenuItem9.Click += toolStripMenuItem9_Click;
            // 
            // toolStripMenuItem10
            // 
            toolStripMenuItem10.Name = "toolStripMenuItem10";
            toolStripMenuItem10.Size = new Size(180, 22);
            toolStripMenuItem10.Text = "90%";
            toolStripMenuItem10.Click += toolStripMenuItem10_Click;
            // 
            // toolStripMenuItem11
            // 
            toolStripMenuItem11.Checked = true;
            toolStripMenuItem11.CheckState = CheckState.Checked;
            toolStripMenuItem11.Name = "toolStripMenuItem11";
            toolStripMenuItem11.Size = new Size(180, 22);
            toolStripMenuItem11.Text = "100%";
            toolStripMenuItem11.Click += toolStripMenuItem11_Click;
            // 
            // fileCachingToolStripMenuItem
            // 
            fileCachingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { offToolStripMenuItem, defaultToolStripMenuItem, maxToolStripMenuItem });
            fileCachingToolStripMenuItem.Name = "fileCachingToolStripMenuItem";
            fileCachingToolStripMenuItem.Size = new Size(206, 22);
            fileCachingToolStripMenuItem.Text = "File Caching";
            // 
            // offToolStripMenuItem
            // 
            offToolStripMenuItem.Name = "offToolStripMenuItem";
            offToolStripMenuItem.Size = new Size(180, 22);
            offToolStripMenuItem.Text = "Off";
            offToolStripMenuItem.Click += offToolStripMenuItem_Click;
            // 
            // defaultToolStripMenuItem
            // 
            defaultToolStripMenuItem.Checked = true;
            defaultToolStripMenuItem.CheckState = CheckState.Checked;
            defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            defaultToolStripMenuItem.Size = new Size(180, 22);
            defaultToolStripMenuItem.Text = "Default";
            defaultToolStripMenuItem.Click += defaultToolStripMenuItem_Click;
            // 
            // maxToolStripMenuItem
            // 
            maxToolStripMenuItem.Name = "maxToolStripMenuItem";
            maxToolStripMenuItem.Size = new Size(180, 22);
            maxToolStripMenuItem.Text = "Max";
            maxToolStripMenuItem.Click += maxToolStripMenuItem_Click;
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
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem enableHardwareDecodeToolStripMenuItem;
        private ToolStripMenuItem volumeToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem toolStripMenuItem10;
        private ToolStripMenuItem toolStripMenuItem11;
        private ToolStripMenuItem fileCachingToolStripMenuItem;
        private ToolStripMenuItem offToolStripMenuItem;
        private ToolStripMenuItem defaultToolStripMenuItem;
        private ToolStripMenuItem maxToolStripMenuItem;
    }
}
