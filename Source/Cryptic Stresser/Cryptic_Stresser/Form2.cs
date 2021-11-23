using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Auth.GG_Winform_Example;
using Guna.UI2.AnimatorNS;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;

namespace Cryptic_Stresser
{
	// Token: 0x0200000B RID: 11
	public partial class Form2 : Form
	{
		// Token: 0x0600003A RID: 58 RVA: 0x000021C0 File Offset: 0x000003C0
		public Form2()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000021D8 File Offset: 0x000003D8
		private void Form2_Load(object sender, EventArgs e)
		{
			this.siticoneCirclePictureBox1.Load(User.ProfilePicture);
			this.user.Text = "Wellcome: " + User.Username;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000206C File Offset: 0x0000026C
		public static void wait(int milliseconds)
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000206C File Offset: 0x0000026C
		private void user_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002207 File Offset: 0x00000407
		private void exitlogin_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000206C File Offset: 0x0000026C
		private void timeformsg_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000206C File Offset: 0x0000026C
		private void timer_1_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000206C File Offset: 0x0000026C
		private void guna2ControlBox1_Click(object sender, EventArgs e)
		{
		}
	}
}
