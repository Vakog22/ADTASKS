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

namespace _18
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        class Service 
        { 
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime date { get; set; }
            public Service(int a, string b, DateTime c) 
            { 
                Id = a;
                Name = b;
                date = c;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            List<Service> services = new List<Service>
            {
                new Service(1, "Первый", DateTime.Now),
                new Service(2, "Второй", DateTime.Now),
                new Service(3, "Третий", DateTime.Now)
            };
            DG.ItemsSource = services;
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
