using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace cookie
{
    public class core
    {
        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool InternetSetCookie(string IpszUrlName, string IbszCookieName, string IpszCookieData);
        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool InternetGetCookieEx(string pchURL, string pchCookieName, StringBuilder pchCookieData, ref System.UInt32 pcchCookieData, int dwFlags, IntPtr lpReserved);
        public static string GetCookies(string url)
        {
            uint datasize = 256;
            StringBuilder cookieData = new StringBuilder((int)datasize);
            if (!InternetGetCookieEx(url, null, cookieData, ref datasize, 0x2000, IntPtr.Zero))
            {
                if (datasize < 0)
                    return null;

                cookieData = new StringBuilder((int)datasize);
                if (!InternetGetCookieEx(url, null, cookieData, ref datasize, 0x00002000, IntPtr.Zero))
                    return null;
            }
            return cookieData.ToString();
        }
        public static void SetCookies(string url,string cookies){
            cookies = TrimALL(cookies);
            string[] cookie = cookies.Split(';');
            foreach(string i in cookie){
                string[] s = i.Split('=');
                if (s.Length == 1)
                {
                    InternetSetCookie(url, s[0], "");
                }else{
                    InternetSetCookie(url,s[0],s[1]);
                }
            }
        }
        private static string TrimALL(string src){ 
            string ret="";
            foreach(char c in src.ToCharArray(0,src.Length)){
                if (c != Convert.ToChar(" "))
                {
                    ret += c;
                }
            }
            return ret;
        }
    
    }
}
