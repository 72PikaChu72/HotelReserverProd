   M S B A M L   `   `   `  ����H  DHotelReserver, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:HotelReserver.PagesHotelReserver.Pages  5      "    HotelReserver.Pages.Bookings   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:HotelReserver.Pages     5        N� Title$  Bookings��5	      .��5      � 
�������.+�5   
   �� -   5        $	��←��5      $
��Left=�6   $��	10,10,0,0q�68   $	��Top=�6K   $��Bahnschrift SemiBold)�6c   $��40��6�   $��40��6�   $��30(�6�   ���	#FF007ACC
�������$��0q�6�   6�   �� 5   
   -   5        $��BookingsList��5      $��10,55,561,26q�6R   6h   �� 5   
   -   5        $��TimeSelection��5      $��Все��6&   $
��Left=�64   $��	55,10,0,0q�6O   $	��Top=�6b   $��Bahnschrift SemiBold)�6z   $��86��6�   $��40��6�   $��16(�6�   ���	#FF007ACC
�������$��0q�6�   6�   �� 5   
   -   5        $��DoneBtn��5      $��Применить��6    $��264,363,0,0q�64   $��Bahnschrift SemiBold)�6I   $��16(�6k   ���	#FF007ACC
�������$��0q�6�   $��40��6�   $	��Top=�6�   $
��Left=�6�   $	��184��6  $y�Hidden=�6  �� 5   
   -   5        $��GuestFIOLbl��5      $y�Hidden=�6#   $��Фио Гостя:��67   $
��Left=�6L   $��Bahnschrift SemiBold)�6g   $��16(�6�   $��
278,21,0,0q�6�   $	��Top=�6�   $	��474��6�   �� 5   
   -   5         ��Name$ StatusSelection��5      $��Все��6*   $
��Left=�68   $��
146,10,0,0q�6S   $	��Top=�6g   $��Bahnschrift SemiBold)�6   $��93��6�   $��40��6�   $��16(�6�   ���	#FF007ACC
�������$��0q�6�   6  �� 5   
   -   5         ��Name$ BookStatusLbl��5      $y�Hidden=�6'   $��Статус брони:��6;   $
��Left=�6S   $��Bahnschrift SemiBold)�6n   $��16(�6�   $��278,181,0,0q�6�   $	��Top=�6�   $	��474��6�   �� 5   
   -   5        $ RoomTypeLbl��5      $y�Hidden=�6%   $��Тип номера:��69   $
��Left=�6O   $��Bahnschrift SemiBold)�6j   $��16(�6�   $��
278,89,0,0q�6�   $	��Top=�6�   $	��474��6�   �� 5   
   -	   5        $ DateOfStartLbl��5      $y�Hidden=�6(   $"��Дата заселения:��6<   $
��Left=�6V   $��Bahnschrift SemiBold)�6q   $��16(�6�   $��278,123,0,0q�6�   $	��Top=�6�   $	��474��6�   �� 5   
   -
   5        $ DateOfEndLbl��5      $y�Hidden=�6&   $"��Дата выселения:��6:   $
��Left=�6T   $��Bahnschrift SemiBold)�6o   $��16(�6�   $��278,152,0,0q�6�   $	��Top=�6�   $	��474��6�   �� 5   
   -   5        $ WelcomeGuestBtn��5      $!��Заселить Гостя��6*   $��453,363,0,0q�6C   $��Bahnschrift SemiBold)�6X   $��16(�6z   ���	#FF007ACC
�������$��0q�6�   $��40��6�   $	��Top=�6�   $
��Left=�6  $	��184��6  $y�Hidden=�6)  �� 5   
   -   5        $ NoteLbl��5      $y�Hidden=�6!   $��Комментарий:��65   $
��Left=�6L   $��Bahnschrift SemiBold)�6g   $��16(�6�   $��278,210,0,0q�6�   $	��Top=�6�   $	��474��6�   �� 5   
   -   5        $��StatusCombo��5      $��Bahnschrift SemiBold)�6&   $
��Left=�6H   $��400,186,0,0q�6c   $	��Top=�6x   $	��120��6�   $��19��6�   $y�Hidden=�6�   �� 5   
   -   5         ��Name$ NoteBox��5      $��400,211,0,0q�6#    �� TextWrapping$
 Wrap=�68   $��Center=�6L   $��Center=�6n   $�� ��6�   $��Bahnschrift SemiBold)�6�   $��0��6�   $��28��6�   $	��Top=�6�   $
��Left=�6�   $	��343��6	  $y�Hidden=�6  �� 5   
   -   5        $ 
RoomNumber��5      $y�Hidden=�6$   $%��Заселить в номер:��68   $
��Left=�6T   $��Bahnschrift SemiBold)�6o   $��16(�6�   $��278,245,0,0q�6�   $	��Top=�6�   $	��474��6�   �� 5   
   -   5         ��Name$ 	RoomCombo��5      $��Bahnschrift SemiBold)�6&   $
��Left=�6H   $��425,250,0,0q�6c   $	��Top=�6x   $	��120��6�   $��19��6�   $y�Hidden=�6�   �� 5   
   -   5        $ GuestNumber��5      $y�Hidden=�6%   $"��Номер телефона:��69   $
��Left=�6S   $��Bahnschrift SemiBold)�6n   $��16(�6�   $��278,279,0,0q�6�   $	��Top=�6�   $	��474��6�   5      5      