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
using Calculator.other;

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double number1 = 0;
        double number2 = 0;
        string operation = "";
        int n = 1;
        int c = 0;
       

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if ((n == 1)&&(Conclusion.Text != "-0"))
            {
                Conclusion.Text = "1";
                n = 0;
            }
            else if ((Conclusion.Text == "-0"))
            {
                Conclusion.Text += ",1";
                c = 1;
            }
            else
            {
                Conclusion.Text += 1;
            }

        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if ((n == 1) && (Conclusion.Text != "-0"))
            {
                Conclusion.Text = "2";
                n = 0;
            }
            else if ((Conclusion.Text == "-0"))
            {
                Conclusion.Text += ",2";
                c = 1;
            }
            else
            {
                Conclusion.Text += 2;
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if ((n == 1) && (Conclusion.Text != "-0"))
            {
                Conclusion.Text = "3";
                n = 0;
            }
            else if ((Conclusion.Text == "-0"))
            {
                Conclusion.Text += ",3";
                c = 1;
            }
            else
            {
                Conclusion.Text += 3;
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if ((n == 1) && (Conclusion.Text != "-0"))
            {
                Conclusion.Text = "4";
                n = 0;
            }
            else if ((Conclusion.Text == "-0"))
            {
                Conclusion.Text += ",4";
                c = 1;
            }
            else
            {
                Conclusion.Text += 4;
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {

            if ((n == 1) && (Conclusion.Text != "-0"))
            {
                Conclusion.Text = "5";
                n = 0;
            }
            else if ((Conclusion.Text == "-0"))
            {
                Conclusion.Text += ",5";
                c = 1;
            }
            else
            {
                Conclusion.Text += 5;
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if ((n == 1) && (Conclusion.Text != "-0"))
            {
                Conclusion.Text = "6";
                n = 0;
            }
            else if ((Conclusion.Text == "-0"))
            {
                Conclusion.Text += ",6";
                c = 1;
            }
            else
            {
                Conclusion.Text += 6;
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if ((n == 1) && (Conclusion.Text != "-0"))
            {
                Conclusion.Text = "7";
                n = 0;
            }
            else if ((Conclusion.Text == "-0"))
            {
                Conclusion.Text += ",7";
                c = 1;
            }
            else
            {
                Conclusion.Text += 7;
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if ((n == 1) && (Conclusion.Text != "-0"))
            {
                Conclusion.Text = "8";
                n = 0;
            }
            else if ((Conclusion.Text == "-0"))
            {
                Conclusion.Text += ",8";
                c = 1;
            }
            else
            {
                Conclusion.Text += 8;
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if ((n == 1) && (Conclusion.Text != "-0"))
            {
                Conclusion.Text = "9";
                n = 0;
            }
            else if ((Conclusion.Text == "-0"))
            {
                Conclusion.Text += ",9";
                c = 1;
            }
            else
            {
                Conclusion.Text += 9;
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if ((n == 1) && (Conclusion.Text != "-0"))
            {
                Conclusion.Text = "0";
                n = 0;
            }
            else if ((Conclusion.Text == "-0"))
            {
                Conclusion.Text += ",0";
                c = 1;
            }
            else
            {
                Conclusion.Text += 0;
            }
        }
        private void btnComma_Click(object sender, RoutedEventArgs e)
        {
            if (c == 0)
            {
                Conclusion.Text += ",";
                c = 1;
            }

        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            number1 = Convert.ToDouble(Conclusion.Text);
            operation = "+";
            Conclusion.Text = "0";
            c = 0;
            n = 1;
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            number1 = Convert.ToDouble(Conclusion.Text);
            operation = "-";
            Conclusion.Text = "0";
            c = 0;
            n = 1;
        }

        private void btnMyltiply_Click(object sender, RoutedEventArgs e)
        {
            number1 = Convert.ToDouble(Conclusion.Text);
            operation = "x";
            Conclusion.Text = "0";
            c = 0;
            n = 1;
        }

        private void btnDevision_Click(object sender, RoutedEventArgs e)
        {
            number1 = Convert.ToDouble(Conclusion.Text);
            operation = "/";
            Conclusion.Text = "0";
            c = 0;
            n = 1;
        }
        private void btnPercent_Click(object sender, RoutedEventArgs e)
        {
            number1 = Convert.ToDouble(Conclusion.Text);
            operation = "%";
            Conclusion.Text = "0";
            c = 0;
            n = 1;
        }

        private void PM(string num)
        {
            n = 1;
            c = 0;
            if (Convert.ToDouble(num) < 0)
            {
                f = 1;
            }
            else if (Convert.ToDouble(num) <= 0)
            {
                f = 0;
            }
        }
        private void btnEqually_Click(object sender, RoutedEventArgs e)
        {

            switch (operation)
            {
                case "+":
                    Conclusion.Text = (Calculat.Plus(Convert.ToDouble(number1), Convert.ToDouble(Conclusion.Text))).ToString();
                    PM(Conclusion.Text);
                    break;
                case "-":
                    Conclusion.Text =(Calculat.Minus(Convert.ToDouble(number1), Convert.ToDouble(Conclusion.Text))).ToString();
                    PM(Conclusion.Text);
                    break;
                case "x":
                    Conclusion.Text = (Calculat.Multiplier(Convert.ToDouble(number1), Convert.ToDouble(Conclusion.Text))).ToString();
                    PM(Conclusion.Text);
                    break;
                case "/":
                    Conclusion.Text = (Calculat.Fission(Convert.ToDouble(number1), Convert.ToDouble(Conclusion.Text))).ToString();
                    PM(Conclusion.Text);
                    break;
                case "%":
                    Conclusion.Text = (Calculat.Persent(Convert.ToDouble(number1), Convert.ToDouble(Conclusion.Text))).ToString();
                    PM(Conclusion.Text);
                    break;
            }
        }

        private void btnAC_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            PM(Conclusion.Text);
            operation = "";
            Conclusion.Text = "0";
            

        }

        int f = 0;

        private void btnPM_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(Conclusion.Text) < 0)
            {
                f = 1;
            }
            else if (Convert.ToDouble(Conclusion.Text) <= 0)
            {
                f = 0;
            }


            if (Conclusion.Text != string.Empty)
            {
                if (f == 0)
                {
                    Conclusion.Text = "-" + Conclusion.Text;
                    f = 1;
                }
                else
                {
                    string str = Conclusion.Text;
                    int l = Conclusion.Text.Length;
                    Conclusion.Text = null;
                    for (int i = 1; i < l; i++)
                    {
                        Conclusion.Text += str[i];
                    }
                    f = 0;
                }
            }
        }
    }
}
