using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace FeiGou
{
    public partial class UCfriend : UserControl
    {
        private Form1 frm;

        public Form1 Frm {
            get { return frm; }
            set { frm = value; }
        }

        private Friend curFriend;

        public Friend CurFriend{
            get { return curFriend; }
            set {
                curFriend = value;
                this.lblFrNickName.Text = value.NameNick;
                this.lblFrShuoShuo.Text = value.ShuoShuo;
                this.pic_friend.Image=this.frm.ilHeadImages.Images[value.HeadImageIndex];

            }
        }

        public UCfriend()
        {
            InitializeComponent();
        }

        private void UCfriend_Load(object sender, EventArgs e)
        {

        }
    }
}
