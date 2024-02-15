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
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
			((System.ComponentModel.ISupportInitialize)bitrateView).BeginInit();
			SuspendLayout();
			// 
			// trackLinkBox
			// 
			trackLinkBox.Anchor = AnchorStyles.None;
			trackLinkBox.Location = new Point(10, 46);
			trackLinkBox.Margin = new Padding(3, 2, 3, 2);
			trackLinkBox.Name = "trackLinkBox";
			trackLinkBox.Size = new Size(401, 23);
			trackLinkBox.TabIndex = 1;
			// 
			// downloadTrackButton
			// 
			downloadTrackButton.Anchor = AnchorStyles.None;
			downloadTrackButton.BackColor = Color.White;
			downloadTrackButton.Location = new Point(416, 44);
			downloadTrackButton.Margin = new Padding(3, 2, 3, 2);
			downloadTrackButton.Name = "downloadTrackButton";
			downloadTrackButton.Size = new Size(82, 22);
			downloadTrackButton.TabIndex = 2;
			downloadTrackButton.Text = "Search";
			downloadTrackButton.UseVisualStyleBackColor = false;
			downloadTrackButton.Click += SearchTrackButton_Click;
			// 
			// downloadProgress
			// 
			downloadProgress.Anchor = AnchorStyles.None;
			downloadProgress.Location = new Point(10, 106);
			downloadProgress.Margin = new Padding(3, 2, 3, 2);
			downloadProgress.Name = "downloadProgress";
			downloadProgress.Size = new Size(488, 22);
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
			cancelButton.Location = new Point(416, 70);
			cancelButton.Margin = new Padding(3, 2, 3, 2);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(82, 22);
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
			bitrateView.BackgroundColor = SystemColors.Control;
			bitrateView.BorderStyle = BorderStyle.None;
			bitrateView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			bitrateView.GridColor = Color.White;
			bitrateView.Location = new Point(10, 123);
			bitrateView.Margin = new Padding(3, 2, 3, 2);
			bitrateView.MultiSelect = false;
			bitrateView.Name = "bitrateView";
			bitrateView.ReadOnly = true;
			bitrateView.RowHeadersVisible = false;
			bitrateView.RowHeadersWidth = 51;
			bitrateView.ScrollBars = ScrollBars.Vertical;
			bitrateView.Size = new Size(136, 106);
			bitrateView.TabIndex = 5;
			bitrateView.Visible = false;
			// 
			// trackLabel
			// 
			trackLabel.AutoSize = true;
			trackLabel.Location = new Point(10, 89);
			trackLabel.Name = "trackLabel";
			trackLabel.Size = new Size(69, 15);
			trackLabel.TabIndex = 6;
			trackLabel.Text = "TrackName:";
			trackLabel.Visible = false;
			// 
			// trackName
			// 
			trackName.AutoSize = true;
			trackName.Location = new Point(76, 89);
			trackName.Name = "trackName";
			trackName.Size = new Size(29, 15);
			trackName.TabIndex = 7;
			trackName.Text = "Title";
			trackName.Visible = false;
			// 
			// downloadButton
			// 
			downloadButton.BackColor = Color.Chartreuse;
			downloadButton.Location = new Point(49, 232);
			downloadButton.Margin = new Padding(3, 2, 3, 2);
			downloadButton.Name = "downloadButton";
			downloadButton.Size = new Size(82, 22);
			downloadButton.TabIndex = 8;
			downloadButton.Text = "Download";
			downloadButton.UseVisualStyleBackColor = false;
			downloadButton.Visible = false;
			downloadButton.Click += DownloadButton_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(10, 29);
			label1.Name = "label1";
			label1.Size = new Size(62, 15);
			label1.TabIndex = 9;
			label1.Text = "audio link:";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(509, 265);
			Controls.Add(label1);
			Controls.Add(downloadButton);
			Controls.Add(trackName);
			Controls.Add(trackLabel);
			Controls.Add(bitrateView);
			Controls.Add(cancelButton);
			Controls.Add(downloadProgress);
			Controls.Add(downloadTrackButton);
			Controls.Add(trackLinkBox);
			Margin = new Padding(3, 2, 3, 2);
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
		private Label label1;
	}
}
