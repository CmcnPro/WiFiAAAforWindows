using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
//using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using System.Runtime.InteropServices;

namespace WiFiAAA
{
    public partial class TokenPicture : Form
    {
        Boolean ISCLICK_Flag = false;
        string UserID, Token;
        public ManualResetEvent eventX;
        Open.OpenAAASoapClient aaa = new Open.OpenAAASoapClient();
        
        private Image byteArrayToImage(byte[] Bytes)
        {
            using (MemoryStream ms = new MemoryStream(Bytes))
            {
                Image outputImg = Image.FromStream(ms);
                return outputImg;
            }
        }
        

        public TokenPicture()
        {
            InitializeComponent();
            TokenPic.Image = byteArrayToImage(aaa.GetTokenPictureBytes());
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserIDTxt_TextChanged(object sender, EventArgs e)
        {
            
        }
 
        public void LoginBut_Click(object sender, EventArgs e)
        {
            UserID = UserIDTxt.Text;
            string UserPw = UserPwTxt.Text;
            
            //获取内网IP
            IPAddress ipAddr = null;
            IPAddress[] arrIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress ip in arrIP)
            {
                if (System.Net.Sockets.AddressFamily.InterNetwork.Equals(ip.AddressFamily))
                {
                    ipAddr = ip;
                }
                else if (System.Net.Sockets.AddressFamily.InterNetworkV6.Equals(ip.AddressFamily))
                {
                    ipAddr = ip;
                }
            }
            string UserIP = ipAddr.ToString();

            string OpenAPIVersion ="1.0.0.0";
             Token = TokenTxt.Text;
            //MessageBox.Show(UserIP);

            

            Open.LoginResultInfo lr =   aaa.Login(UserID, UserPw, UserIP, OpenAPIVersion, Token);

            //MessageBox.Show(lr.NetGroupName);

            //labNetGName.Text = lr.NetGroupName;
            //labExpireTime.Text = lr.ExpireTime.ToShortDateString();
            //labUserName.Text = lr.UserName;
            //labMsg.Text = lr.Message;


            if (lr.IsWrong ==null ) MessageBox.Show("无法连接到服务器");

            if (lr.IsLogin != true)
            {
                if (lr.IsExpire == true) MessageBox.Show("账户已过期！");
                if (lr.IsIDPWWrong == true) MessageBox.Show("账户密码错误！");
                if (lr.IsIPInvalid == true) MessageBox.Show("IP无效！");
                if (lr.IsDisable == true) MessageBox.Show("账户无效，请联系信息中心！");
                if (lr.IsWrong == true) MessageBox.Show("发生其他错误（注：你的登陆请求已经成功传递要服务器）");
            }

            //Thread thred = new Thread(new ThreadStart());
            //thred.IsBackground = true;
            //thred.Start();

            labNetGName.Text = lr.NetGroupName;
            labExpireTime.Text = lr.ExpireTime.ToShortDateString();
            labUserName.Text = lr.UserName;
            labMsg.Text = lr.Message;

            MessageBox.Show(lr.Message);

            Thread t = new Thread(new ThreadStart(keep));
            t.IsBackground = true;
            t.Start();
            

                //        ThreadPool.QueueUserWorkItem(new WaitCallback(delegate(object o)
                //{
                //    int i = 0;
                //    while (true)
                //    {
                //        Thread.Sleep(25000);
                //        aaa.KeepSession(UserID, Token);
                //        i++;
                //        if (i == 23)
                //        {
                //            BeepUp.Beep(500, 700); 
                //            MessageBox.Show("请再次输入验证码！");
                //            //TokenPic.Image = byteArrayToImage(aaa.GetTokenPictureBytes());
                //        }
                //        if (ISCLICK_Flag = true)
                //            eventX.WaitOne();
                //    }
                //}
                //));

            //while (lr.IsLogin == true) 
            //{

            //    labNetGName.Text = lr.NetGroupName;
            //    labExpireTime.Text = lr.ExpireTime.ToShortDateString();
            //    labUserName.Text = lr.UserName;
            //    labMsg.Text = lr.Message;

               
            //}
        }

        public void keep()
        {
            int i = 0;
            while (true)
            {
                Thread.Sleep(25000);
                aaa.KeepSession(UserID, Token);
                i++;
                if (i == 23)
                {
                    BeepUp.Beep(500, 700);
                    MessageBox.Show("请再次输入验证码！");
                }
                //if (ISCLICK_Flag = true)
                //    break;
            }
        }

        private void TokenPicture_Load(object sender, EventArgs e)
        {

        }

        private void TokenBut_Click(object sender, EventArgs e)
        {
            ISCLICK_Flag = true;
            TokenPic.Image = byteArrayToImage(aaa.GetTokenPictureBytes());
            ISCLICK_Flag = false;
        }

        private void LogoutBut_Click(object sender, EventArgs e)
        {
            string UserID = UserIDTxt.Text;
            string Token = TokenTxt.Text;
            string LogOut =  aaa.Logout(UserID,Token);
            MessageBox.Show(LogOut);
        }

        
    }
}

// 声明  
public class BeepUp  //新建一个类
{
    /// <param name="iFrequency">声音频率（从37Hz到32767Hz）。在windows95中忽略</param>  
    /// <param name="iDuration">声音的持续时间，以毫秒为单位。</param>  
    [DllImport("Kernel32.dll")] //引入命名空间 using System.Runtime.InteropServices;  
    public static extern bool Beep(int frequency, int duration);
}
