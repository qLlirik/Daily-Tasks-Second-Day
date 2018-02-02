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
    /// Логика взаимодействия для AddNewCostumersWindow.xaml
    /// </summary>
    public partial class AddNewCostumersWindow : Window
    {
        Entity db = AddOrderWindow.db;
        Costumers cst = new Costumers();

        public AddNewCostumersWindow()
        {
            InitializeComponent();

            this.DataContext = cst;
        }

        private void click_AddNewCostimer(object sender, RoutedEventArgs e)
        {
            
            try
            {
                if (cst.INN == 0)
                {
                    throw new Exception();
                }

                db.Costumers.Add(cst);
                db.SaveChanges();

                MessageBox.Show("Добавление нового заказчика прошла успешно!", "Perfect", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
                new AddOrderWindow().Show();
            }
            catch
            {
                MessageBox.Show("Введите данные!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
