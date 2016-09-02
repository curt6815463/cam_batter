using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAM_better
{
    public partial class Form1 : Form
    {
        String runnerTime;
        SocketListener socketListen;
        DB db;
        Gopro gp;
        public Form1()
        {
            InitializeComponent();
            runnerTime = "";
            socketListen = new SocketListener();
            db = new DB();
            gp = new Gopro();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void connect_Click(object sender, EventArgs e)
        {
            MessageBox.Show(socketListen.handleIPaddr(ipAddressTxt.Text, portTxt.Text));
        }

        private void searchRunner_Click(object sender, EventArgs e)
        {
            String[] runnerInfo = db.getRunnerInfo(runnerNum.Text);
            if(runnerInfo != null)
            {
                name.Text = runnerInfo[0];
                outCode.Text = runnerInfo[1];
                time.Text = runnerInfo[2].Substring(12);
                runnerTime = runnerInfo[2];
            }
            else
            {
                name.Text = "";
                outCode.Text = "";
                time.Text = "";
                MessageBox.Show("無此跑者");
            }
        }




        private void searchVideo_Click(object sender, EventArgs e)
        {         

            if(runnerTime != "")
            {
                gp.searchVideo(runnerTime,db.getStratTime());
            }
            else
            {
                MessageBox.Show("請確認時間是否紀錄");
            }
        }

        private void shuttle_Click(object sender, EventArgs e)
        {
            gp.shutter();
            if(db.getStratTime() == "")
            {
                db.setStartTime(DateTime.Now);
            }
        }

        private void photo_Click(object sender, EventArgs e)
        {
            db.createPhotoList();
            gp.createPhoto(db.getSelectRNum(), db.getSelectRTime(), db.getStratTime());

        }
    }
}
