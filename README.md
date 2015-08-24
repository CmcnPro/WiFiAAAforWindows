# WiFiAAA for Windows
===

成都东软学院第三方网络客户端 For Windows

## What's AAA

AAA 是计算机网络安全术语 认证(Authentication)、授权(Authorization)、计帐(Accounting) 的缩写。

## What's WiFiAAA

WiFiAAA 是基于OpenAAA协议开发的第三方网络客户端

根据相关规定，网络上开源的版本不会加入开启承载网络的功能！

## About WiFiAAA.xml
<<<<<<< HEAD
从V1.0.0开始增加了一个XML的配置文件，里面以 明文 存放上网账户及其密码。
认为不安全的，可以不使用该配置文件或者自己写一种加密方式。
当你下载本项目后，在本md文件和程序源码中可以看到xml文件的命名和格式。
=======
从V1.0.0开始增加了一个XML的配置文件，原项目是必读的，没有是无法运行的。
下面是该XML配置文件的格式，目前才用的还是明文保存
>>>>>>> 2cfb1af6820a36fae58f4fe3538df49362aa3a9d
<config>
	<UserID></UserID>
	<UserPW></UserPW>
</config>

## Notes
2015/8/24 V1.1.0 优化内存（好像本来就占得的不大），修复多次提醒输入验证码的BUG，优化文本，提高用户体验度。

2015/6/4 V1.0.0 增强正确IP获取能力，增加自定义IP功能，增加读取账户密码的功能，增加查看项目墙内主页，修复BUG，添加更加完整的注释。

2015/5/4 V0.9.9.0 修复BUG，提高用户体验，增加兼容性。

2015/4/9 V0.9.8.0 精简大量代码，添加注释。

2015/4/3 V0.9.7.2 RC发布，增加快捷键功能，修复再次输入验证码，发送KeepSession请求时，Tonken错误的BUG。

2015/4/3 V0.9.7.1 RC发布，修复一些问题，开始内部测试使用。

## What used library

.NetFramework 4.5.1 	OpenAAA WebService 1.0.0.0

## Author

Written by CmcnPro
