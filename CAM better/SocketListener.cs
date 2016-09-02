using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CAM_better
{
    class SocketListener
    {
        private Socket socket;
        private Thread Connectthread;
        DB db = new DB();
        public String handleIPaddr(String ip_input, String port_input)
        {
            try
            {
                IPAddress ip = IPAddress.Parse(ip_input);
                Int32 port = Int32.Parse(port_input);
                IPEndPoint ipPoint = new IPEndPoint(ip, port);
                if (StartConnect(ipPoint))
                {
                    return "連線成功";
                }
                else
                {
                    return "連線失敗";
                }
            }
            catch
            {
                return "請輸入正確主機號碼";
            }
        }
        private bool StartConnect(IPEndPoint ipPoint) //StartConnect
        {
            
            try
            {
                //Ping ping = new Ping();  //先pingIP是否存在在做Socket Connect 也可設Socket Timeout
                //PingReply r = ping.Send(ipPoint.Address, 3);
                //if (r.Status == IPStatus.Success)
                //{              
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); //設定socket連接的格式
                socket.Connect(ipPoint);//Connect
                if (socket.IsBound)
                {
                    Connectthread = new Thread(Show_Msg);  //New a Thread do Show_Msg()
                    Connectthread.Start();
                    return true;
                }
                else
                {
                    return false;
                }
                //}
                //else
                //{ return false; }
            }
            catch (Exception ex)
            {
                try
                {
                    socket.Close();
                    Connectthread.Abort();
                }
                catch
                { }
                return false;
            }
        }
        void Show_Msg()
        {
            while (true)  //Socket Listener
            {
                try
                {
                    byte[] bytes = new byte[1024 * 1024 * 2];   //buffer
                    int length = socket.Receive(bytes);
                    string Msg = System.Text.Encoding.ASCII.GetString(bytes, 0, length);  //Encode                  
                    //db.writeSocket(Msg);
                    Receive_Show(Msg);
                }
                catch (Exception ex)
                {

                }
            }
        }
        string tmp = "";
        void Receive_Show(string Msg)
        {
            try
            {
                if (Msg.Length == 38 && !Msg.Contains("\0"))    //Msg will be "aa0058xxxxxxxxxxxxxxxxxxxxxx"  38bytes
                {
                    if (LRCCheck(Msg))  //LRC CHECK
                        db.writeTime(Msg);
                }
                else
                {
                    if (Msg != "" && !Msg.Contains("\0"))   //Msg will be "aa0058xxxxxxxxxxx" or "XXXXXXXXXXXX"
                    {
                        if (Msg.Contains("\r\n"))
                        {
                            if (tmp.Length + Msg.IndexOf("\r\n") < 36)  //if temp="" and Msg = "0058xxxxxxxxxxxxxxxxxx/r/naa0058xxxxxxxxxxxxxxxxx/r/n"
                            {
                                Msg = Msg.Substring(Msg.IndexOf("\r\n") + 2);
                                tmp = "";
                            }
                        }
                        tmp += Msg;  //Merge  "aa0058xxxxxxxxxxx" + "XXXXXXXXXXXX"  
                    }
                    if (tmp.Length == 38)
                    {

                        if (LRCCheck(tmp))
                            db.writeTime(tmp);
                        tmp = "";
                    }
                    if (tmp.Length > 38)    //over 38bytes Msg will be "aa0058xxxxxxxxxxxxxxxxxxxxx\r\naa0058xxxxxxxxxxxxxxxxxxx/r/naa0058xxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
                    {
                        int len = tmp.Length;
                        for (int i = 0; i < len / 38; i++)
                        {
                            string spilit_str = tmp.Substring(0, 38);
                            if (LRCCheck(spilit_str))
                                db.writeTime(spilit_str);
                            tmp = tmp.Substring(38, tmp.Length - 38);
                        }
                    }
                    if (Msg.Contains("\0"))
                    {
                        Msg.Replace("\0", "");
                    }
                    if (Msg.Contains("?"))
                    {
                        Msg = "";
                    }
                }
            }
            catch (Exception ex)
            {
                Msg = "";
                tmp = "";
            }
        }
        public bool LRCCheck(string payload)
        {
            int LRC = 0;
            try
            {
                payload.Substring(2, 32).ToList().ForEach(x => LRC += x);
                return Convert.ToString(LRC, 16).Substring(1).Equals(payload.Substring(34, 2));
            }
            catch
            {
                return false;
            }
        }
    }
}
