using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace eelc_luki
{
	public class CreateEntry : Form
	{
		private string msgboxHlavickaHlaska = "EELC :: Upozornenie";

		private string fieldEmptyHlaska = "Vyplň prosím všetky dáta!";

		private string file1NotFoundHlaska = "Súbor 'zoznamPracFill' sa nenašiel.";

		private string file2NotFoundHlaska = "Súbor 'adminLog' sa nenašiel.";

		private string file3NotFoundHlaska = "Súbor 'userLog' sa nenašiel.";

		private IContainer components = null;

		private Label label1;

		private Label label2;

		private Label label3;

		private Label label4;

		private Label label5;

		private Label label6;

		private ComboBox comboboxik_nazovPrace;

		private ComboBox comboboxik_menoZiaka;

		private ComboBox comboboxik_trieda;

		private ComboBox comboboxik_casOdovzd;

		private ComboBox comboboxik_hodnotenie;

		private CheckBox checkBox1;

		private CheckBox checkBox2;

		private CheckBox checkBox3;

		private CheckBox checkBox5;

		private CheckBox checkBox6;

		private Button button1;

		private DateTimePicker dateTimePicker1;

		private CheckBox stayOpened;

		public CreateEntry()
		{
			InitializeComponent();
			CreateEntry_Load();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				comboboxik_nazovPrace.DropDownStyle = ComboBoxStyle.DropDown;
				string text = comboboxik_nazovPrace.Text;
			}
			else
			{
				comboboxik_nazovPrace.DropDownStyle = ComboBoxStyle.DropDownList;
				string text2 = comboboxik_nazovPrace.SelectedItem.ToString();
			}
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox2.Checked)
			{
				comboboxik_menoZiaka.DropDownStyle = ComboBoxStyle.DropDown;
				string text = comboboxik_menoZiaka.Text;
			}
			else
			{
				comboboxik_menoZiaka.DropDownStyle = ComboBoxStyle.DropDownList;
				string text2 = comboboxik_menoZiaka.SelectedItem.ToString();
			}
		}

		private void checkBox5_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox5.Checked)
			{
				string text = comboboxik_casOdovzd.Text;
				comboboxik_casOdovzd.DropDownStyle = ComboBoxStyle.DropDown;
			}
			else
			{
				comboboxik_casOdovzd.DropDownStyle = ComboBoxStyle.DropDownList;
				string text2 = comboboxik_casOdovzd.SelectedItem.ToString();
			}
		}

		private void checkBox6_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox6.Checked)
			{
				comboboxik_hodnotenie.DropDownStyle = ComboBoxStyle.DropDown;
				string text = comboboxik_hodnotenie.Text;
			}
			else
			{
				comboboxik_hodnotenie.DropDownStyle = ComboBoxStyle.DropDownList;
				string text2 = comboboxik_hodnotenie.SelectedItem.ToString();
			}
		}

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox3.Checked)
			{
				comboboxik_trieda.DropDownStyle = ComboBoxStyle.DropDown;
				string text = comboboxik_trieda.Text;
			}
			else
			{
				comboboxik_trieda.DropDownStyle = ComboBoxStyle.DropDownList;
				string text2 = comboboxik_trieda.SelectedItem.ToString();
			}
		}

		private void CreateEntry_Load()
		{
			if (File.Exists("data\\zoznamPrac"))
			{
				string[] array = File.ReadAllLines("data\\zoznamPrac");
				string[] array2 = array;
				foreach (string item in array2)
				{
					comboboxik_nazovPrace.Items.Add(item);
				}
			}
			else
			{
				MessageBox.Show("Súbor 'zoznamPrac' sa nenašiel.", "EELC :: Upozornenie", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			if (File.Exists("data\\zoznamMienZiakov"))
			{
				string[] array3 = File.ReadAllLines("data\\zoznamMienZiakov");
				string[] array4 = array3;
				foreach (string item2 in array4)
				{
					comboboxik_menoZiaka.Items.Add(item2);
				}
			}
			else
			{
				MessageBox.Show("Súbor 'zoznamMienZiakov' sa nenašiel.", "EELC :: Upozornenie", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			if (File.Exists("data\\zoznamTried"))
			{
				string[] array5 = File.ReadAllLines("data\\zoznamTried");
				string[] array6 = array5;
				foreach (string item3 in array6)
				{
					comboboxik_trieda.Items.Add(item3);
				}
			}
			else
			{
				MessageBox.Show("Súbor 'zoznamTried' sa nenašiel.", "EELC :: Upozornenie", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			if (File.Exists("data\\zoznamTypovZaznamov"))
			{
				string[] array7 = File.ReadAllLines("data\\zoznamTypovZaznamov");
				string[] array8 = array7;
				foreach (string item4 in array8)
				{
					comboboxik_casOdovzd.Items.Add(item4);
				}
			}
			else
			{
				MessageBox.Show("Súbor 'zoznamTypovZaznamov' sa nenašiel.", "EELC :: Upozornenie", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			if (File.Exists("data\\zoznamHodnoteni"))
			{
				string[] array9 = File.ReadAllLines("data\\zoznamHodnoteni");
				string[] array10 = array9;
				foreach (string item5 in array10)
				{
					comboboxik_hodnotenie.Items.Add(item5);
				}
			}
			else
			{
				MessageBox.Show("Súbor 'zoznamHodnoteni' sa nenašiel.", "EELC :: Upozornenie", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string text = DateTime.Today.ToString("dd.MM.yyyy") + " - " + DateTime.Now.ToString("HH:mm:ss");
			if (comboboxik_nazovPrace.SelectedIndex > -1)
			{
				text = text + " - " + comboboxik_nazovPrace.SelectedItem.ToString();
			}
			else
			{
				MessageBox.Show(fieldEmptyHlaska, msgboxHlavickaHlaska, MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			if (comboboxik_menoZiaka.SelectedIndex > -1)
			{
				text = text + " - " + comboboxik_menoZiaka.SelectedItem.ToString();
			}
			else
			{
				MessageBox.Show(fieldEmptyHlaska, msgboxHlavickaHlaska, MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			if (comboboxik_trieda.SelectedIndex > -1)
			{
				text = text + " - " + comboboxik_trieda.SelectedItem.ToString();
			}
			else
			{
				MessageBox.Show(fieldEmptyHlaska, msgboxHlavickaHlaska, MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			if (comboboxik_casOdovzd.SelectedIndex > -1)
			{
				text = text + " - " + comboboxik_casOdovzd.SelectedItem.ToString();
			}
			else
			{
				MessageBox.Show(fieldEmptyHlaska, msgboxHlavickaHlaska, MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			if (File.Exists("data\\zoznamPracFill"))
			{
				string[] array = File.ReadAllLines("data\\zoznamPracFill");
				(Application.OpenForms[0] as Form1).LbZoznamZaznamov.Items.Clear();
				string[] array2 = array;
				foreach (string item in array2)
				{
					(Application.OpenForms[0] as Form1).LbZoznamZaznamov.Items.Add(item);
				}
				(Application.OpenForms[0] as Form1).LbZoznamZaznamov.Items.Add(text);
				File.AppendAllText("data\\zoznamPracFill", text + Environment.NewLine);
			}
			else
			{
				MessageBox.Show(file1NotFoundHlaska, msgboxHlavickaHlaska, MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			if (File.Exists("data\\adminLog"))
			{
				string[] array3 = File.ReadAllLines("data\\adminLog");
				string[] array4 = array3;
				foreach (string item2 in array4)
				{
					(Application.OpenForms[0] as Form1).LbadminLog.Items.Add(item2);
				}
			}
			else
			{
				MessageBox.Show(file2NotFoundHlaska, msgboxHlavickaHlaska, MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			if (File.Exists("data\\userLog"))
			{
				string[] array5 = File.ReadAllLines("data\\userLog");
				string[] array6 = array5;
				foreach (string item3 in array6)
				{
					(Application.OpenForms[0] as Form1).LbPrehladUzivatelov.Items.Add(item3);
				}
			}
			else
			{
				MessageBox.Show(file3NotFoundHlaska, msgboxHlavickaHlaska, MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			if (!stayOpened.Checked)
			{
				Close();
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eelc_luki.CreateEntry));
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			label6 = new System.Windows.Forms.Label();
			comboboxik_nazovPrace = new System.Windows.Forms.ComboBox();
			comboboxik_menoZiaka = new System.Windows.Forms.ComboBox();
			comboboxik_trieda = new System.Windows.Forms.ComboBox();
			comboboxik_casOdovzd = new System.Windows.Forms.ComboBox();
			comboboxik_hodnotenie = new System.Windows.Forms.ComboBox();
			checkBox1 = new System.Windows.Forms.CheckBox();
			checkBox2 = new System.Windows.Forms.CheckBox();
			checkBox3 = new System.Windows.Forms.CheckBox();
			checkBox5 = new System.Windows.Forms.CheckBox();
			checkBox6 = new System.Windows.Forms.CheckBox();
			button1 = new System.Windows.Forms.Button();
			dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			stayOpened = new System.Windows.Forms.CheckBox();
			SuspendLayout();
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(51, 26);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(71, 13);
			label1.TabIndex = 0;
			label1.Text = "Názov práce:";
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(51, 114);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(99, 13);
			label2.TabIndex = 1;
			label2.Text = "Dátum odovzdania:";
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(51, 139);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(70, 13);
			label3.TabIndex = 2;
			label3.Text = "Typ záznamu";
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(51, 163);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(95, 13);
			label4.TabIndex = 3;
			label4.Text = "Hodnotenie práce:";
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(51, 59);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(65, 13);
			label5.TabIndex = 4;
			label5.Text = "Meno žiaka:";
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(51, 87);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(40, 13);
			label6.TabIndex = 5;
			label6.Text = "Trieda:";
			comboboxik_nazovPrace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			comboboxik_nazovPrace.FormattingEnabled = true;
			comboboxik_nazovPrace.Location = new System.Drawing.Point(152, 24);
			comboboxik_nazovPrace.Name = "comboboxik_nazovPrace";
			comboboxik_nazovPrace.Size = new System.Drawing.Size(240, 21);
			comboboxik_nazovPrace.TabIndex = 6;
			comboboxik_menoZiaka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			comboboxik_menoZiaka.FormattingEnabled = true;
			comboboxik_menoZiaka.Location = new System.Drawing.Point(152, 51);
			comboboxik_menoZiaka.Name = "comboboxik_menoZiaka";
			comboboxik_menoZiaka.Size = new System.Drawing.Size(240, 21);
			comboboxik_menoZiaka.TabIndex = 7;
			comboboxik_trieda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			comboboxik_trieda.FormattingEnabled = true;
			comboboxik_trieda.Location = new System.Drawing.Point(152, 79);
			comboboxik_trieda.Name = "comboboxik_trieda";
			comboboxik_trieda.Size = new System.Drawing.Size(240, 21);
			comboboxik_trieda.TabIndex = 8;
			comboboxik_casOdovzd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			comboboxik_casOdovzd.FormattingEnabled = true;
			comboboxik_casOdovzd.Location = new System.Drawing.Point(152, 133);
			comboboxik_casOdovzd.Name = "comboboxik_casOdovzd";
			comboboxik_casOdovzd.Size = new System.Drawing.Size(240, 21);
			comboboxik_casOdovzd.TabIndex = 10;
			comboboxik_hodnotenie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			comboboxik_hodnotenie.Enabled = false;
			comboboxik_hodnotenie.FormattingEnabled = true;
			comboboxik_hodnotenie.Location = new System.Drawing.Point(152, 160);
			comboboxik_hodnotenie.Name = "comboboxik_hodnotenie";
			comboboxik_hodnotenie.Size = new System.Drawing.Size(240, 21);
			comboboxik_hodnotenie.TabIndex = 11;
			checkBox1.AutoSize = true;
			checkBox1.Enabled = false;
			checkBox1.Location = new System.Drawing.Point(398, 26);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new System.Drawing.Size(40, 17);
			checkBox1.TabIndex = 12;
			checkBox1.Text = "Iný";
			checkBox1.UseVisualStyleBackColor = true;
			checkBox1.CheckedChanged += new System.EventHandler(checkBox1_CheckedChanged);
			checkBox2.AutoSize = true;
			checkBox2.Enabled = false;
			checkBox2.Location = new System.Drawing.Point(398, 55);
			checkBox2.Name = "checkBox2";
			checkBox2.Size = new System.Drawing.Size(41, 17);
			checkBox2.TabIndex = 13;
			checkBox2.Text = "Iné";
			checkBox2.UseVisualStyleBackColor = true;
			checkBox2.CheckedChanged += new System.EventHandler(checkBox2_CheckedChanged);
			checkBox3.AutoSize = true;
			checkBox3.Enabled = false;
			checkBox3.Location = new System.Drawing.Point(397, 83);
			checkBox3.Name = "checkBox3";
			checkBox3.Size = new System.Drawing.Size(41, 17);
			checkBox3.TabIndex = 14;
			checkBox3.Text = "Iná";
			checkBox3.UseVisualStyleBackColor = true;
			checkBox3.CheckedChanged += new System.EventHandler(checkBox3_CheckedChanged);
			checkBox5.AutoSize = true;
			checkBox5.Enabled = false;
			checkBox5.Location = new System.Drawing.Point(397, 135);
			checkBox5.Name = "checkBox5";
			checkBox5.Size = new System.Drawing.Size(40, 17);
			checkBox5.TabIndex = 16;
			checkBox5.Text = "Iný";
			checkBox5.UseVisualStyleBackColor = true;
			checkBox5.CheckedChanged += new System.EventHandler(checkBox5_CheckedChanged);
			checkBox6.AutoSize = true;
			checkBox6.Enabled = false;
			checkBox6.Location = new System.Drawing.Point(398, 162);
			checkBox6.Name = "checkBox6";
			checkBox6.Size = new System.Drawing.Size(41, 17);
			checkBox6.TabIndex = 17;
			checkBox6.Text = "Iné";
			checkBox6.UseVisualStyleBackColor = true;
			checkBox6.CheckedChanged += new System.EventHandler(checkBox6_CheckedChanged);
			button1.ForeColor = System.Drawing.Color.FromArgb(0, 192, 0);
			button1.Location = new System.Drawing.Point(54, 187);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(171, 33);
			button1.TabIndex = 18;
			button1.Text = "Vytvoriť záznam";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(button1_Click);
			dateTimePicker1.Location = new System.Drawing.Point(152, 107);
			dateTimePicker1.MaxDate = new System.DateTime(2056, 12, 31, 0, 0, 0, 0);
			dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			dateTimePicker1.TabIndex = 19;
			stayOpened.AutoSize = true;
			stayOpened.Location = new System.Drawing.Point(302, 196);
			stayOpened.Name = "stayOpened";
			stayOpened.Size = new System.Drawing.Size(135, 17);
			stayOpened.TabIndex = 20;
			stayOpened.Text = "Nechať okno spustené";
			stayOpened.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(485, 227);
			base.Controls.Add(stayOpened);
			base.Controls.Add(dateTimePicker1);
			base.Controls.Add(button1);
			base.Controls.Add(checkBox6);
			base.Controls.Add(checkBox5);
			base.Controls.Add(checkBox3);
			base.Controls.Add(checkBox2);
			base.Controls.Add(checkBox1);
			base.Controls.Add(comboboxik_hodnotenie);
			base.Controls.Add(comboboxik_casOdovzd);
			base.Controls.Add(comboboxik_trieda);
			base.Controls.Add(comboboxik_menoZiaka);
			base.Controls.Add(comboboxik_nazovPrace);
			base.Controls.Add(label6);
			base.Controls.Add(label5);
			base.Controls.Add(label4);
			base.Controls.Add(label3);
			base.Controls.Add(label2);
			base.Controls.Add(label1);
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "CreateEntry";
			Text = "Vytvorenie záznamu";
			ResumeLayout(false);
			PerformLayout();
		}
	}
}
