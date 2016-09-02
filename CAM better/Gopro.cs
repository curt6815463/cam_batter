using HtmlAgilityPack;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CAM_better
{
    class Gopro
    {
        ArrayList videoList;
        Vlc vlc;
        FFmpeg ffmpeg;
        string path;
        public Gopro()
        {
            videoList = new ArrayList();
            vlc = new Vlc();
            ffmpeg = new FFmpeg();
            path = "http://10.5.5.9/videos/DCIM/100GOPRO/";
        }

        public void shutter() //啟動攝影
        {
            getReq("http://10.5.5.9/gp/gpControl/command/shutter?p=1");
        }

        async static void getReq(String url)//發出攝影req
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage res = await client.GetAsync(url);
            }
            catch(Exception)
            {}            
        }

        public int[] selectFile(int offset) //找出哪一個五分鐘影片
        {
            int[] itemAndPlayTime = new int[2];
            itemAndPlayTime[0] = offset / 300;       //第幾個片段播
            itemAndPlayTime[1] = offset % 300;       //第幾秒播
            return itemAndPlayTime;         
        }

        public void searchVideo(String startTime, String runnerTime)   //call vlc撥放
        {
            TimeSpan ts = timeSubtract(startTime, runnerTime);
            int[] playInfo = selectFile((int)ts.TotalSeconds);
            loadFile();
            vlc.play(playInfo[0],playInfo[1],videoList,path);
        }

        public TimeSpan timeSubtract(String startTime,String runnerTime) //起跑與跑者時間相減
        {
            DateTime sTime = DateTime.Parse(startTime);
            DateTime rTime = DateTime.Parse(runnerTime);
            TimeSpan ts = rTime.Subtract(sTime).Duration();
            return ts;
        }

        public void createPhoto(ArrayList runnerNum, ArrayList finishTime, String startTime)
        {
            loadFile();
            
            for (int i = 0; i < runnerNum.Count; i++)
            {
                TimeSpan ts = timeSubtract(startTime, finishTime[i].ToString());
                int[] createInfo = selectFile((int)ts.TotalSeconds);
                ffmpeg.createPhoto(createInfo[0],createInfo[1],path,videoList,runnerNum[i].ToString());
            }
        }



        public void loadFile()   //取得gopro上檔案，目前有連線愈時問題
        {
            try
            {
                videoList.Clear();
                HtmlWeb webClient = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = webClient.Load(path);
                HtmlNodeCollection nameNodes = doc.DocumentNode.SelectNodes(@"//a[@class='link']");
                foreach (HtmlNode node in nameNodes)
                {
                    String strValue = node.InnerText;  //擷取字串
                    if (strValue.IndexOf(".MP4") > -1)
                    {
                        videoList.Add(strValue);
                    }

                }
            }
            catch (Exception)
            {

                Console.WriteLine("gopro 未連接");
            }

        }
    }
}
