using SecondDay.DateBase;
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
using System.Windows.Shapes;

namespace SecondDay.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddRouteWindow.xaml
    /// </summary>
    public partial class AddRouteWindow : Window
    {
        Entity db = new Entity();

        public AddRouteWindow()
        {
            InitializeComponent();

            cbxShip.ItemsSource = db.Ships.ToList();
            cbxShip.DisplayMemberPath = "Name";
            cbxShip.SelectedIndex = 0;

            dpArriv.SelectedDate = DateTime.Now;
            dpDepart.SelectedDate = DateTime.Now;

            cbxParty.ItemsSource = db.Party.ToList();

            cbxPorts.ItemsSource = db.Ports.ToList();
        }

        private void click_Back(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void click_Delete1(object sender, RoutedEventArgs e)
        {
            lvParties.Items.Remove(((Button)sender).DataContext);
        }

        private void click_Delete2(object sender, RoutedEventArgs e)
        {
            lvPorts.Items.Remove(((Button)sender).DataContext);
        }

        private void select_cbxPorts(object sender, SelectionChangedEventArgs e)
        {
            lvPorts.Items.Add(((ComboBox)sender).SelectedItem);
        }

        private void select_cbxParty(object sender, SelectionChangedEventArgs e)
        {
            lvParties.Items.Add(((ComboBox)sender).SelectedItem);
        }

        private void click_cbxPorts(object sender, MouseButtonEventArgs e)
        {
            select_cbxPorts(null,null);
        }

        private void click_cbxParties(object sender, MouseButtonEventArgs e)
        {
            select_cbxParty(null,null);
        }

        private void click_AddRoute(object sender, RoutedEventArgs e)
        {
            if ((lvParties.Items.Count == 0) || (lvPorts.Items.Count == 0))
            {
                MessageBox.Show("Выберите партии/порты!","Error",MessageBoxButton.OK,MessageBoxImage.Error);
                return;
            }

            db.Routes.Add(new Routes {
                ShipID = ((Ships)cbxShip.SelectedItem).RegNumber,
                DepartureDate = dpDepart.SelectedDate.Value,
                ArriveDate = dpArriv.SelectedDate.Value
            });
            db.SaveChanges();

            var rout = db.Routes.ToList().Last();

            foreach(var i in lvParties.Items)
            {
                var party = (Party)i;
                db.PartiesInRout.Add(new PartiesInRout
                {
                    RoutID = rout.ID,
                    PartyCustomValue = party.CustomValue
                });
            }

            int number = 1;
            foreach(var i in lvPorts.Items)
            {
                var port = (Ports)i;
                db.PortsInRout.Add(new PortsInRout {
                    RoutID = rout.ID,
                    PortID = port.ID,
                    PriorityInRout = number
                });
                number++;
            }

            db.SaveChanges();

            MessageBox.Show("Рейс был добавлен!","Perfect",MessageBoxButton.OK,MessageBoxImage.Information);
            this.Close();
        }
    }
}
