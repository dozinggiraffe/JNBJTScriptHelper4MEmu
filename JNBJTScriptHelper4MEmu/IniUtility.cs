using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace JNBJTScriptHelper4MEmu
{
    public class IniUtility
    {


        ///声明读写INI文件的API函数 
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public static long WriteIni(String Section, String Key, String Value, String Path)
        {
            return WritePrivateProfileString(Section, Key, Value, Path);
        }


        public static String ReadIni(string Section, String Key, String val, String Path)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, "", temp, 255, Path);
            return temp.ToString();

        }

    }
}
