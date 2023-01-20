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

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        bool cleared = true;

        int maxCharacters = 15;
        int currentCharacters = 1;

        float previousNumber;
        float currentNumber;

        string buffer = "none";

        public MainWindow()
        {
            InitializeComponent();
        }

        //Numbers
        private void zero_Click(object sender, RoutedEventArgs e)
        {
            if (cleared)
            {

            }
            else if (currentCharacters != maxCharacters)
            {
                currentCharacters++;
                calculateTextBox.Text += "0";
            }
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {   
            if (cleared)
            {
                calculateTextBox.Text = "1";
                cleared = false;
            }
            else if (currentCharacters != maxCharacters)
            {
                currentCharacters++;
                calculateTextBox.Text += "1";
            }
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            if (cleared)
            {
                calculateTextBox.Text = "2";
                cleared = false;
            }
            else if (currentCharacters != maxCharacters)
            {
                currentCharacters++;
                calculateTextBox.Text += "2";
            }
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            if (cleared)
            {
                calculateTextBox.Text = "3";
                cleared = false;
            }
            else if (currentCharacters != maxCharacters)
            {
                currentCharacters++;
                calculateTextBox.Text += "3";
            }
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            if (cleared)
            {
                calculateTextBox.Text = "4";
                cleared = false;
            }
            else if (currentCharacters != maxCharacters)
            {
                currentCharacters++;
                calculateTextBox.Text += "4";
            }
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            if (cleared)
            {
                calculateTextBox.Text = "5";
                cleared = false;
            }
            else if (currentCharacters != maxCharacters)
            {
                currentCharacters++;
                calculateTextBox.Text += "5";
            }
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            if (cleared)
            {
                calculateTextBox.Text = "6";
                cleared = false;
            }
            else if (currentCharacters != maxCharacters)
            {
                currentCharacters++;
                calculateTextBox.Text += "6";
            }
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            if (cleared)
            {
                calculateTextBox.Text = "7";
                cleared = false;
            }
            else if (currentCharacters != maxCharacters)
            {
                currentCharacters++;
                calculateTextBox.Text += "7";
            }
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            if (cleared)
            {
                calculateTextBox.Text = "8";
                cleared = false;
            }
            else if (currentCharacters != maxCharacters)
            {
                currentCharacters++;
                calculateTextBox.Text += "8";
            }
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            if (cleared)
            {
                calculateTextBox.Text = "9";
                cleared = false;
            }
            else if (currentCharacters != maxCharacters)
            {
                currentCharacters++;
                calculateTextBox.Text += "9";
            }
        }

        //Operations
        private void clear_Click(object sender, RoutedEventArgs e)
        {
            clearCalculator();
        }

        private void clearNumber_Click(object sender, RoutedEventArgs e)
        {
            if (calculateTextBox.Text.Length == 1)
            {
                clearCalculator();
            }
            else
            {
                calculateTextBox.Text = calculateTextBox.Text.Remove(calculateTextBox.Text.Length - 1);
                currentCharacters--;
            }
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            previousNumber = float.Parse(calculateTextBox.Text);
            clearCalculator();
            buffer = "add";
        }

        private void sub_Click(object sender, RoutedEventArgs e)
        {
            previousNumber = float.Parse(calculateTextBox.Text);
            clearCalculator();
            buffer = "sub";
        }

        private void mult_Click(object sender, RoutedEventArgs e)
        {
            previousNumber = float.Parse(calculateTextBox.Text);
            clearCalculator();
            buffer = "mult";
        }

        private void div_Click(object sender, RoutedEventArgs e)
        {
            previousNumber = float.Parse(calculateTextBox.Text);
            clearCalculator();
            buffer = "div";
        }

        private void percent_Click(object sender, RoutedEventArgs e)
        {
            previousNumber = float.Parse(calculateTextBox.Text);
            clearCalculator();
            buffer = "percent";
        }

        private void equals_Click(object sender, RoutedEventArgs e)
        {
            currentNumber = float.Parse(calculateTextBox.Text);

            switch (buffer){
                case "add":
                    calculateTextBox.Text = Math.Round((previousNumber + currentNumber), 5).ToString();
                break;

                case "sub":
                    calculateTextBox.Text = Math.Round((previousNumber - currentNumber), 5).ToString();
                break;

                case "mult":
                    calculateTextBox.Text = Math.Round((previousNumber * currentNumber), 5).ToString();
                break;

                case "div":
                    calculateTextBox.Text = Math.Round((previousNumber / currentNumber), 5).ToString();
                break;

                case "percent":
                    calculateTextBox.Text = Math.Round((previousNumber * (currentNumber/100)), 5).ToString();
                break;

                case "none":

                break;
            }

            buffer = "none";
            checkForClear();
            currentCharacters = calculateTextBox.Text.Length;
        }

        //Misc
        private void twozeros_Click(object sender, RoutedEventArgs e)
        {
            if (cleared)
            {

            }
            else if (currentCharacters < maxCharacters-1)
            {
                currentCharacters += 2;
                calculateTextBox.Text += "00";
            }
        }

        private void point_Click(object sender, RoutedEventArgs e)
        {
            if (!calculateTextBox.Text.Contains(','))
            {
                calculateTextBox.Text += ',';
            }
            else
            {

            }
        }

        //Subcommands
        private void clearCalculator()
        {
            calculateTextBox.Text = "0";
            cleared = true;
            currentCharacters = 1;
        }

        private void checkForClear()
        {
            if (calculateTextBox.Text.Equals("0"))
            {
                clearCalculator();
            }
        }

    }
}
