using System;
using System.Linq;
using System.Security.Principal;

namespace Auth.GG_Winform_Example
{
	// Token: 0x0200001F RID: 31
	internal class Constants
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600009D RID: 157 RVA: 0x000023A8 File Offset: 0x000005A8
		// (set) Token: 0x0600009E RID: 158 RVA: 0x000023AF File Offset: 0x000005AF
		public static string Token { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600009F RID: 159 RVA: 0x000023B7 File Offset: 0x000005B7
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x000023BE File Offset: 0x000005BE
		public static string Date { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x000023C6 File Offset: 0x000005C6
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x000023CD File Offset: 0x000005CD
		public static string APIENCRYPTKEY { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x000023D5 File Offset: 0x000005D5
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x000023DC File Offset: 0x000005DC
		public static string APIENCRYPTSALT { get; set; }

		// Token: 0x060000A5 RID: 165 RVA: 0x0000ED30 File Offset: 0x0000CF30
		public static string RandomString(int length)
		{
			return new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789", length)
			select s[Constants.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000ED7C File Offset: 0x0000CF7C
		public static string HWID()
		{
			return WindowsIdentity.GetCurrent().User.Value;
		}

		// Token: 0x040000DF RID: 223
		public static bool Breached = false;

		// Token: 0x040000E0 RID: 224
		public static bool Started = false;

		// Token: 0x040000E1 RID: 225
		public static string IV = null;

		// Token: 0x040000E2 RID: 226
		public static string Key = null;

		// Token: 0x040000E3 RID: 227
		public static string ApiUrl = "https://api.auth.gg/csharp/";

		// Token: 0x040000E4 RID: 228
		public static bool Initialized = false;

		// Token: 0x040000E5 RID: 229
		public static Random random = new Random();
	}
}
