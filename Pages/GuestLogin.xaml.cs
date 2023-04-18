using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для GuestLogin.xaml
    /// </summary>
    public partial class GuestLogin : Page
    {
        public GuestLogin()
        {
            InitializeComponent();
        }

        private void GoBackBtn(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            try 
            { 
                dt = App.Get($"SELECT [id],[FIO] FROM [HotelReserver].[dbo].[Guests] Where PhoneNumber = '{LoginBox.Text}' and Password = '{PasswordBox.Password}'");
                App.UserId = Convert.ToInt32(dt.Rows[0][0].ToString());
                App.UserType = "Зарегестрированный пользователь";
                App.UserFIO = dt.Rows[0][1].ToString();
                NavigationService.Navigate(new GuestPage());
            }
            catch 
            { 
                MessageBox.Show("Неправильный логин или пароль");
                return;
            }
            

        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new GuestRegister());
        }
    }
}
