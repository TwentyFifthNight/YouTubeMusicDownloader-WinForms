namespace YouTubeMusicDownloader
{
    partial class Form1
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
            trackLinkBox = new TextBox();
            downloadTrackButton = new Button();
            downloadProgress = new ProgressBar();
            fileSystemWatcher1 = new FileSystemWatcher();
            cancelButton = new Button();
            bitrateView = new DataGridView();
            trackLabel = new Label();
            trackName = new Label();
            downloadButton = new Button();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bitrateView).BeginInit();
            SuspendLayout();
            // 
            // trackLinkBox
            // 
            trackLinkBox.Anchor = AnchorStyles.None;
            trackLinkBox.Location = new Point(12, 61);
            trackLinkBox.Name = "trackLinkBox";
            trackLinkBox.Size = new Size(458, 27);
            trackLinkBox.TabIndex = 1;
            trackLinkBox.Text = "https://www.youtube.com/watch?v=uu5YtclG4DI&list=PLqUwbjvFM2oqroiEUVsmwGQPp2ki22h32&index=2&ab_channel=inelvy";
            // 
            // downloadTrackButton
            // 
            downloadTrackButton.Anchor = AnchorStyles.None;
            downloadTrackButton.BackColor = Color.White;
            downloadTrackButton.Location = new Point(476, 59);
            downloadTrackButton.Name = "downloadTrackButton";
            downloadTrackButton.Size = new Size(94, 29);
            downloadTrackButton.TabIndex = 2;
            downloadTrackButton.Text = "Search";
            downloadTrackButton.UseVisualStyleBackColor = false;
            downloadTrackButton.Click += SearchTrackButton_Click;
            // 
            // downloadProgress
            // 
            downloadProgress.Anchor = AnchorStyles.None;
            downloadProgress.Location = new Point(12, 141);
            downloadProgress.Name = "downloadProgress";
            downloadProgress.Size = new Size(558, 29);
            downloadProgress.TabIndex = 3;
            downloadProgress.Visible = false;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.None;
            cancelButton.BackColor = Color.Red;
            cancelButton.Location = new Point(476, 94);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Visible = false;
            cancelButton.Click += CancelButton_Click;
            // 
            // bitrateView
            // 
            bitrateView.AllowUserToAddRows = false;
            bitrateView.AllowUserToDeleteRows = false;
            bitrateView.AllowUserToResizeColumns = false;
            bitrateView.AllowUserToResizeRows = false;
            bitrateView.BackgroundColor = Color.White;
            bitrateView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bitrateView.GridColor = Color.White;
            bitrateView.Location = new Point(12, 164);
            bitrateView.MultiSelect = false;
            bitrateView.Name = "bitrateView";
            bitrateView.ReadOnly = true;
            bitrateView.RowHeadersVisible = false;
            bitrateView.RowHeadersWidth = 51;
            bitrateView.ScrollBars = ScrollBars.Vertical;
            bitrateView.Size = new Size(155, 142);
            bitrateView.TabIndex = 5;
            bitrateView.Visible = false;
            // 
            // trackLabel
            // 
            trackLabel.AutoSize = true;
            trackLabel.Location = new Point(12, 141);
            trackLabel.Name = "trackLabel";
            trackLabel.Size = new Size(86, 20);
            trackLabel.TabIndex = 6;
            trackLabel.Text = "TrackName:";
            trackLabel.Visible = false;
            // 
            // trackName
            // 
            trackName.AutoSize = true;
            trackName.Location = new Point(104, 141);
            trackName.Name = "trackName";
            trackName.Size = new Size(50, 20);
            trackName.TabIndex = 7;
            trackName.Text = "label2";
            trackName.Visible = false;
            // 
            // downloadButton
            // 
            downloadButton.BackColor = Color.Chartreuse;
            downloadButton.Location = new Point(44, 312);
            downloadButton.Name = "downloadButton";
            downloadButton.Size = new Size(94, 29);
            downloadButton.TabIndex = 8;
            downloadButton.Text = "Download";
            downloadButton.UseVisualStyleBackColor = false;
            downloadButton.Visible = false;
            downloadButton.Click += DownloadButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 353);
            Controls.Add(downloadButton);
            Controls.Add(trackName);
            Controls.Add(trackLabel);
            Controls.Add(bitrateView);
            Controls.Add(cancelButton);
            Controls.Add(downloadProgress);
            Controls.Add(downloadTrackButton);
            Controls.Add(trackLinkBox);
            Name = "Form1";
            Text = "YouTubeDownloader";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bitrateView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox trackLinkBox;
        private Button downloadTrackButton;
        private ProgressBar downloadProgress;
        private FileSystemWatcher fileSystemWatcher1;
        private Button cancelButton;
        private DataGridView bitrateView;
        private Label trackName;
        private Label trackLabel;
        private Button downloadButton;
    }
}
