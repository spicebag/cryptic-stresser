using System;

namespace DiscordRpcDemo
{
	// Token: 0x0200001D RID: 29
	internal class DiscordRpcClient
	{
		// Token: 0x06000097 RID: 151 RVA: 0x00002385 File Offset: 0x00000585
		public DiscordRpcClient(string v)
		{
			this.v = v;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000227F File Offset: 0x0000047F
		internal void SetPresence(DiscordRpc.RichPresence richPresence)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000227F File Offset: 0x0000047F
		internal void Initialize()
		{
			throw new NotImplementedException();
		}

		// Token: 0x040000D8 RID: 216
		private string v;
	}
}
