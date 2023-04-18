using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для BookAsGuest.xaml
    /// </summary>
    public partial class BookAsGuest : Page
    {
        public BookAsGuest()
        {
            InitializeComponent();
            foreach(DataRow row in App.Get($"SELECT RoomType FROM RoomTypes").Rows)
            {
                RoomTypeCombo.Items.Add(row[0].ToString());
            }
        }

        private void GoBackBtn(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
        private static void Login(string PhoneNumber, string Password)
        {
                DataTable dt = new DataTable();
                dt = App.Get($"SELECT [id],[FIO] FROM [Guests] Where PhoneNumber = '{PhoneNumber}' and Password = '{Password}'");
                App.UserId = Convert.ToInt32(dt.Rows[0][0].ToString());
                App.UserType = "Зарегестрированный пользователь";
                App.UserFIO = dt.Rows[0][1].ToString();
        }

        private void BookBtn(object sender, RoutedEventArgs e)
        {

            //Try to login
            try
            {
                Login(PhoneNumberBox.Text,PasswordBox.Text);
            }
            catch
            {
                //Try to register
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
                if (RPassportSeries.IsMatch(PassportSeriesBox.Text.Replace(" ", "")))
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
                if (RDateOfBirth.IsMatch(DateBox.DisplayDate.Date.ToString("dd.MM.yyyy")) && DateBox.DisplayDate.Date != DateTime.Now.Date)
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
                App.UserFIO = FIOBox.Text;
                App.UserType = "Зарегестрированный пользователь";
                //Then try to login
                Login(PhoneNumberBox.Text, PasswordBox.Text);
            }
            //If logged in, book
            if (App.UserType != "Зарегестрированный пользователь") return;
            if (RoomTypeCombo.SelectedIndex == -1) { MessageBox.Show("Выберите тип комнаты"); return;}
            if (DateOfStartBox.DisplayDate.Date <= DateTime.Now.Date || DateOfEndBox.DisplayDate.Date <= DateTime.Now.Date || DateOfEndBox.DisplayDate.Date < DateOfStartBox.DisplayDate.Date) { MessageBox.Show("Проверьте даты заселения и выселения"); return; }
            App.BookARoom(RoomTypeCombo.SelectedIndex+1, DateOfStartBox.DisplayDate.Date, DateOfEndBox.DisplayDate.Date,App.UserId,"Новый гость");
            MessageBox.Show("Успешно забронировано!");
            NavigationService.Navigate(new GuestPage());
        }
    }
}
