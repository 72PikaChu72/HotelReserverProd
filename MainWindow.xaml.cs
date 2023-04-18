﻿using HotelReserver.Pages;
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

namespace HotelReserver
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            try { App.Get("Select * from RoomStatuses"); } catch (Exception ex) { MessageBox.Show(ex.Message); Application.Current.Shutdown(); return; }
            InitializeComponent();
            MainFrame.Content = new LoginPage();
        }
    }
}
