   M S B A M L   `   `   `  ����H  DHotelReserver, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:HotelReserver.PagesHotelReserver.Pages  5      '    !HotelReserver.Pages.GuestRegister   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:HotelReserver.Pages     5        N� Title$  GuestRegister��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� -   5        $	��←��5      $
��Left=�6   $��	10,10,0,0q�68   $	��Top=�6K   $��Bahnschrift SemiBold)�6c   $��40��6�   $��40��6�   $��30(�6�   ���	#FF007ACC
�������$��0q�6�   $��0��6�   ��.  6  �� 5   
   -   5        $*��$Зарегистрироваться��5      $��Center=�6.   $��0,10,0,0q�6K   $	��Top=�6]   $��Bahnschrift SemiBold)�6u   $	��566��6�   $��40��6�   $��30(�6�   ���	#FF007ACC
�������$��0q�6�   $��8��6  ��.  6  �� 5   
   $��Пароль��6   $
��Left=�6!   $	��Top=�6<   $��
175,10,0,0q�6T   $��22(�6h   $��Bahnschrift SemiBold)�6v   $��34��6�   $��7��6�   �� 5   
   -   5         ��Name$ PasswordBox��5      $��265,10,117,0q�6'   $�� ��6=   $��Center=�6E   $��Bahnschrift SemiBold)�6i   $��Center=�6�   $��7��6�   $��5��6�   �� 5   
   $!��Номер телефона��6   $
��Left=�6)   $	��Top=�6D   $��	83,10,0,0q�6\   $��22(�6o   $��Bahnschrift SemiBold)�6}   $��34��6�   $��6��6�   �� 5   
   -   5        $ PhoneNumberBox��5      $��265,10,117,0q�6*   $�� ��6@   $��Center=�6H   $��Bahnschrift SemiBold)�6l   $��Center=�6�   $��6��6�   $��4��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ DateBox��5      $
��Left=�6&   $��
265,10,0,0q�6A   $	��Top=�6U   $��401.5��6m   $��34��6{   $��18(�6�   $��Bahnschrift SemiBold)�6�   $��5��6�   $��3��6�   �� 5   
   $��Дата рождения��6   $
��Left=�6(   $	��Top=�6C   $��	90,10,0,0q�6[   $��22(�6n   $��Bahnschrift SemiBold)�6|   $��34��6�   $	��172��6�   $��5��6�   �� 5    
   $!��Номер паспорта��6   $
��Left=�6)   $	��Top=�6D   $��	87,10,0,0q�6\   $��22(�6o   $��Bahnschrift SemiBold)�6}   $��34��6�   $��4��6�   �� 5!   
   -   5        $ PassportNumberBox��5!      $��265,10,117,0q�6-   $�� ��6C   $��Center=�6K   $��Bahnschrift SemiBold)�6o   $��Center=�6�   $��4��6�   $��2��6�   �� 5"   
   $!��Серия паспорта��6   $
��Left=�6)   $	��Top=�6D   $��	87,10,0,0q�6\   $��22(�6o   $��Bahnschrift SemiBold)�6}   $��34��6�   $��3��6�   �� 5#   
   -   5        $ PassportSeriesBox��5#      $��265,10,117,0q�6-   $�� ��6C   $��Center=�6K   $��Bahnschrift SemiBold)�6o   $��Center=�6�   $��3��6�   $��1��6�   �� 5$   
   $��ФИО��6   $
��Left=�6   $	��Top=�69   $��
202,10,0,0q�6Q   $��22(�6e   $��Bahnschrift SemiBold)�6s   $��34��6�   $��2��6�   �� 5%   
   -   5        $ FIOBox��5%      $��265,10,117,0q�6"   $�� ��68   $��Center=�6@   $��Bahnschrift SemiBold)�6d   $��Center=�6�   $��2��6�   $��0��6�   5&      5(      