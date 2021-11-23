using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Threading;

namespace Auth.GG_Winform_Example
{
	// Token: 0x0200002A RID: 42
	internal class InfoManager
	{
		// Token: 0x060000FE RID: 254 RVA: 0x000025C4 File Offset: 0x000007C4
		public InfoManager()
		{
			this.lastGateway = this.GetGatewayMAC();
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000025DA File Offset: 0x000007DA
		public void StartListener()
		{
			this.timer = new Timer(delegate(object _)
			{
				this.OnCallBack();
			}, null, 5000, -1);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00010C84 File Offset: 0x0000EE84
		private void OnCallBack()
		{
			this.timer.Dispose();
			bool flag = !(this.GetGatewayMAC() == this.lastGateway);
			if (flag)
			{
				Constants.Breached = true;
				Process.GetCurrentProcess().Kill();
			}
			else
			{
				this.lastGateway = this.GetGatewayMAC();
			}
			this.timer = new Timer(delegate(object _)
			{
				this.OnCallBack();
			}, null, 5000, -1);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00010CF8 File Offset: 0x0000EEF8
		public static IPAddress GetDefaultGateway()
		{
			return (from g in (from n in NetworkInterface.GetAllNetworkInterfaces()
			where n.OperationalStatus == OperationalStatus.Up
			where n.NetworkInterfaceType != NetworkInterfaceType.Loopback
			select n).SelectMany(delegate(NetworkInterface n)
			{
				IPInterfaceProperties ipproperties = n.GetIPProperties();
				return (ipproperties != null) ? ipproperties.GatewayAddresses : null;
			})
			select (g != null) ? g.Address : null into a
			where a != null
			select a).FirstOrDefault<IPAddress>();
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00010DC8 File Offset: 0x0000EFC8
		private string GetArpTable()
		{
			string pathRoot = Path.GetPathRoot(Environment.SystemDirectory);
			string result;
			using (Process process = Process.Start(new ProcessStartInfo
			{
				FileName = pathRoot + "Windows\\System32\\arp.exe",
				Arguments = "-a",
				UseShellExecute = false,
				RedirectStandardOutput = true,
				CreateNoWindow = true
			}))
			{
				using (StreamReader standardOutput = process.StandardOutput)
				{
					result = standardOutput.ReadToEnd();
				}
			}
			return result;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00010E6C File Offset: 0x0000F06C
		private string GetGatewayMAC()
		{
			string arg = InfoManager.GetDefaultGateway().ToString();
			string pattern = string.Format("({0} [\\W]*) ([a-z0-9-]*)", arg);
			Regex regex = new Regex(pattern);
			Match match = regex.Match(this.GetArpTable());
			return match.Groups[2].ToString();
		}

		// Token: 0x04000108 RID: 264
		private Timer timer;

		// Token: 0x04000109 RID: 265
		private string lastGateway;
	}
}
