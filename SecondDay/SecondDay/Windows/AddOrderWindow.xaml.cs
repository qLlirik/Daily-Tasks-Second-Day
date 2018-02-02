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
    /// Логика взаимодействия для AddOrderWindow.xaml
    /// </summary>
    public partial class AddOrderWindow : Window
    {
        static public Entity db = new Entity();

        public AddOrderWindow()
        {
            InitializeComponent();

            SelectCBXCosignee();
            SelectCBXSender();
            SelectCBXUnit();
            SelectCBXOrigin();
            SelectCBXDesination();
        }

        private void SelectCBXSender()
        {
            cbxSender.ItemsSource = db.Costumers.ToList();
            cbxSender.DisplayMemberPath = "Name";
            cbxSender.SelectedIndex = 0;
        }

        private void SelectCBXCosignee()
        {
            cbxConsignee.ItemsSource = db.Costumers.ToList();
            cbxConsignee.DisplayMemberPath = "Name";
            cbxConsignee.SelectedIndex = 0;
        }

        private void SelectCBXUnit()
        {
            cbxUnit.ItemsSource = db.Units.ToList();
            cbxUnit.DisplayMemberPath = "FullName";
            cbxUnit.SelectedIndex = 0;
        }

        private void SelectCBXOrigin()
        {
            cbxOrigin.ItemsSource = db.Cities.ToList();
            cbxOrigin.DisplayMemberPath = "Name";
            cbxOrigin.SelectedIndex = 0;
        }

        private void SelectCBXDesination()
        {
            cbxDesination.ItemsSource = db.Cities.ToList();
            cbxDesination.DisplayMemberPath = "Name";
            cbxDesination.SelectedIndex = 0;
        }

        private void click_Back(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void click_AddInTheList(object sender, RoutedEventArgs e)
        {
            try
            {
                if (((Costumers)cbxConsignee.SelectedItem).ID == ((Costumers)cbxSender.SelectedItem).ID)
                {
                    MessageBox.Show("Вы не можете отправить груз самому себе!","Error",MessageBoxButton.OK,MessageBoxImage.Error);
                    return;
                }

                if (((Cities)cbxDesination.SelectedItem).ID == ((Cities)cbxOrigin.SelectedItem).ID)
                {
                    MessageBox.Show("Вы не можете отправить груз в город отправления!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                lv.Items.Add(new Order {
                    Costumers = (Costumers)cbxSender.SelectedItem,
                    Costumers1 = (Costumers)cbxConsignee.SelectedItem,
                    Shipment = tbxShipment.Text,
                    DeclareValue = decimal.Parse(tbxDeclareValue.Text),
                    Units = (Units)cbxUnit.SelectedItem,
                    InsureValue = decimal.Parse(tbxInsureValue.Text),
                    Cities = (Cities)cbxOrigin.SelectedItem,
                    Cities1 = (Cities)cbxDesination.SelectedItem
                });
            }
            catch 
            {
                MessageBox.Show("Введите корректные данные!","Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }

        private void click_Delete(object sender, RoutedEventArgs e)
        {
            var order = ((Button)sender).DataContext;
            lv.Items.Remove(order);
        }

        private void click_Save(object sender, RoutedEventArgs e)
        {
            foreach(var i in lv.Items)
            {
                db.Order.Add((Order)i);
            }

            db.SaveChanges();
            MessageBox.Show("Добавление груза/ов прошло успешно!","Perfect",MessageBoxButton.OK,MessageBoxImage.Information);
            this.Close();
        }

        private void click_AddNewCostumer(object sender, RoutedEventArgs e)
        {
            new AddNewCostumersWindow().Show();
            this.Close();
        }
    }
}
