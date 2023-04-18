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
    /// Логика взаимодействия для Rooms.xaml
    /// </summary>
    public partial class Rooms : Page
    {
        public Rooms()
        {
            InitializeComponent();
            App.RoomsGet();
            foreach (var room in App.Rooms) { RoomsList.Items.Add(room.Number);}
        }

        private void GoBackBtn(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BookedSelectionBtn(object sender, RoutedEventArgs e)
        {
            RoomsList.Items.Clear();
            if (BookingSelection.Content.ToString() == "Все")
            {
                BookingSelection.Content = "Занятые";
                foreach (var room in App.Rooms.Where(f=>f.Status=="Занят")) { RoomsList.Items.Add(room.Number); }
            }
            else if(BookingSelection.Content.ToString() == "Занятые")
            {
                BookingSelection.Content = "Свободные";
                foreach (var room in App.Rooms.Where(f => f.Status == "Свободен")) { RoomsList.Items.Add(room.Number); }
            }
            else
            {
                BookingSelection.Content = "Все";
                foreach (var room in App.Rooms) { RoomsList.Items.Add(room.Number); }
            }
        }

        private void RoomsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RoomsList.SelectedIndex != -1)
            {
                KickBtn.Visibility = Visibility.Visible;
                DoneBtn.Visibility = Visibility.Visible;
                RoomNumber.Visibility = Visibility.Visible;
                Guest.Visibility = Visibility.Visible;
                RoomType.Visibility = Visibility.Visible;
                Note.Visibility = Visibility.Visible;
                NoteText.Visibility = Visibility.Visible;
                RoomStatus.Visibility = Visibility.Visible;

                foreach(Room room in App.Rooms)
                {
                    if(room.Number == Convert.ToInt32(RoomsList.SelectedItem))
                    {
                        RoomNumber.Content = "Комната номер "+room.Number;
                        RoomStatus.Content = "Статус комнаты: " + room.Status;
                        RoomType.Content = "Вид комнаты: " + room.RoomType;
                        Guest.Content = "Гость: " + room.GuestFIO;
                        NoteText.Text = room.Note;
                    }
                }
            }
            else
            {
                KickBtn.Visibility = Visibility.Hidden;
                DoneBtn.Visibility = Visibility.Hidden;
                RoomNumber.Visibility = Visibility.Hidden;
                Guest.Visibility = Visibility.Hidden;
                RoomType.Visibility = Visibility.Hidden;
                Note.Visibility = Visibility.Hidden;
                NoteText.Visibility = Visibility.Hidden;
                RoomStatus.Visibility = Visibility.Hidden;
            }
        }

        private void DoneBtnClick(object sender, RoutedEventArgs e)
        {
            try 
            {
                App.Set($"Update Rooms Set Note = '{NoteText.Text}' where RoomNumber = '{RoomsList.SelectedItem}' ");
            }
            catch
            {
                return;
            }
            MessageBox.Show("Успешно применено!");
        }

        private void KickBtnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                App.Set($"Update Rooms Set CurrentGuestId = NULL,Status = '2' where RoomNumber = '{RoomsList.SelectedItem}' ");
            }
            catch
            {
                return;
            }
            MessageBox.Show("Гость успешно выселен!");
            App.RoomsGet();
            RoomsList.Items.Clear();
            foreach (var room in App.Rooms) { RoomsList.Items.Add(room.Number); }
        }
    }
}
