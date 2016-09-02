using System;

namespace CAM_better
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ipAddressTxt = new System.Windows.Forms.TextBox();
            this.connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.portTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchVideo = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.outCode = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchRunner = new System.Windows.Forms.Button();
            this.runnerNum = new System.Windows.Forms.TextBox();
            this.shuttle = new System.Windows.Forms.Button();
            this.photo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ipAddressTxt
            // 
            this.ipAddressTxt.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ipAddressTxt.Location = new System.Drawing.Point(97, 19);
            this.ipAddressTxt.Name = "ipAddressTxt";
            this.ipAddressTxt.Size = new System.Drawing.Size(109, 29);
            this.ipAddressTxt.TabIndex = 1;
            this.ipAddressTxt.Text = "10.15.1.";
            // 
            // connect
            // 
            this.connect.Font = new System.Drawing.Font("Microsoft JhengHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.connect.Location = new System.Drawing.Point(7, 101);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(199, 39);
            this.connect.TabIndex = 2;
            this.connect.Text = "connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "主機IP：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(22, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port：";
            // 
            // portTxt
            // 
            this.portTxt.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.portTxt.Location = new System.Drawing.Point(97, 64);
            this.portTxt.Name = "portTxt";
            this.portTxt.Size = new System.Drawing.Size(109, 29);
            this.portTxt.TabIndex = 5;
            this.portTxt.Text = "10000";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.portTxt);
            this.panel1.Controls.Add(this.ipAddressTxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.connect);
            this.panel1.Font = new System.Drawing.Font("Vivaldi", 8.25F);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 152);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.searchVideo);
            this.panel2.Controls.Add(this.time);
            this.panel2.Controls.Add(this.outCode);
            this.panel2.Controls.Add(this.name);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.searchRunner);
            this.panel2.Controls.Add(this.runnerNum);
            this.panel2.Location = new System.Drawing.Point(293, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 324);
            this.panel2.TabIndex = 3;
            // 
            // searchVideo
            // 
            this.searchVideo.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.searchVideo.Location = new System.Drawing.Point(133, 251);
            this.searchVideo.Name = "searchVideo";
            this.searchVideo.Size = new System.Drawing.Size(99, 52);
            this.searchVideo.TabIndex = 10;
            this.searchVideo.Text = "查詢影片";
            this.searchVideo.UseVisualStyleBackColor = true;
            this.searchVideo.Click += new System.EventHandler(this.searchVideo_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.time.Location = new System.Drawing.Point(129, 201);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 21);
            this.time.TabIndex = 9;
            // 
            // outCode
            // 
            this.outCode.AutoSize = true;
            this.outCode.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.outCode.Location = new System.Drawing.Point(129, 141);
            this.outCode.Name = "outCode";
            this.outCode.Size = new System.Drawing.Size(0, 21);
            this.outCode.TabIndex = 8;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.name.Location = new System.Drawing.Point(129, 81);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(0, 21);
            this.name.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(3, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "到達時間：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(3, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "晶片外碼：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(3, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "跑者姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(3, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "跑者編號：";
            // 
            // searchRunner
            // 
            this.searchRunner.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.searchRunner.Location = new System.Drawing.Point(7, 251);
            this.searchRunner.Name = "searchRunner";
            this.searchRunner.Size = new System.Drawing.Size(99, 52);
            this.searchRunner.TabIndex = 2;
            this.searchRunner.Text = "查詢跑者";
            this.searchRunner.UseVisualStyleBackColor = true;
            this.searchRunner.Click += new System.EventHandler(this.searchRunner_Click);
            // 
            // runnerNum
            // 
            this.runnerNum.Location = new System.Drawing.Point(133, 20);
            this.runnerNum.Name = "runnerNum";
            this.runnerNum.Size = new System.Drawing.Size(109, 22);
            this.runnerNum.TabIndex = 1;
            // 
            // shuttle
            // 
            this.shuttle.Font = new System.Drawing.Font("Microsoft JhengHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.shuttle.Location = new System.Drawing.Point(12, 276);
            this.shuttle.Name = "shuttle";
            this.shuttle.Size = new System.Drawing.Size(199, 39);
            this.shuttle.TabIndex = 6;
            this.shuttle.Text = "開始錄影";
            this.shuttle.UseVisualStyleBackColor = true;
            this.shuttle.Click += new System.EventHandler(this.shuttle_Click);
            // 
            // photo
            // 
            this.photo.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.photo.Location = new System.Drawing.Point(300, 366);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(116, 38);
            this.photo.TabIndex = 7;
            this.photo.Text = "產生照片";
            this.photo.UseVisualStyleBackColor = true;
            this.photo.Click += new System.EventHandler(this.photo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 416);
            this.Controls.Add(this.photo);
            this.Controls.Add(this.shuttle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.TextBox ipAddressTxt;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button searchRunner;
        private System.Windows.Forms.TextBox runnerNum;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label outCode;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button searchVideo;
        private System.Windows.Forms.Button shuttle;
        private System.Windows.Forms.Button photo;
    }
}

