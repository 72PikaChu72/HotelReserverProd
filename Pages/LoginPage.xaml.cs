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
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginAsGuestClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new GuestPage());
        }

        private void LoginBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                App.UserFIO = App.Get($"Select FIO from Administrators WHERE login = '{LoginBox.Text}' and password = '{PasswordBox.Password}'").Rows[0][0].ToString();
            }
            catch 
            { 
                MessageBox.Show("Такого пользователя не существует!"); 
                App.UserFIO = "Unauthorised";
                App.UserType = "Гость";
                return; 
            }
            App.UserType = "Администратор";
            NavigationService.Navigate(new EmployeesPage());
        }
    }
}
