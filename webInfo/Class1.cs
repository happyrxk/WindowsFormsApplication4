using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace webInfo
{
    public class infoWeb
    {
        public string loginUrl;
        public string logOutUrl;
        public string logOutUrlDomain;
        public string usernameId;
        public string passwordId;
        public string submitButtId;
        public string homeUrl;
        public infoWeb(string website) { 
            switch(website){
                case "163":
                    info_163 info163 = new info_163();
                    loginUrl = info163.loginUrl;
                    logOutUrl = info163.logOutUrl;
                    logOutUrlDomain = info163.logOutUrlDomain;
                    usernameId = info163.usernameId;
                    passwordId = info163.passwordId;
                    submitButtId = info163.submitButtId;
                    homeUrl = info163.homeUrl;
                    break;
                case "sina":
                    info_sina infosina = new info_sina();
                    loginUrl = infosina.loginUrl;
                    logOutUrl = infosina.logOutUrl;
                    logOutUrlDomain = infosina.logOutUrlDomain;
                    usernameId = infosina.usernameId;
                    passwordId = infosina.passwordId;
                    submitButtId = infosina.submitButtId;
                    homeUrl = infosina.homeUrl;
                    break;
                case "baidu":
                    info_baidu infobaidu = new info_baidu();
                    loginUrl = infobaidu.loginUrl;
                    logOutUrl = infobaidu.logOutUrl;
                    logOutUrlDomain = infobaidu.logOutUrlDomain;
                    usernameId = infobaidu.usernameId;
                    passwordId = infobaidu.passwordId;
                    submitButtId = infobaidu.submitButtId;
                    homeUrl = infobaidu.homeUrl;
                    break;
            }
        }
    }
    public class info_163
    {
        public  string loginUrl = "http://reg.163.com/logins.jsp";
        public  string logOutUrl = "http://reg.163.com/Logout.jsp";
        public  string logOutUrlDomain = "http://reg.163.com/";
        public string homeUrl = "http://reg.163.com/Main.jsp";
        public  string usernameId = "username";
        public  string passwordId = "password";
        public  string submitButtId = "loginBtn";
    }

    public class info_sina
    {
        public string loginUrl = "http://login.sina.com.cn/";
        public string logOutUrl = "http://login.sina.com.cn/sso/logout.php";
        public string logOutUrlDomain = "http://login.sina.com.cn/A";
        public string homeUrl = "http://login.sina.com.cn/member/my.php";
        public string usernameId = "username";
        public string passwordId = "password";
        public string submitButtId = "";
    }

    public class info_baidu {
        public string loginUrl = "https://passport.baidu.com/v2/?login";
        public string logOutUrl = "http://passport.baidu.com/?logout";
        public string logOutUrlDomain = "http://www.baidu.com/";
        public string homeUrl = "http://passport.baidu.com/center";
        public string usernameId = "TANGRAM__3__userName";
        public string passwordId = "TANGRAM__3__password";
        public string submitButtId = "";
    }

}
