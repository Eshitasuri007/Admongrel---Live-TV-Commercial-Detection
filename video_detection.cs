using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AdBreakDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            // Directory where frame images will be saved
            string framesDirectory = "";
            

            // Path to your live stream
            string liveStreamPath = "add_path_here";

            // Run FFmpeg to continuously extract frames from the live stream
            while (true)
            {
                ExtractFrames(liveStreamPath, framesDirectory);
            }
        }

        static void ExtractFrames(string liveStreamPath, string framesDirectory)
        {
            // Use FFmpeg to extract frames from the live stream
            Process ffmpegProcess = new Process();
            ffmpegProcess.StartInfo.FileName = "/opt/homebrew/bin/ffmpeg";
            ffmpegProcess.StartInfo.Arguments = $"-i {liveStreamPath} -vf fps=2 -vsync vfr {framesDirectory}/frame%d.jpg";
            ffmpegProcess.StartInfo.UseShellExecute = false;
            ffmpegProcess.StartInfo.RedirectStandardOutput = true;
            ffmpegProcess.Start();
            ffmpegProcess.WaitForExit();
        }
    }
}
