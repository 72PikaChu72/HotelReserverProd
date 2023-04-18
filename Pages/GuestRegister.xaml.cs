using System;
using System.Collections.Generic;
using System.Linq;
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

namespace HotelReserver.Pages
{
    /// <summary>
    /// Логика взаимодействия для GuestRegister.xaml
    /// </summary>
    public partial class GuestRegister : Page
    {
        public GuestRegister()
        {
            InitializeComponent();
        }

        private void GoBackBtn(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void RegisterBtn(object sender, RoutedEventArgs e)
        {
            string FIO = "";
            string PassportNumber = "";
            string PassportSeries = "";
            string DateOfBirth = "";
            string PhoneNumber = "";
            string Password = PasswordBox.Text;
            //#FFABADB3
            SolidColorBrush DefaultColor = new SolidColorBrush(Color.FromRgb(171, 173, 179));
            SolidColorBrush RedColor = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            FIOBox.BorderBrush = DefaultColor;
            PassportNumberBox.BorderBrush = DefaultColor;
            PassportSeriesBox.BorderBrush = DefaultColor;
            DateBox.BorderBrush = DefaultColor;
            PhoneNumberBox.BorderBrush = DefaultColor;
            PasswordBox.BorderBrush = DefaultColor;

            Regex RFIO = new Regex(@"^[\p{L}']+ [\p{L}']+ [\p{L}']+$");
            Regex RPassportSeries = new Regex(@"^\d{4}$");
            Regex RPassportNumber = new Regex(@"^\d{6}$");
            Regex RDateOfBirth = new Regex(@"^\d{2}\.\d{2}\.\d{4}$");
            Regex RPhoneNumber = new Regex(@"^(?:\+7|8)\d{10}$");
            Regex RPassword = new Regex(@"^.{8,}$");
            if (RFIO.IsMatch(FIOBox.Text))
            {
                FIO = FIOBox.Text;
            }
            else
            {
                FIOBox.BorderBrush = RedColor;
                MessageBox.Show("Проверьте правильность ФИО");
                return;
            }
            if(RPassportSeries.IsMatch(PassportSeriesBox.Text.Replace(" ", "")))
            {
                PassportSeries = PassportSeriesBox.Text.Replace(" ", "");
            }
            else
            {
                PassportSeriesBox.BorderBrush = RedColor;
                MessageBox.Show("Проверьте правильность серии паспорта");
                return;
            }
            if (RPassportNumber.IsMatch(PassportNumberBox.Text.Replace(" ", "")))
            {
                PassportNumber = PassportNumberBox.Text.Replace(" ", "");
            }
            else
            {
                PassportNumberBox.BorderBrush = RedColor;
                MessageBox.Show("Проверьте правильность номера паспорта");
                return;
            }
            if (RDateOfBirth.IsMatch(DateBox.DisplayDate.Date.ToString("dd.MM.yyyy"))&&DateBox.DisplayDate.Date!=DateTime.Now.Date)
            {
                DateOfBirth = DateBox.DisplayDate.Date.ToString("dd.MM.yyyy");
            }
            else
            {
                DateBox.BorderBrush = RedColor;
                MessageBox.Show("Проверьте правильность даты рождения");
                return;
            }
            if (RPhoneNumber.IsMatch(PhoneNumberBox.Text))
            {
                PhoneNumber = PhoneNumberBox.Text;
            }
            else
            {
                PhoneNumberBox.BorderBrush = RedColor;
                MessageBox.Show("Проверьте правильность номера телефона");
                return;
            }
            if (RPassword.IsMatch(PasswordBox.Text))
            {
                Password = PasswordBox.Text;
            }
            else
            {
                PasswordBox.BorderBrush = RedColor;
                MessageBox.Show("Пароль должен содержать более 8 символов");
                return;
            }
            try
            {
                App.Set($"Insert Into [Guests](FIO,PassportNumber,PassportSeries,DateOfBirth,PhoneNumber,Password)Values('{FIO}','{PassportNumber}','{PassportSeries}','{DateOfBirth}','{PhoneNumber}','{Password}')");
            }
            catch { return; }
            MessageBox.Show("Успешно зарегистрирован!");
            App.UserFIO = FIOBox.Text;
            App.UserType = "Зарегестрированный пользователь";
            NavigationService.Navigate(new GuestPage());
        }
    }
}
