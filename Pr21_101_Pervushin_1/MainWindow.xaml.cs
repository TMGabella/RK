using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Pr21_101_Pervushin_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void NumberTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var numberTextBox = sender as TextBox;
            if (numberTextBox == null) return;

            var number = numberTextBox.Text;

            if (number.Length == 12 && Regex.IsMatch(number, @"^\d{12}$"))
            {
                var product = int.Parse(number.Substring(0, 3)) * int.Parse(number.Substring(3, 9));
                var sum = int.Parse(number.Substring(9, 3)) + int.Parse(number.Substring(3, 9));

                if (product == sum)
                {
                    ResultTextBlock.Text = "Произведение и сумма равны!";
                }
                else
                {
                    ResultTextBlock.Text = "Произведение и сумма не равны!";
                }
            }
            else
            {
                ResultTextBlock.Text = "Введите правильное 12-значное число!";
            }
        }
    }
}
