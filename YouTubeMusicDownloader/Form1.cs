using System.Data;
using YoutubeExplode.Videos.Streams;

namespace YouTubeMusicDownloader
{
    public partial class Form1 : Form
    {
        private Dictionary<string, AudioOnlyStreamInfo> bitrateStreamDictionary = new();
        private readonly string musicDirName = "Music";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void SearchTrackButton_Click(object sender, EventArgs e)
        {
            string trackUrl = trackLinkBox.Text;
            if (string.IsNullOrEmpty(trackUrl))
                MessageBox.Show("Invalid Url", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Tuple<string, List<AudioOnlyStreamInfo>> audioData;
            try
            {
                audioData = await YouTubeDownloader.GetAudioData(trackUrl);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string audioName = audioData.Item1;
            List<AudioOnlyStreamInfo> streamList = audioData.Item2;
            if (streamList.Count == 0)
            {
                MessageBox.Show("Track not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ShowTrackData(audioName, streamList);
        }

        private void ShowTrackData(string name, List<AudioOnlyStreamInfo> streamList)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Bitrate", typeof(string));

            bitrateStreamDictionary.Clear();
            foreach (var audio in streamList)
            {
                table.Rows.Add(audio.Bitrate.ToString());
                bitrateStreamDictionary.Add(audio.Bitrate.ToString(), audio);
            }
            bitrateView.DataSource = table;
            bitrateView.AutoResizeColumns();

            trackName.Text = name;
            trackName.Visible = true;
            trackLabel.Visible = true;
            bitrateView.Visible = true;
            downloadButton.Visible = true;
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            if(bitrateView.CurrentRow.Index == -1 || bitrateView.CurrentCell == null || 
                bitrateView.CurrentCell.Value == null)
            {
                MessageBox.Show("Invalid row", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var streamInfo = bitrateStreamDictionary[bitrateView.CurrentCell.Value.ToString()];
            if (streamInfo != null)
            {
                DownloadTrack(streamInfo, trackName.Text);
            }
        }

        private void HideTrackData()
        {
            trackName.Visible = false;
            trackLabel.Visible = false;
            bitrateView.Visible = false;
            downloadButton.Visible = false;
        }

        private async void DownloadTrack(AudioOnlyStreamInfo streamInfo, string trackName)
        {
            var assemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var assemblyParentPath = Path.GetDirectoryName(assemblyPath);
            var musicDir = Path.Combine(assemblyParentPath, musicDirName);

            if (!Directory.Exists(musicDir))
                Directory.CreateDirectory(musicDir);

            try
            {
                downloadProgress.Value = 0;

                var progress = new Progress<int>(percent =>
                {
                    downloadProgress.Value = percent;
                });

                HideTrackData();
                downloadProgress.Visible = true;
                downloadTrackButton.Enabled = false;
                cancelButton.Visible = true;

                switch (await YouTubeDownloader.DownloadYouTubeAudio(streamInfo, trackName, musicDir, progress))
                {
                    case YouTubeDownloader.DownloadState.Downloaded:
                        MessageBox.Show("Audio downloaded successfully.", "Downloaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case YouTubeDownloader.DownloadState.Cancelled:
                        MessageBox.Show("Audio download cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("An error occured while downloading the audio(check your internet connection).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cancelButton.Visible = false;
                downloadProgress.Visible = false;
                downloadTrackButton.Enabled = true;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            YouTubeDownloader.CancelDownload();
        }
    }
}
