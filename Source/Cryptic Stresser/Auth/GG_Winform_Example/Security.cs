using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Auth.GG_Winform_Example
{
	// Token: 0x02000025 RID: 37
	internal class Security
	{
		// Token: 0x060000E7 RID: 231 RVA: 0x00010558 File Offset: 0x0000E758
		public static string Signature(string value)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				byte[] bytes = Encoding.UTF8.GetBytes(value);
				byte[] value2 = md.ComputeHash(bytes);
				result = BitConverter.ToString(value2).Replace("-", "");
			}
			return result;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000105B8 File Offset: 0x0000E7B8
		private static string Session(int length)
		{
			Random random = new Random();
			return new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz", length)
			select s[random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00010604 File Offset: 0x0000E804
		public static string Obfuscate(int length)
		{
			Random random = new Random();
			return new string((from s in Enumerable.Repeat<string>("gd8JQ57nxXzLLMPrLylVhxoGnWGCFjO4knKTfRE6mVvdjug2NF/4aptAsZcdIGbAPmcx0O+ftU/KvMIjcfUnH3j+IMdhAW5OpoX3MrjQdf5AAP97tTB5g1wdDSAqKpq9gw06t3VaqMWZHKtPSuAXy0kkZRsc+DicpcY8E9+vWMHXa3jMdbPx4YES0p66GzhqLd/heA2zMvX8iWv4wK7S3QKIW/a9dD4ALZJpmcr9OOE=", length)
			select s[random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00010650 File Offset: 0x0000E850
		public static void Start()
		{
			string pathRoot = Path.GetPathRoot(Environment.SystemDirectory);
			bool started = Constants.Started;
			if (started)
			{
				Process.GetCurrentProcess().Kill();
			}
			else
			{
				using (StreamReader streamReader = new StreamReader(pathRoot + "Windows\\System32\\drivers\\etc\\hosts"))
				{
					string text = streamReader.ReadToEnd();
					bool flag = text.Contains("api.auth.gg");
					if (flag)
					{
						Constants.Breached = true;
						Process.GetCurrentProcess().Kill();
					}
				}
				InfoManager infoManager = new InfoManager();
				infoManager.StartListener();
				Constants.Token = Guid.NewGuid().ToString();
				ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback(Security.PinPublicKey));
				Constants.APIENCRYPTKEY = Convert.ToBase64String(Encoding.Default.GetBytes(Security.Session(32)));
				Constants.APIENCRYPTSALT = Convert.ToBase64String(Encoding.Default.GetBytes(Security.Session(16)));
				Constants.IV = Convert.ToBase64String(Encoding.Default.GetBytes(Constants.RandomString(16)));
				Constants.Key = Convert.ToBase64String(Encoding.Default.GetBytes(Constants.RandomString(32)));
				Constants.Started = true;
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000107A0 File Offset: 0x0000E9A0
		public static void End()
		{
			bool flag = !Constants.Started;
			if (flag)
			{
				Process.GetCurrentProcess().Kill();
			}
			else
			{
				Constants.Token = null;
				ServicePointManager.ServerCertificateValidationCallback = ((object <p0>, X509Certificate <p1>, X509Chain <p2>, SslPolicyErrors <p3>) => true);
				Constants.APIENCRYPTKEY = null;
				Constants.APIENCRYPTSALT = null;
				Constants.IV = null;
				Constants.Key = null;
				Constants.Started = false;
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00010818 File Offset: 0x0000EA18
		private static bool PinPublicKey(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return certificate != null && certificate.GetPublicKeyString() == "045C03C7FB0E76A822AB197B6663C288D9632E55B39B80296CBCD978707A7E5B3EAE1DB5D487CE9F0E448C3557079CE142F5A41B7F1F6436077D8F3FF7C311888C";
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00010840 File Offset: 0x0000EA40
		public static string Integrity(string filename)
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

		// Token: 0x060000EE RID: 238 RVA: 0x000108C0 File Offset: 0x0000EAC0
		public static bool MaliciousCheck(string date)
		{
			DateTime d = DateTime.Parse(date);
			DateTime now = DateTime.Now;
			TimeSpan timeSpan = d - now;
			bool flag = Convert.ToInt32(timeSpan.Seconds.ToString().Replace("-", "")) >= 5 || Convert.ToInt32(timeSpan.Minutes.ToString().Replace("-", "")) >= 1;
			bool result;
			if (flag)
			{
				Constants.Breached = true;
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x04000103 RID: 259
		private const string _key = "045C03C7FB0E76A822AB197B6663C288D9632E55B39B80296CBCD978707A7E5B3EAE1DB5D487CE9F0E448C3557079CE142F5A41B7F1F6436077D8F3FF7C311888C";
	}
}
