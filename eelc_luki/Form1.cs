using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using eelc_luki.Properties;

namespace eelc_luki
{
	public class Form1 : Form
	{
		private string msgbox1HlavickaHlaska = "EELC :: Upozornenie";
//		private string msgbox2HlavickaHlaska = "EELC :: Info";
		private string msgbox3HlavickaHlaska = "EELC :: Akcia dokončená";
		private string fileNotFoundHlaska = "Súbor 'zoznamAdminUctov' sa nenašiel.";
		private string entryArchivedHlaska = "Záznam bol archivovaný. Nájdeš ho v archíve záznamov.";
		private string emptyArchiveEntryHlaska = "Vyber prosím záznam ktorý chceš archivovať.";
		public static string appName = "EELC";
		public static string version = "20221.201539";
		public static string datum = DateTime.Today.ToString("dd.MM.yyyy");
		public static string uzivatel = Environment.UserName;
		public static string nazovpc = Environment.MachineName;
		private IContainer components = null;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel stripVerzia;
		private ToolStripStatusLabel toolStripStatusLabel2;
		private ToolStripStatusLabel stripDatum;
		private ToolStripStatusLabel toolStripStatusLabel4;
		private ToolStripStatusLabel stripCas;
		private ToolStripStatusLabel toolStripStatusLabel6;
		private ToolStripStatusLabel stripUzivatel;
		private ToolStripStatusLabel toolStripStatusLabel8;
		private ToolStripStatusLabel stripPCName;
		private ToolStripStatusLabel toolStripStatusLabel10;
		private Timer timer1;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem súborToolStripMenuItem;
		private GroupBox groupBox1;
		private Button button4;
		private Button button3;
		private Button button2;
		private Button button1;
		private Button button8;
		private Button button7;
		private Button button5;
		public ListBox LbZoznamZaznamov;
		private ToolStripMenuItem helpToolStripMenuItem;
		private GroupBox groupBox2;
		private ToolStripMenuItem helpToolStripMenuItem1;
		private GroupBox groupBox3;
		public ToolStripStatusLabel statApp;
		private ToolStripStatusLabel toolStripStatusLabel1;
		private GroupBox groupBox4;
		private GroupBox groupBox5;
		public ListBox LbadminLog;
		private ToolStripMenuItem podmienkyPoužívaniaToolStripMenuItem;
		private NotifyIcon notifyIcon1;
		private ToolStripMenuItem tuZatiaľNičNieJeToolStripMenuItem;
		private PrintDocument printer;
		private PrintDialog printDialog1;
		public ListBox LbPrehladUzivatelov;
		private Label label1;
		private ToolStripMenuItem zoznamZmienToolStripMenuItem;
		private ToolStripStatusLabel toolStripStatusLabel3;

		public Form1()
		{
			InitializeComponent();
			Text = appName + " [user: " + uzivatel + "]";
			timer1.Start();
			CreateConfigurationFiles();
			if ((bool)Settings.Default["FirstRun"])
			{
				Settings.Default["FirstRun"] = false;
				Settings.Default.Save();
				MessageBox.Show("Prečítaj si prosím nápovedu k aplikácii", "EELC :: Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		private void CreateConfigurationFiles()
		{
			try
			{
				if (!Directory.Exists("data"))
				{
					DirectoryInfo directoryInfo = Directory.CreateDirectory("data");
					directoryInfo.Attributes = FileAttributes.Hidden | FileAttributes.Directory;
				}
				if (!File.Exists("data\\zoznamPracFill"))
				{
					File.Create("data\\zoznamPracFill");
				}
				if (!File.Exists("data\\zoznamMienZiakov"))
				{
					File.Create("data\\zoznamMienZiakov");
				}
				if (!File.Exists("data\\zoznamPrac"))
				{
					File.Create("data\\zoznamPrac");
				}
				if (!File.Exists("data\\userLog"))
				{
					File.Create("data\\userLog");
				}
				if (!File.Exists("data\\adminLog"))
				{
					File.Create("data\\adminLog");
				}
				if (!File.Exists("data\\zoznamTypovZaznamov"))
				{
					File.Create("data\\zoznamTypovZaznamov");
				}
				if (!File.Exists("data\\zoznamHodnotei"))
				{
					File.Create("data\\zoznamHodnoteni");
				}
				if (!File.Exists("data\\zoznamTried"))
				{
					File.Create("data\\zoznamTried");
				}
				if (!File.Exists("data\\zoznamZaznamov"))
				{
					File.Create("data\\zoznamZaznamov");
				}
				if (!File.Exists("data\\zoznamAdminUctov"))
				{
					File.Create("data\\zoznamAdminUctov");
				}
				if (!File.Exists("data\\archiv"))
				{
					File.Create("data\\archiv");
				}
				FillConfigurationFiles("data\\zoznamPracFill");
				FillConfigurationFiles("data\\zoznamMienZiakov");
				FillConfigurationFiles("data\\zoznamPrac");
				FillConfigurationFiles("data\\userLog");
				FillConfigurationFiles("data\\adminLog");
				FillConfigurationFiles("data\\zoznamTypovZaznamov");
				FillConfigurationFiles("data\\zoznamHodnoteni");
				FillConfigurationFiles("data\\zoznamTried");
				FillConfigurationFiles("data\\zoznamZaznamov");
				FillConfigurationFiles("data\\zoznamAdminUctov");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void FillConfigurationFiles(string file)
		{
			try
			{
				if (!File.Exists(file))
				{
					return;
				}
				StreamWriter streamWriter = new StreamWriter(file);
				if (file == "data\\zoznamAdminUctov")
				{
					streamWriter.WriteLine(uzivatel);
					streamWriter.WriteLine(nazovpc);
				}
				if (file == "data\\zoznamZaznamov")
				{
				}
				if (file == "data\\zoznamTried")
				{
					streamWriter.WriteLine("1.A");
					streamWriter.WriteLine("1.C");
					streamWriter.WriteLine("1.D");
					streamWriter.WriteLine("1.EA");
					streamWriter.WriteLine("1.EB");
					streamWriter.WriteLine("1.EC");
					streamWriter.WriteLine("1.EE");
					streamWriter.WriteLine("2.CE");
					streamWriter.WriteLine("2.D");
					streamWriter.WriteLine("2.DT");
					streamWriter.WriteLine("2.EA");
					streamWriter.WriteLine("2.EB");
					streamWriter.WriteLine("3.CE");
					streamWriter.WriteLine("3.D");
					streamWriter.WriteLine("3.DT");
					streamWriter.WriteLine("3.EA");
					streamWriter.WriteLine("3.EB");
					streamWriter.WriteLine("4.CT");
					streamWriter.WriteLine("4.D");
					streamWriter.WriteLine("4.EA");
					streamWriter.WriteLine("4.EB");
				}
				if (file == "data\\zoznamHodnoteni")
				{
				}
				if (file == "data\\zoznamTypovZaznamov")
				{
					streamWriter.WriteLine("Odovzdane");
					streamWriter.WriteLine("Prijate");
				}
				if (file == "data\\adminLog")
				{
				}
				if (file == "data\\zoznamPrac")
				{
					streamWriter.WriteLine("Meranie napatia a prudu");
					streamWriter.WriteLine("Meranie odporov priamou metodou");
					streamWriter.WriteLine("Meranie odporov nepriamou metodou");
					streamWriter.WriteLine("Meranie parametrov technickej cievky");
					streamWriter.WriteLine("Meranie kapacity");
					streamWriter.WriteLine("Meranie na rezonancnych obvodoch");
					streamWriter.WriteLine("Meranie vykonu jednosmerneho prudu");
					streamWriter.WriteLine("Meranie vykonu striedaveho prudu");
				}
				if (file == "data\\zoznamMienZiakov")
				{
					for (int i = 0; i < 50; i++)
					{
						streamWriter.WriteLine("Meno Priezvisko {0}", i);
					}
				}
				if (file == "data\\zoznamPracFill")
				{
				}
				streamWriter.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			stripCas.Text = DateTime.Now.ToString("HH:mm:ss");
			stripVerzia.Text = $"{version}";
			stripDatum.Text = $"{datum}";
			stripUzivatel.Text = uzivatel;
			stripPCName.Text = nazovpc;
			CheckAdmin();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			stripCas.Text = DateTime.Now.ToString("HH:mm:ss");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				CreateEntry createEntry = new CreateEntry();
				createEntry.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (File.Exists("data\\zoznamPracFill"))
			{
				File.WriteAllText("data\\zoznamPracFill", string.Empty);
			}
			Application.Exit();
		}

		private void podmienkyPoužívaniaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			About about = new About();
			about.Show();
		}

		public void PopulateListBox(ListBox lsb, string Folder, string FileType)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Folder);
			FileInfo[] files = directoryInfo.GetFiles(FileType);
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				lsb.Items.Add(fileInfo.Name);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			UserRegistration userRegistration = new UserRegistration();
			userRegistration.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Archive archive = new Archive();
			if (LbZoznamZaznamov.SelectedItem != null)
			{
				if (File.Exists("data\\archiv.eelcdatafile"))
				{
					File.Delete("data\\archiv.eelcdatafile");
				}
				File.Copy("data\\zoznamPracFill", "data\\archiv.eelcdatafile");
				MessageBox.Show(entryArchivedHlaska, msgbox3HlavickaHlaska, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				MessageBox.Show(emptyArchiveEntryHlaska, msgbox1HlavickaHlaska, MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			Archive archive = new Archive();
			archive.Show();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			Setup setup = new Setup();
			setup.Show();
		}

		private void CheckAdmin()
		{
			try
			{
				if (File.Exists("data\\zoznamAdminUctov.eelcdatafile"))
				{
					string text = File.ReadAllText("data\\zoznamAdminUctov.eelcdatafile");
					if (text.Contains(uzivatel) && text.Contains(nazovpc))
					{
						Setup setup = new Setup();
						setup.button6.Enabled = true;
						button8.Enabled = true;
					}
				}
				else
				{
					MessageBox.Show(fileNotFoundHlaska, msgbox1HlavickaHlaska, MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void zoznamZmienToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ChangeLog changeLog = new ChangeLog();
			changeLog.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			printDialog1.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripVerzia = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripDatum = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripCas = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripUzivatel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripPCName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel10 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statApp = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.súborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tuZatiaľNičNieJeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.podmienkyPoužívaniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoznamZmienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.LbZoznamZaznamov = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LbPrehladUzivatelov = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.LbadminLog = new System.Windows.Forms.ListBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.printer = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.stripVerzia,
            this.toolStripStatusLabel2,
            this.stripDatum,
            this.toolStripStatusLabel4,
            this.stripCas,
            this.toolStripStatusLabel6,
            this.stripUzivatel,
            this.toolStripStatusLabel8,
            this.stripPCName,
            this.toolStripStatusLabel10,
            this.statApp,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(40, 17);
            this.toolStripStatusLabel3.Text = "Verzia:";
            // 
            // stripVerzia
            // 
            this.stripVerzia.ForeColor = System.Drawing.Color.Red;
            this.stripVerzia.Name = "stripVerzia";
            this.stripVerzia.Size = new System.Drawing.Size(70, 17);
            this.stripVerzia.Text = "0.00.00.0000";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(46, 17);
            this.toolStripStatusLabel2.Text = "Dátum:";
            // 
            // stripDatum
            // 
            this.stripDatum.ForeColor = System.Drawing.Color.Fuchsia;
            this.stripDatum.Name = "stripDatum";
            this.stripDatum.Size = new System.Drawing.Size(61, 17);
            this.stripDatum.Text = "00.00.0000";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(29, 17);
            this.toolStripStatusLabel4.Text = "Čas:";
            // 
            // stripCas
            // 
            this.stripCas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.stripCas.Name = "stripCas";
            this.stripCas.Size = new System.Drawing.Size(49, 17);
            this.stripCas.Text = "00:00:00";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(52, 17);
            this.toolStripStatusLabel6.Text = "Užívateľ:";
            // 
            // stripUzivatel
            // 
            this.stripUzivatel.ForeColor = System.Drawing.Color.Aqua;
            this.stripUzivatel.Name = "stripUzivatel";
            this.stripUzivatel.Size = new System.Drawing.Size(29, 17);
            this.stripUzivatel.Text = "user";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatusLabel8.Text = "Počítač:";
            // 
            // stripPCName
            // 
            this.stripPCName.ForeColor = System.Drawing.Color.Lime;
            this.stripPCName.Name = "stripPCName";
            this.stripPCName.Size = new System.Drawing.Size(20, 17);
            this.stripPCName.Text = "pc";
            // 
            // toolStripStatusLabel10
            // 
            this.toolStripStatusLabel10.Name = "toolStripStatusLabel10";
            this.toolStripStatusLabel10.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel10.Text = "Status:";
            // 
            // statApp
            // 
            this.statApp.ForeColor = System.Drawing.Color.Blue;
            this.statApp.Name = "statApp";
            this.statApp.Size = new System.Drawing.Size(107, 17);
            this.statApp.Text = "EELC inicializovaná";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(191, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "Autor: Lukáš \"LUKI\" Maár";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.súborToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.zoznamZmienToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // súborToolStripMenuItem
            // 
            this.súborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tuZatiaľNičNieJeToolStripMenuItem});
            this.súborToolStripMenuItem.Name = "súborToolStripMenuItem";
            this.súborToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.súborToolStripMenuItem.Text = "Súbor";
            // 
            // tuZatiaľNičNieJeToolStripMenuItem
            // 
            this.tuZatiaľNičNieJeToolStripMenuItem.Name = "tuZatiaľNičNieJeToolStripMenuItem";
            this.tuZatiaľNičNieJeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.tuZatiaľNičNieJeToolStripMenuItem.Text = "Tu zatiaľ nič nie je";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.podmienkyPoužívaniaToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.helpToolStripMenuItem.Text = "Pomoc";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.helpToolStripMenuItem1.Text = "Nápoveda";
            // 
            // podmienkyPoužívaniaToolStripMenuItem
            // 
            this.podmienkyPoužívaniaToolStripMenuItem.Name = "podmienkyPoužívaniaToolStripMenuItem";
            this.podmienkyPoužívaniaToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.podmienkyPoužívaniaToolStripMenuItem.Text = "O aplikácii";
            this.podmienkyPoužívaniaToolStripMenuItem.Click += new System.EventHandler(this.podmienkyPoužívaniaToolStripMenuItem_Click);
            // 
            // zoznamZmienToolStripMenuItem
            // 
            this.zoznamZmienToolStripMenuItem.Name = "zoznamZmienToolStripMenuItem";
            this.zoznamZmienToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.zoznamZmienToolStripMenuItem.Text = "Zoznam zmien";
            this.zoznamZmienToolStripMenuItem.Click += new System.EventHandler(this.zoznamZmienToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 275);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Správa záznamov";
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button7.Location = new System.Drawing.Point(21, 187);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(159, 36);
            this.button7.TabIndex = 12;
            this.button7.Text = "Zobraziť archív";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.Blue;
            this.button5.Location = new System.Drawing.Point(21, 229);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 36);
            this.button5.TabIndex = 10;
            this.button5.Text = "Tlačiť záznamy";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.Location = new System.Drawing.Point(21, 145);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 36);
            this.button4.TabIndex = 9;
            this.button4.Text = "Archivovať záznam";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(21, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 36);
            this.button3.TabIndex = 8;
            this.button3.Text = "Náhľad";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Fuchsia;
            this.button2.Location = new System.Drawing.Point(21, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "Zúčastniť sa / Prihlásiť sa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(21, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Vytvoriť záznam";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.ForeColor = System.Drawing.Color.Red;
            this.button8.Location = new System.Drawing.Point(15, 28);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(159, 36);
            this.button8.TabIndex = 13;
            this.button8.Text = "EELC ADMIN PANEL";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // LbZoznamZaznamov
            // 
            this.LbZoznamZaznamov.FormattingEnabled = true;
            this.LbZoznamZaznamov.Location = new System.Drawing.Point(6, 19);
            this.LbZoznamZaznamov.Name = "LbZoznamZaznamov";
            this.LbZoznamZaznamov.Size = new System.Drawing.Size(555, 82);
            this.LbZoznamZaznamov.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Location = new System.Drawing.Point(18, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 82);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Administrácia EELC";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LbZoznamZaznamov);
            this.groupBox3.Location = new System.Drawing.Point(221, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(567, 117);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Evidencia elaborátov";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LbPrehladUzivatelov);
            this.groupBox4.Location = new System.Drawing.Point(221, 150);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(567, 117);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Prehľad užívateľov";
            // 
            // LbPrehladUzivatelov
            // 
            this.LbPrehladUzivatelov.FormattingEnabled = true;
            this.LbPrehladUzivatelov.Location = new System.Drawing.Point(6, 22);
            this.LbPrehladUzivatelov.Name = "LbPrehladUzivatelov";
            this.LbPrehladUzivatelov.Size = new System.Drawing.Size(555, 82);
            this.LbPrehladUzivatelov.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.LbadminLog);
            this.groupBox5.Location = new System.Drawing.Point(221, 273);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(567, 117);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Prehľad administratívnych úkonov";
            // 
            // LbadminLog
            // 
            this.LbadminLog.FormattingEnabled = true;
            this.LbadminLog.Location = new System.Drawing.Point(6, 22);
            this.LbadminLog.Name = "LbadminLog";
            this.LbadminLog.Size = new System.Drawing.Size(555, 82);
            this.LbadminLog.TabIndex = 3;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipTitle = "EELC beží";
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(127, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Elektronická Evidencia Laboratórnych Cvičení (\"EELC\")";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	}
}
