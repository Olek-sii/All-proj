using System;
using System.Windows.Forms;
namespace CalcForms {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e) {
            try {
                double a = Double.Parse(textBox1.Text);
                double b = Double.Parse(textBox2.Text);
                char c = textBox3.Text[0];
                double result = Calc.calculate(a, b, c);
                textBox4.Text = result.ToString();
            } catch (Exception ex) {
                textBox4.Text = ex.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            textBox6.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e) {
            textBox6.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e) {
            textBox6.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e) {
            textBox6.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e) {
            textBox6.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e) {
            textBox6.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e) {
            textBox6.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e) {
            textBox6.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e) {
            textBox6.Text += 9;
        }

        private void button10_Click(object sender, EventArgs e) {
            if (textBox6.Text.Length != 0) {
                textBox6.Text += 0;
            }
        }

        private void button11_Click(object sender, EventArgs e) {
            try {
                _a = Int32.Parse(textBox6.Text);
            } catch (Exception) {
            }
            textBox6.Text = "";
            _op = '+';
        }

        private void button12_Click(object sender, EventArgs e) {
            try {
                _a = Int32.Parse(textBox6.Text);
            } catch (Exception) {
            }
            textBox6.Text = "";
            _op = '-';
        }

        private void button13_Click(object sender, EventArgs e) {
            try {
                _a = Int32.Parse(textBox6.Text);
            } catch (Exception) {
            }
            textBox6.Text = "";
            _op = '*';
        }

        private void button15_Click(object sender, EventArgs e) {
            try {
                _a = Int32.Parse(textBox6.Text);
            } catch (Exception) {
            }
            textBox6.Text = "";
            _op = '/';
        }

        private void button14_Click(object sender, EventArgs e) {
            if (_op != '0') {
                try {
                    _b = Int32.Parse(textBox6.Text);
                    textBox6.Text = Calc.calculate(_a, _b, _op).ToString();
                } catch (Exception) {
                }
            }
        }

        private static int _a = 0;
        private static int _b = 0;
        private static char _op = '0';
    }
    class Calc {
        public static double calculate(double a, double b, char c) {
            double result = 0;
            switch (c) {
                case '+': result = a + b; break;
                case '-': result = a - b; break;
                case '*': result = a * b; break;
                case '/': result = a / b; break;
            }
            return result;
        }
    }
}
