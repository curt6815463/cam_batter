using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAM_better
{
    class FFmpeg
    {
        Process p;
        public FFmpeg()
        {
            p = new Process();
        }

        public void createPhoto(int item, int startCatchPoint, String path, ArrayList videoList , String rNum)
        {
            Console.WriteLine(item);
            Console.WriteLine(startCatchPoint);
            Console.WriteLine(rNum);
            p.StartInfo.FileName = @"C:\Users\User\Desktop\tool\ffmpeg-20160809-369ed11-win64-static\bin\ffmpeg.exe";
            //ffmpegP.StartInfo.Arguments = "-ss 50 -i http://10.5.5.9/videos/DCIM/100GOPRO/G0011615.MP4 -y -r 1 -t 1 asdf.jpg";
            p.StartInfo.Arguments = " -ss " + startCatchPoint + " -i " + path + videoList[item] + " -y -r 1 -t 1 " + rNum + ".jpg";

            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = false;

            p.Start(); // 執行 !
            p.WaitForExit();
            p.Close();
        }
    }
}
