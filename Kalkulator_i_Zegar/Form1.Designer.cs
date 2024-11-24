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
            this.zmieńZegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmieńStylZegaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styl1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styl2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styl3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelClock = new System.Windows.Forms.Panel();
            this.zmieńKolorZegaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zielonyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niebieskiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.domyślnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // jeden
            // 
            this.jeden.Location = new System.Drawing.Point(158, 253);
            this.jeden.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.jeden.Name = "jeden";
            this.jeden.Size = new System.Drawing.Size(62, 58);
            this.jeden.TabIndex = 0;
            this.jeden.Text = "1";
            this.jeden.UseVisualStyleBackColor = true;
            this.jeden.Click += new System.EventHandler(this.jeden_Click);
            this.jeden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // dwa
            // 
            this.dwa.Location = new System.Drawing.Point(235, 253);
            this.dwa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dwa.Name = "dwa";
            this.dwa.Size = new System.Drawing.Size(62, 58);
            this.dwa.TabIndex = 1;
            this.dwa.Text = "2";
            this.dwa.UseVisualStyleBackColor = true;
            this.dwa.Click += new System.EventHandler(this.dwa_Click);
            this.dwa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // trzy
            // 
            this.trzy.Location = new System.Drawing.Point(314, 187);
            this.trzy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trzy.Name = "trzy";
            this.trzy.Size = new System.Drawing.Size(62, 58);
            this.trzy.TabIndex = 2;
            this.trzy.Text = "3";
            this.trzy.UseVisualStyleBackColor = true;
            this.trzy.Click += new System.EventHandler(this.trzy_Click);
            this.trzy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // cztery
            // 
            this.cztery.Location = new System.Drawing.Point(158, 187);
            this.cztery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cztery.Name = "cztery";
            this.cztery.Size = new System.Drawing.Size(62, 58);
            this.cztery.TabIndex = 3;
            this.cztery.Text = "4";
            this.cztery.UseVisualStyleBackColor = true;
            this.cztery.Click += new System.EventHandler(this.cztery_Click);
            this.cztery.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // piec
            // 
            this.piec.Location = new System.Drawing.Point(235, 187);
            this.piec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.piec.Name = "piec";
            this.piec.Size = new System.Drawing.Size(62, 58);
            this.piec.TabIndex = 4;
            this.piec.Text = "5";
            this.piec.UseVisualStyleBackColor = true;
            this.piec.Click += new System.EventHandler(this.piec_Click);
            this.piec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // szesc
            // 
            this.szesc.Location = new System.Drawing.Point(314, 253);
            this.szesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.szesc.Name = "szesc";
            this.szesc.Size = new System.Drawing.Size(62, 58);
            this.szesc.TabIndex = 5;
            this.szesc.Text = "6";
            this.szesc.UseVisualStyleBackColor = true;
            this.szesc.Click += new System.EventHandler(this.szesc_Click);
            this.szesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // siedem
            // 
            this.siedem.Location = new System.Drawing.Point(158, 121);
            this.siedem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.siedem.Name = "siedem";
            this.siedem.Size = new System.Drawing.Size(62, 58);
            this.siedem.TabIndex = 6;
            this.siedem.Text = "7";
            this.siedem.UseVisualStyleBackColor = true;
            this.siedem.Click += new System.EventHandler(this.siedem_Click);
            this.siedem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // osiem
            // 
            this.osiem.Location = new System.Drawing.Point(235, 121);
            this.osiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.osiem.Name = "osiem";
            this.osiem.Size = new System.Drawing.Size(62, 58);
            this.osiem.TabIndex = 7;
            this.osiem.Text = "8";
            this.osiem.UseVisualStyleBackColor = true;
            this.osiem.Click += new System.EventHandler(this.osiem_Click);
            this.osiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // dziewiec
            // 
            this.dziewiec.Location = new System.Drawing.Point(314, 121);
            this.dziewiec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dziewiec.Name = "dziewiec";
            this.dziewiec.Size = new System.Drawing.Size(62, 58);
            this.dziewiec.TabIndex = 8;
            this.dziewiec.Text = "9";
            this.dziewiec.UseVisualStyleBackColor = true;
            this.dziewiec.Click += new System.EventHandler(this.dziewiec_Click);
            this.dziewiec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(158, 319);
            this.zero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(139, 58);
            this.zero.TabIndex = 9;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            this.zero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // przecinek
            // 
            this.przecinek.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przecinek.Location = new System.Drawing.Point(314, 319);
            this.przecinek.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.przecinek.Name = "przecinek";
            this.przecinek.Size = new System.Drawing.Size(62, 58);
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
            this.rownaSie.Location = new System.Drawing.Point(460, 253);
            this.rownaSie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rownaSie.Name = "rownaSie";
            this.rownaSie.Size = new System.Drawing.Size(62, 124);
            this.rownaSie.TabIndex = 11;
            this.rownaSie.Text = "=";
            this.rownaSie.UseVisualStyleBackColor = true;
            this.rownaSie.Click += new System.EventHandler(this.rownaSie_Click);
            this.rownaSie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // dodawanie
            // 
            this.dodawanie.Location = new System.Drawing.Point(392, 253);
            this.dodawanie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dodawanie.Name = "dodawanie";
            this.dodawanie.Size = new System.Drawing.Size(62, 58);
            this.dodawanie.TabIndex = 12;
            this.dodawanie.Text = "+";
            this.dodawanie.UseVisualStyleBackColor = true;
            this.dodawanie.Click += new System.EventHandler(this.dodawanie_Click);
            this.dodawanie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // odejmowanie
            // 
            this.odejmowanie.Location = new System.Drawing.Point(392, 187);
            this.odejmowanie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.odejmowanie.Name = "odejmowanie";
            this.odejmowanie.Size = new System.Drawing.Size(62, 58);
            this.odejmowanie.TabIndex = 13;
            this.odejmowanie.Text = "-";
            this.odejmowanie.UseVisualStyleBackColor = true;
            this.odejmowanie.Click += new System.EventHandler(this.odejmowanie_Click);
            this.odejmowanie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // mnozenie
            // 
            this.mnozenie.Location = new System.Drawing.Point(392, 121);
            this.mnozenie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mnozenie.Name = "mnozenie";
            this.mnozenie.Size = new System.Drawing.Size(62, 58);
            this.mnozenie.TabIndex = 14;
            this.mnozenie.Text = "x";
            this.mnozenie.UseVisualStyleBackColor = true;
            this.mnozenie.Click += new System.EventHandler(this.mnozenie_Click);
            this.mnozenie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // dzielenie
            // 
            this.dzielenie.Location = new System.Drawing.Point(392, 319);
            this.dzielenie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dzielenie.Name = "dzielenie";
            this.dzielenie.Size = new System.Drawing.Size(62, 58);
            this.dzielenie.TabIndex = 15;
            this.dzielenie.Text = ":";
            this.dzielenie.UseVisualStyleBackColor = true;
            this.dzielenie.Click += new System.EventHandler(this.dzielenie_Click);
            this.dzielenie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // czyszczenieWszystko
            // 
            this.czyszczenieWszystko.Location = new System.Drawing.Point(460, 121);
            this.czyszczenieWszystko.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.czyszczenieWszystko.Name = "czyszczenieWszystko";
            this.czyszczenieWszystko.Size = new System.Drawing.Size(62, 58);
            this.czyszczenieWszystko.TabIndex = 16;
            this.czyszczenieWszystko.Text = "C";
            this.czyszczenieWszystko.UseVisualStyleBackColor = true;
            this.czyszczenieWszystko.Click += new System.EventHandler(this.czyszczenieWszystko_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(927, 34);
            this.toolStrip2.TabIndex = 18;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wczytajTłoDomyślneToolStripMenuItem,
            this.zmieńStylZegaraToolStripMenuItem,
            this.zmieńKolorZegaraToolStripMenuItem,
            this.zmieńZegarToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::Kalkulator_i_Zegar.Properties.Resources.doge;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(77, 29);
            this.toolStripDropDownButton1.Text = "Plik";
            // 
            // wczytajTłoDomyślneToolStripMenuItem
            // 
            this.wczytajTłoDomyślneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tłoDomyślneToolStripMenuItem,
            this.twojeTłoToolStripMenuItem});
            this.wczytajTłoDomyślneToolStripMenuItem.Name = "wczytajTłoDomyślneToolStripMenuItem";
            this.wczytajTłoDomyślneToolStripMenuItem.Size = new System.Drawing.Size(252, 34);
            this.wczytajTłoDomyślneToolStripMenuItem.Text = "Wczytaj";
            // 
            // tłoDomyślneToolStripMenuItem
            // 
            this.tłoDomyślneToolStripMenuItem.Name = "tłoDomyślneToolStripMenuItem";
            this.tłoDomyślneToolStripMenuItem.Size = new System.Drawing.Size(222, 34);
            this.tłoDomyślneToolStripMenuItem.Text = "Tło domyślne";
            this.tłoDomyślneToolStripMenuItem.Click += new System.EventHandler(this.tłoDomyślneToolStripMenuItem_Click);
            // 
            // twojeTłoToolStripMenuItem
            // 
            this.twojeTłoToolStripMenuItem.Name = "twojeTłoToolStripMenuItem";
            this.twojeTłoToolStripMenuItem.Size = new System.Drawing.Size(222, 34);
            this.twojeTłoToolStripMenuItem.Text = "Twoje tło";
            this.twojeTłoToolStripMenuItem.Click += new System.EventHandler(this.twojeTłoToolStripMenuItem_Click);
            // 
            // zmieńZegarToolStripMenuItem
            // 
            this.zmieńZegarToolStripMenuItem.Name = "zmieńZegarToolStripMenuItem";
            this.zmieńZegarToolStripMenuItem.Size = new System.Drawing.Size(252, 34);
            this.zmieńZegarToolStripMenuItem.Text = "Zmień zegar";
            this.zmieńZegarToolStripMenuItem.Click += new System.EventHandler(this.zmieńZegarToolStripMenuItem_Click);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(252, 34);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // zmieńStylZegaraToolStripMenuItem
            // 
            this.zmieńStylZegaraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.styl1ToolStripMenuItem,
            this.styl2ToolStripMenuItem,
            this.styl3ToolStripMenuItem});
            this.zmieńStylZegaraToolStripMenuItem.Name = "zmieńStylZegaraToolStripMenuItem";
            this.zmieńStylZegaraToolStripMenuItem.Size = new System.Drawing.Size(252, 34);
            this.zmieńStylZegaraToolStripMenuItem.Text = "Zmień styl zegara";
            // 
            // styl1ToolStripMenuItem
            // 
            this.styl1ToolStripMenuItem.Name = "styl1ToolStripMenuItem";
            this.styl1ToolStripMenuItem.Size = new System.Drawing.Size(157, 34);
            this.styl1ToolStripMenuItem.Text = "Styl 1";
            this.styl1ToolStripMenuItem.Click += new System.EventHandler(this.styl1ToolStripMenuItem_Click);
            // 
            // styl2ToolStripMenuItem
            // 
            this.styl2ToolStripMenuItem.Name = "styl2ToolStripMenuItem";
            this.styl2ToolStripMenuItem.Size = new System.Drawing.Size(157, 34);
            this.styl2ToolStripMenuItem.Text = "Styl 2";
            this.styl2ToolStripMenuItem.Click += new System.EventHandler(this.styl2ToolStripMenuItem_Click);
            // 
            // styl3ToolStripMenuItem
            // 
            this.styl3ToolStripMenuItem.Name = "styl3ToolStripMenuItem";
            this.styl3ToolStripMenuItem.Size = new System.Drawing.Size(157, 34);
            this.styl3ToolStripMenuItem.Text = "Styl 3";
            this.styl3ToolStripMenuItem.Click += new System.EventHandler(this.styl3ToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(123, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(780, 573);
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
            this.label1.Location = new System.Drawing.Point(15, 528);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Twój obrazek";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Image = global::Kalkulator_i_Zegar.Properties.Resources.doge;
            this.label2.Location = new System.Drawing.Point(687, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 102);
            this.label2.TabIndex = 21;
            this.label2.Text = "  ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(144, 38);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(444, 71);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Miriam Mono CLM", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(588, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 53);
            this.label4.TabIndex = 24;
            this.label4.Text = "00:00:00";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelClock
            // 
            this.panelClock.BackColor = System.Drawing.Color.Transparent;
            this.panelClock.Location = new System.Drawing.Point(556, 232);
            this.panelClock.Name = "panelClock";
            this.panelClock.Size = new System.Drawing.Size(329, 299);
            this.panelClock.TabIndex = 32;
            this.panelClock.VisibleChanged += new System.EventHandler(this.zmieńZegarToolStripMenuItem_Click);
            this.panelClock.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelClock_Paint);
            // 
            // zmieńKolorZegaraToolStripMenuItem
            // 
            this.zmieńKolorZegaraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zielonyToolStripMenuItem,
            this.niebieskiToolStripMenuItem,
            this.domyślnyToolStripMenuItem});
            this.zmieńKolorZegaraToolStripMenuItem.Name = "zmieńKolorZegaraToolStripMenuItem";
            this.zmieńKolorZegaraToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.zmieńKolorZegaraToolStripMenuItem.Text = "Zmień kolor zegara";
            // 
            // zielonyToolStripMenuItem
            // 
            this.zielonyToolStripMenuItem.BackColor = System.Drawing.Color.DarkGreen;
            this.zielonyToolStripMenuItem.Name = "zielonyToolStripMenuItem";
            this.zielonyToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.zielonyToolStripMenuItem.Text = "Zielony";
            this.zielonyToolStripMenuItem.Click += new System.EventHandler(this.zielonyToolStripMenuItem_Click);
            // 
            // niebieskiToolStripMenuItem
            // 
            this.niebieskiToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.niebieskiToolStripMenuItem.Name = "niebieskiToolStripMenuItem";
            this.niebieskiToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.niebieskiToolStripMenuItem.Text = "Niebieski";
            this.niebieskiToolStripMenuItem.Click += new System.EventHandler(this.niebieskiToolStripMenuItem_Click);
            // 
            // domyślnyToolStripMenuItem
            // 
            this.domyślnyToolStripMenuItem.Name = "domyślnyToolStripMenuItem";
            this.domyślnyToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.domyślnyToolStripMenuItem.Text = "Domyślny";
            this.domyślnyToolStripMenuItem.Click += new System.EventHandler(this.domyślnyToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 602);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelClock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip2);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Panel panelClock;
        private System.Windows.Forms.ToolStripMenuItem zmieńZegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmieńStylZegaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styl1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styl2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styl3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmieńKolorZegaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zielonyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem niebieskiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem domyślnyToolStripMenuItem;
    }
}

