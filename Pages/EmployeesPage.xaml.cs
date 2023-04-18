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

namespace HotelReserver.Pages
{
    /// <summary>
    /// Логика взаимодействия для EmployeesPage.xaml
    /// </summary>
    public partial class EmployeesPage : Page
    {
        public EmployeesPage()
        {
            InitializeComponent();
            FIOLabel.Content = FIOLabel.Content + " " + App.UserFIO;
        }

        private void LogoutClick(object sender, RoutedEventArgs e)
        {
            App.UserType = "Unauthorised";
            App.UserFIO = "Гость";
            NavigationService.Navigate(new LoginPage());
        }

        private void RoomsClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Rooms());
        }

        private void BookingsClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Bookings());
        }
    }
}
