using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace InfoSystem
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<ICompanyUnit> Nodes;

        Randomize rnd = new Randomize();
        public MainWindow()
        {
            InitializeComponent();
            #region Исходные данные
            Nodes = new ObservableCollection<ICompanyUnit>
            {
                new Company("Рога и копыта")
                {
                    CUnits = new ObservableCollection<ICompanyUnit>()
                    {
                        new Manager(1, rnd.NextFullName(), rnd.Next(20,50), 2000),
                        new Department("Бухгалтерия")
                        {
                            CUnits = new ObservableCollection<ICompanyUnit>
                            {
                                new Manager(2, rnd.NextFullName(), rnd.Next(20,50), 1200),
                                new Intern(2, rnd.NextFullName(), rnd.Next(20,50)),
                                new Intern(2, rnd.NextFullName(), rnd.Next(20,50)),
                                new Worker(2, rnd.NextFullName(), rnd.Next(20,50))
                            }
                        },
                        new Department("Отдел кадров")
                        {
                            CUnits = new ObservableCollection<ICompanyUnit>
                            {
                                new Manager(3, rnd.NextFullName(), rnd.Next(20,50), 1200),
                                new Intern(3, rnd.NextFullName(), rnd.Next(20,50)),
                                new Intern(3, rnd.NextFullName(), rnd.Next(20,50)),
                                new Worker(3, rnd.NextFullName(), rnd.Next(20,50))
                            }
                        },
                        new Department("IT")
                        {
                            CUnits = new ObservableCollection<ICompanyUnit>
                            {
                                new Manager(4, rnd.NextFullName(), rnd.Next(20,50), 1200),
                                new Worker(4, rnd.NextFullName(), rnd.Next(20,50)),
                                new Department("Кодеры")
                                {
                                    CUnits = new ObservableCollection<ICompanyUnit>
                                    {
                                        new Manager(5, rnd.NextFullName(), rnd.Next(20,50), 1200),
                                        new Department("C#")
                                        {
                                            CUnits = new ObservableCollection<ICompanyUnit>
                                            {
                                                new Manager(6, rnd.NextFullName(), rnd.Next(20,50), 1200),
                                                new Worker(6, rnd.NextFullName(), rnd.Next(20,50)),
                                                new Worker(6, rnd.NextFullName(), rnd.Next(20,50)),
                                                new Worker(6, rnd.NextFullName(), rnd.Next(20,50)),
                                                new Worker(6, rnd.NextFullName(), rnd.Next(20,50)),
                                            }
                                        },
                                        new Department("Pyton")
                                        {
                                            CUnits= new ObservableCollection<ICompanyUnit>
                                            {
                                                new Manager(7, rnd.NextFullName(), rnd.Next(20,50), 1200),
                                                new Worker(7, rnd.NextFullName(), rnd.Next(20,50)),
                                                new Worker(7, rnd.NextFullName(), rnd.Next(20,50)),
                                                new Worker(7, rnd.NextFullName(), rnd.Next(20,50)),
                                                new Worker(7, rnd.NextFullName(), rnd.Next(20,50)),
                                            }
                                        },
                                        new Department("Frontend")
                                        {
                                            CUnits = new ObservableCollection<ICompanyUnit>
                                            {
                                                new Manager(8, rnd.NextFullName(), rnd.Next(20,50), 1200),
                                                new Worker(8, rnd.NextFullName(), rnd.Next(20,50)),
                                                new Worker(8, rnd.NextFullName(), rnd.Next(20,50)),
                                                new Worker(8, rnd.NextFullName(), rnd.Next(20,50)),
                                                new Worker(8, rnd.NextFullName(), rnd.Next(20,50)),
                                                new Worker(8, rnd.NextFullName(), rnd.Next(20,50))
                                            }
                                        }

                                    }
                                },
                                new Department("Тестировщики")
                                {
                                    CUnits = new ObservableCollection<ICompanyUnit>
                                    {
                                        new Manager(9, rnd.NextFullName(), rnd.Next(20,50), 1200),
                                        new Worker(9, rnd.NextFullName(), rnd.Next(20,50)),
                                        new Worker(9, rnd.NextFullName(), rnd.Next(20,50)),
                                        new Worker(9, rnd.NextFullName(), rnd.Next(20,50)),
                                        new Worker(9, rnd.NextFullName(), rnd.Next(20,50)),
                                        new Worker(9, rnd.NextFullName(), rnd.Next(20,50)),
                                        new Worker(9, rnd.NextFullName(), rnd.Next(20,50)),
                                    }
                                }

                            }
                        },
                        new Department("Хозяйственный")
                        {
                            CUnits= new ObservableCollection<ICompanyUnit>
                            {
                                new Manager(10, rnd.NextFullName(), rnd.Next(20,50), 1200),
                                new Worker(10, rnd.NextFullName(), rnd.Next(20,50)),
                                new Worker(10, rnd.NextFullName(), rnd.Next(20,50)),
                                new Worker(10, rnd.NextFullName(), rnd.Next(20,50)),
                                new Worker(10, rnd.NextFullName(), rnd.Next(20,50))
                            }
                        }
                    }
                }
            };
            CompanyStructureView.ItemsSource = Nodes;
            CompanyStructureView.Items.Refresh();
            #endregion



        }


        private void ButtonRnd_Click(object sender, RoutedEventArgs e)
        {
        }

        private void GetStructure()
        {
        }
    }
}
