using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Timer = System.Windows.Forms.Timer;


namespace CaLCuLaToR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Tick += new EventHandler(timer2_Tick);
            timer.Interval = 1000;
        }

        Timer timer = null;
        public double a;
        public double b;
        public char c;
        public string u;
        public string s;
        public bool znak = true;


        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox1.Text += "00";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            textBox1.Text += "000";
        }

        private void button12_Click(object sender, EventArgs e) // +
        {
            textBox1.Text = textBox1.Text.Replace("(", "");
            textBox1.Text = textBox1.Text.Replace(")", "");
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                c = '+';
                textBox1.Text = "";
            }
            catch (Exception)
            {
            }
        }
        private void button14_Click(object sender, EventArgs e) // -
        {
            textBox1.Text = textBox1.Text.Replace("(", "");
            textBox1.Text = textBox1.Text.Replace(")", "");
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                c = '-';
                textBox1.Text = "";
            }
            catch (Exception)
            {
            }
        }
        private void button11_Click(object sender, EventArgs e) //  /
        {
            textBox1.Text = textBox1.Text.Replace("(", "");
            textBox1.Text = textBox1.Text.Replace(")", "");
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                c = '/';
                textBox1.Text = "";
            }
            catch (Exception)
            {
            }
        }
        private void button10_Click(object sender, EventArgs e) // *
        {
            textBox1.Text = textBox1.Text.Replace("(", "");
            textBox1.Text = textBox1.Text.Replace(")", "");
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                c = '*';
                textBox1.Text = "";
            }
            catch (Exception)
            {
            }
        }
        private void button9_Click(object sender, EventArgs e) //=
        {
            try
            {
                textBox1.Text = textBox1.Text.Replace("(", "");
            textBox1.Text = textBox1.Text.Replace(")", "");

            timer1.Start();
            progressBar1.Value = 0;

            b = Convert.ToDouble(textBox1.Text);
            textBox1.Text = " ";
            switch (c)
            {
                case '+':
                    textBox2.Text = Convert.ToString(a + "+" + b + "=");
                    textBox1.Text = Convert.ToString(a + b);
                    break;
                case '-':
                    textBox2.Text = Convert.ToString(a + "-" + b + "=");
                    textBox1.Text = Convert.ToString(a - b);
                    break;
                case '*':
                    textBox2.Text = Convert.ToString(a + "*" + b + "=");
                    textBox1.Text = Convert.ToString(a * b);
                    break;
                case '/':
                    textBox2.Text = Convert.ToString(a + "/" + b + "=");
                    textBox1.Text = Convert.ToString(a / b);
                    break;
                case '√':
                    textBox1.Text = Convert.ToString(Math.Pow(a, 1.0 / b));
                    textBox2.Text = Convert.ToString(b + "√" + a);
                    break;
                case '^':
                    textBox1.Text = Convert.ToString(Math.Pow(a, b));
                    textBox2.Text = Convert.ToString(a + "^" + b + "=");
                    break;
                case '%':
                    textBox1.Text = Convert.ToString(((a / b) * 100) + "%");
                    textBox2.Text = Convert.ToString(a + "%" + b + "=");
                    break;
             }
            switch (u)
            {
                case "logA(x)":
                    textBox2.Text = Convert.ToString("Log" + b + "(" + a + ")");
                    textBox1.Text = Convert.ToString((Math.Log10(a)) / (Math.Log10(b)));
                    break;
            }
            }
            catch (Exception)
            {

            }
        }

        private void button17_Click(object sender, EventArgs e)//,
        {
            if (textBox1.Text == "")
            {
                textBox1.Text += "0" + ",";
            }
            else if (textBox1.Text.IndexOf(",") == -1)
            {
                textBox1.Text += ",";
            }
            
        }

        private void button20_Click(object sender, EventArgs e)//x^2
        {
            try
            {
                textBox1.Text = textBox1.Text.Replace("(", "");
                textBox1.Text = textBox1.Text.Replace(")", "");
                a = Convert.ToDouble(textBox1.Text);
                textBox2.Text = Convert.ToString(a + "^2");
                textBox1.Text = Convert.ToString(Math.Pow(a, 2));
            }
            catch (Exception)
            {

            }
        }

        private void button25_Click(object sender, EventArgs e)//Sqrt
        {
            textBox1.Text = textBox1.Text.Replace("(", "");
            textBox1.Text = textBox1.Text.Replace(")", "");
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox2.Text = Convert.ToString("Sqrt(" + a + ")= ");
                textBox1.Text = Convert.ToString(Math.Sqrt(a));
            }
            catch (Exception)
            {

            }
        }

        private void button24_Click(object sender, EventArgs e)//sin
        {
            textBox1.Text = textBox1.Text.Replace("(", "");
            textBox1.Text = textBox1.Text.Replace(")", "");
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox2.Text = Convert.ToString("sin(" + a + "°" + ")= ");
                textBox1.Text = Convert.ToString(Math.Sin((a * Math.PI) / 180));
            }
            catch (Exception)
            {

            }
        }

        private void button23_Click(object sender, EventArgs e)//cos
        {
            textBox1.Text = textBox1.Text.Replace("(", "");
            textBox1.Text = textBox1.Text.Replace(")", "");

            try
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox2.Text = Convert.ToString("cos(" + a + "°" + ")= ");
                textBox1.Text = Convert.ToString(Math.Cos((a * Math.PI) / 180));
            }
            catch (Exception)
            {

            }
        }

        private void button22_Click(object sender, EventArgs e)//tan
        {
            textBox1.Text = textBox1.Text.Replace("(", "");
            textBox1.Text = textBox1.Text.Replace(")", "");
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox2.Text = Convert.ToString("tan(" + a + "°" + ")= ");
                textBox1.Text = Convert.ToString(Math.Tan((a * Math.PI) / 180));
            }
            catch (Exception)
            {

            }
        }

        private void button21_Click(object sender, EventArgs e)//ctan
        {
            textBox1.Text = textBox1.Text.Replace("(", "");
            textBox1.Text = textBox1.Text.Replace(")", "");
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox2.Text = Convert.ToString("ctan(" + a + "°" + ")= ");
                textBox1.Text = Convert.ToString((Math.Cos((a * Math.PI) / 180)) / (Math.Sin((a * Math.PI) / 180)));
            }
            catch (Exception)
            {

            }
        }

        private void button27_Click(object sender, EventArgs e) // C
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            timer2.Stop();
            a = 0;
            b = 0;
            znak = true;


        }

        private void button26_Click(object sender, EventArgs e) // стрелка
        {
            string s = textBox1.Text;
            s = s.Substring(0, s.Length - 1);

            textBox1.Text = s;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

            //this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)//Справка
        {
            MessageBox.Show("ALIKHAN TORTAY, CALCULATOR 2019", "О Программе");
        }

        private void timer1_Tick(object sender, EventArgs e)//timer1
        {
            progressBar1.PerformStep();
        }

        private void timer2_Tick(object sender, EventArgs e)//timer2
        {
            int t = DateTime.Now.Hour;
            int g = DateTime.Now.Minute;
            int k = DateTime.Now.Second;

            int r = DateTime.Now.Day;
            int o = DateTime.Now.Month;
            int v = DateTime.Now.Year;

            string time = "";
            string time1 = "";

            if (t < 10)
            {
                time += "0" + t;
            }
            else
            {
                time += t;
            }

            time += ":";

            if (g < 10)
            {
                time += "0" + g;
            }
            else
            {
                time += g;
            }
            time += ":";

            if (k < 10)
            {
                time += "0" + k;
            }
            else
            {
                time += k;
            }

            if (r < 10)
            {
                time += "0" + r;
            }
            else
            {
                time1 += r;
            }
            time1 += ".";
            if (o < 10)
            {
                time1 += "0" + o;
            }
            else
            {
                time += o;
            }
            time1 += ".";
            time1 += v;


            textBox1.Text = time;
            textBox2.Text = time1;

        }

        private void button30_Click(object sender, EventArgs e)//ln
        {
            textBox1.Text = textBox1.Text.Replace("(", "");
            textBox1.Text = textBox1.Text.Replace(")", "");
            try
            {

                a = Convert.ToDouble(textBox1.Text);
                textBox2.Text = Convert.ToString("ln(" + a + " )=");
                textBox1.Text = Convert.ToString(Math.Log(a));
            }
            catch (Exception)
            {

            }
        }

        private void button29_Click(object sender, EventArgs e)//√
        {
            textBox1.Text = textBox1.Text.Replace("(", "");
            textBox1.Text = textBox1.Text.Replace(")", "");
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                c = '√';
                textBox1.Text = "";
            }
            catch (Exception)
            {

            }
        }

        private void button28_Click(object sender, EventArgs e)//1/n
        {
            textBox1.Text = textBox1.Text.Replace("(", "");
            textBox1.Text = textBox1.Text.Replace(")", "");
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox2.Text = Convert.ToString("1" + "/" + a + "=");
                textBox1.Text = Convert.ToString(1 / a);
            }
            catch (Exception)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)//%s
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
            c = '%';

            textBox1.Text = "";
            }
            catch (Exception)
            {

            }
        }

        private void button33_Click(object sender, EventArgs e)//x^n
        {
            try
            {
                textBox1.Text = textBox1.Text.Replace("(", "");
                textBox1.Text = textBox1.Text.Replace(")", "");
                a = Convert.ToDouble(textBox1.Text);
                c = '^';
                textBox1.Text = "";
            }
            catch (Exception)
            {

            }
        }

        private void button34_Click(object sender, EventArgs e)//PI
        {
            textBox1.Text = Convert.ToString("3.1456");
        }

        private void button35_Click(object sender, EventArgs e)//10^X
        {
            textBox1.Text = textBox1.Text.Replace("(", "");
            textBox1.Text = textBox1.Text.Replace(")", "");
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox2.Text = Convert.ToString("10" + "^" + a + "=");
                textBox1.Text = Convert.ToString(Math.Pow(10, a));
            }
            catch (Exception)
            {

            }
        }

        private void button36_Click(object sender, EventArgs e)//n!
        {
            textBox1.Text = textBox1.Text.Replace("(", "");
            textBox1.Text = textBox1.Text.Replace(")", "");
            try
            {
                double s = 1;
                a = Convert.ToDouble(textBox1.Text);
                for (int i = 1; i <= a; i++)
                {
                    s = s * i;
                }
                textBox1.Text = Convert.ToString(s);
                textBox2.Text = Convert.ToString(a + "!" + "=");

            
            }
        catch (Exception) 
            {
            }
            }

        private void button37_Click(object sender, EventArgs e) // (
        {
            if (znak == true )
            {
                textBox1.Text = "(" + textBox1.Text;
                znak = false;
           }
            else if (znak==false)
            {
                textBox1.Text = textBox1.Text + ")";
                znak = true;

            }
        }

      

        private void button40_Click(object sender, EventArgs e) //timer2 Start
        {
            timer2.Start();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            timer1.Start();
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                u = "logA(x)";
                textBox1.Text = "";
            }
            catch (Exception)
            {

            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }
    }
    }
