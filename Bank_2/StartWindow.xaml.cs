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

namespace Bank_2
{
    /// <summary>
    /// Логика взаимодействия для StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        static string[] Emploees;
        static StartWindow()
        {
            Emploees = new string[] { "Консультант", "Менеджер" };
        }
        public StartWindow()
        {
            InitializeComponent();
            EmploeesComboBox.ItemsSource = Emploees;
        }

        private void ButtonОк_Click(object sender, RoutedEventArgs e)
        {
            if(EmploeesComboBox.SelectedItem != null)
            {
                if (EmploeesComboBox.SelectedItem.ToString().Equals(Emploees[0])) MainWindow.WhoUseIt = 0;
                if (EmploeesComboBox.SelectedItem.ToString().Equals(Emploees[1])) MainWindow.WhoUseIt = 1;
                startWindow.Hide();
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            }
        }
    }
}
