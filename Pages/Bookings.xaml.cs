using HotelReserver.Classes;
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
    /// Логика взаимодействия для Bookings.xaml
    /// </summary>
    public partial class Bookings : Page
    {
        public static string SelectedStatus = "Все";
        public static string SelectedTime = "Все";
        public Bookings()
        {
            InitializeComponent();
            App.BookingsGet();
            App.RoomsGet();
            BookingsList.Items.Clear();
            foreach (var Booking in App.Bookings) { BookingsList.Items.Add(Booking.BookerFIO); }
            foreach (DataRow status in App.Get($"Select Status from BookingStatuses").Rows) { StatusCombo.Items.Add(status[0]); }
        }

        private void TimeSelectionBtn(object sender, RoutedEventArgs e)
        {
            BookingsList.Items.Clear();
            if (TimeSelection.Content.ToString() == "Все")
            {
                TimeSelection.Content = "Сегодня";
                SelectedTime = "Сегодня";
                if(SelectedStatus == "Все")
                {
                    foreach (var Booking in App.Bookings.Where(f => f.DateOfStart.Date == DateTime.Now.Date)) { BookingsList.Items.Add(Booking.BookerFIO); }
                }
                else
                {
                    foreach (var Booking in App.Bookings.Where(f => f.DateOfStart.Date == DateTime.Now.Date&&f.Status==SelectedStatus)) { BookingsList.Items.Add(Booking.BookerFIO); }
                }
            }
            else
            {
                TimeSelection.Content = "Все";
                SelectedTime = "Все";
                if(SelectedStatus == "Все")
                {
                    foreach (var Booking in App.Bookings) { BookingsList.Items.Add(Booking.BookerFIO); }
                }
                else
                {
                    foreach (var Booking in App.Bookings.Where(f => f.Status == SelectedStatus)) { BookingsList.Items.Add(Booking.BookerFIO); }
                }
                
            }
        }

        private void StatusSelectionBtn(object sender, RoutedEventArgs e)
        {

            BookingsList.Items.Clear();
            if (StatusSelection.Content.ToString() == "Все")
            {
                StatusSelection.Content = "Не подтвержденные";
                SelectedStatus = "Не подтвержден";
            }
            else if(StatusSelection.Content.ToString() == "Не подтвержденные")
            {
                StatusSelection.Content = "Подтвержденные";
                SelectedStatus = "Подтвержден";
            }
            else if (StatusSelection.Content.ToString() == "Подтвержденные")
            {
                StatusSelection.Content = "Заселенные";
                SelectedStatus = "Заселен";
            }
            else if(StatusSelection.Content.ToString() == "Заселенные")
            {
                StatusSelection.Content = "Истекшие";
                SelectedStatus = "Истек";
            }
            else
            {
                StatusSelection.Content = "Все";
                SelectedStatus = "Все";
            }
            if(TimeSelection.Content.ToString() == "Все")
            {
                if (SelectedStatus == "Все")
                {
                    foreach (var Booking in App.Bookings) { BookingsList.Items.Add(Booking.BookerFIO); }
                }
                else
                {
                    foreach (var Booking in App.Bookings.Where(f => f.Status == SelectedStatus)) { BookingsList.Items.Add(Booking.BookerFIO); }
                }
            }
            else
            {
                if (SelectedStatus == "Все")
                {
                    foreach (var Booking in App.Bookings.Where(f => f.DateOfStart.Date == DateTime.Now.Date)) { BookingsList.Items.Add(Booking.BookerFIO); }
                }
                else
                {
                    foreach (var Booking in App.Bookings.Where(f => f.DateOfStart.Date == DateTime.Now.Date && f.Status == SelectedStatus)) { BookingsList.Items.Add(Booking.BookerFIO); }
                }
            }
        }

        private void GoBackBtn(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void RoomsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (BookingsList.SelectedIndex != -1)
            {
                DoneBtn.Visibility = Visibility.Visible;
                GuestFIOLbl.Visibility = Visibility.Visible;
                DateOfStartLbl.Visibility = Visibility.Visible;
                DateOfEndLbl.Visibility = Visibility.Visible;
                RoomTypeLbl.Visibility = Visibility.Visible;
                NoteLbl.Visibility = Visibility.Visible;
                NoteBox.Visibility = Visibility.Visible;
                BookStatusLbl.Visibility = Visibility.Visible;
                StatusCombo.Visibility = Visibility.Visible;
                RoomCombo.Visibility = Visibility.Visible;
                RoomNumber.Visibility = Visibility.Visible;
                WelcomeGuestBtn.Visibility = Visibility.Visible;
                GuestNumber.Visibility= Visibility.Visible;
                foreach (Booking booking in App.Bookings)
                {
                    if (booking.BookerFIO == BookingsList.SelectedItem.ToString())
                    {
                        RoomCombo.Items.Clear();
                        foreach (Room room in App.Rooms.Where(f => f.Status == "Свободен"&&f.RoomType==booking.RoomType)){ RoomCombo.Items.Add(room.Number); }
                        GuestFIOLbl.Content = "Фио гостя: " + booking.BookerFIO;
                        DateOfStartLbl.Content = "Дата заселения: " + booking.DateOfStart.ToString("dd.MM.yyyy");
                        DateOfEndLbl.Content = "Дата выселения: " + booking.DateOfEnd.ToString("dd.MM.yyyy");
                        RoomTypeLbl.Content = "Тип номера: " + booking.RoomType;
                        GuestNumber.Content = "Номер телефона:" + App.Get($"Select PhoneNumber from Guests where FIO = '{booking.BookerFIO}'").Rows[0][0].ToString();
                        StatusCombo.SelectedItem = booking.Status;
                        NoteBox.Text = booking.Note;

                    }
                }
            }
            else
            {
                DoneBtn.Visibility = Visibility.Hidden;
                GuestFIOLbl.Visibility = Visibility.Hidden;
                DateOfStartLbl.Visibility = Visibility.Hidden;
                DateOfEndLbl.Visibility = Visibility.Hidden;
                RoomTypeLbl.Visibility = Visibility.Hidden;
                NoteLbl.Visibility = Visibility.Hidden;
                NoteBox.Visibility = Visibility.Hidden;
                BookStatusLbl.Visibility = Visibility.Hidden;
                StatusCombo.Visibility = Visibility.Hidden;
                RoomCombo.Visibility = Visibility.Hidden;
                RoomNumber.Visibility = Visibility.Hidden;
                WelcomeGuestBtn.Visibility = Visibility.Hidden;
                GuestNumber.Visibility = Visibility.Hidden;
            }
        }

        private void DoneBtnClick(object sender, RoutedEventArgs e)
        {
            int id = 0;
            foreach (var Booking in App.Bookings.Where(f => f.BookerFIO == BookingsList.SelectedItem.ToString())) { id = Booking.id; }
            App.Set($"Update Bookings SET status = '{StatusCombo.SelectedIndex + 1}',Note = '{NoteBox.Text}' where id='{id}'");
            App.BookingsGet();
            App.RoomsGet();
            BookingsList.Items.Clear();
            if (TimeSelection.Content.ToString() == "Все")
            {
                if (SelectedStatus == "Все")
                {
                    foreach (var Booking in App.Bookings) { BookingsList.Items.Add(Booking.BookerFIO); }
                }
                else
                {
                    foreach (var Booking in App.Bookings.Where(f => f.Status == SelectedStatus)) { BookingsList.Items.Add(Booking.BookerFIO); }
                }
            }
            else
            {
                if (SelectedStatus == "Все")
                {
                    foreach (var Booking in App.Bookings.Where(f => f.DateOfStart.Date == DateTime.Now.Date)) { BookingsList.Items.Add(Booking.BookerFIO); }
                }
                else
                {
                    foreach (var Booking in App.Bookings.Where(f => f.DateOfStart.Date == DateTime.Now.Date && f.Status == SelectedStatus)) { BookingsList.Items.Add(Booking.BookerFIO); }
                }
            }
            
        }

        private void WelcomeBtnClick(object sender, RoutedEventArgs e)
        {
            if (RoomCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите комнату для заселения");
                return;
            }

                int id = 0;
                foreach (var Booking in App.Bookings.Where(f => f.BookerFIO == BookingsList.SelectedItem.ToString())) { id = Booking.id; }
                App.Set($"Update Bookings SET status = '3',Note = '{NoteBox.Text}' where id='{id}'");
                App.Set($"Update Rooms SET Status = '1',CurrentGuestId='{App.Get($"Select Id from Guests Where FIO = '{BookingsList.SelectedItem}'").Rows[0][0]}' where RoomNumber='{RoomCombo.SelectedItem}'");
                App.BookingsGet();
                App.RoomsGet();
                BookingsList.Items.Clear();
                if (TimeSelection.Content.ToString() == "Все")
                {
                    if (SelectedStatus == "Все")
                    {
                        foreach (var Booking in App.Bookings) { BookingsList.Items.Add(Booking.BookerFIO); }
                    }
                    else
                    {
                        foreach (var Booking in App.Bookings.Where(f => f.Status == SelectedStatus)) { BookingsList.Items.Add(Booking.BookerFIO); }
                    }
                }
                else
                {
                    if (SelectedStatus == "Все")
                    {
                        foreach (var Booking in App.Bookings.Where(f => f.DateOfStart.Date == DateTime.Now.Date)) { BookingsList.Items.Add(Booking.BookerFIO); }
                    }
                    else
                    {
                        foreach (var Booking in App.Bookings.Where(f => f.DateOfStart.Date == DateTime.Now.Date && f.Status == SelectedStatus)) { BookingsList.Items.Add(Booking.BookerFIO); }
                    }
                }
            

        }
    }
}
