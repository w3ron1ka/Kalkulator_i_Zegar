using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_i_Zegar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void twojeTłoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.CheckFileExists = false;
            this.openFileDialog1.ShowDialog();
            this.label1.Text = this.openFileDialog1.FileName;

            try
            {
                this.pictureBox1.Load(this.openFileDialog1.FileName);
            }
            catch (System.IO.FileNotFoundException ex1)
            {
                MessageBox.Show(ex1.Message);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }
            catch
            {
                this.label1.Text = "Wykryto nieznany blad";
            }
        }

        private void tłoDomyślneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Load("Resources\\simsala.jpg");
            this.label1.Text = ("Simsala Grimm");
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                    this.jeden.PerformClick();
                    break;
                case '2':
                    this.dwa.PerformClick();
                    break;
                case '3':
                    this.trzy.PerformClick();
                    break;
                case '4':
                    this.cztery.PerformClick();
                    break;
                case '5':
                    this.piec.PerformClick();
                    break;
                case '6':
                    this.szesc.PerformClick();
                    break;
                case '7':
                    this.siedem.PerformClick();
                    break;
                case '8':
                    this.osiem.PerformClick();
                    break;
                case '9':
                    this.dziewiec.PerformClick();
                    break;
                case '0':
                    this.zero.PerformClick();
                    break;
                case '+':
                    this.dodawanie.PerformClick();
                    break;
                case '-':
                    this.odejmowanie.PerformClick();
                    break;
                case 'x':
                    this.mnozenie.PerformClick();
                    break;
                case ':':
                    this.dzielenie.PerformClick();
                    break;
                case '=':
                    this.rownaSie.PerformClick();
                    break;
                case ',' :
                    this.przecinek.PerformClick();
                    break;
                case 'c':
                    this.czyszczenieWszystko.PerformClick();
                    break;
                case 'C':
                    this.czyszczenieWszystko.PerformClick();
                    break;
            }
        }

        private void jeden_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = (textBox1.Text + "1");
        }

        private void dwa_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = (textBox1.Text + "2");
        }

        private void trzy_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = (textBox1.Text + "3");
        }

        private void cztery_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = (textBox1.Text + "4");
        }

        private void piec_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = (textBox1.Text + "5");
        }

        private void szesc_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = (textBox1.Text + "6");
        }

        private void siedem_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = (textBox1.Text + "7");
        }

        private void osiem_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = (textBox1.Text + "8");
        }

        private void dziewiec_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = (textBox1.Text +"9");
        }

        private void zero_Click(object sender, EventArgs e)
        {

            this.textBox1.Text = (textBox1.Text + "0");
        }
        private void przecinek_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = (textBox1.Text + ",");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private double wykonajDzialanie (double liczba1, double liczba2, char dzialanie)
        {           

            switch (dzialanie)
            {
                case '+':
                    wynik = liczba1 + liczba2;
                    break;
                case '-':
                    wynik = liczba1 - liczba2;
                    break;
                case 'x':
                    wynik = liczba1 * liczba2;
                    break;
                case ':':
                    if (liczba2 == 0)
                    {
                        MessageBox.Show("Pamietaj kolego nie dziel przez zero!");       // nie uzywamy wyjatku bo dla wyniku ktory jest zmienna double nie ma wyjatku - wychodzi nieskonczonosc, dlatego reczne sprawdzenie
                    }
                    else
                    {
                        wynik = liczba1 / liczba2;
                    }
                    break;
                default:
                    wynik = 0;
                    break;
            }       

            return wynik;
        }
        //eleleoel
        //komentarz kolejny a co
        private void rownaSie_Click(object sender, EventArgs e)
        {
            drugaLiczba = double.Parse(textBox1.Text);
            this.wykonajDzialanie(pierwszaLiczba, drugaLiczba, dzialanie);
            this.textBox1.Text = wynik.ToString();                          // To.String() zamienia wynik (double) na String
            this.label2.Text = "=";
        }

        private void dodawanie_Click(object sender, EventArgs e)
        {
            pierwszaLiczba = double.Parse(textBox1.Text);       // .Parse  konwertuje String na double
            this.textBox1.Text = " ";
            this.label2.Text = "+";
            dzialanie = '+';
        }

        private void odejmowanie_Click(object sender, EventArgs e)
        {
            pierwszaLiczba = double.Parse(textBox1.Text);
            this.textBox1.Text = " ";
            this.label2.Text = "-";
            dzialanie = '-';
        }

        private void mnozenie_Click(object sender, EventArgs e)
        {
            pierwszaLiczba = double.Parse(textBox1.Text);
            //this.textBox1.Text = (textBox1.Text + "x");           // jednak nie wyswietlamy w textBox1 działania  tylko z boku w label
            this.textBox1.Text = " ";
            this.label2.Text = "x";
            dzialanie = 'x';
        }

        private void dzielenie_Click(object sender, EventArgs e)
        {
            pierwszaLiczba = double.Parse(textBox1.Text);
            this.textBox1.Text = " ";
            this.label2.Text = ":";
            dzialanie = ':';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void czyszczenieWszystko_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
        }
    }
}
