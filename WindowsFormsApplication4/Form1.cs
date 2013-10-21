using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using cookie;
using System.Net;
using System.Threading;
using System.Web;
using webInfo;
namespace WindowsFormsApplication4
{
    
    public partial class Form1 : Form
    {




        Data[] items;
        int index = 0;
        server myServer;
        webInfo.infoWeb myWebInfo;
        string webUrl;
        public Form1()
        {
            
            InitializeComponent();
            myServer = new server();
            //webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(test);
            webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(changeText);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            index = 0;
            myWebInfo = new infoWeb("163");
            items = myServer.getUserInfo("163");
            //myWebInfo.loginUrl;
            foreach(Data item in items){
               // WebBrowser wb = new WebBrowser();
               // wb.Navigate("http://t.163.com/session");
               // wb.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(changeText);
                
            }

            //cookie.core.SetCookies("http://www.baidu.com", "BAIDUID=521BFCBD1CB25E10D130CC2371FAC037:FG=1; H_PS_PSSID=3364_3424_1448_3089; BDUSS=Blc2t1ZDhBbTd-dFlFakw3UC1OaHl-djFHdjBCU0V0elBQfm9nVlZsTU42WWxTQVFBQUFBJCQAAAAAAAAAAAEAAADkm5gdMTM2MTgzMTkyNTYAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA1cYlINXGJSeT; HOSUPPORT=1; Hm_lvt_90056b3f84f90da57dc0f40150f005d5=1382177793; Hm_lpvt_90056b3f84f90da57dc0f40150f005d5=1382177807; SAVEUSERID=480e1624ecd775cac16f9073a1929a87bca8ff; USERNAMETYPE=2; HISTORY_E=0926e7412afb5487f1c61018e4dfbe8357360847beb9c7; PTOKEN=a2fce7f9a244a69d1cf0de7f4fdbd0be; STOKEN=d399877eeace63e0842b4fc3bda15603");
            //MessageBox.Show(cookie.core.GetCookies("http://www.baidu.com"));
            //cookie.core.SetCookies("http://weibo.com/", "SUS=SID-3286645891-1382182663-GZ-n3b8m-a74c290a3941abe57e0eb211ff227ec7; SUE=es%3Dbe0cc4071fd2adffab2d2a436405390c%26ev%3Dv1%26es2%3D2e4f636535fe7b5d974da8bb46c94157%26rs0%3DIMafjNmI3bVbR5F8b%252BB7g9%252BBbvGY8fOUNMOawtKa7dEjmaCClmQ7m%252FHnjii0wsTubOuwWZ5PyiN7ZT6qxFlBcUE4eiycDuCS1Fy32H80lBovbRjjnm34wXMLXWu4x4bS3Ke5enbQBLp3m6pyQ7YaJqEQ4AW1WtA5E8rloI0DqIg%253D%26rv%3D0; SUP=cv%3D1%26bt%3D1382182663%26et%3D1382269063%26d%3D40c3%26i%3D7ec7%26us%3D1%26vf%3D0%26vt%3D0%26ac%3D2%26st%3D0%26lt%3D1%26uid%3D3286645891%26user%3D457786907%2540qq.com%26ag%3D4%26name%3D457786907%2540qq.com%26nick%3Dlol945%26sex%3D%26ps%3D0%26email%3D%26dob%3D%26ln%3D457786907%2540qq.com%26os%3D%26fmp%3D%26lcp%3D; ALF=1384774663; sso_info=v02m6alo5qztaybtrC5jYOUpp2WpaSPk4yyjoOYto2DlLiOk4TA; U_TRS1=00000068.ba0a2189.52626f0c.8ad0620b; U_TRS2=00000068.ba1d2189.52626f0c.6964908d; tgc=TGT-MzI4NjY0NTg5MQ==-1382182663-gz-48288BDCB64B4C1A464E2EC9AF1C7DAE; ALC=ac%3D2%26bt%3D1382182663%26cv%3D4.0%26et%3D1384774663%26uid%3D3286645891%26vf%3D0%26vt%3D0%26es%3Dc15ed13f2f811fdd609f245838f97afc; LT=1382182663");
           
            //MessageBox.Show(cookie.core.GetCookies("http://login.sina.com.cn"));
            //cookie.core.SetCookies("http://t.163.com", "_ntes_nnid=0a4d1251955c9fd1a8062940ad9a6400,1382090517346; _ntes_nuid=0a4d1251955c9fd1a8062940ad9a6400; P_INFO=happyrxk@gmail.com|1382106357|0|other|00&99|chq&1382105009&other#chq&null#10#0#0|&0|t|happyrxk@gmail.com; ALLYESID4=00131018173432872526709; usertrack=c+5+hFJhPQRuWnVd899TAg==; NTES_SESS=pTGKe6eKPz6T.oX7rVsEtnYl2qZfGBc3ENYKu29nhtiz22wsVv_GY.WiS3w8_3b6rhn7r9n3RBupLGjpQoIoN7L9oxPRGvSj1ZET622LWKXOtfO3YLPFslnOey8e.N3ZgPN.DRcomOPy0acJTIAIwkaBF4WtDW36m; S_INFO=1382106357|0|##|happyrxk@gmail.com; ANTICSRF=0cbfc67be6c24d7d3cd8f5e1d9a62c67; T_INFO=F9C5D3AE1F7D31FCE81BC2069FCFE5495C51C1E0BA58AA032B416ECC07AABEC083A3E82DE8B4D58F09A7B1FA13A74BC4; ui_tip_cookie=56328974@qq.com%261%266%260%7Chappyrxk@gmail.com%261%264%260%7C; SID=e7685bba-911f-4cba-97e0-34723a8aad72; JSESSIONID=adbWcuZeDpNG5eHht9lhu");
            //MessageBox.Show(cookie.core.GetCookies("http://t.163.com"));

            //webBrowser1.Navigate("http://login.sina.com.cn/member/my.php?entry=sso");
            //webBrowser1.Navigate("http://weibo.com/");
            webBrowser1.Navigate(myWebInfo.loginUrl);

            //webBrowser1.Stop();
           
            //webBrowser1.Navigate("http://www.baidu.com");
            
            
            //while(webBrowser1.ReadyState==WebBrowserReadyState.Complete){
               
              //  break;
           
            
        }



        public void test(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.ReadyState != WebBrowserReadyState.Complete)
                return;
            MessageBox.Show(webBrowser1.Url.ToString() + "\n" + cookie.core.GetCookies(webBrowser1.Url.ToString()));
        
        }


        public void changeText(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.ReadyState != WebBrowserReadyState.Complete)
                return;
            MessageBox.Show(webBrowser1.Url.ToString()+"\n"+cookie.core.GetCookies(webBrowser1.Url.ToString()));
            //MessageBox.Show(webBrowser1.Url.ToString());
            if (webUrl == webBrowser1.Url.ToString())
            {
                return;
            }
            
           /* HtmlElement headerDiv = webBrowser1.Document.GetElementById("headNav");
            HtmlElement littleDiv = headerDiv.GetElementsByTagName("div")[0];
            HtmlElement loginBlock = littleDiv.GetElementsByTagName("li")[19];
            loginBlock.GetElementsByTagName("a")[0].InvokeMember("click");
            webBrowser1.Document.GetElementById("poplayer_username").SetAttribute("value","56328974@qq.com");
           */

            if (webBrowser1.Url.ToString() == myWebInfo.loginUrl)
            {

                if (index < items.Length)
                {
                   
                }
                else {
                    return;
                }
                //webBrowser1.Document.Cookie.Remove();
             
                webBrowser1.Document.GetElementById(myWebInfo.usernameId).SetAttribute("value",items[index].username);
                webBrowser1.Document.GetElementById(myWebInfo.passwordId).SetAttribute("value", items[index].password);
                //webBrowser1.Document.GetElementById(myWebInfo.submitButtId).InvokeMember("click");
                HtmlElement form = webBrowser1.Document.Forms[0];
                HtmlElementCollection inputs = form.GetElementsByTagName("input");
                HtmlElement subButton = inputs[inputs.Count - 1];
                subButton.InvokeMember("click");

                // webBrowser1.Document.Cookie = "NTES_SESS=N17AZFORH0HCoJzKbiFtqYWVzvcIZSskLsH1mvAtFQ7h33iAYgUFoCyR1yTx_nmBnFL5DhZJoeybN3JV1x30Aqi_E3gqkkvCWzvxFw_bEaGZQOPkkGaMtZ2c7MRPBpkiwdyw.bEEH1o32HzRXN.yGDAVF;S_INFO=1381830680|0|##|56328974@qq.com;JSESSIONID=abcIyby_z5CGn5HCUH7gu";
                index++;
                //Thread.Sleep(1000);
                //webBrowser1.Navigate("http://t.163.com/");
            }
            else if (webBrowser1.Url.ToString() == myWebInfo.logOutUrlDomain)
            {
                if (webBrowser1.ReadyState != WebBrowserReadyState.Complete)
                    return;
                //webBrowser1.Stop();
                if(index<items.Length){
                    webBrowser1.Navigate(myWebInfo.loginUrl);
                }
                
                

            }
            else
            {
                try {
                  //  myServer.setUserCookie(items[index - 1].id, cookie.core.GetCookies(webBrowser1.Url.ToString()));
                }
                catch(Exception erros){
                
                }
                Thread.Sleep(1000);
                webBrowser1.Navigate(myWebInfo.logOutUrl);
                

                
               // webBrowser1.S;

                   // HtmlElement parentDiv= webBrowser1.Document.GetElementById("moduleNavi");
                   // HtmlElement li = parentDiv.GetElementsByTagName("li")[1];
                    //li.GetElementsByTagName("a")[0].InvokeMember("click");
                   // webBrowser1.GoBack();
                   
                   // webRequest = (HttpWebRequest)WebRequest.Create(new Uri("http://reg.163.com/Logout.jsp"));
                   // webRequest.GetResponse();
                   // webBrowser1.Navigate("http://t.163.com/session");
                  

            }
            //string[] s = webBrowser1.Url.ToString();
            if(webBrowser1.Url.ToString().Split('?')[0]==myWebInfo.homeUrl){
                string c = cookie.core.GetCookies(webBrowser1.Url.ToString());
                MessageBox.Show(cookie.core.GetCookies(webBrowser1.Url.ToString()));
               // MessageBox.Show(cookie.core.GetCookies(" http://login.sina.com.cn/"));
           
                
                // c = cookie.core.GetCookies(webBrowser1.Url.ToString());

                   

                    myServer.setUserCookie(items[index - 1].id,c);
                  
 
            }
            webUrl = webBrowser1.Url.ToString();
           
            
            //MessageBox.Show(webBrowser1.Url.ToString());
        }


        private void button2_Click(object sender, EventArgs e)
        {
            index = 0;
            myWebInfo = new infoWeb("sina");
            items = myServer.getUserInfo("sina");
            webBrowser1.Navigate(myWebInfo.loginUrl);


            //MessageBox.Show(webBrowser1.Document.Cookie);
            //MessageBox.Show(cookie.core.GetCookies(webBrowser1.Url.ToString()));
            //MessageBox.Show(cookie.core.GetCookies("http://t.163.com/session"));
           // webBrowser1.Navigate("http://reg.163.com/Logout.jsp");
            
            //webBrowser1.Document.Cookie.Remove(0,webBrowser1.Document.Cookie.Length);
            //ClearCookie();
            
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            index = 0;
            myWebInfo = new infoWeb("baidu");
            items = myServer.getUserInfo("baidu");
            webBrowser1.Navigate(myWebInfo.loginUrl);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cookie.core.SetCookies("https://passport.baidu.com/center", "BAIDUID=521BFCBD1CB25E10D130CC2371FAC037:FG=1; H_PS_PSSID=3364_3424_1448_3089; BDUSS=HVWQnptak51N1kzRHhHbXp2WGtsQjgtUXhFMXVTaVZWdjEtMTFaLXZzeEhISXBTQVFBQUFBJCQAAAAAAAAAAAEAAADkm5gdMTM2MTgzMTkyNTYAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAEePYlJHj2JSZ; HOSUPPORT=1; SAVEUSERID=480e1624ecd775cac16f9073a1929a87bca8ff; USERNAMETYPE=2; HISTORY_E=0926e7412afb5487f1c61018e4dfbe8357360847beb9c7; Hm_lvt_90056b3f84f90da57dc0f40150f005d5=1382189090,1382190778,1382190799,1382190819; Hm_lpvt_90056b3f84f90da57dc0f40150f005d5=1382190921; PTOKEN=f61accf1173561b5bfa4caec4bf5c13d; STOKEN=62fc93aa0b90168259338e5aa2a51c00");
            MessageBox.Show(cookie.core.GetCookies("http://passport.baidu.com/center"));
            webBrowser1.Navigate("http://www.baidu.com");

           // cookie.core.SetCookies("http://weibo.com", "SUS=SID-3286645891-1382184704-GZ-lgumh-0df448ba29aa77c0744b9ff2565f7ec7; SUE=es%3Dcf2e8892a2543b1feeb54372b9e34361%26ev%3Dv1%26es2%3D6c769292a5b46e8e5c4d211c7387d89e%26rs0%3Dl3lz3o0vY07Zr8y7XNrAsGEfIMoQVvSpnuVvu56lhwL7CUzN1xbp96q%252F8oZ6kPLbpy2INvZU7dtADQwCL4YiuJEjrMboqSpzBmkmiTPsSQMt0dOWqfpJVA24rNCCKvELVTl2MR9t0jXlYAHQ8ISVw2V97%252B5gIsaNrMV7wzRaGZE%253D%26rv%3D0; SUP=cv%3D1%26bt%3D1382184704%26et%3D1382271104%26d%3D40c3%26i%3D7ec7%26us%3D1%26vf%3D0%26vt%3D0%26ac%3D2%26st%3D0%26lt%3D1%26uid%3D3286645891%26user%3D457786907%2540qq.com%26ag%3D4%26name%3D457786907%2540qq.com%26nick%3Dlol945%26sex%3D%26ps%3D0%26email%3D%26dob%3D%26ln%3D457786907%2540qq.com%26os%3D%26fmp%3D%26lcp%3D; ALF=1384776704; sso_info=v02m6alo5qztaybtrC5jYOUpp2WpaSPk4yyjoOYto2DlLiOk4TA; tgc=TGT-MzI4NjY0NTg5MQ==-1382184704-gz-C70AB61CE7A8ABFD51F1F30F11ABE363; ALC=ac%3D2%26bt%3D1382184704%26cv%3D4.0%26et%3D1384776704%26uid%3D3286645891%26vf%3D0%26vt%3D0%26es%3D88be04f0a2f65832c7dcb2ce24504f75; LT=1382184704");
            //MessageBox.Show(cookie.core.GetCookies("http://weibo.com"));
            //webBrowser1.Navigate("http://weibo.com");

            cookie.core.SetCookies("http://t.163.com", "_ntes_nnid=0a4d1251955c9fd1a8062940ad9a6400,1382171023546; _ntes_nuid=0a4d1251955c9fd1a8062940ad9a6400; P_INFO=56328974@qq.com|1382188743|0|other|00&99|chq&1382184745&other#chq&null#10#0#0|&0||56328974@qq.com; ALLYESID4=00131018173432872526709; usertrack=c+5+hFJhPQRuWnVd899TAg==; NTES_SESS=goOWtjEplE9UYxOGyNX9D8DxC0s3ebCjgTPktDtPGUsWdd3iJH08EqeLOeGnPSMIS871fWADEceygdDmOndji_EP4laCew.RhVueLXSWW3HvVrTQQUxtYAZRatLTIKQ32VkdK.w9KMIasLxj_ctoN4wm8; S_INFO=1382188743|0|##|56328974@qq.com; ANTICSRF=31e2c118c29c9351f84197d319e68cd2; T_INFO=E922D094271D15487E5066DB55F05D61F9C5D3AE1F7D31FCE81BC2069FCFE54983A3E82DE8B4D58F09A7B1FA13A74BC4; ui_tip_cookie=56328974@qq.com%261%266%260%7Chappyrxk@gmail.com%261%266%260%7C; SID=7b74ee2f-5a2d-480e-b921-45a72fe01f8a; JSESSIONID=acbvWf5GmaiXIc8bN3qhu");
            //MessageBox.Show(cookie.core.GetCookies("http://t.163.com"));
            //webBrowser1.Navigate("http://t.163.com");

        }
    }
}
