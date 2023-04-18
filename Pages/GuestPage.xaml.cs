using Microsoft.SqlServer.Server;
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
    /// Логика взаимодействия для GuestPage.xaml
    /// </summary>
    public partial class GuestPage : Page
    {
        public GuestPage()
        {
            InitializeComponent();
            FIOLabel.Content = "Добро пожаловать, "+ "Гость";
            if (App.UserType != "Unauthorised")
            {
                FIOLabel.Content = "Добро пожаловать, " + " " + App.UserFIO;
                LoginBtn.Content = "Выйти из аккаунта";
            }
        }

        private void GoBackBtn(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LoginPage());
        }

        private void CheckBookClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CheckBookingAsGuest());
        }

        private void LoginClick(object sender, RoutedEventArgs e)
        {
            if(App.UserType == "Unauthorised")
            {
                NavigationService.Navigate(new GuestLogin());
            }
            else
            {
                App.UserType = "Unauthorised";
                App.UserFIO = "Гость";
                NavigationService.Navigate(new GuestPage());
            }
        }

        private void BookClick(object sender, RoutedEventArgs e)
        {
            if(App.UserType == "Unauthorised")
            {
                NavigationService.Navigate(new BookAsGuest());
            }
            else
            {
                NavigationService.Navigate(new BookAsRegistered());
            }
        }
    }
}
