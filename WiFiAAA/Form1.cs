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
        string UserIP;
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

        //获取IP
        public void GetIP()
        {
            //获取真实的内网IP,可能在某些多网卡的并不能获取正确的内网IP
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

        //读取WiFiAAA.xml内的用户信息
        /*目前在窗体初始化时读取，检测不到该配置文件的存在会停止工作，配置文件的格式如下
         <config>
	            <UserID></UserID>
	            <UserPW></UserPW>
           </config>
         */
        public void GetXML()
        {
            XmlDocument XML = new XmlDocument();
            XML.Load("WiFiAAA.xml");
            XmlNode root = XML.SelectSingleNode("config");
            XmlNode XMLID = root.SelectSingleNode("UserID");
            string strID = XMLID.InnerText;
            UserIDTxt.Text = strID;
            XmlNode XMLPW = root.SelectSingleNode("UserPW");
            string strPW = XMLPW.InnerText;
            UserPwTxt.Text = strPW;
        }
        
        //初始化并获取验证码
        public TokenPicture()
        {
            InitializeComponent();
            if (System.IO.File.Exists(@"WiFiAAA.xml"))//判断是否存在WiFiAAA.xml这个配置文件的存在，在就读取里面的信息
            {
                GetXML();
            }
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
            string OpenAPIVersion ="1.0.0.0";
             Token = TokenTxt.Text;
             //MessageBox.Show(UserIP);

            Open.LoginResultInfo lr =   aaa.Login(UserID, UserPw, UserIP, OpenAPIVersion, Token);

            if (lr.IsWrong ==null ) MessageBox.Show("无法连接到服务器");

            if (lr.IsLogin != true)
            {
                if (lr.IsExpire == true) MessageBox.Show("账户已过期！");
                if (lr.IsIDPWWrong == true) MessageBox.Show("账户密码错误！");
                if (lr.IsIPInvalid == true) MessageBox.Show("IP无效！");
                if (lr.IsDisable == true) MessageBox.Show("账户无效，请联系信息中心！");
                if (lr.IsWrong == true) MessageBox.Show("发生其他错误（注：你的登陆请求已经成功传递要服务器）");
                labMsg.Text = lr.Message;
            }
            else 
            {
                labNetGName.Text = "带宽组：" + lr.NetGroupName;
                labExpireTime.Text = "账户有效期：" + lr.ExpireTime.ToShortDateString();
                labUserName.Text = "户主：" + lr.UserName;
                labMsg.Text = lr.Message+" 正在保持通信";
                MessageBox.Show(lr.Message);
                //创建线程，用来保持Keep通信
          
                Thread t = new Thread(new ThreadStart(keep));
                t.IsBackground = true;
                t.Start();
            }
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
                    //播放webAAA的提示音
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

        //自定义IP功能
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UserIP = MyIPTextBox.Text;
        }

        //项目墙内主页
        private void WebSiteHome_Click(object sender, EventArgs e)
        {
           System.Diagnostics.Process.Start("http://cmcnpro.cn/?p=7");
        }
      
    }
}

// 滴滴声 目前的版本中已停用，改为播放webAAA的提示音
public class BeepUp  //新建一个类
{
    /// <param name="iFrequency">声音频率（从37Hz到32767Hz）。在windows95中忽略</param>  
    /// <param name="iDuration">声音的持续时间，以毫秒为单位。</param>  
    [DllImport("Kernel32.dll")] //引入命名空间 using System.Runtime.InteropServices;  
    public static extern bool Beep(int frequency, int duration);
}


