using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace eelc_luki
{
	public class Setup : Form
	{
		private string msgboxHlavickaHlaska = "EELC :: Info";
		private string areyousureHlaska = "Si si istý že chceš premazať archív ?";
		private IContainer components = null;
		private ContextMenuStrip contextMenuStrip1;
		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
		private Button button5;
		public Button button6;
		public Button button7;

		public Setup()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (File.Exists("data\\zoznamPrac"))
			{
				Process.Start("notepad.exe", "data\\zoznamPrac");
			}
			else
			{
				MessageBox.Show("Súbor 'zoznamPrac' neexistuje! Skontrolujte si prosím dáta používajúce EELC", "EELC :: Upozornenie", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (File.Exists("data\\zoznamMienZiakov"))
			{
				Process.Start("notepad.exe", "data\\zoznamMienZiakov");
			}
			else
			{
				MessageBox.Show("Súbor 'zoznamMienZiakov.eelcdatafile' neexistuje! Skontrolujte si prosím dáta používajúce EELC", "EELC :: Upozornenie", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (File.Exists("data\\zoznamTypovZaznamov"))
			{
				Process.Start("notepad.exe", "data\\zoznamTypovZaznamov");
			}
			else
			{
				MessageBox.Show("Súbor 'zoznamTypovZaznamov' neexistuje! Skontrolujte si prosím dáta používajúce EELC", "EELC :: Upozornenie", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (File.Exists("data\\zoznamHodnoteni"))
			{
				Process.Start("notepad.exe", "data\\zoznamHodnoteni");
			}
			else
			{
				MessageBox.Show("Súbor 'zoznamHodnoteni' neexistuje! Skontrolujte si prosím dáta používajúce EELC", "EELC :: Upozornenie", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (File.Exists("data\\zoznamTried"))
			{
				Process.Start("notepad.exe", "data\\zoznamTried");
			}
			else
			{
				MessageBox.Show("Súbor 'zoznamPrac' neexistuje! Skontrolujte si prosím dáta používajúce EELC", "EELC :: Upozornenie", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (File.Exists("data\\zoznamAdminUctov"))
			{
				Process.Start("notepad.exe", "data\\zoznamAdminUctov");
			}
			else
			{
				MessageBox.Show("Súbor 'zoznamAdminUctov' neexistuje! Skontrolujte si prosím dáta používajúce EELC", "EELC :: Upozornenie", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			switch (MessageBox.Show(areyousureHlaska,msgboxHlavickaHlaska,MessageBoxButtons.YesNo,MessageBoxIcon.Question))
			{
			case DialogResult.Yes:
				if (File.Exists("data\\archiv"))
				{
					File.WriteAllText("data\\archiv", string.Empty);
				}
				else
				{
					MessageBox.Show("Súbor 'archiv' neexistuje! Skontrolujte si prosím dáta používajúce EELC", "EELC :: Upozornenie", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			break;
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eelc_luki.Setup));
			contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
			button1 = new System.Windows.Forms.Button();
			button2 = new System.Windows.Forms.Button();
			button3 = new System.Windows.Forms.Button();
			button4 = new System.Windows.Forms.Button();
			button5 = new System.Windows.Forms.Button();
			button6 = new System.Windows.Forms.Button();
			button7 = new System.Windows.Forms.Button();
			SuspendLayout();
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			button1.Location = new System.Drawing.Point(45, 25);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(129, 34);
			button1.TabIndex = 1;
			button1.Text = "Zoznam prác";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(button1_Click);
			button2.Location = new System.Drawing.Point(45, 65);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(129, 34);
			button2.TabIndex = 2;
			button2.Text = "Zoznam mien";
			button2.UseVisualStyleBackColor = true;
			button2.Click += new System.EventHandler(button2_Click);
			button3.Location = new System.Drawing.Point(45, 105);
			button3.Name = "button3";
			button3.Size = new System.Drawing.Size(129, 34);
			button3.TabIndex = 3;
			button3.Text = "Zoznam typov záznamov";
			button3.UseVisualStyleBackColor = true;
			button3.Click += new System.EventHandler(button3_Click);
			button4.Enabled = false;
			button4.Location = new System.Drawing.Point(45, 145);
			button4.Name = "button4";
			button4.Size = new System.Drawing.Size(129, 34);
			button4.TabIndex = 4;
			button4.Text = "Zoznam hodnotení";
			button4.UseVisualStyleBackColor = true;
			button4.Click += new System.EventHandler(button4_Click);
			button5.Location = new System.Drawing.Point(45, 185);
			button5.Name = "button5";
			button5.Size = new System.Drawing.Size(129, 34);
			button5.TabIndex = 5;
			button5.Text = "Zoznam tried";
			button5.UseVisualStyleBackColor = true;
			button5.Click += new System.EventHandler(button5_Click);
			button6.Location = new System.Drawing.Point(45, 225);
			button6.Name = "button6";
			button6.Size = new System.Drawing.Size(129, 34);
			button6.TabIndex = 6;
			button6.Text = "Zoznam admin účtov";
			button6.UseVisualStyleBackColor = true;
			button6.Click += new System.EventHandler(button6_Click);
			button7.Location = new System.Drawing.Point(45, 265);
			button7.Name = "button7";
			button7.Size = new System.Drawing.Size(129, 34);
			button7.TabIndex = 7;
			button7.Text = "Premazať archív";
			button7.UseVisualStyleBackColor = true;
			button7.Click += new System.EventHandler(button7_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(220, 308);
			base.Controls.Add(button7);
			base.Controls.Add(button6);
			base.Controls.Add(button5);
			base.Controls.Add(button4);
			base.Controls.Add(button3);
			base.Controls.Add(button2);
			base.Controls.Add(button1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			//base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Setup";
			Text = "EELC-AP";
			ResumeLayout(false);
		}
	}
}
