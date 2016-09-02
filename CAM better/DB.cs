using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAM_better
{
    class DB
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader dataR;
        private ArrayList firstInList = new ArrayList(); //用來判斷是否第一次通過終點
        private ArrayList selectedRNum = new ArrayList(); //用來存放產生照片名單的NUM
        private ArrayList selectedRTime = new ArrayList(); //用來存放產生照片名單的Time
        public DB()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\documents\visual studio 2015\Projects\CAM better\CAM better\camDB.mdf;Integrated Security=True");
        }
        private void connectDB()
        {
            try
            {
                con.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("資料庫連線失敗");
                throw e;
            }

        }

        private void disConnectDB()
        {
            con.Close();
        }

        public void setStartTime(DateTime startTime) //設定開錄時間
        {
            connectDB();
            cmd = new SqlCommand("UPDATE startTime SET time = @startTime where Id = 1", con);
            cmd.Parameters.Add("@startTime", startTime);
            cmd.ExecuteNonQuery();
        }

        public string getStratTime() //取得起跑時間
        {
            string startTime;
            connectDB();
            cmd = new SqlCommand("select Id,time from startTime where Id = 1", con);
            dataR = cmd.ExecuteReader();
            dataR.Read();         
            startTime = dataR["time"].ToString();    //先取資料後關閉資源
            dataR.Close();
            disConnectDB();
            return startTime;           
        }

        public void writeTime(String socket)  //將收到的跑者socket時間資料寫入DB
        {
            //string sDate = "2010/05/04 13:15:10";
            //string sDate2 = "2010/05/04 15:27:06";
            //DateTime dt = DateTime.ParseExact(sDate, "yyyy/MM/dd HH:mm:ss", null, System.Globalization.DateTimeStyles.AllowWhiteSpaces);
            //DateTime dt2 = DateTime.ParseExact(sDate2, "yyyy/MM/dd HH:mm:ss", null, System.Globalization.DateTimeStyles.AllowWhiteSpaces);
            //TimeSpan tp = dt.Subtract(dt2).Duration();
            //Console.WriteLine("天: " + tp.Days.ToString() + " 秒: " + tp.Seconds.ToString() + " 分: " + tp.Minutes.ToString() + " 總秒: " + tp.TotalSeconds.ToString());
            //string chipid;
            //Console.WriteLine("chipid=" + chipid + " " + "times" + times);
            
            string chipInNum = socket.Substring(socket.IndexOf("059"), 12); //get chipID 
            string times = "20" + socket.Substring(socket.IndexOf("059") + 16, 12); //get Time
            DateTime dt = DateTime.ParseExact(times, "yyyyMMddHHmmss", null, System.Globalization.DateTimeStyles.AllowWhiteSpaces);
            if (!firstInList.Contains(chipInNum))
            {
                firstInList.Add(chipInNum);
                connectDB();
                cmd = new SqlCommand("UPDATE runnerInfo SET finishTime = @dt WHERE chipInNum = @ChipInNum", con);
                cmd.Parameters.Add("@ChipInNum", chipInNum);
                cmd.Parameters.Add("@dt", dt);
                cmd.ExecuteNonQuery();
                disConnectDB();
            }
        }

        public String[] getRunnerInfo(String Num) //取得跑者資料秀在form上
        {
            try
            {
                String[] runnerInfo = new String[3];
                connectDB();          
                cmd = new SqlCommand("select runnerName,chipOutNum,finishTime from runnerInfo where runnerNum = " + Num, con);
                dataR = cmd.ExecuteReader();
                dataR.Read();
                runnerInfo[0] = dataR["runnerName"].ToString();
                runnerInfo[1] = dataR["chipOutNum"].ToString();
                runnerInfo[2] = dataR["finishTime"].ToString();
                return runnerInfo;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                disConnectDB();
            }
        }

        public void createPhotoList()
        {
            connectDB();
            cmd = new SqlCommand("select runnerNum,finishTime from runnerInfo where finishTime IS NOT NULL And  photoCheck = 0", con);
            dataR = cmd.ExecuteReader();
            selectedRNum.Clear();
            selectedRTime.Clear();
            if (dataR.HasRows)
            {
                while (dataR.Read())
                {
                    String runnerNum = dataR["runnerNum"].ToString();
                    String finishTime = dataR["finishTime"].ToString();
                    
                    selectedRTime.Add(finishTime);
                    selectedRNum.Add(runnerNum);

                }
            }
            disConnectDB();
            dataR.Close();
        }
        public ArrayList getSelectRTime()
        {
            return selectedRTime;
        }

        public ArrayList getSelectRNum()
        {
            return selectedRNum;
        }


    }
}
