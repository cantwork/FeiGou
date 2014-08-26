using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace FeiGou
{
    public partial class Form1 : Form
    {
        public delegate void delAddFriend(Friend friend);

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            UdpClient uc = new UdpClient();
            string msg = "LOGIN|" + this.lblNickName.Text + "|31|o啦啦啦";
            byte[] bmsg = Encoding.Default.GetBytes(msg);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("255.255.255.255"), 9527);
            uc.Send(bmsg, bmsg.Length, ipep);
        }

        private void listen()
        {
            UdpClient uc = new UdpClient(9527);
            while (true)
            {
                IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 0);
                byte[] bmsg = uc.Receive(ref ipep);
                string msg = Encoding.Default.GetString(bmsg);
                string[] s = msg.Split('|');
                if(s.Length!=4)
                {
                    continue;
                }
                if(s[0]=="LOGIN")
                {
                    Friend friend = new Friend();
                    int curIndex = Convert.ToInt32(s[2]);
                    if(curIndex<0||curIndex>=this.ilHeadImages.Images.Count)
                    {
                        curIndex = 0;
                    }
                    friend.HeadImageIndex = curIndex;
                    friend.NameNick=s[1];
                    friend.ShuoShuo=s[3];

                    object[] pars=new object[1];
                    pars[0]=friend;
                    this.Invoke(new delAddFriend(this.addUcf),pars);
                   
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1.CheckForIllegalCrossThreadCalls = false;
            Thread th = new Thread(new ThreadStart(listen));
            Thread.Sleep(100);
            th.IsBackground = true;
            th.Start();

            //for (int i = 0; i < 100; i++)
            //{
            //    UCfriend ucf = new UCfriend();
            //    ucf.Top = i * ucf.Height;
            //    this.pnFriend.Controls.Add(ucf);
            //}

        }

        public void addUcf(Friend f) 
        { 
             UCfriend ucf = new UCfriend();  
             ucf.CurFriend = f;
             ucf.Top = this.pnFriend.Controls.Count * ucf.Height;
             this.pnFriend.Controls.Add(ucf);
            
        }

        private void pnFriend_Paint(object sender, PaintEventArgs e)
        {

        }

        

    }
}
