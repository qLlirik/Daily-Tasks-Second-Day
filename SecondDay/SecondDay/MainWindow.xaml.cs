using SecondDay.Windows;
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

namespace SecondDay
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

        private void click_AddOrder(object sender, RoutedEventArgs e)
        {
            new AddOrderWindow().Show();
        }

        private void click_JoinOrdersAndParties(object sender, RoutedEventArgs e)
        {
            new JoinOrderAndPartiesWindow().Show();
        }

        private void click_AddRoute(object sender, RoutedEventArgs e)
        {
            new AddRouteWindow().Show();
        }
    }
}
