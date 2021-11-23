using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Net;
using System.Text;

namespace Auth.GG_Winform_Example
{
	// Token: 0x02000024 RID: 36
	internal class API
	{
		// Token: 0x060000DC RID: 220 RVA: 0x0000F1B4 File Offset: 0x0000D3B4
		public static void Log(string username, string action)
		{
			bool flag = !Constants.Initialized;
			if (flag)
			{
				Process.GetCurrentProcess().Kill();
			}
			bool flag2 = string.IsNullOrWhiteSpace(action);
			if (flag2)
			{
				Process.GetCurrentProcess().Kill();
			}
			string[] array = new string[0];
			using (WebClient webClient = new WebClient())
			{
				try
				{
					Security.Start();
					webClient.Proxy = null;
					Encoding @default = Encoding.Default;
					WebClient webClient2 = webClient;
					string apiUrl = Constants.ApiUrl;
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["token"] = Encryption.EncryptService(Constants.Token);
					nameValueCollection["aid"] = Encryption.APIService(OnProgramStart.AID);
					nameValueCollection["username"] = Encryption.APIService(username);
					nameValueCollection["pcuser"] = Encryption.APIService(Environment.UserName);
					nameValueCollection["session_id"] = Constants.IV;
					nameValueCollection["api_id"] = Constants.APIENCRYPTSALT;
					nameValueCollection["api_key"] = Constants.APIENCRYPTKEY;
					nameValueCollection["data"] = Encryption.APIService(action);
					nameValueCollection["session_key"] = Constants.Key;
					nameValueCollection["secret"] = Encryption.APIService(OnProgramStart.Secret);
					nameValueCollection["type"] = Encryption.APIService("log");
					array = Encryption.DecryptService(@default.GetString(webClient2.UploadValues(apiUrl, nameValueCollection))).Split("|".ToCharArray());
					Security.End();
				}
				catch (Exception ex)
				{
					Process.GetCurrentProcess().Kill();
				}
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000F370 File Offset: 0x0000D570
		public static void UploadPic(string username, string path)
		{
			bool flag = string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(path);
			if (flag)
			{
				Process.GetCurrentProcess().Kill();
			}
			string[] array = new string[0];
			using (WebClient webClient = new WebClient())
			{
				try
				{
					webClient.Proxy = null;
					Security.Start();
					Encoding @default = Encoding.Default;
					WebClient webClient2 = webClient;
					string apiUrl = Constants.ApiUrl;
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["token"] = Encryption.EncryptService(Constants.Token);
					nameValueCollection["timestamp"] = Encryption.EncryptService(DateTime.Now.ToString());
					nameValueCollection["aid"] = Encryption.APIService(OnProgramStart.AID);
					nameValueCollection["username"] = Encryption.APIService(username);
					nameValueCollection["picbytes"] = Encryption.APIService(path);
					nameValueCollection["session_id"] = Constants.IV;
					nameValueCollection["api_id"] = Constants.APIENCRYPTSALT;
					nameValueCollection["api_key"] = Constants.APIENCRYPTKEY;
					nameValueCollection["session_key"] = Constants.Key;
					nameValueCollection["secret"] = Encryption.APIService(OnProgramStart.Secret);
					nameValueCollection["type"] = Encryption.APIService("uploadpic");
					array = Encryption.DecryptService(@default.GetString(webClient2.UploadValues(apiUrl, nameValueCollection))).Split("|".ToCharArray());
					string text = array[0];
					string a = text;
					if (!(a == "success"))
					{
						if (!(a == "permissions"))
						{
							if (!(a == "maxsize"))
							{
								if (a == "failed")
								{
									Security.End();
								}
							}
							else
							{
								Security.End();
							}
						}
						else
						{
							Security.End();
						}
					}
					else
					{
						Security.End();
					}
				}
				catch (Exception ex)
				{
					Process.GetCurrentProcess().Kill();
				}
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000F584 File Offset: 0x0000D784
		public static bool AIO(string AIO)
		{
			bool flag = API.AIOLogin(AIO);
			bool result;
			if (flag)
			{
				result = true;
			}
			else
			{
				bool flag2 = API.AIORegister(AIO);
				result = flag2;
			}
			return result;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000F5B8 File Offset: 0x0000D7B8
		public static bool AIOLogin(string AIO)
		{
			bool flag = !Constants.Initialized;
			if (flag)
			{
				Process.GetCurrentProcess().Kill();
			}
			bool flag2 = string.IsNullOrWhiteSpace(AIO);
			if (flag2)
			{
				Process.GetCurrentProcess().Kill();
			}
			string[] array = new string[0];
			bool result;
			using (WebClient webClient = new WebClient())
			{
				try
				{
					Security.Start();
					webClient.Proxy = null;
					Encoding @default = Encoding.Default;
					WebClient webClient2 = webClient;
					string apiUrl = Constants.ApiUrl;
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["token"] = Encryption.EncryptService(Constants.Token);
					nameValueCollection["timestamp"] = Encryption.EncryptService(DateTime.Now.ToString());
					nameValueCollection["aid"] = Encryption.APIService(OnProgramStart.AID);
					nameValueCollection["session_id"] = Constants.IV;
					nameValueCollection["api_id"] = Constants.APIENCRYPTSALT;
					nameValueCollection["api_key"] = Constants.APIENCRYPTKEY;
					nameValueCollection["username"] = Encryption.APIService(AIO);
					nameValueCollection["password"] = Encryption.APIService(AIO);
					nameValueCollection["hwid"] = Encryption.APIService(Constants.HWID());
					nameValueCollection["session_key"] = Constants.Key;
					nameValueCollection["secret"] = Encryption.APIService(OnProgramStart.Secret);
					nameValueCollection["type"] = Encryption.APIService("login");
					array = Encryption.DecryptService(@default.GetString(webClient2.UploadValues(apiUrl, nameValueCollection))).Split("|".ToCharArray());
					bool flag3 = array[0] != Constants.Token;
					if (flag3)
					{
						Process.GetCurrentProcess().Kill();
					}
					bool flag4 = Security.MaliciousCheck(array[1]);
					if (flag4)
					{
						Process.GetCurrentProcess().Kill();
					}
					bool breached = Constants.Breached;
					if (breached)
					{
						Process.GetCurrentProcess().Kill();
					}
					string text = array[2];
					string a = text;
					if (a == "success")
					{
						Security.End();
						User.ID = array[3];
						User.Username = array[4];
						User.Password = array[5];
						User.Email = array[6];
						User.HWID = array[7];
						User.UserVariable = array[8];
						User.Rank = array[9];
						User.IP = array[10];
						User.Expiry = array[11];
						User.LastLogin = array[12];
						User.RegisterDate = array[13];
						string text2 = array[14];
						User.ProfilePicture = array[15];
						foreach (string text3 in text2.Split(new char[]
						{
							'~'
						}))
						{
							string[] array3 = text3.Split(new char[]
							{
								'^'
							});
							try
							{
								App.Variables.Add(array3[0], array3[1]);
							}
							catch
							{
							}
						}
						return true;
					}
					if (a == "invalid_details")
					{
						Security.End();
						return false;
					}
					if (a == "time_expired")
					{
						Security.End();
						return false;
					}
					if (a == "hwid_updated")
					{
						Security.End();
						return false;
					}
					if (a == "invalid_hwid")
					{
						Security.End();
						return false;
					}
				}
				catch (Exception ex)
				{
					Security.End();
					Process.GetCurrentProcess().Kill();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000F974 File Offset: 0x0000DB74
		public static bool AIORegister(string AIO)
		{
			bool flag = !Constants.Initialized;
			if (flag)
			{
				Security.End();
				Process.GetCurrentProcess().Kill();
			}
			bool flag2 = string.IsNullOrWhiteSpace(AIO);
			if (flag2)
			{
				Process.GetCurrentProcess().Kill();
			}
			string[] array = new string[0];
			bool result;
			using (WebClient webClient = new WebClient())
			{
				try
				{
					Security.Start();
					webClient.Proxy = null;
					Encoding @default = Encoding.Default;
					WebClient webClient2 = webClient;
					string apiUrl = Constants.ApiUrl;
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["token"] = Encryption.EncryptService(Constants.Token);
					nameValueCollection["timestamp"] = Encryption.EncryptService(DateTime.Now.ToString());
					nameValueCollection["aid"] = Encryption.APIService(OnProgramStart.AID);
					nameValueCollection["session_id"] = Constants.IV;
					nameValueCollection["api_id"] = Constants.APIENCRYPTSALT;
					nameValueCollection["api_key"] = Constants.APIENCRYPTKEY;
					nameValueCollection["session_key"] = Constants.Key;
					nameValueCollection["secret"] = Encryption.APIService(OnProgramStart.Secret);
					nameValueCollection["type"] = Encryption.APIService("register");
					nameValueCollection["username"] = Encryption.APIService(AIO);
					nameValueCollection["password"] = Encryption.APIService(AIO);
					nameValueCollection["email"] = Encryption.APIService(AIO);
					nameValueCollection["license"] = Encryption.APIService(AIO);
					nameValueCollection["hwid"] = Encryption.APIService(Constants.HWID());
					array = Encryption.DecryptService(@default.GetString(webClient2.UploadValues(apiUrl, nameValueCollection))).Split("|".ToCharArray());
					bool flag3 = array[0] != Constants.Token;
					if (flag3)
					{
						Security.End();
						Process.GetCurrentProcess().Kill();
					}
					bool flag4 = Security.MaliciousCheck(array[1]);
					if (flag4)
					{
						Process.GetCurrentProcess().Kill();
					}
					bool breached = Constants.Breached;
					if (breached)
					{
						Process.GetCurrentProcess().Kill();
					}
					Security.End();
					string text = array[2];
					string a = text;
					if (a == "success")
					{
						return true;
					}
					if (a == "error")
					{
						return false;
					}
				}
				catch (Exception ex)
				{
					Process.GetCurrentProcess().Kill();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000FC08 File Offset: 0x0000DE08
		public static bool Login(string username, string password)
		{
			bool flag = !Constants.Initialized;
			if (flag)
			{
				Process.GetCurrentProcess().Kill();
			}
			bool flag2 = string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password);
			if (flag2)
			{
				Process.GetCurrentProcess().Kill();
			}
			string[] array = new string[0];
			bool result;
			using (WebClient webClient = new WebClient())
			{
				try
				{
					Security.Start();
					webClient.Proxy = null;
					Encoding @default = Encoding.Default;
					WebClient webClient2 = webClient;
					string apiUrl = Constants.ApiUrl;
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["token"] = Encryption.EncryptService(Constants.Token);
					nameValueCollection["timestamp"] = Encryption.EncryptService(DateTime.Now.ToString());
					nameValueCollection["aid"] = Encryption.APIService(OnProgramStart.AID);
					nameValueCollection["session_id"] = Constants.IV;
					nameValueCollection["api_id"] = Constants.APIENCRYPTSALT;
					nameValueCollection["api_key"] = Constants.APIENCRYPTKEY;
					nameValueCollection["username"] = Encryption.APIService(username);
					nameValueCollection["password"] = Encryption.APIService(password);
					nameValueCollection["hwid"] = Encryption.APIService(Constants.HWID());
					nameValueCollection["session_key"] = Constants.Key;
					nameValueCollection["secret"] = Encryption.APIService(OnProgramStart.Secret);
					nameValueCollection["type"] = Encryption.APIService("login");
					array = Encryption.DecryptService(@default.GetString(webClient2.UploadValues(apiUrl, nameValueCollection))).Split("|".ToCharArray());
					bool flag3 = array[0] != Constants.Token;
					if (flag3)
					{
						Process.GetCurrentProcess().Kill();
					}
					bool flag4 = Security.MaliciousCheck(array[1]);
					if (flag4)
					{
						Process.GetCurrentProcess().Kill();
					}
					bool breached = Constants.Breached;
					if (breached)
					{
						Process.GetCurrentProcess().Kill();
					}
					string text = array[2];
					string a = text;
					if (a == "success")
					{
						User.ID = array[3];
						User.Username = array[4];
						User.Password = array[5];
						User.Email = array[6];
						User.HWID = array[7];
						User.UserVariable = array[8];
						User.Rank = array[9];
						User.IP = array[10];
						User.Expiry = array[11];
						User.LastLogin = array[12];
						User.RegisterDate = array[13];
						string text2 = array[14];
						User.ProfilePicture = array[15];
						foreach (string text3 in text2.Split(new char[]
						{
							'~'
						}))
						{
							string[] array3 = text3.Split(new char[]
							{
								'^'
							});
							try
							{
								App.Variables.Add(array3[0], array3[1]);
							}
							catch
							{
							}
						}
						Security.End();
						return true;
					}
					if (a == "invalid_details")
					{
						Security.End();
						return false;
					}
					if (a == "time_expired")
					{
						Security.End();
						return false;
					}
					if (a == "hwid_updated")
					{
						Security.End();
						return false;
					}
					if (a == "invalid_hwid")
					{
						Security.End();
						return false;
					}
				}
				catch (Exception ex)
				{
					Security.End();
					Process.GetCurrentProcess().Kill();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000FFD0 File Offset: 0x0000E1D0
		public static bool Register(string username, string password, string email, string license)
		{
			bool flag = !Constants.Initialized;
			if (flag)
			{
				Security.End();
				Process.GetCurrentProcess().Kill();
			}
			bool flag2 = string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(license);
			if (flag2)
			{
				Process.GetCurrentProcess().Kill();
			}
			string[] array = new string[0];
			bool result;
			using (WebClient webClient = new WebClient())
			{
				try
				{
					Security.Start();
					webClient.Proxy = null;
					Encoding @default = Encoding.Default;
					WebClient webClient2 = webClient;
					string apiUrl = Constants.ApiUrl;
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["token"] = Encryption.EncryptService(Constants.Token);
					nameValueCollection["timestamp"] = Encryption.EncryptService(DateTime.Now.ToString());
					nameValueCollection["aid"] = Encryption.APIService(OnProgramStart.AID);
					nameValueCollection["session_id"] = Constants.IV;
					nameValueCollection["api_id"] = Constants.APIENCRYPTSALT;
					nameValueCollection["api_key"] = Constants.APIENCRYPTKEY;
					nameValueCollection["session_key"] = Constants.Key;
					nameValueCollection["secret"] = Encryption.APIService(OnProgramStart.Secret);
					nameValueCollection["type"] = Encryption.APIService("register");
					nameValueCollection["username"] = Encryption.APIService(username);
					nameValueCollection["password"] = Encryption.APIService(password);
					nameValueCollection["email"] = Encryption.APIService(email);
					nameValueCollection["license"] = Encryption.APIService(license);
					nameValueCollection["hwid"] = Encryption.APIService(Constants.HWID());
					array = Encryption.DecryptService(@default.GetString(webClient2.UploadValues(apiUrl, nameValueCollection))).Split("|".ToCharArray());
					bool flag3 = array[0] != Constants.Token;
					if (flag3)
					{
						Security.End();
						Process.GetCurrentProcess().Kill();
					}
					bool flag4 = Security.MaliciousCheck(array[1]);
					if (flag4)
					{
						Process.GetCurrentProcess().Kill();
					}
					bool breached = Constants.Breached;
					if (breached)
					{
						Process.GetCurrentProcess().Kill();
					}
					string text = array[2];
					string a = text;
					if (a == "success")
					{
						Security.End();
						return true;
					}
					if (a == "invalid_license")
					{
						Security.End();
						return false;
					}
					if (a == "email_used")
					{
						Security.End();
						return false;
					}
					if (a == "invalid_username")
					{
						Security.End();
						return false;
					}
				}
				catch (Exception ex)
				{
					Process.GetCurrentProcess().Kill();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000102B8 File Offset: 0x0000E4B8
		public static bool ExtendSubscription(string username, string password, string license)
		{
			bool flag = !Constants.Initialized;
			if (flag)
			{
				Security.End();
				Process.GetCurrentProcess().Kill();
			}
			bool flag2 = string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(license);
			if (flag2)
			{
				Process.GetCurrentProcess().Kill();
			}
			string[] array = new string[0];
			bool result;
			using (WebClient webClient = new WebClient())
			{
				try
				{
					Security.Start();
					webClient.Proxy = null;
					Encoding @default = Encoding.Default;
					WebClient webClient2 = webClient;
					string apiUrl = Constants.ApiUrl;
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["token"] = Encryption.EncryptService(Constants.Token);
					nameValueCollection["timestamp"] = Encryption.EncryptService(DateTime.Now.ToString());
					nameValueCollection["aid"] = Encryption.APIService(OnProgramStart.AID);
					nameValueCollection["session_id"] = Constants.IV;
					nameValueCollection["api_id"] = Constants.APIENCRYPTSALT;
					nameValueCollection["api_key"] = Constants.APIENCRYPTKEY;
					nameValueCollection["session_key"] = Constants.Key;
					nameValueCollection["secret"] = Encryption.APIService(OnProgramStart.Secret);
					nameValueCollection["type"] = Encryption.APIService("extend");
					nameValueCollection["username"] = Encryption.APIService(username);
					nameValueCollection["password"] = Encryption.APIService(password);
					nameValueCollection["license"] = Encryption.APIService(license);
					array = Encryption.DecryptService(@default.GetString(webClient2.UploadValues(apiUrl, nameValueCollection))).Split("|".ToCharArray());
					bool flag3 = array[0] != Constants.Token;
					if (flag3)
					{
						Security.End();
						Process.GetCurrentProcess().Kill();
					}
					bool flag4 = Security.MaliciousCheck(array[1]);
					if (flag4)
					{
						Process.GetCurrentProcess().Kill();
					}
					bool breached = Constants.Breached;
					if (breached)
					{
						Process.GetCurrentProcess().Kill();
					}
					string text = array[2];
					string a = text;
					if (a == "success")
					{
						Security.End();
						return true;
					}
					if (a == "invalid_token")
					{
						Security.End();
						return false;
					}
					if (a == "invalid_details")
					{
						Security.End();
						return false;
					}
				}
				catch (Exception ex)
				{
					Process.GetCurrentProcess().Kill();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000227F File Offset: 0x0000047F
		internal static void Log(object user2, string v)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000227F File Offset: 0x0000047F
		internal static void UploadPic(string username, object pic)
		{
			throw new NotImplementedException();
		}
	}
}
