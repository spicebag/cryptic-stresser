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
	internal class Protection
	{
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
		private static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.LPStr)] string library);

		[DllImport("user32.dll")]
		public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);

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

		public static void ChallengeCheck()
		{
			MessageBox.Show("Process Check Failed. Make sure you close ALL Debuggers", "Project Resurrect");
			Environment.Exit(0);
		}

		public static void CheckCurrentProcess()
		{
			bool flag = Process.GetCurrentProcess().ProcessName == "VOIDVOIDVOID" || Process.GetCurrentProcess().ProcessName == "VOIDVOIDVOID" || Process.GetCurrentProcess().ProcessName == "VOIDVOIDVOID";
			if (!flag)
			{
				MessageBox.Show("Process Check Failed. Make sure you close ALL Debuggers", "Project Resurrect");
				Environment.Exit(0);
			}
		}

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
							// Environment.Exit(0);
						}
						catch
						{
							MessageBox.Show("Process Check Failed. Make sure you close ALL Debuggers", "Project Resurrect");
							// Environment.Exit(0);
						}
					}
				}
			}
		}

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

		public static void ProtectionCheckLoop()
		{
		}

		public static void ProtectionCheck()
		{
			Protection.BlockProc();
			Protection.DisableProxySettings();
			Protection.CheckForAnyProxyConnections();
		}

		public static bool CheckForFiddler()
		{
			return Protection.LoadLibraryA("FiddlerCore4.dll") != IntPtr.Zero || Protection.LoadLibraryA("Titanium.Web.Proxy.dll") != IntPtr.Zero;
		}

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
					// Process.GetCurrentProcess().Kill();
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
					// Process.GetCurrentProcess().Kill();
				}
			}
			catch
			{
			}
		}

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

		[DllImport("kernel32.dll")]
		public static extern IntPtr GetModuleHandle(string lpModuleName);

		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		private static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, ref bool isDebuggerPresent);

		public const int INTERNET_OPTION_SETTINGS_CHANGED = 39;

		public const int INTERNET_OPTION_REFRESH = 37;

		public static bool settingsReturn;

		public static bool refreshReturn;

		private static readonly List<string> ProcessName = new List<string>
		{
			"VOIDVOIDVOIDVOID",
		};
	}
}
