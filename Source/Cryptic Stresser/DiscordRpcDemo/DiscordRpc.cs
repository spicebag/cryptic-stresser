using System;
using System.Runtime.InteropServices;

namespace DiscordRpcDemo
{
	// Token: 0x02000017 RID: 23
	public class DiscordRpc
	{
		// Token: 0x06000085 RID: 133
		[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_Initialize")]
		public static extern void Initialize(string applicationId, ref DiscordRpc.EventHandlers handlers, bool autoRegister, string optionalSteamId);

		// Token: 0x06000086 RID: 134
		[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_RunCallbacks")]
		public static extern void RunCallbacks();

		// Token: 0x06000087 RID: 135
		[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_Shutdown")]
		public static extern void Shutdown();

		// Token: 0x06000088 RID: 136
		[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_UpdatePresence")]
		public static extern void UpdatePresence(ref DiscordRpc.RichPresence presence);

		// Token: 0x06000089 RID: 137 RVA: 0x0000227F File Offset: 0x0000047F
		internal static void Initialize(string v1, ref object handlers, bool v2, object p)
		{
			throw new NotImplementedException();
		}

		// Token: 0x040000C5 RID: 197
		private static object client;

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x0600008C RID: 140
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void DisconnectedCallback(int errorCode, string message);

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x06000090 RID: 144
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void ErrorCallback(int errorCode, string message);

		// Token: 0x0200001A RID: 26
		public struct EventHandlers
		{
			// Token: 0x040000C6 RID: 198
			public DiscordRpc.ReadyCallback readyCallback;

			// Token: 0x040000C7 RID: 199
			public DiscordRpc.DisconnectedCallback disconnectedCallback;

			// Token: 0x040000C8 RID: 200
			public DiscordRpc.ErrorCallback errorCallback;
		}

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x06000094 RID: 148
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void ReadyCallback();

		// Token: 0x0200001C RID: 28
		[Serializable]
		public struct RichPresence
		{
			// Token: 0x040000C9 RID: 201
			public string state;

			// Token: 0x040000CA RID: 202
			public string details;

			// Token: 0x040000CB RID: 203
			public long startTimestamp;

			// Token: 0x040000CC RID: 204
			public long endTimestamp;

			// Token: 0x040000CD RID: 205
			public string largeImageKey;

			// Token: 0x040000CE RID: 206
			public string largeImageText;

			// Token: 0x040000CF RID: 207
			public string smallImageKey;

			// Token: 0x040000D0 RID: 208
			public string smallImageText;

			// Token: 0x040000D1 RID: 209
			public string partyId;

			// Token: 0x040000D2 RID: 210
			public int partySize;

			// Token: 0x040000D3 RID: 211
			public int partyMax;

			// Token: 0x040000D4 RID: 212
			public string matchSecret;

			// Token: 0x040000D5 RID: 213
			public string joinSecret;

			// Token: 0x040000D6 RID: 214
			public string spectateSecret;

			// Token: 0x040000D7 RID: 215
			public bool instance;
		}
	}
}
