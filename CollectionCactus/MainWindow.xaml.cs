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
using CollectionCactus.page;

namespace CollectionCactus
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

        int a = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            a = 1;
            MainFrame.NavigationService.Navigate(new CactusPage(this));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            a = 2;
            MainFrame.NavigationService.Navigate(new Instruction(this));
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            a = 3;
            MainFrame.NavigationService.Navigate(new Collection(this));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            a = 4;
            MainFrame.NavigationService.Navigate(new Exhibition(this));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            a = 5;
            MainFrame.NavigationService.Navigate(new list_collection(this));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            a = 6;
            MainFrame.NavigationService.Navigate(new list_exhibition(this));
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if(a == 1)
            {
                MainFrame.NavigationService.Navigate(new CactusPage(this));
            }
            else if(a == 2)
            {
                MainFrame.NavigationService.Navigate(new Instruction(this));
            }
            else if (a == 3)
            {
                MainFrame.NavigationService.Navigate(new Collection(this));
            }
            else if (a == 4)
            {
                MainFrame.NavigationService.Navigate(new Exhibition(this));
            }
            else if (a == 5)
            {
                MainFrame.NavigationService.Navigate(new list_collection(this));
            }
            else if (a == 6)
            {
                MainFrame.NavigationService.Navigate(new list_exhibition(this));
            }
        }
    }
}
