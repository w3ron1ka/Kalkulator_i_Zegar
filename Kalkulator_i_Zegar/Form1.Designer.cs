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
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // jeden
            // 
            this.jeden.Location = new System.Drawing.Point(165, 240);
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
            this.dwa.Location = new System.Drawing.Point(274, 240);
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
            this.trzy.Location = new System.Drawing.Point(384, 240);
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
            this.cztery.Location = new System.Drawing.Point(165, 197);
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
            this.piec.Location = new System.Drawing.Point(274, 197);
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
            this.szesc.Location = new System.Drawing.Point(384, 197);
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
            this.siedem.Location = new System.Drawing.Point(165, 142);
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
            this.osiem.Location = new System.Drawing.Point(274, 142);
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
            this.dziewiec.Location = new System.Drawing.Point(384, 142);
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
            this.zero.Location = new System.Drawing.Point(274, 297);
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
            this.przecinek.Location = new System.Drawing.Point(165, 297);
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
            this.rownaSie.Location = new System.Drawing.Point(384, 297);
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
            this.dodawanie.Location = new System.Drawing.Point(520, 141);
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
            this.odejmowanie.Location = new System.Drawing.Point(520, 196);
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
            this.mnozenie.Location = new System.Drawing.Point(520, 240);
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
            this.dzielenie.Location = new System.Drawing.Point(520, 297);
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
            this.czyszczenieWszystko.Location = new System.Drawing.Point(654, 141);
            this.czyszczenieWszystko.Name = "czyszczenieWszystko";
            this.czyszczenieWszystko.Size = new System.Drawing.Size(75, 23);
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
            this.toolStrip2.Size = new System.Drawing.Size(824, 27);
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
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(66, 24);
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
            this.pictureBox1.Location = new System.Drawing.Point(127, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(685, 440);
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
            this.label2.Location = new System.Drawing.Point(601, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 82);
            this.label2.TabIndex = 21;
            this.label2.Text = "  ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(165, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(430, 61);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 482);
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
    }
}

