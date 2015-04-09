namespace WiFiAAA
{
    partial class TokenPicture
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TokenPicture));
            this.TokenPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TokenTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserIDTxt = new System.Windows.Forms.TextBox();
            this.UserPwTxt = new System.Windows.Forms.TextBox();
            this.LoginBut = new System.Windows.Forms.Button();
            this.LogoutBut = new System.Windows.Forms.Button();
            this.labNetGName = new System.Windows.Forms.Label();
            this.labExpireTime = new System.Windows.Forms.Label();
            this.labUserName = new System.Windows.Forms.Label();
            this.labMsg = new System.Windows.Forms.Label();
            this.TokenBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TokenPic)).BeginInit();
            this.SuspendLayout();
            // 
            // TokenPic
            // 
            this.TokenPic.Location = new System.Drawing.Point(12, 12);
            this.TokenPic.Name = "TokenPic";
            this.TokenPic.Size = new System.Drawing.Size(240, 90);
            this.TokenPic.TabIndex = 0;
            this.TokenPic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "请输入验证码：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TokenTxt
            // 
            this.TokenTxt.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TokenTxt.Location = new System.Drawing.Point(12, 133);
            this.TokenTxt.Name = "TokenTxt";
            this.TokenTxt.Size = new System.Drawing.Size(240, 33);
            this.TokenTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(7, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "用户名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(26, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "密码：";
            // 
            // UserIDTxt
            // 
            this.UserIDTxt.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserIDTxt.Location = new System.Drawing.Point(82, 182);
            this.UserIDTxt.Name = "UserIDTxt";
            this.UserIDTxt.Size = new System.Drawing.Size(170, 33);
            this.UserIDTxt.TabIndex = 5;
            this.UserIDTxt.TextChanged += new System.EventHandler(this.UserIDTxt_TextChanged);
            // 
            // UserPwTxt
            // 
            this.UserPwTxt.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserPwTxt.Location = new System.Drawing.Point(82, 232);
            this.UserPwTxt.Name = "UserPwTxt";
            this.UserPwTxt.PasswordChar = '*';
            this.UserPwTxt.Size = new System.Drawing.Size(170, 33);
            this.UserPwTxt.TabIndex = 6;
            // 
            // LoginBut
            // 
            this.LoginBut.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoginBut.Location = new System.Drawing.Point(270, 133);
            this.LoginBut.Name = "LoginBut";
            this.LoginBut.Size = new System.Drawing.Size(191, 64);
            this.LoginBut.TabIndex = 7;
            this.LoginBut.Text = "登陆";
            this.LoginBut.UseVisualStyleBackColor = true;
            this.LoginBut.Click += new System.EventHandler(this.LoginBut_Click);
            // 
            // LogoutBut
            // 
            this.LogoutBut.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LogoutBut.Location = new System.Drawing.Point(270, 203);
            this.LogoutBut.Name = "LogoutBut";
            this.LogoutBut.Size = new System.Drawing.Size(191, 64);
            this.LogoutBut.TabIndex = 8;
            this.LogoutBut.Text = "注销";
            this.LogoutBut.UseVisualStyleBackColor = true;
            this.LogoutBut.Click += new System.EventHandler(this.LogoutBut_Click);
            // 
            // labNetGName
            // 
            this.labNetGName.AutoSize = true;
            this.labNetGName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labNetGName.Location = new System.Drawing.Point(281, 12);
            this.labNetGName.Name = "labNetGName";
            this.labNetGName.Size = new System.Drawing.Size(0, 17);
            this.labNetGName.TabIndex = 9;
            // 
            // labExpireTime
            // 
            this.labExpireTime.AutoSize = true;
            this.labExpireTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labExpireTime.Location = new System.Drawing.Point(281, 33);
            this.labExpireTime.Name = "labExpireTime";
            this.labExpireTime.Size = new System.Drawing.Size(0, 17);
            this.labExpireTime.TabIndex = 10;
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labUserName.Location = new System.Drawing.Point(281, 54);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(0, 17);
            this.labUserName.TabIndex = 11;
            // 
            // labMsg
            // 
            this.labMsg.AutoSize = true;
            this.labMsg.Location = new System.Drawing.Point(281, 90);
            this.labMsg.Name = "labMsg";
            this.labMsg.Size = new System.Drawing.Size(0, 12);
            this.labMsg.TabIndex = 12;
            // 
            // TokenBut
            // 
            this.TokenBut.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TokenBut.Location = new System.Drawing.Point(164, 105);
            this.TokenBut.Name = "TokenBut";
            this.TokenBut.Size = new System.Drawing.Size(87, 24);
            this.TokenBut.TabIndex = 13;
            this.TokenBut.Text = "刷新验证码";
            this.TokenBut.UseVisualStyleBackColor = true;
            this.TokenBut.Click += new System.EventHandler(this.TokenBut_Click);
            // 
            // TokenPicture
            // 
            this.AcceptButton = this.LoginBut;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 279);
            this.Controls.Add(this.TokenBut);
            this.Controls.Add(this.labMsg);
            this.Controls.Add(this.labUserName);
            this.Controls.Add(this.labExpireTime);
            this.Controls.Add(this.labNetGName);
            this.Controls.Add(this.LogoutBut);
            this.Controls.Add(this.LoginBut);
            this.Controls.Add(this.UserPwTxt);
            this.Controls.Add(this.UserIDTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TokenTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TokenPic);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TokenPicture";
            this.Text = "WiFiAAA by CmcnPro";
            this.Load += new System.EventHandler(this.TokenPicture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TokenPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TokenPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TokenTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserIDTxt;
        private System.Windows.Forms.TextBox UserPwTxt;
        private System.Windows.Forms.Button LoginBut;
        private System.Windows.Forms.Button LogoutBut;
        private System.Windows.Forms.Label labNetGName;
        private System.Windows.Forms.Label labExpireTime;
        private System.Windows.Forms.Label labUserName;
        private System.Windows.Forms.Label labMsg;
        private System.Windows.Forms.Button TokenBut;
    }
}

