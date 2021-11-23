using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Cryptic_Stresser
{
	// Token: 0x02000005 RID: 5
	public class Data
	{
		// Token: 0x06000019 RID: 25 RVA: 0x00002DA4 File Offset: 0x00000FA4
		[DebuggerStepThrough]
		public static Task<string> NewsText()
		{
			Data.<NewsText>d__0 <NewsText>d__ = new Data.<NewsText>d__0();
			<NewsText>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<NewsText>d__.<>1__state = -1;
			<NewsText>d__.<>t__builder.Start<Data.<NewsText>d__0>(ref <NewsText>d__);
			return <NewsText>d__.<>t__builder.Task;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002DE4 File Offset: 0x00000FE4
		[DebuggerStepThrough]
		public static Task<string> Download(string url)
		{
			Data.<Download>d__1 <Download>d__ = new Data.<Download>d__1();
			<Download>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<Download>d__.url = url;
			<Download>d__.<>1__state = -1;
			<Download>d__.<>t__builder.Start<Data.<Download>d__1>(ref <Download>d__);
			return <Download>d__.<>t__builder.Task;
		}

		// Token: 0x04000009 RID: 9
		public static FusionApp App = new FusionApp("APPID");
	}
}
