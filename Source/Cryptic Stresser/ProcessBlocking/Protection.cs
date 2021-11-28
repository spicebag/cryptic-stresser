using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ProcessBlocking
{
	// Token: 0x02000002 RID: 2
	internal class Protection
	{
		// Token: 0x06000002 RID: 2
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
		private static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.LPStr)] string library);

		// Token: 0x06000003 RID: 3
		[DllImport("user32.dll")]
		public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);

		// Token: 0x06000004 RID: 4 RVA: 0x0000265C File Offset: 0x0000085C
		public static string CalculateMD5(string filename)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(filename))
				{
					byte[] value = md.ComputeHash(fileStream);
					result = BitConverter.ToString(value).Replace("-", "").ToLowerInvariant();
				}
			}
			return result;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002052 File Offset: 0x00000252
		public static void ChallengeCheck()
		{
			MessageBox.Show("Process Check Failed. Make sure you close ALL Debuggers", "Project Resurrect");
			Environment.Exit(0);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000026D4 File Offset: 0x000008D4
		public static void CheckCurrentProcess()
		{
			bool flag = Process.GetCurrentProcess().ProcessName == "RegAsm" || Process.GetCurrentProcess().ProcessName == "cvtres" || Process.GetCurrentProcess().ProcessName == "RegSvcs";
			if (!flag)
			{
				MessageBox.Show("Process Check Failed. Make sure you close ALL Debuggers", "Project Resurrect");
				Environment.Exit(0);
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002748 File Offset: 0x00000948
		public static void LoopBlockProcess()
		{
			new Thread(delegate()
			{
				Protection.BlockProc();
			})
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000278C File Offset: 0x0000098C
		private static void BlockProc()
		{
			string[] array = new string[]
			{
				"VOIDVOIDVOIDVOID"
			};
			bool flag = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly().Location)).Length > 2;
			if (flag)
			{
				Environment.Exit(0);
			}
			foreach (string processName in array)
			{
				Process[] processesByName = Process.GetProcessesByName(processName);
				bool flag2 = processesByName.Length != 0;
				if (flag2)
				{
					MessageBox.Show("Process Check Failed. Make sure you close ALL Debuggers", "Project Resurrect");
					Environment.Exit(0);
				}
			}
			foreach (Process process in Process.GetProcesses())
			{
				foreach (string value in array)
				{
					bool flag3 = false;
					bool flag4 = process.MainWindowTitle.ToLower().Contains(value) || process.ProcessName.ToLower().Contains(value) || process.MainWindowTitle.ToLower().Contains(value) || process.ProcessName.ToLower().Contains(value);
					if (flag4)
					{
						flag3 = true;
					}
					bool flag5 = flag3;
					if (flag5)
					{
						try
						{
							MessageBox.Show("Process Check Failed. Make sure you close ALL Debuggers", "Project Resurrect");
							Environment.Exit(0);
						}
						catch
						{
							MessageBox.Show("Process Check Failed. Make sure you close ALL Debuggers", "Project Resurrect");
							Environment.Exit(0);
						}
					}
				}
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002B1C File Offset: 0x00000D1C
		public static void ProtectionCheckLoopThread()
		{
			new Thread(delegate()
			{
				Protection.ProtectionCheckLoop();
			})
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000206C File Offset: 0x0000026C
		public static void ProtectionCheckLoop()
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000206F File Offset: 0x0000026F
		public static void ProtectionCheck()
		{
			Protection.BlockProc();
			Protection.DisableProxySettings();
			Protection.CheckForAnyProxyConnections();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002B60 File Offset: 0x00000D60
		public static bool CheckForFiddler()
		{
			return Protection.LoadLibraryA("FiddlerCore4.dll") != IntPtr.Zero || Protection.LoadLibraryA("Titanium.Web.Proxy.dll") != IntPtr.Zero;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002BAC File Offset: 0x00000DAC
		public static void DisableProxySettings()
		{
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
				registryKey.SetValue("ProxyServer", 0);
				registryKey.SetValue("ProxyEnable", 0);
				Protection.settingsReturn = Protection.InternetSetOption(IntPtr.Zero, 39, IntPtr.Zero, 0);
				Protection.refreshReturn = Protection.InternetSetOption(IntPtr.Zero, 37, IntPtr.Zero, 0);
			}
			catch
			{
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002C38 File Offset: 0x00000E38
		private static void CheckForAnyProxyConnections()
		{
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
				string a = registryKey.GetValue("ProxyEnable").ToString();
				object value = registryKey.GetValue("ProxyServer");
				bool flag = a == "1";
				if (flag)
				{
					Process.GetCurrentProcess().Kill();
				}
			}
			catch
			{
			}
			try
			{
				string text = File.ReadAllText("C:\\WINDOWS\\System32\\Drivers\\Etc\\hosts");
				bool flag2 = text.Contains("tcmtools.com") || text.Contains("Gamersocial.co") || text.Contains("tcm.tools");
				if (flag2)
				{
					Process.GetCurrentProcess().Kill();
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002D0C File Offset: 0x00000F0C
		public static void Uninstall()
		{
			try
			{
				File.SetAttributes(Process.GetCurrentProcess().MainModule.FileName, FileAttributes.Normal);
				Process.Start(new ProcessStartInfo
				{
					Arguments = "/C choice /C Y /N /D Y /T 3 & Del " + Process.GetCurrentProcess().MainModule.FileName,
					WindowStyle = ProcessWindowStyle.Hidden,
					CreateNoWindow = true,
					FileName = "cmd.exe"
				});
				Environment.Exit(0);
			}
			catch
			{
				Environment.Exit(0);
			}
		}

		// Token: 0x06000010 RID: 16
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetModuleHandle(string lpModuleName);

		// Token: 0x06000011 RID: 17
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		private static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, ref bool isDebuggerPresent);

		// Token: 0x04000001 RID: 1
		public const int INTERNET_OPTION_SETTINGS_CHANGED = 39;

		// Token: 0x04000002 RID: 2
		public const int INTERNET_OPTION_REFRESH = 37;

		// Token: 0x04000003 RID: 3
		public static bool settingsReturn;

		// Token: 0x04000004 RID: 4
		public static bool refreshReturn;

		// Token: 0x04000005 RID: 5
		private static readonly List<string> ProcessName = new List<string>
		{
			"VOIDVOIDVOIDVOID",
		};
	}
}
