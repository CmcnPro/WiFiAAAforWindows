# WiFiAAA for Windows
===

成都东软学院第三方网络客户端 For Windows

## What's AAA

AAA 是计算机网络安全术语 认证(Authentication)、授权(Authorization)、计帐(Accounting) 的缩写。

## What's WiFiAAA

WiFiAAA 是基于OpenAAA协议开发的第三方网络客户端

根据相关规定，网络上开源的版本不会加入开启承载网络的功能！

## About WiFiAAA.xml

从V1.0.0开始增加了一个XML的配置文件，里面以 明文 存放上网账户及其密码。
认为不安全的，可以不使用该配置文件或者自己写一种加密方式。
当你下载本项目后，在本md文件和程序源码中可以看到xml文件的命名和格式。

<config>
	<UserID></UserID>
	<UserPW></UserPW>
</config>

## Notes
2015/9/8 V1.1.1 
	1、屏蔽IPV6地址
	2、增加最小化托盘功能
	3、除密码框外，所有的文本框屏蔽 空格
	4、细节优化，提高用户体验度

2015/8/24 V1.1.0 
	1、优化内存
	2、修复多次提醒输入验证码的BUG
	3、优化文本，提高用户体验度。

2015/6/4 V1.0.0 
	1、增强正确IP获取能力
	2、增加自定义IP功能
	3、增加读取账户密码的功能
	4、增加查看项目墙内主页
	5、修复BUG
	6、添加更加完整的注释

2015/5/4 V0.9.9.0 
	修复BUG，提高用户体验，增加兼容性。

2015/4/9 V0.9.8.0 
	精简大量代码，添加注释。

2015/4/3 V0.9.7.2 
	1、增加快捷键功能，
	2、修复再次输入验证码，发送KeepSession请求时，Tonken错误的BUG。

2015/4/3 V0.9.7.1 
	开始内部测试使用。

## What used library

.NetFramework 4.5.1 	OpenAAA WebService 1.0.0.0

## Author

Written by CmcnPro
