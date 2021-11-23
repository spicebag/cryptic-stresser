namespace Cryptic_Stresser
{
	// Token: 0x0200000B RID: 11
	public partial class Form2 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000042 RID: 66 RVA: 0x00006290 File Offset: 0x00004490
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000062C8 File Offset: 0x000044C8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Guna.UI2.AnimatorNS.Animation animation = new global::Guna.UI2.AnimatorNS.Animation();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Cryptic_Stresser.Form2));
			this.guna2Elipse1 = new global::Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.label25 = new global::System.Windows.Forms.Label();
			this.user = new global::System.Windows.Forms.Label();
			this.siticoneCirclePictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.guna2ControlBox1 = new global::Guna.UI2.WinForms.Guna2ControlBox();
			this.guna2AnimateWindow1 = new global::Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
			this.guna2DragControl1 = new global::Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.reg = new global::Guna.UI2.WinForms.Guna2Transition();
			((global::System.ComponentModel.ISupportInitialize)this.siticoneCirclePictureBox1).BeginInit();
			base.SuspendLayout();
			this.guna2Elipse1.BorderRadius = 30;
			this.guna2Elipse1.TargetControl = this;
			this.label25.AutoSize = true;
			this.reg.SetDecoration(this.label25, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.label25.Font = new global::System.Drawing.Font("Arial", 14.25f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Italic | global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label25.ForeColor = global::System.Drawing.Color.White;
			this.label25.Location = new global::System.Drawing.Point(12, 7);
			this.label25.Name = "label25";
			this.label25.Size = new global::System.Drawing.Size(59, 23);
			this.label25.TabIndex = 10;
			this.label25.Text = "Hello";
			this.user.AutoSize = true;
			this.reg.SetDecoration(this.user, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.user.Font = new global::System.Drawing.Font("Arial", 14.25f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Italic | global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
			this.user.ForeColor = global::System.Drawing.Color.White;
			this.user.Location = new global::System.Drawing.Point(12, 32);
			this.user.Name = "user";
			this.user.Size = new global::System.Drawing.Size(52, 23);
			this.user.TabIndex = 11;
			this.user.Text = "user";
			this.user.Click += new global::System.EventHandler(this.user_Click);
			this.siticoneCirclePictureBox1.BackColor = global::System.Drawing.Color.Black;
			this.reg.SetDecoration(this.siticoneCirclePictureBox1, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.siticoneCirclePictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("siticoneCirclePictureBox1.Image");
			this.siticoneCirclePictureBox1.Location = new global::System.Drawing.Point(270, 6);
			this.siticoneCirclePictureBox1.Name = "siticoneCirclePictureBox1";
			this.siticoneCirclePictureBox1.Size = new global::System.Drawing.Size(24, 24);
			this.siticoneCirclePictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.siticoneCirclePictureBox1.TabIndex = 12;
			this.siticoneCirclePictureBox1.TabStop = false;
			this.guna2ControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.guna2ControlBox1.ControlBoxStyle = global::Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
			this.reg.SetDecoration(this.guna2ControlBox1, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.guna2ControlBox1.FillColor = global::System.Drawing.Color.Black;
			this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
			this.guna2ControlBox1.IconColor = global::System.Drawing.Color.White;
			this.guna2ControlBox1.Location = new global::System.Drawing.Point(348, 14);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
			this.guna2ControlBox1.Size = new global::System.Drawing.Size(28, 29);
			this.guna2ControlBox1.TabIndex = 13;
			this.guna2ControlBox1.Click += new global::System.EventHandler(this.guna2ControlBox1_Click);
			this.guna2AnimateWindow1.AnimationType = global::Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_ACTIVATE;
			this.guna2AnimateWindow1.TargetForm = this;
			this.guna2DragControl1.TargetControl = this;
			this.reg.AnimationType = global::Guna.UI2.AnimatorNS.AnimationType.Transparent;
			this.reg.Cursor = null;
			animation.AnimateOnlyDifferences = true;
			animation.BlindCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation3.BlindCoeff");
			animation.LeafCoeff = 0f;
			animation.MaxTime = 1f;
			animation.MinTime = 0f;
			animation.MosaicCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation3.MosaicCoeff");
			animation.MosaicShift = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation3.MosaicShift");
			animation.MosaicSize = 0;
			animation.Padding = new global::System.Windows.Forms.Padding(0);
			animation.RotateCoeff = 0f;
			animation.RotateLimit = 0f;
			animation.ScaleCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation3.ScaleCoeff");
			animation.SlideCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation3.SlideCoeff");
			animation.TimeCoeff = 0f;
			animation.TransparencyCoeff = 1f;
			this.reg.DefaultAnimation = animation;
			this.reg.Interval = 20;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			base.ClientSize = new global::System.Drawing.Size(388, 64);
			base.Controls.Add(this.guna2ControlBox1);
			base.Controls.Add(this.siticoneCirclePictureBox1);
			base.Controls.Add(this.user);
			base.Controls.Add(this.label25);
			this.reg.SetDecoration(this, global::Guna.UI2.AnimatorNS.DecorationType.None);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form2";
			this.Text = "UserNotify";
			base.Load += new global::System.EventHandler(this.Form2_Load);
			((global::System.ComponentModel.ISupportInitialize)this.siticoneCirclePictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000045 RID: 69
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000046 RID: 70
		private global::Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.Label user;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.Label label25;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.PictureBox siticoneCirclePictureBox1;

		// Token: 0x0400004A RID: 74
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;

		// Token: 0x0400004B RID: 75
		private global::Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;

		// Token: 0x0400004C RID: 76
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;

		// Token: 0x0400004D RID: 77
		private global::Guna.UI2.WinForms.Guna2Transition reg;
	}
}
