using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAM_better
{
    class Vlc
    {
        Process p;
        public Vlc()
        {
            p = new Process();
        }
        public void play(int item, int startPlayT, ArrayList videoList, String path)
        {
            p.StartInfo.FileName = @"C:\Program Files (x86)\VideoLAN\VLC\vlc.exe"; //http://10.5.5.9/videos/DCIM/100GOPRO/G0011355.MP4
            p.StartInfo.Arguments = path + videoList[item] + " --start-time " + startPlayT;
            p.Start();
            p.WaitForExit();
            p.Close();
        }
    }
}
