using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bank_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Consultant Employee;
        public MainWindow()
        {
            InitializeComponent();
            Employee = new Consultant("Clients.txt");
            DbListView.ItemsSource = Employee.Clients;
        }

        private void ButtonOk_Click(object sender, RoutedEventArgs e)
        {
            
            if (DbListView.SelectedItem != null)
            {
                Employee.SetClientsData(DbListView.SelectedItem as Client, TextBoxPhoneNumber.Text);
                DbListView.Items.Refresh();
            }
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            Employee.Save();
        }
    }
}
