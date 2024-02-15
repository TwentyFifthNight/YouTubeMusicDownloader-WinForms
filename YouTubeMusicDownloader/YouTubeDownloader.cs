using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;

namespace YouTubeMusicDownloader
{
    internal class YouTubeDownloader
    {
        private static bool isDownloadCanceled = false;
        private static readonly YoutubeClient youtube = new();
        private static readonly HttpClient httpClient = new();

        public enum DownloadState
        {
            Downloaded,
            Cancelled
        }

        public static async Task<Tuple<string, List<AudioOnlyStreamInfo>>> GetAudioData(string videoUrl)
        {
            Video video;
            try
            {
                video = await youtube.Videos.GetAsync(videoUrl);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                throw new ArgumentException("Invalid Url");
            }

            string sanitizedTitle = string.Join("_", video.Title.Split(Path.GetInvalidFileNameChars()));

            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);
            return new Tuple<string, List<AudioOnlyStreamInfo>>(sanitizedTitle, streamManifest.GetAudioOnlyStreams().OrderByDescending(s => s.Bitrate).ToList());
        }

        public static async Task<DownloadState> DownloadYouTubeAudio(AudioOnlyStreamInfo streamInfo, string outputName, string outputDirectory, IProgress<int>? progress = null)
        {
            var stream = await httpClient.GetStreamAsync(streamInfo.Url);
            Console.WriteLine(streamInfo.Url);
            isDownloadCanceled = false;
            string dateTime = DateTime.Now.ToString().Replace('.', '_').Replace(':', '_');

            string outputFilePath = Path.Combine(outputDirectory, $"{outputName}_{dateTime}.mp3");
            return await SaveStreamToFile(stream, outputFilePath, streamInfo.Size.Bytes, progress);
        }

        private static async Task<DownloadState> SaveStreamToFile(Stream stream, string outputFilePath, long size, IProgress<int>? progress = null)
        {
            try
            {
                using FileStream outputStream = File.Create(outputFilePath);
                byte[] buffer = new byte[16 * 1024];
                int read;
                long count = 0;
                while (!isDownloadCanceled && (read = await stream.ReadAsync(buffer)) > 0)
                {
                    await outputStream.WriteAsync(buffer.AsMemory(0, read));
                    count += read;
                    progress?.Report(Convert.ToInt32(count * 100.0 / size));
                }
            }
            catch (Exception)
            {
                File.Delete(outputFilePath);
                Console.WriteLine("Error occured while downloading audio");
                throw;
            }

            if (isDownloadCanceled)
            {
                File.Delete(outputFilePath);
                Console.WriteLine("Download canceled");
                return DownloadState.Cancelled;
            }
            else
            {
                Console.WriteLine("Download completed!");
                Console.WriteLine($"Audio saved as: {outputFilePath}");
                return DownloadState.Downloaded;
            }
        }

        public static void CancelDownload()
        {
            isDownloadCanceled = true;
        }
    }
}
