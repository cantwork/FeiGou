namespace FeiGou
{
    partial class UCfriend
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCfriend));
            this.pic_friend = new System.Windows.Forms.PictureBox();
            this.lblFrNickName = new System.Windows.Forms.Label();
            this.lblFrShuoShuo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_friend)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_friend
            // 
            this.pic_friend.Image = ((System.Drawing.Image)(resources.GetObject("pic_friend.Image")));
            this.pic_friend.Location = new System.Drawing.Point(4, 4);
            this.pic_friend.Name = "pic_friend";
            this.pic_friend.Size = new System.Drawing.Size(60, 60);
            this.pic_friend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_friend.TabIndex = 0;
            this.pic_friend.TabStop = false;
            // 
            // lblFrNickName
            // 
            this.lblFrNickName.AutoSize = true;
            this.lblFrNickName.Location = new System.Drawing.Point(84, 16);
            this.lblFrNickName.Name = "lblFrNickName";
            this.lblFrNickName.Size = new System.Drawing.Size(41, 12);
            this.lblFrNickName.TabIndex = 1;
            this.lblFrNickName.Text = "label1";
            // 
            // lblFrShuoShuo
            // 
            this.lblFrShuoShuo.AutoSize = true;
            this.lblFrShuoShuo.Location = new System.Drawing.Point(84, 41);
            this.lblFrShuoShuo.Name = "lblFrShuoShuo";
            this.lblFrShuoShuo.Size = new System.Drawing.Size(41, 12);
            this.lblFrShuoShuo.TabIndex = 2;
            this.lblFrShuoShuo.Text = "label2";
            // 
            // UCfriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFrShuoShuo);
            this.Controls.Add(this.lblFrNickName);
            this.Controls.Add(this.pic_friend);
            this.Name = "UCfriend";
            this.Size = new System.Drawing.Size(269, 70);
            this.Load += new System.EventHandler(this.UCfriend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_friend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_friend;
        private System.Windows.Forms.Label lblFrNickName;
        private System.Windows.Forms.Label lblFrShuoShuo;
    }
}
