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
using static _18.ServiceList;

namespace _18
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DG.ItemsSource = ServiceList.services;
        }


        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            services.Remove(DG.SelectedItem as Service);
            DG.Items.Refresh();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddEditWindow addEditWindow = new AddEditWindow();
            addEditWindow.Show();
            DG.Items.Refresh();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            DG.Items.Refresh();
        }
    }
}
