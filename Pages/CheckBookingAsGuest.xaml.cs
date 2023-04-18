using HotelReserver.Classes;
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
    /// Логика взаимодействия для CheckBookingAsGuest.xaml
    /// </summary>
    public partial class CheckBookingAsGuest : Page
    {
        public CheckBookingAsGuest()
        {
            InitializeComponent();
            if(App.UserType == "Unauthorised")
            {
                GuestFIOLbl.Visibility = Visibility.Hidden;
                GuestFIOLbl.Visibility = Visibility.Hidden;
                DateOfStartLbl.Visibility = Visibility.Hidden;
                DateOfEndLbl.Visibility = Visibility.Hidden;
                RoomTypeLbl.Visibility = Visibility.Hidden;
                NoteLbl.Visibility = Visibility.Hidden;
                BookStatusLbl.Visibility = Visibility.Hidden;
                RoomNumber.Visibility = Visibility.Hidden;
                WarningLbl.Visibility = Visibility.Visible;
            }
            else
            {
                GuestFIOLbl.Visibility = Visibility.Visible;
                GuestFIOLbl.Visibility = Visibility.Visible;
                DateOfStartLbl.Visibility = Visibility.Visible;
                DateOfEndLbl.Visibility = Visibility.Visible;
                RoomTypeLbl.Visibility = Visibility.Visible;
                NoteLbl.Visibility = Visibility.Visible;
                BookStatusLbl.Visibility = Visibility.Visible;
                RoomNumber.Visibility = Visibility.Visible;
                WarningLbl.Visibility = Visibility.Hidden;
                App.BookingsGet();
                foreach (Booking booking in App.Bookings)
                {
                    if (booking.BookerFIO == App.UserFIO)
                    {
                        GuestFIOLbl.Content = "Фио гостя: " + booking.BookerFIO;
                        DateOfStartLbl.Content = "Дата заселения: " + booking.DateOfStart.ToString("dd.MM.yyyy");
                        DateOfEndLbl.Content = "Дата выселения: " + booking.DateOfEnd.ToString("dd.MM.yyyy");
                        RoomTypeLbl.Content = "Тип номера: " + booking.RoomType;
                        BookStatusLbl.Content = "Статус: "+booking.Status;
                        NoteLbl.Content = "Комментарий: "+booking.Note;

                    }
                }
            }
            
        }

        private void GoBackBtn(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
