using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace eelc_luki
{
	public class UserRegistration : Form
	{
		private string msgboxHlavickaHlaska = "EELC :: Upozornenie";
		private string userExistsHlaska = "Tento užívateľ sa už nachádza v zozname! Nepomýlili ste sa ?";
		private IContainer components = null;
		private TextBox registrovacitb;
		private Button button1;
		private ListBox LbregistrovaniUzivatelia;
		private Label label1;
		private Label label2;
		private Label label3;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private Label label5;
		internal Label LblUpozornenieNeaktualny;
        private TextBox amountRqstTb;
        private CheckBox checkBox2;
        private TextBox textBox1;
        private CheckBox checkBox1;

		public UserRegistration()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
            amountRqstTb.ReadOnly = true;
            if (amountRqstTb.Text == "")  
            {
                amountRqstTb.Text = "10";
                MessageBox.Show("Nevyplnili ste maximálny počet záujemcov! Nastavujem počet na predvolenú hodnotu 10 záujemcov ...", "EELC :: Upozornenie", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
			if (!LbregistrovaniUzivatelia.Items.Contains("Uzivatel s ID  ' " + registrovacitb.Text + " 'uspesne registrovany!"))
			{
				LbregistrovaniUzivatelia.Items.Add("Uzivatel s ID  ' " + registrovacitb.Text + " ' uspesne registrovany!");
				registrovacitb.Focus();
				Naplnenie();
				registrovacitb.Text = string.Empty;
			}
			else
			{
				MessageBox.Show(userExistsHlaska,msgboxHlavickaHlaska,MessageBoxButtons.OK,MessageBoxIcon.Hand);
				registrovacitb.Focus();
			}
		}

		private void Naplnenie()
		{
            if (checkBox2.Checked)
            {
                amountRqstTb.Text = "0";
                label3.Text = "0";
                button1.Enabled = true;
                LblUpozornenieNeaktualny.Visible = false;
                registrovacitb.Enabled = true;
                registrovacitb.Focus();
            }
			else
            {
                int num = Convert.ToInt32(amountRqstTb.Text);
                int num2 = num - LbregistrovaniUzivatelia.Items.Count;
                label3.Text = Convert.ToString(num2);
 //             label4.Text = Convert.ToString(num);
                if (num2 == 0)
                {
                    button1.Enabled = false;
                    LblUpozornenieNeaktualny.Visible = true;
                    registrovacitb.Enabled = false;
                }
                else
                {
                    button1.Enabled = true;
                    LblUpozornenieNeaktualny.Visible = false;
                    registrovacitb.Enabled = true;
                }
                registrovacitb.Focus();
            }
		}

		private void registrovacitb_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (checkBox1.Checked)
			{
				SendKeys.SendWait("{ENTER}");
				registrovacitb.ReadOnly = true;
			}
			else
			{
				registrovacitb.ReadOnly = false;
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
            this.registrovacitb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LbregistrovaniUzivatelia = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.amountRqstTb = new System.Windows.Forms.TextBox();
            this.LblUpozornenieNeaktualny = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // registrovacitb
            // 
            this.registrovacitb.Location = new System.Drawing.Point(15, 19);
            this.registrovacitb.Name = "registrovacitb";
            this.registrovacitb.Size = new System.Drawing.Size(164, 20);
            this.registrovacitb.TabIndex = 0;
            this.registrovacitb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.registrovacitb_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pridať";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LbregistrovaniUzivatelia
            // 
            this.LbregistrovaniUzivatelia.FormattingEnabled = true;
            this.LbregistrovaniUzivatelia.Location = new System.Drawing.Point(6, 52);
            this.LbregistrovaniUzivatelia.Name = "LbregistrovaniUzivatelia";
            this.LbregistrovaniUzivatelia.Size = new System.Drawing.Size(561, 342);
            this.LbregistrovaniUzivatelia.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Maximálny počet užívateľov:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Počet dostupných užívateľov:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(539, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.registrovacitb);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(15, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 83);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrácia nového záujemcu";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 50);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Skenovať";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.amountRqstTb);
            this.groupBox2.Controls.Add(this.LblUpozornenieNeaktualny);
            this.groupBox2.Controls.Add(this.LbregistrovaniUzivatelia);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(209, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(579, 410);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Záznamy registrácie";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(176, 31);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(95, 17);
            this.checkBox2.TabIndex = 44;
            this.checkBox2.Text = "Neobmedzené";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // amountRqstTb
            // 
            this.amountRqstTb.Location = new System.Drawing.Point(143, 29);
            this.amountRqstTb.Name = "amountRqstTb";
            this.amountRqstTb.Size = new System.Drawing.Size(27, 20);
            this.amountRqstTb.TabIndex = 43;
            // 
            // LblUpozornenieNeaktualny
            // 
            this.LblUpozornenieNeaktualny.BackColor = System.Drawing.Color.Firebrick;
            this.LblUpozornenieNeaktualny.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblUpozornenieNeaktualny.ForeColor = System.Drawing.Color.White;
            this.LblUpozornenieNeaktualny.Location = new System.Drawing.Point(6, 180);
            this.LblUpozornenieNeaktualny.Name = "LblUpozornenieNeaktualny";
            this.LblUpozornenieNeaktualny.Size = new System.Drawing.Size(573, 48);
            this.LblUpozornenieNeaktualny.TabIndex = 42;
            this.LblUpozornenieNeaktualny.Text = "Dosiahli ste maximálny počet užívateľov! Vytvorte prosím nový záznam! ";
            this.LblUpozornenieNeaktualny.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblUpozornenieNeaktualny.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(4, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(15, 117);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(188, 321);
            this.textBox1.TabIndex = 10;
            // 
            // UserRegistration
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "UserRegistration";
            this.Text = "Prihlásenie sa / Zúčastnenie sa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
    }
}
