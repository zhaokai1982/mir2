﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Utils
{
    public class BrowserHelper
    {
        private static void OpenChrometBrowser(string url)
        {
            try
            {
                var openKey = @"SOFTWARE\Wow6432Node\Google\Chrome";
                if (IntPtr.Size == 4)
                {
                    openKey = @"SOFTWARE\Google\Chrome";
                }
                RegistryKey appPath = Registry.LocalMachine.OpenSubKey(openKey);

                if (appPath != null)
                {
                    var result = Process.Start("chrome.exe", url);
                    if (result == null)
                    {
                        OpenIetBrowser(url);
                    }
                }
                else
                {
                    OpenDefaultBrowser(url);
                }
            }
            catch
            {
                OpenDefaultBrowser(url);
            }
        }

        private static void OpenIetBrowser(string url)
        {
            try
            {
                Process.Start("iexplore.exe", url);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                try
                {
                    if (File.Exists(@"C:\Program Files\Internet Explorer\iexplore.exe"))
                    {
                        ProcessStartInfo processStartInfo = new ProcessStartInfo
                        {
                            FileName = @"C:\Program Files\Internet Explorer\iexplore.exe",
                            Arguments = url,
                            UseShellExecute = false,
                            CreateNoWindow = true
                        };
                        Process.Start(processStartInfo);
                    }
                    else
                    {
                        if (File.Exists(@"C:\Program Files (x86)\Internet Explorer\iexplore.exe"))
                        {
                            ProcessStartInfo processStartInfo = new ProcessStartInfo
                            {
                                FileName = @"C:\Program Files (x86)\Internet Explorer\iexplore.exe",
                                Arguments = url,
                                UseShellExecute = false,
                                CreateNoWindow = true
                            };
                            Process.Start(processStartInfo);
                        }
                        else     //检测IE不存在提供提示，并提供下载地址，现在问题万一检测时，客户系统不在C盘咋搞，C++有检测系统命令，一会找找。
                        {
                            if (MessageBox.Show("系统中未安装Internet Explorer.你想下载并安装它吗?", null, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                OpenDefaultBrowser("http://windows.microsoft.com/zh-cn/internet-explorer/download-ie"); //小凯郁闷啦，微软总变更地址，这个为难我了
                            }                                                                                          //更郁闷的，疫情啥时候过去解封啊！！！           
                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        public static void OpenDefaultBrowser(string url)
        {
            try
            {
                RegistryKey key = Registry.ClassesRoot.OpenSubKey(@"http\shell\open\command\");
                if (key != null)
                {
                    string s = key.GetValue("").ToString();
                    var lastIndex = s.IndexOf(".exe", StringComparison.Ordinal);
                    var path = s.Substring(1, lastIndex + 3);
                    var result = Process.Start(path, url);
                    if (result == null)
                    {
                        var result1 = Process.Start("explorer.exe", url);
                        if (result1 == null)
                        {
                            Process.Start(url);
                        }
                    }
                }
                else
                {
                    var result1 = Process.Start("explorer.exe", url);
                    if (result1 == null)
                    {
                        Process.Start(url);
                    }
                }
            }
            catch
            {
                OpenIetBrowser(url);
            }
        }
    }
}
