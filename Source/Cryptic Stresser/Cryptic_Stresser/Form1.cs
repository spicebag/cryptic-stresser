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
	public partial class Form1 : Form
	{
		public Form1()
		{
			this.InitializeComponent();
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			this.reg.Show(this.panel1, false, null);
			this.G.Show(this.Back, false, null);
			this.G.Show(this.reg111, false, null);
		}

		private void Back_Click(object sender, EventArgs e)
		{
			this.G.Hide(this.Back, false, null);
			this.reg.Hide(this.panel1, false, null);
		}

		private void guna2Separator1_Click(object sender, EventArgs e)
		{
		}

		private void guna2Button3_Click(object sender, EventArgs e)
		{
			this.reg.Show(this.panel2, false, null);
			this.G.Show(this.Back2, false, null);
		}

		private void guna2Button4_Click(object sender, EventArgs e)
		{
			this.reg.Hide(this.panel2, false, null);
		}

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

		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

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

		private void exitlogin_Click(object sender, EventArgs e)
		{
		}

		private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
		{
		}

		private DiscordRpc.EventHandlers handlers;

		private DiscordRpc.RichPresence presence;
	}
}
