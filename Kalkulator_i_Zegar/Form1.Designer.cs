using System;

namespace Kalkulator_i_Zegar
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        double wynik = 0;
        double pierwszaLiczba = 0;
        double drugaLiczba = 0;
        char dzialanie;
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.jeden = new System.Windows.Forms.Button();
            this.dwa = new System.Windows.Forms.Button();
            this.trzy = new System.Windows.Forms.Button();
            this.cztery = new System.Windows.Forms.Button();
            this.piec = new System.Windows.Forms.Button();
            this.szesc = new System.Windows.Forms.Button();
            this.siedem = new System.Windows.Forms.Button();
            this.osiem = new System.Windows.Forms.Button();
            this.dziewiec = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.przecinek = new System.Windows.Forms.Button();
            this.rownaSie = new System.Windows.Forms.Button();
            this.dodawanie = new System.Windows.Forms.Button();
            this.odejmowanie = new System.Windows.Forms.Button();
            this.mnozenie = new System.Windows.Forms.Button();
            this.dzielenie = new System.Windows.Forms.Button();
            this.czyszczenieWszystko = new System.Windows.Forms.Button();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.wczytajTłoDomyślneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tłoDomyślneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twojeTłoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StyleButton1 = new System.Windows.Forms.Button();
            this.StyleButton2 = new System.Windows.Forms.Button();
            this.StyleButton3 = new System.Windows.Forms.Button();
            this.BlackButton = new System.Windows.Forms.Button();
            this.GreenButton = new System.Windows.Forms.Button();
            this.BlueButton = new System.Windows.Forms.Button();
            this.panelClock = new System.Windows.Forms.Panel();
            this.ChangeClock = new System.Windows.Forms.Button();
            this.kolor_tla1 = new System.Windows.Forms.Button();
            this.kolor_tla2 = new System.Windows.Forms.Button();
            this.kolor_tla3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // jeden
            // 
            this.jeden.Location = new System.Drawing.Point(128, 170);
            this.jeden.Name = "jeden";
            this.jeden.Size = new System.Drawing.Size(75, 23);
            this.jeden.TabIndex = 0;
            this.jeden.Text = "1";
            this.jeden.UseVisualStyleBackColor = true;
            this.jeden.Click += new System.EventHandler(this.jeden_Click);
            this.jeden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // dwa
            // 
            this.dwa.Location = new System.Drawing.Point(208, 170);
            this.dwa.Name = "dwa";
            this.dwa.Size = new System.Drawing.Size(75, 23);
            this.dwa.TabIndex = 1;
            this.dwa.Text = "2";
            this.dwa.UseVisualStyleBackColor = true;
            this.dwa.Click += new System.EventHandler(this.dwa_Click);
            this.dwa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // trzy
            // 
            this.trzy.Location = new System.Drawing.Point(288, 170);
            this.trzy.Name = "trzy";
            this.trzy.Size = new System.Drawing.Size(75, 23);
            this.trzy.TabIndex = 2;
            this.trzy.Text = "3";
            this.trzy.UseVisualStyleBackColor = true;
            this.trzy.Click += new System.EventHandler(this.trzy_Click);
            this.trzy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // cztery
            // 
            this.cztery.Location = new System.Drawing.Point(128, 141);
            this.cztery.Name = "cztery";
            this.cztery.Size = new System.Drawing.Size(75, 23);
            this.cztery.TabIndex = 3;
            this.cztery.Text = "4";
            this.cztery.UseVisualStyleBackColor = true;
            this.cztery.Click += new System.EventHandler(this.cztery_Click);
            this.cztery.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // piec
            // 
            this.piec.Location = new System.Drawing.Point(208, 141);
            this.piec.Name = "piec";
            this.piec.Size = new System.Drawing.Size(75, 23);
            this.piec.TabIndex = 4;
            this.piec.Text = "5";
            this.piec.UseVisualStyleBackColor = true;
            this.piec.Click += new System.EventHandler(this.piec_Click);
            this.piec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // szesc
            // 
            this.szesc.Location = new System.Drawing.Point(288, 141);
            this.szesc.Name = "szesc";
            this.szesc.Size = new System.Drawing.Size(75, 23);
            this.szesc.TabIndex = 5;
            this.szesc.Text = "6";
            this.szesc.UseVisualStyleBackColor = true;
            this.szesc.Click += new System.EventHandler(this.szesc_Click);
            this.szesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // siedem
            // 
            this.siedem.Location = new System.Drawing.Point(128, 109);
            this.siedem.Name = "siedem";
            this.siedem.Size = new System.Drawing.Size(75, 23);
            this.siedem.TabIndex = 6;
            this.siedem.Text = "7";
            this.siedem.UseVisualStyleBackColor = true;
            this.siedem.Click += new System.EventHandler(this.siedem_Click);
            this.siedem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // osiem
            // 
            this.osiem.Location = new System.Drawing.Point(208, 109);
            this.osiem.Name = "osiem";
            this.osiem.Size = new System.Drawing.Size(75, 23);
            this.osiem.TabIndex = 7;
            this.osiem.Text = "8";
            this.osiem.UseVisualStyleBackColor = true;
            this.osiem.Click += new System.EventHandler(this.osiem_Click);
            this.osiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // dziewiec
            // 
            this.dziewiec.Location = new System.Drawing.Point(288, 109);
            this.dziewiec.Name = "dziewiec";
            this.dziewiec.Size = new System.Drawing.Size(75, 23);
            this.dziewiec.TabIndex = 8;
            this.dziewiec.Text = "9";
            this.dziewiec.UseVisualStyleBackColor = true;
            this.dziewiec.Click += new System.EventHandler(this.dziewiec_Click);
            this.dziewiec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(208, 200);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(75, 23);
            this.zero.TabIndex = 9;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            this.zero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // przecinek
            // 
            this.przecinek.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przecinek.Location = new System.Drawing.Point(128, 200);
            this.przecinek.Name = "przecinek";
            this.przecinek.Size = new System.Drawing.Size(75, 23);
            this.przecinek.TabIndex = 10;
            this.przecinek.Text = ",";
            this.przecinek.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.przecinek.UseCompatibleTextRendering = true;
            this.przecinek.UseVisualStyleBackColor = true;
            this.przecinek.Click += new System.EventHandler(this.przecinek_Click);
            this.przecinek.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // rownaSie
            // 
            this.rownaSie.Location = new System.Drawing.Point(288, 200);
            this.rownaSie.Name = "rownaSie";
            this.rownaSie.Size = new System.Drawing.Size(75, 23);
            this.rownaSie.TabIndex = 11;
            this.rownaSie.Text = "=";
            this.rownaSie.UseVisualStyleBackColor = true;
            this.rownaSie.Click += new System.EventHandler(this.rownaSie_Click);
            this.rownaSie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // dodawanie
            // 
            this.dodawanie.Location = new System.Drawing.Point(368, 109);
            this.dodawanie.Name = "dodawanie";
            this.dodawanie.Size = new System.Drawing.Size(75, 23);
            this.dodawanie.TabIndex = 12;
            this.dodawanie.Text = "+";
            this.dodawanie.UseVisualStyleBackColor = true;
            this.dodawanie.Click += new System.EventHandler(this.dodawanie_Click);
            this.dodawanie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // odejmowanie
            // 
            this.odejmowanie.Location = new System.Drawing.Point(368, 141);
            this.odejmowanie.Name = "odejmowanie";
            this.odejmowanie.Size = new System.Drawing.Size(75, 23);
            this.odejmowanie.TabIndex = 13;
            this.odejmowanie.Text = "-";
            this.odejmowanie.UseVisualStyleBackColor = true;
            this.odejmowanie.Click += new System.EventHandler(this.odejmowanie_Click);
            this.odejmowanie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // mnozenie
            // 
            this.mnozenie.Location = new System.Drawing.Point(368, 170);
            this.mnozenie.Name = "mnozenie";
            this.mnozenie.Size = new System.Drawing.Size(75, 23);
            this.mnozenie.TabIndex = 14;
            this.mnozenie.Text = "x";
            this.mnozenie.UseVisualStyleBackColor = true;
            this.mnozenie.Click += new System.EventHandler(this.mnozenie_Click);
            this.mnozenie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // dzielenie
            // 
            this.dzielenie.Location = new System.Drawing.Point(368, 200);
            this.dzielenie.Name = "dzielenie";
            this.dzielenie.Size = new System.Drawing.Size(75, 23);
            this.dzielenie.TabIndex = 15;
            this.dzielenie.Text = ":";
            this.dzielenie.UseVisualStyleBackColor = true;
            this.dzielenie.Click += new System.EventHandler(this.dzielenie_Click);
            this.dzielenie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // czyszczenieWszystko
            // 
            this.czyszczenieWszystko.Location = new System.Drawing.Point(448, 109);
            this.czyszczenieWszystko.Name = "czyszczenieWszystko";
            this.czyszczenieWszystko.Size = new System.Drawing.Size(75, 23);
            this.czyszczenieWszystko.TabIndex = 16;
            this.czyszczenieWszystko.Text = "C";
            this.czyszczenieWszystko.UseVisualStyleBackColor = true;
            this.czyszczenieWszystko.Click += new System.EventHandler(this.czyszczenieWszystko_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip2.Size = new System.Drawing.Size(834, 27);
            this.toolStrip2.TabIndex = 18;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wczytajTłoDomyślneToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::Kalkulator_i_Zegar.Properties.Resources.doge;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(66, 28);
            this.toolStripDropDownButton1.Text = "Plik";
            // 
            // wczytajTłoDomyślneToolStripMenuItem
            // 
            this.wczytajTłoDomyślneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tłoDomyślneToolStripMenuItem,
            this.twojeTłoToolStripMenuItem});
            this.wczytajTłoDomyślneToolStripMenuItem.Name = "wczytajTłoDomyślneToolStripMenuItem";
            this.wczytajTłoDomyślneToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.wczytajTłoDomyślneToolStripMenuItem.Text = "Wczytaj";
            // 
            // tłoDomyślneToolStripMenuItem
            // 
            this.tłoDomyślneToolStripMenuItem.Name = "tłoDomyślneToolStripMenuItem";
            this.tłoDomyślneToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.tłoDomyślneToolStripMenuItem.Text = "Tło domyślne";
            this.tłoDomyślneToolStripMenuItem.Click += new System.EventHandler(this.tłoDomyślneToolStripMenuItem_Click);
            // 
            // twojeTłoToolStripMenuItem
            // 
            this.twojeTłoToolStripMenuItem.Name = "twojeTłoToolStripMenuItem";
            this.twojeTłoToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.twojeTłoToolStripMenuItem.Text = "Twoje tło";
            this.twojeTłoToolStripMenuItem.Click += new System.EventHandler(this.twojeTłoToolStripMenuItem_Click);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(109, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(694, 440);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Twój obrazek";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Image = global::Kalkulator_i_Zegar.Properties.Resources.doge;
            this.label2.Location = new System.Drawing.Point(594, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 79);
            this.label2.TabIndex = 21;
            this.label2.Text = "  ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(128, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(395, 61);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Miriam Mono CLM", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(532, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 44);
            this.label4.TabIndex = 24;
            this.label4.Text = "00:00:00";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StyleButton1
            // 
            this.StyleButton1.Font = new System.Drawing.Font("NSimSun", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StyleButton1.Location = new System.Drawing.Point(486, 441);
            this.StyleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StyleButton1.Name = "StyleButton1";
            this.StyleButton1.Size = new System.Drawing.Size(71, 29);
            this.StyleButton1.TabIndex = 28;
            this.StyleButton1.Text = "Styl 1";
            this.StyleButton1.UseVisualStyleBackColor = true;
            this.StyleButton1.Click += new System.EventHandler(this.StyleButton1_Click);
            // 
            // StyleButton2
            // 
            this.StyleButton2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StyleButton2.Location = new System.Drawing.Point(558, 439);
            this.StyleButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StyleButton2.Name = "StyleButton2";
            this.StyleButton2.Size = new System.Drawing.Size(67, 29);
            this.StyleButton2.TabIndex = 29;
            this.StyleButton2.Text = "Styl 2";
            this.StyleButton2.UseVisualStyleBackColor = true;
            this.StyleButton2.Click += new System.EventHandler(this.StyleButton2_Click);
            // 
            // StyleButton3
            // 
            this.StyleButton3.Font = new System.Drawing.Font("Miriam Mono CLM", 6.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.StyleButton3.Location = new System.Drawing.Point(630, 440);
            this.StyleButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StyleButton3.Name = "StyleButton3";
            this.StyleButton3.Size = new System.Drawing.Size(71, 29);
            this.StyleButton3.TabIndex = 30;
            this.StyleButton3.Text = "Styl 3";
            this.StyleButton3.UseVisualStyleBackColor = true;
            this.StyleButton3.Click += new System.EventHandler(this.StyleButton3_Click);
            // 
            // BlackButton
            // 
            this.BlackButton.BackColor = System.Drawing.Color.Black;
            this.BlackButton.Location = new System.Drawing.Point(776, 443);
            this.BlackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BlackButton.Name = "BlackButton";
            this.BlackButton.Size = new System.Drawing.Size(27, 26);
            this.BlackButton.TabIndex = 31;
            this.BlackButton.UseVisualStyleBackColor = false;
            this.BlackButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // GreenButton
            // 
            this.GreenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.GreenButton.Location = new System.Drawing.Point(707, 443);
            this.GreenButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Size = new System.Drawing.Size(29, 26);
            this.GreenButton.TabIndex = 25;
            this.GreenButton.UseVisualStyleBackColor = false;
            this.GreenButton.Click += new System.EventHandler(this.BlueButton_Click);
            // 
            // BlueButton
            // 
            this.BlueButton.BackColor = System.Drawing.Color.Navy;
            this.BlueButton.Location = new System.Drawing.Point(743, 443);
            this.BlueButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BlueButton.Name = "BlueButton";
            this.BlueButton.Size = new System.Drawing.Size(29, 26);
            this.BlueButton.TabIndex = 27;
            this.BlueButton.UseVisualStyleBackColor = false;
            this.BlueButton.Click += new System.EventHandler(this.PinkButton_Click);
            // 
            // panelClock
            // 
            this.panelClock.BackColor = System.Drawing.Color.Transparent;
            this.panelClock.Location = new System.Drawing.Point(504, 186);
            this.panelClock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelClock.Name = "panelClock";
            this.panelClock.Size = new System.Drawing.Size(279, 219);
            this.panelClock.TabIndex = 32;
            this.panelClock.VisibleChanged += new System.EventHandler(this.ChangeClock_Click);
            this.panelClock.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelClock_Paint);
            // 
            // ChangeClock
            // 
            this.ChangeClock.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ChangeClock.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeClock.Location = new System.Drawing.Point(368, 409);
            this.ChangeClock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangeClock.Name = "ChangeClock";
            this.ChangeClock.Size = new System.Drawing.Size(104, 59);
            this.ChangeClock.TabIndex = 0;
            this.ChangeClock.Text = "Zmień zegar";
            this.ChangeClock.UseVisualStyleBackColor = false;
            this.ChangeClock.Click += new System.EventHandler(this.ChangeClock_Click);
            // 
            // kolor_tla1
            // 
            this.kolor_tla1.BackColor = System.Drawing.Color.CadetBlue;
            this.kolor_tla1.ForeColor = System.Drawing.Color.White;
            this.kolor_tla1.Location = new System.Drawing.Point(16, 142);
            this.kolor_tla1.Name = "kolor_tla1";
            this.kolor_tla1.Size = new System.Drawing.Size(75, 23);
            this.kolor_tla1.TabIndex = 33;
            this.kolor_tla1.UseVisualStyleBackColor = false;
            this.kolor_tla1.Click += new System.EventHandler(this.kolor_tla1_Click);
            // 
            // kolor_tla2
            // 
            this.kolor_tla2.BackColor = System.Drawing.Color.LavenderBlush;
            this.kolor_tla2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kolor_tla2.Location = new System.Drawing.Point(16, 171);
            this.kolor_tla2.Name = "kolor_tla2";
            this.kolor_tla2.Size = new System.Drawing.Size(75, 23);
            this.kolor_tla2.TabIndex = 34;
            this.kolor_tla2.UseVisualStyleBackColor = false;
            this.kolor_tla2.Click += new System.EventHandler(this.kolor_tla2_Click);
            // 
            // kolor_tla3
            // 
            this.kolor_tla3.BackColor = System.Drawing.SystemColors.Control;
            this.kolor_tla3.Location = new System.Drawing.Point(16, 200);
            this.kolor_tla3.Name = "kolor_tla3";
            this.kolor_tla3.Size = new System.Drawing.Size(75, 23);
            this.kolor_tla3.TabIndex = 35;
            this.kolor_tla3.UseVisualStyleBackColor = false;
            this.kolor_tla3.Click += new System.EventHandler(this.kolor_tla3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Kolory tła:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 499);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kolor_tla3);
            this.Controls.Add(this.kolor_tla2);
            this.Controls.Add(this.kolor_tla1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChangeClock);
            this.Controls.Add(this.panelClock);
            this.Controls.Add(this.BlackButton);
            this.Controls.Add(this.StyleButton3);
            this.Controls.Add(this.StyleButton2);
            this.Controls.Add(this.StyleButton1);
            this.Controls.Add(this.BlueButton);
            this.Controls.Add(this.GreenButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.czyszczenieWszystko);
            this.Controls.Add(this.dzielenie);
            this.Controls.Add(this.mnozenie);
            this.Controls.Add(this.odejmowanie);
            this.Controls.Add(this.dodawanie);
            this.Controls.Add(this.rownaSie);
            this.Controls.Add(this.przecinek);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.dziewiec);
            this.Controls.Add(this.osiem);
            this.Controls.Add(this.siedem);
            this.Controls.Add(this.szesc);
            this.Controls.Add(this.piec);
            this.Controls.Add(this.cztery);
            this.Controls.Add(this.trzy);
            this.Controls.Add(this.dwa);
            this.Controls.Add(this.jeden);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button jeden;
        private System.Windows.Forms.Button dwa;
        private System.Windows.Forms.Button trzy;
        private System.Windows.Forms.Button cztery;
        private System.Windows.Forms.Button piec;
        private System.Windows.Forms.Button szesc;
        private System.Windows.Forms.Button siedem;
        private System.Windows.Forms.Button osiem;
        private System.Windows.Forms.Button dziewiec;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button przecinek;
        private System.Windows.Forms.Button rownaSie;
        private System.Windows.Forms.Button dodawanie;
        private System.Windows.Forms.Button odejmowanie;
        private System.Windows.Forms.Button mnozenie;
        private System.Windows.Forms.Button dzielenie;
        private System.Windows.Forms.Button czyszczenieWszystko;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem wczytajTłoDomyślneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tłoDomyślneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twojeTłoToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button StyleButton1;
        private System.Windows.Forms.Button StyleButton2;
        private System.Windows.Forms.Button StyleButton3;
        private System.Windows.Forms.Button BlackButton;
        private System.Windows.Forms.Button GreenButton;
        private System.Windows.Forms.Button BlueButton;
        private System.Windows.Forms.Panel panelClock;
        private System.Windows.Forms.Button ChangeClock;
        private System.Windows.Forms.Button kolor_tla1;
        private System.Windows.Forms.Button kolor_tla2;
        private System.Windows.Forms.Button kolor_tla3;
        private System.Windows.Forms.Label label3;
    }
}

