using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace eelc_luki
{
	public class About : Form
	{
		private IContainer components = null;

		private RichTextBox richTextBox1;

		public About()
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eelc_luki.About));
			richTextBox1 = new System.Windows.Forms.RichTextBox();
			SuspendLayout();
			richTextBox1.Location = new System.Drawing.Point(9, 12);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.ReadOnly = true;
			richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			richTextBox1.Size = new System.Drawing.Size(788, 434);
			richTextBox1.TabIndex = 0;
	//		richTextBox1.Text = resources.GetString("richTextBox1.Text");
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(800, 450);
			base.Controls.Add(richTextBox1);
		//	base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "About";
			Text = "O aplikácii";
			ResumeLayout(false);
		}
	}
}
