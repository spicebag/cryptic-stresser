using System;
using System.Windows.Forms;
using Auth.GG_Winform_Example;

namespace Cryptic_Stresser
{
	// Token: 0x02000013 RID: 19
	internal static class Program
	{
		// Token: 0x06000076 RID: 118 RVA: 0x000022EB File Offset: 0x000004EB
		[STAThread]
		private static void Main()
		{
			OnProgramStart.Initialize("Cryptic Stresser", "713067", "rPZi0kzEWGla3kaLlTf9exq76K2njf64Aqu", "1.0");
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
