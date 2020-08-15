using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JNBJTScriptHelper4MEmu
{
    static class CMDHelper
    {
        private static string CmdPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.System) + "\\cmd.exe";

        public static void RunCmdCommand(string command, out string output)
        {
            using (Process process = new Process())
            {
                command = command.Trim().TrimEnd('&') + "&exit";

                process.StartInfo.FileName = CmdPath;
                process.StartInfo.CreateNoWindow = true;// 隐藏窗口运行
                process.StartInfo.RedirectStandardError = true;// 重定向错误流
                process.StartInfo.RedirectStandardInput = true;// 重定向输入流
                process.StartInfo.RedirectStandardOutput = true;// 重定向输出流
                process.StartInfo.UseShellExecute = false;

                process.Start();

                process.StandardInput.WriteLine(command);// 写入Cmd命令
                process.StandardInput.AutoFlush = true;

                output = process.StandardOutput.ReadToEnd();//读取结果
                process.WaitForExit();
                process.Close();
            }
        }
    }
}
