using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Auth.GG_Winform_Example;
using Cryptic_Stresser.Properties;
using DiscordRpcDemo;
using Guna.UI2.AnimatorNS;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;

namespace Cryptic_Stresser
{
	// Token: 0x02000008 RID: 8
	public partial class Form1 : Form
	{
		// Token: 0x06000023 RID: 35 RVA: 0x000020E0 File Offset: 0x000002E0
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000020F8 File Offset: 0x000002F8
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			this.reg.Show(this.panel1, false, null);
			this.G.Show(this.Back, false, null);
			this.G.Show(this.reg111, false, null);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002137 File Offset: 0x00000337
		private void Back_Click(object sender, EventArgs e)
		{
			this.G.Hide(this.Back, false, null);
			this.reg.Hide(this.panel1, false, null);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000206C File Offset: 0x0000026C
		private void guna2Separator1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002162 File Offset: 0x00000362
		private void guna2Button3_Click(object sender, EventArgs e)
		{
			this.reg.Show(this.panel2, false, null);
			this.G.Show(this.Back2, false, null);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000218D File Offset: 0x0000038D
		private void guna2Button4_Click(object sender, EventArgs e)
		{
			this.reg.Hide(this.panel2, false, null);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003064 File Offset: 0x00001264
		private void reg111_Click(object sender, EventArgs e)
		{
			bool flag = !this.email.Text.Contains("#");
			if (flag)
			{
				MessageBox.Show("Please enter your discord username and tag", "Cryptic Stresser", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				bool flag2 = API.Register(this.User.Text, this.Pass.Text, this.email.Text, this.Token.Text);
				if (flag2)
				{
					this.msgtext.Text = "Account Made! log In";
					this.msg.BackColor = Color.Green;
					this.msgpanel.Show(this.msg, false, null);
					this.timeformsg.Start();
				}
				else
				{
					this.msgtext.Text = "Something Went Wrong, Try Again";
					this.msg.BackColor = Color.Red;
					this.msgpanel.Show(this.msg, false, null);
					this.timeformsg.Start();
				}
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003168 File Offset: 0x00001368
		[DebuggerStepThrough]
		private Task guna2Button2_ClickAsync(object sender, EventArgs e)
		{
			Form1.<guna2Button2_ClickAsync>d__9 <guna2Button2_ClickAsync>d__ = new Form1.<guna2Button2_ClickAsync>d__9();
			<guna2Button2_ClickAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<guna2Button2_ClickAsync>d__.<>4__this = this;
			<guna2Button2_ClickAsync>d__.sender = sender;
			<guna2Button2_ClickAsync>d__.e = e;
			<guna2Button2_ClickAsync>d__.<>1__state = -1;
			<guna2Button2_ClickAsync>d__.<>t__builder.Start<Form1.<guna2Button2_ClickAsync>d__9>(ref <guna2Button2_ClickAsync>d__);
			return <guna2Button2_ClickAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000206C File Offset: 0x0000026C
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000031BC File Offset: 0x000013BC
		private void Form1_Load(object sender, EventArgs e)
		{
			this.handlers = default(DiscordRpc.EventHandlers);
			DiscordRpc.Initialize("910667330290343978", ref this.handlers, true, null);
			this.handlers = default(DiscordRpc.EventHandlers);
			DiscordRpc.Initialize("910667330290343978", ref this.handlers, true, null);
			this.presence.details = "Owner Ghostly | S5NTA";
			this.presence.state = "By Cryptic Team";
			this.presence.largeImageKey = "cryptic_background";
			this.presence.smallImageKey = "cryptic_logo_690px_png";
			DiscordRpc.UpdatePresence(ref this.presence);
			bool rememberme = Settings.Default.rememberme;
			if (rememberme)
			{
				this.User1.Text = Settings.Default.username;
				this.Pass2.Text = Settings.Default.password;
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003290 File Offset: 0x00001490
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			bool flag = API.Login(this.User1.Text, this.Pass2.Text);
			if (flag)
			{
				this.msgtext.Text = "Login Successful, Redirecting";
				Form2 form = new Form2();
				form.Show();
				this.msg.BackColor = Color.Green;
				this.msgpanel.Show(this.msg, false, null);
				this.timeformsg.Start();
				Form1.wait(2000);
				MainHub mainHub = new MainHub();
				mainHub.Show();
				base.Hide();
			}
			else
			{
				this.msgtext.Text = "Something Went Wrong, Try Again";
				this.msg.BackColor = Color.Red;
				this.msgpanel.Show(this.msg, false, null);
				this.timeformsg.Start();
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003374 File Offset: 0x00001574
		public static void wait(int milliseconds)
		{
			Timer timer1 = new Timer();
			bool flag = milliseconds == 0 || milliseconds < 0;
			if (!flag)
			{
				timer1.Interval = milliseconds;
				timer1.Enabled = true;
				timer1.Start();
				timer1.Tick += delegate(object s, EventArgs e)
				{
					timer1.Enabled = false;
					timer1.Stop();
				};
				while (timer1.Enabled)
				{
					Application.DoEvents();
				}
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000033FC File Offset: 0x000015FC
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

		// Token: 0x06000030 RID: 48 RVA: 0x0000344C File Offset: 0x0000164C
		private void exit_Tick(object sender, EventArgs e)
		{
			bool flag = base.Opacity > 0.0;
			if (flag)
			{
				base.Opacity -= 0.05;
			}
			else
			{
				this.exit.Stop();
				Application.Exit();
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000206C File Offset: 0x0000026C
		private void exitlogin_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000206C File Offset: 0x0000026C
		private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
		{
		}

		// Token: 0x04000017 RID: 23
		private DiscordRpc.EventHandlers handlers;

		// Token: 0x04000018 RID: 24
		private DiscordRpc.RichPresence presence;
	}
}
