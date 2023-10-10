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

namespace Bank_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int WhoUseIt { get; set; }
        Consultant Employee;
        public MainWindow()
        {
            InitializeComponent();
            if (WhoUseIt == 1) { Employee = new Manager("Clients.txt"); }
            else
            {
                Employee = new Consultant("Clients.txt");
                ButtonAdd.IsEnabled = false;
                TextBoxLastname.IsEnabled = false;
                TextBoxFirstname.IsEnabled = false;
                TextBoxPartonymic.IsEnabled = false;
                TextBoxPassNumber.IsEnabled = false;
            }
            DbListView.ItemsSource = Employee.Clients;
        }

        private void ButtonChange_Click(object sender, RoutedEventArgs e)
        {
            if (DbListView.SelectedItem != null)
            {
                string[] para = new string[]
                {
                    TextBoxLastname.Text,
                    TextBoxFirstname.Text,
                    TextBoxPartonymic.Text,
                    TextBoxPhoneNumber.Text,
                    TextBoxPassNumber.Text 
                };
                Employee.Edit(DbListView.SelectedItem as Client, para);
                DbListView.Items.Refresh();
            }
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            string[] para = new string[]
            {
                    TextBoxLastname.Text,
                    TextBoxFirstname.Text,
                    TextBoxPartonymic.Text,
                    TextBoxPhoneNumber.Text,
                    TextBoxPassNumber.Text
            };
            ((Manager)Employee).AddClient(para);
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            Employee.Save();
        }

        private void mainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            App.Current.Shutdown();
        }

    }
}
