using System;
using System.Collections.Generic;

namespace Auth.GG_Winform_Example
{
	// Token: 0x0200001E RID: 30
	internal class App
	{
		// Token: 0x0600009A RID: 154 RVA: 0x0000ECC4 File Offset: 0x0000CEC4
		public static string GrabVariable(string name)
		{
			string result;
			try
			{
				bool flag = User.ID != null || User.HWID != null || User.IP != null || !Constants.Breached;
				if (flag)
				{
					result = App.Variables[name];
				}
				else
				{
					Constants.Breached = true;
					result = "User is not logged in, possible breach detected!";
				}
			}
			catch
			{
				result = "N/A";
			}
			return result;
		}

		// Token: 0x040000D9 RID: 217
		public static string Error = null;

		// Token: 0x040000DA RID: 218
		public static Dictionary<string, string> Variables = new Dictionary<string, string>();
	}
}
