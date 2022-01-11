using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace eelc_luki
{
	public class Archive : Form
	{
		private string msgboxHlavickaHlaska = "EELC :: Upozornenie";

		private string fileNotFoundHlaska = "Súbor 'archiv' sa nenašiel.";

		private IContainer components = null;

		public ListBox LbArchivovaneZaznamy;

		public Archive()
		{
			InitializeComponent();
		}

		private void Archive_Load(object sender, EventArgs e)
		{
			if (File.Exists("data\\archiv"))
			{
				string[] array = File.ReadAllLines("data\\archiv");
				string[] array2 = array;
				foreach (string item in array2)
				{
					LbArchivovaneZaznamy.Items.Add(item);
				}
			}
			else
			{
				MessageBox.Show(fileNotFoundHlaska, msgboxHlavickaHlaska, MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eelc_luki.Archive));
			LbArchivovaneZaznamy = new System.Windows.Forms.ListBox();
			SuspendLayout();
			LbArchivovaneZaznamy.FormattingEnabled = true;
			LbArchivovaneZaznamy.Location = new System.Drawing.Point(7, 12);
			LbArchivovaneZaznamy.Name = "LbArchivovaneZaznamy";
			LbArchivovaneZaznamy.Size = new System.Drawing.Size(793, 420);
			LbArchivovaneZaznamy.TabIndex = 0;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(800, 450);
			base.Controls.Add(LbArchivovaneZaznamy);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		//	base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "Archive";
			Text = "Archív záznamov";
			base.Load += new System.EventHandler(Archive_Load);
			ResumeLayout(false);
		}
	}
}
