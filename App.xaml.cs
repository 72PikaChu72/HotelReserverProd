using HotelReserver.Classes;
using HotelReserver.Pages;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HotelReserver
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        // Данные о сервере
        public static SqlConnection Connection = new SqlConnection("server=PikaChu-PC\\PIKACHUSQL;Trusted_Connection=yes;database=HotelReserver");



        public static List<Room> Rooms = new List<Room>();
        public static List<Booking> Bookings = new List<Booking>();
        public static int UserId = -1;
        public static string UserType = "Unauthorised";
        public static string UserFIO = "Гость";
        public static DataTable Get(string Query)
        {
            try
            {
                DataTable dataTable = new DataTable("dataBase");
                Connection.Open();
                SqlCommand sqlCommand = Connection.CreateCommand();
                sqlCommand.CommandText = Query;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);
                Connection.Close();
                return dataTable;
            }
            catch(Exception ex)
            {
                Connection.Close();
                MessageBox.Show("Ошибка " + ex.Message);
                return null;
            }
        }
        public static void RoomsGet()
        {
            DataTable dataTable = Get("SELECT [RoomNumber],[CurrentGuestId],[Note],[Status],[RoomType] FROM [Rooms]");
            Rooms.Clear();
            foreach (DataRow a in dataTable.Rows)
            {
                Room room = new Room();
                room.Number = Convert.ToInt32(a[0]);
                if (Convert.ToString(a[1]) != "") room.GuestFIO = Get($"SELECT FIO FROM Guests where Id = '{Convert.ToString(a[1])}'").Rows[0][0].ToString(); ;
                room.Note = Convert.ToString(a[2]);
                if (Convert.ToString(a[3]) != "") room.Status = Get($"SELECT Status FROM RoomStatuses where Id = '{Convert.ToString(a[3])}'").Rows[0][0].ToString();
                if (Convert.ToString(a[4]) != "") room.RoomType = Get($"SELECT RoomType FROM RoomTypes where Id = '{Convert.ToString(a[4])}'").Rows[0][0].ToString();
                Rooms.Add(room);
            }

        }
        public static void BookingsGet()
        {
            DataTable dataTable = Get("SELECT * FROM [Bookings]");
            Bookings.Clear();
            foreach (DataRow a in dataTable.Rows)
            {
                Booking booking = new Booking();
                booking.id = Convert.ToInt32(a[0]);
                if (Convert.ToString(a[1]) != "") booking.RoomType = Get($"SELECT RoomType FROM RoomTypes where id = '{Convert.ToString(a[1])}'").Rows[0][0].ToString();
                booking.DateOfStart = Convert.ToDateTime(a[2]);
                booking.DateOfEnd = Convert.ToDateTime(a[3]);
                if (Convert.ToString(a[4]) != "") booking.BookerFIO = Get($"SELECT FIO FROM Guests where id = '{Convert.ToString(a[4])}'").Rows[0][0].ToString();
                booking.Note = Convert.ToString(a[5]);
                booking.Status = Get($"SELECT Status FROM BookingStatuses where id = '{Convert.ToString(a[6])}'").Rows[0][0].ToString();
                Bookings.Add(booking);
            }
        }
        public static void Set(string Query)
        {
            try
            {
                Connection.Open();
                SqlCommand sqlCommand = Connection.CreateCommand();
                sqlCommand.CommandText = Query;
                sqlCommand.ExecuteNonQuery();
                Connection.Close();
            }
            catch(Exception ex)
            {
                Connection.Close();
                MessageBox.Show("Ошибка "+ex.Message);
            }
        } 
        public static void BookARoom(int Type, DateTime DateOfStart, DateTime DateOfEnd,int UserId,string Note)
        {
            Set($"Delete from Bookings where GuestId='{UserId}'");
            Set($"Insert Into Bookings (RoomType,DateOfStart,DateOfEnd,GuestId,Status,Note) Values('{Type}','{DateOfStart.Date.ToString("dd.MM.yyyy")}','{DateOfEnd.Date.ToString("dd.MM.yyyy")}','{UserId}','1','{Note}')");
        }

    }
}
