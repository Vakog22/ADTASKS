using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
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
using System.Xml.Linq;

namespace _25
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Appointment> services = new List<Appointment>();
        class Doctor
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        class Appointment
        {
            public int DoctorId { get; set; }
            public int ServiceId { get; set; }
            public DateTime Date { get; set; }
        }

        class Service
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public MainWindow()
        {
            InitializeComponent();

            List<Doctor> doctors = new List<Doctor>();
            Doctor group = new Doctor();
            group.Id = 1;
            group.Name = "Сатана";
            doctors.Add(group);

            List<Service> services = new List<Service>();
            Service manufacturer = new Service();
            manufacturer.Id = 1;
            manufacturer.Name = "Вырывание челюсти";
            services.Add(manufacturer);

            cmbdoctor.ItemsSource = doctors;
            cmbdoctor.SelectedIndex = 0;
            cmbdoctor.DisplayMemberPath = "Name";

            cmbservice.ItemsSource = services;
            cmbservice.SelectedIndex = 0;
            cmbservice.DisplayMemberPath = "Name";

        }

        private void btnButton_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(dp.Text))
            {
                MessageBox.Show("Пиздец");
            }
            else
            {
                Appointment appointment = new Appointment();
                appointment.Date = Convert.ToDateTime(dp.Text);
                appointment.ServiceId = (cmbservice.SelectedItem as Service).Id;
                appointment.DoctorId = (cmbdoctor.SelectedItem as Doctor).Id;
                MessageBox.Show("Заебись");
            }
        }
    }
}
