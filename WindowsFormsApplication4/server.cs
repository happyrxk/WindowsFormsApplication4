using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
namespace WindowsFormsApplication4
{
    class server
    {
        public static string url = "http://127.0.0.1/cookies/api.php";
        public Data[] getUserInfo(string type) {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(new Uri(url));
            string postData;
            postData = "type=get&web="+type;
            byte[] byteArray = UTF8Encoding.Default.GetBytes(postData);
            webRequest.Method = "Post";
            webRequest.ContentType = "application/x-www-form-urlencoded";
            webRequest.ContentLength = byteArray.Length;
            webRequest.KeepAlive = true;
            Stream newStream = webRequest.GetRequestStream();
            // Send the data.
            newStream.Write(byteArray, 0, byteArray.Length);    
            newStream.Close();


            HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();
            StreamReader sr = new StreamReader(webResponse.GetResponseStream());
            string response = sr.ReadToEnd();

            //MessageBox.Show(response);
            Data[] items = JosnDeserialize<Data[]>(response, null);
            return items;
        }
        public void setUserCookie(int id,string cookie){
           
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(new Uri(url));
            string postData;
            string nowCookie = "";
            byte[] ba = System.Text.Encoding.Default.GetBytes(cookie);
            nowCookie = Convert.ToBase64String(ba);

            //MessageBox.Show(nowCookie);
            postData = "type=set&id=" +id+ "&cookie=" + nowCookie;
            byte[] byteArray = ASCIIEncoding.Default.GetBytes(postData);
            webRequest.Method = "Post";
            webRequest.ContentType = "application/x-www-form-urlencoded";
            webRequest.ContentLength = byteArray.Length;
            webRequest.KeepAlive = true;
            Stream newStream = webRequest.GetRequestStream();
            // Send the data.
            newStream.Write(byteArray, 0, byteArray.Length);    
            newStream.Close();
            webRequest.GetResponse();
        }
        public static T JosnDeserialize<T>(string input, T def)
        {
            if (string.IsNullOrEmpty(input))
                return def;
            try
            {
                JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
                return jsSerializer.Deserialize<T>(input);
            }
            catch (InvalidOperationException)
            {
                return def;
            }
        }  


    }
    class Data
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string cookie { get; set; }

    }
}
