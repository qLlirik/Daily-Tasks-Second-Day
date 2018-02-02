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
    /// Логика взаимодействия для JoinOrderAndPartiesWindow.xaml
    /// </summary>
    public partial class JoinOrderAndPartiesWindow : Window
    {
        Entity db = new Entity();

        public JoinOrderAndPartiesWindow()
        {
            InitializeComponent();

            foreach (var i in db.Order)
                lvOrders.Items.Add(i);
        }

        private void click_Back(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void click_AddInTheList(object sender, RoutedEventArgs e)
        {
            lvSelectOrders.Items.Add((Order)((Button)sender).DataContext);
            lvOrders.Items.Remove((Order)((Button)sender).DataContext);
        }

        private void click_Delete(object sender, RoutedEventArgs e)
        {
            lvOrders.Items.Add((Order)((Button)sender).DataContext);
            lvSelectOrders.Items.Remove((Order)((Button)sender).DataContext);
        }

        private void click_Join(object sender, RoutedEventArgs e)
        {
            if (lvSelectOrders.Items.Count == 0)
            {
                MessageBox.Show("Выберите грузы для объединения в партии!","Error",MessageBoxButton.OK,MessageBoxImage.Error);
                return;
            }

            int origin = 0;
            int dest = 0;
            foreach(var i in lvSelectOrders.Items)
            {
                if (((origin != 0) || (dest != 0)) && ((origin != ((Order)i).OriginCityID) || (dest != ((Order)i).DestinationCityID)))
                {
                    MessageBox.Show("У выбранных грузов отличаются города отправления/назначения!","Error",MessageBoxButton.OK,MessageBoxImage.Error);
                    return;
                }
                origin = ((Order)i).OriginCityID;
                dest = ((Order)i).DestinationCityID;
            }

            double TotalWeight = 0;
            foreach (var i in lvSelectOrders.Items)
                TotalWeight += Convert.ToDouble(((Order)i).DeclareValue);


            var order = (Order)lvSelectOrders.Items[0];
            db.Party.Add(new Party {
                OriginPortID = db.Ports.First(w => w.CityID == order.OriginCityID).ID,
                DestinationPortID = db.Ports.First(w => w.CityID == order.DestinationCityID).ID,
                CustomClearance = chbxDeclar.IsChecked == true? true : false,
                TotalWeight = TotalWeight
            });

            db.SaveChanges();

            var party = db.Party.ToList().Last();

            int number = 1;
            foreach(var i in lvSelectOrders.Items)
            {
                var order1 = (Order)i;
                order1.Number = number;
                order1.PartyCustomValue = party.CustomValue;
                number++;
            }

            db.SaveChanges();
            MessageBox.Show("Партия сформирована!","Perfect",MessageBoxButton.OK,MessageBoxImage.Information);
            this.Close();
        }
    }
}
