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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            symbol.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = Int32.Parse(text1.Text);
            int b = Int32.Parse(text2.Text);
            int selectedIndex = symbol.SelectedIndex;
            switch (selectedIndex)
            {
                case 0:
                    {
                        result.Content = a + b;
                        break;
                    }
                case 1:
                    {
                        result.Content = a - b;
                        break;
                    }
                case 2:
                    {
                        result.Content = a * b;
                        break;
                    }
                case 3:
                    {
                        if (b == 0)
                        {
                            result.Content = "Error";
                        }
                        else
                        {
                            result.Content = a / b;
                        }
                        break;
                    }
                case 4:
                    {
                        if (b == 0)
                        {
                            result.Content = "Error";
                        }
                        else
                        {
                            result.Content = a % b;
                        }
                        break;
                    }
            }

        }
    }
}

