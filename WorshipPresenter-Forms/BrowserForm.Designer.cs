namespace WorshipPresenter_Forms
{
    partial class BrowserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BrowserView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)BrowserView).BeginInit();
            SuspendLayout();
            // 
            // BrowserView
            // 
            BrowserView.AllowExternalDrop = true;
            BrowserView.CreationProperties = null;
            BrowserView.DefaultBackgroundColor = Color.White;
            BrowserView.Dock = DockStyle.Fill;
            BrowserView.Location = new Point(0, 0);
            BrowserView.Name = "BrowserView";
            BrowserView.Size = new Size(972, 600);
            BrowserView.TabIndex = 0;
            BrowserView.ZoomFactor = 1D;
            // 
            // BrowserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 600);
            ControlBox = false;
            Controls.Add(BrowserView);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BrowserForm";
            Text = "BrowserForm";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)BrowserView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Microsoft.Web.WebView2.WinForms.WebView2 BrowserView;
    }
}