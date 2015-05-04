using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
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
        Boolean ISCLICK_Flag = false;//判断刷新验证码的按钮是否被按下
<<<<<<< HEAD
        string UserIP;
=======
>>>>>>> 921eb90cc04ac03c84039dc5240a4faf37c00804
        string UserID, Token;//全局变量
        public ManualResetEvent eventX;
        Open.OpenAAASoapClient aaa = new Open.OpenAAASoapClient();//实例化类
        
        //将字节数组的验证码转换成图片
        private Image byteArrayToImage(byte[] Bytes)
        {
            using (MemoryStream ms = new MemoryStream(Bytes))
            {
                Image outputImg = Image.FromStream(ms);
                return outputImg;
            }
        }
<<<<<<< HEAD

        public void GetIP()
        {
=======
        
        //初始化并获取验证码
        public TokenPicture()
        {
            InitializeComponent();
            TokenPic.Image = byteArrayToImage(aaa.GetTokenPictureBytes());
        }
        
        //手贱，请无视
        private void label1_Click(object sender, EventArgs e){}

        private void UserIDTxt_TextChanged(object sender, EventArgs e){}
 
        //登录按钮
        public void LoginBut_Click(object sender, EventArgs e)
        {
            UserID = UserIDTxt.Text;
            string UserPw = UserPwTxt.Text;
            
>>>>>>> 921eb90cc04ac03c84039dc5240a4faf37c00804
            //获取真实的内网IP
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
            UserIP = ipAddr.ToString();
        }

<<<<<<< HEAD
        
        //初始化并获取验证码
        public TokenPicture()
        {
            InitializeComponent();
            TokenPic.Image = byteArrayToImage(aaa.GetTokenPictureBytes());
            GetIP();
        }
        
        //手贱，请无视
        private void label1_Click(object sender, EventArgs e){}

        private void UserIDTxt_TextChanged(object sender, EventArgs e){}
 
        //登录按钮
        public void LoginBut_Click(object sender, EventArgs e)
        {
            UserID = UserIDTxt.Text;
            string UserPw = UserPwTxt.Text;
            
            ////获取真实的内网IP
            //IPAddress ipAddr = null;
            //IPAddress[] arrIP = Dns.GetHostAddresses(Dns.GetHostName());
            //foreach (IPAddress ip in arrIP)
            //{
            //    if (System.Net.Sockets.AddressFamily.InterNetwork.Equals(ip.AddressFamily))
            //    {
            //        ipAddr = ip;
            //    }
            //    else if (System.Net.Sockets.AddressFamily.InterNetworkV6.Equals(ip.AddressFamily))
            //    {
            //        ipAddr = ip;
            //    }
            //}
            //string UserIP = ipAddr.ToString();

            string OpenAPIVersion ="1.0.0.0";
             Token = TokenTxt.Text;

=======
            string OpenAPIVersion ="1.0.0.0";
             Token = TokenTxt.Text;

>>>>>>> 921eb90cc04ac03c84039dc5240a4faf37c00804
            Open.LoginResultInfo lr =   aaa.Login(UserID, UserPw, UserIP, OpenAPIVersion, Token);

            if (lr.IsWrong ==null ) MessageBox.Show("无法连接到服务器");

            if (lr.IsLogin != true)
            {
                if (lr.IsExpire == true) MessageBox.Show("账户已过期！");
                if (lr.IsIDPWWrong == true) MessageBox.Show("账户密码错误！");
                if (lr.IsIPInvalid == true) MessageBox.Show("IP无效！");
                if (lr.IsDisable == true) MessageBox.Show("账户无效，请联系信息中心！");
                if (lr.IsWrong == true) MessageBox.Show("发生其他错误（注：你的登陆请求已经成功传递要服务器）");
            }

            labNetGName.Text = lr.NetGroupName;
            labExpireTime.Text = lr.ExpireTime.ToShortDateString();
            labUserName.Text = lr.UserName;
            labMsg.Text = lr.Message+" 正在保持通信";

            MessageBox.Show(lr.Message);

            //创建线程，用来保持Keep通信
            Thread t = new Thread(new ThreadStart(keep));
            t.IsBackground = true;
            t.Start();
<<<<<<< HEAD
           
=======
                
>>>>>>> 921eb90cc04ac03c84039dc5240a4faf37c00804
        }

        //keep通信
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
                    WMPLib.WindowsMediaPlayerClass player = new WMPLib.WindowsMediaPlayerClass();
                    player.URL = @"http://aaa.nsu.edu.cn/nsuaaaws/webaaa/notice.wav";
                    player.uiMode = "None";
                    player.settings.volume = 100;
                    player.settings.playCount = 1;
                    player.play();

                    //BeepUp.Beep(500, 700);
                    MessageBox.Show("请再次输入验证码！");
                }
            }
        }
        //再次手贱
        private void TokenPicture_Load(object sender, EventArgs e){}

        //刷新验证码
        private void TokenBut_Click(object sender, EventArgs e)
        {
            ISCLICK_Flag = true;
            TokenPic.Image = byteArrayToImage(aaa.GetTokenPictureBytes());
            ISCLICK_Flag = false;
        }

        //退出按钮
        private void LogoutBut_Click(object sender, EventArgs e)
        {
            string UserID = UserIDTxt.Text;
            string Token = TokenTxt.Text;
            string LogOut =  aaa.Logout(UserID,Token);
            MessageBox.Show(LogOut);
            labMsg.Text = "您已退出";
        }
      
    }
}

// 滴滴声
public class BeepUp  //新建一个类
{
    /// <param name="iFrequency">声音频率（从37Hz到32767Hz）。在windows95中忽略</param>  
    /// <param name="iDuration">声音的持续时间，以毫秒为单位。</param>  
    [DllImport("Kernel32.dll")] //引入命名空间 using System.Runtime.InteropServices;  
    public static extern bool Beep(int frequency, int duration);
}


