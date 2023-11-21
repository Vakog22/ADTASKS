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

namespace _11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Product> products = new List<Product>();
        class Manufacturer 
        { 
            public int Id { get; set; }
            public string Name { get; set; }
        }

        class Product
        {
            public string Name { get; set; }
            public int GroupId { get; set; }
            public int ManufacturerId { get; set; }
            public decimal Cost { get; set; }
        }

        class Group
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public MainWindow()
        {
            InitializeComponent();

            List<Group> groups = new List<Group>();
            Group group = new Group();
            group.Id = 1;
            group.Name = "Типа";
            groups.Add(group);

            List<Manufacturer> manufacturers = new List<Manufacturer>();
            Manufacturer manufacturer = new Manufacturer();
            manufacturer.Id = 1;
            manufacturer.Name = "Типа";
            manufacturers.Add(manufacturer);

            cmbGroup.ItemsSource = groups;
            cmbGroup.SelectedIndex = 0;
            cmbGroup.DisplayMemberPath = "Name";

            cmbManufacturer.ItemsSource = manufacturers;
            cmbManufacturer.SelectedIndex = 0;
            cmbManufacturer.DisplayMemberPath = "Name";
        }

        private void btnButton_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(tbName.Text) && String.IsNullOrEmpty(tbPrice.Text))
            {
                MessageBox.Show("Пиздец");
            }
            else
            {
                Product product = new Product();
                product.Name = tbName.Text;
                product.Cost = Convert.ToDecimal(tbPrice.Text);
                product.ManufacturerId = (cmbManufacturer.SelectedItem as Manufacturer).Id;
                product.GroupId = (cmbGroup.SelectedItem as Group).Id;
                MessageBox.Show("Заебись");
            }
        }
    }
}
