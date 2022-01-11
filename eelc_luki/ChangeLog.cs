using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace eelc_luki
{
	public class ChangeLog : Form
	{
		private IContainer components = null;

		private RichTextBox richTextBox1;

		public ChangeLog()
		{
			InitializeComponent();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eelc_luki.ChangeLog));
			richTextBox1 = new System.Windows.Forms.RichTextBox();
			SuspendLayout();
			richTextBox1.Location = new System.Drawing.Point(9, 7);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.ReadOnly = true;
			richTextBox1.Size = new System.Drawing.Size(787, 438);
			richTextBox1.TabIndex = 0;
//			richTextBox1.Text = resources.GetString("richTextBox1.Text");
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			base.ClientSize = new System.Drawing.Size(800, 450);
			base.Controls.Add(richTextBox1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		//	base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ChangeLog";
			Text = "Zoznam zmien";
			ResumeLayout(false);
		}
	}
}
