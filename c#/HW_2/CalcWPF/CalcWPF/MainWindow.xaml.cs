using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalcWPF {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void calcBtn1_Click(object sender, RoutedEventArgs e) {
            try {
                double a = Double.Parse(textBox.Text);
                double b = Double.Parse(textBox_Copy.Text);
                char c = textBox_Copy1.Text[0];
                double result = Calc.calculate(a, b, c);
                textBox_Copy2.Text = result.ToString();
            } catch (Exception ex) {
                textBox_Copy2.Text = ex.Message;
            }
        }

        private void calcBtn_Click(object sender, RoutedEventArgs e) {
            textBox_Copy3.Text += ((Button)sender).Content;
        }

        private void calcBtn_ClickOp(object sender, RoutedEventArgs e) {
            try {
                if (((Button)sender).Content.ToString() == "=") {
                    _b = Int32.Parse(textBox_Copy3.Text);
                    textBox_Copy3.Text = Calc.calculate(_a, _b, _c).ToString();
                } else {
                    _a = Int32.Parse(textBox_Copy3.Text);
                    textBox_Copy3.Text = "";
                    _c = ((Button)sender).Content.ToString()[0];
                }
            } catch (Exception) { }
        }

        private int _a = 0;
        private int _b = 0;
        private char _c = '0';
    }

    class Calc {
        internal static double calculate(double a, double b, char c) {
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
