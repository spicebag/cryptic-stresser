using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Cryptic_Stresser
{
	public class Data
	{
		[DebuggerStepThrough]
		public static Task<string> NewsText()
		{
			Data.<NewsText>d__0 <NewsText>d__ = new Data.<NewsText>d__0();
			<NewsText>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<NewsText>d__.<>1__state = -1;
			<NewsText>d__.<>t__builder.Start<Data.<NewsText>d__0>(ref <NewsText>d__);
			return <NewsText>d__.<>t__builder.Task;
		}

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

		public static FusionApp App = new FusionApp("APPID");
	}
}
