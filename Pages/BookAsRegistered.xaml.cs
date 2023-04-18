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
    /// Логика взаимодействия для BookAsRegistered.xaml
    /// </summary>
    public partial class BookAsRegistered : Page
    {
        public BookAsRegistered()
        {
            InitializeComponent();
            foreach (DataRow row in App.Get($"SELECT RoomType FROM RoomTypes").Rows)
            {
                RoomTypeCombo.Items.Add(row[0].ToString());
            }
        }

        private void GoBackBtn(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BookBtn(object sender, RoutedEventArgs e)
        {
            if (App.UserType != "Зарегестрированный пользователь") return;
            if (RoomTypeCombo.SelectedIndex == -1) { MessageBox.Show("Выберите тип комнаты"); return; }
            if (DateOfStartBox.DisplayDate.Date <= DateTime.Now.Date || DateOfEndBox.DisplayDate.Date <= DateTime.Now.Date|| DateOfEndBox.DisplayDate.Date < DateOfStartBox.DisplayDate.Date) { MessageBox.Show("Проверьте даты заселения и выселения"); return; }
            App.BookARoom(RoomTypeCombo.SelectedIndex + 1, DateOfStartBox.DisplayDate.Date, DateOfEndBox.DisplayDate.Date, App.UserId, NoteBox.Text);
            MessageBox.Show("Успешно забронировано!");
            NavigationService.Navigate(new GuestPage());
        }
    }
}
