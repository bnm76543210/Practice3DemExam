   M S B A M L   `   `   `  ����H  DPractice3Task, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Practice3Task.WindowsPractice3Task.Windows  5   	   *    $Practice3Task.Windows.NearestEntries   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:Practice3Task.Windows     5   	     � Title$  Список услуг��5   	   $	��450��6   $	��800��6+   ���#E7FABF � Icon$6 0pack://application:,,,/Resources/school_logo.png��6L   $	��800��6�   $	��450��6�    � WindowStartupLocation$ CenterScreen=�6�   .��5	      �  � RowDefinitions 5
   
   �� 5      $��80 �6   6*   �� 5      6   �� 5      $��75 �6   6*   .+�5   
   ��    StandartTextBlock#��[  6   $%��Ближайшие записи��6?   6Y   �� 5   
   $��50��6   $
��Left=�6   $��Center=�66   $��10,0,0,0q�6R   6f   �� 5   
   -   5        $��ListViewUpcomingEntries��5       $��1��6   $��20(�6?    �� View 5      �� 5      .P�5      �� $��Наименование��6%    �� CellTemplate 5      �� 5      .R�5   "   �� ��6,   �� *Service.Name+6L   5      5      �� 5      $��ФИО��6%    5      �� 5      .R�5   "   �� ��5   &   `� 5    *    �� StringFormat$ {0} {1} {2}��67   .1�5!   .   ��  �� Path$ Client.Surname�66   6N   �� 5"   .   $ Client.Name�66   6K   �� 5#   .   $ Client.Patronymic�66   6Q   5$   +   5&   #   5'      5)      �� 5*      $��Email��6%    5+      �� 5,      .R�5-   "   �� ��6,   �� *Client.Email+6L   5.      50      �� 51      $��Телефон��6%    52      �� 53      .R�54   "   �� ��6,   �� *Client.Phone+6L   55      57      �� 58      $)��#Дата и время записи��6%    59      �� 5:      .R�5;   "   �� ��6,   �� *ServiceTime+6K   5<      5>      �� 5?      $/��)Время до начала услуги��6%    5@      �� 5A      .R�5B   "   �� ��6,   �� *
Foreground+��6N   �� *timeToStart+6m   5C      5E      5F      5H      &   System.Windows.Controls.DataGrid  5I   
   -   5        $��DataGridUpcomingEntries��5I   4   $y�Hidden=�6   $��1��6'   $��20(�6S      AutoGenerateColumns .  	   Columns	 5J      0  *System.Windows.Controls.DataGridTextColumn  5K      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Наименование��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *Service.Name+6^     5L      $
 ФИО��6%    5M      `� 5N      $ {0} {1} {2}��6'   .1�5O      �� $ Client.Surname�6&   6>   �� 5P      $ Client.Name�6&   6;   �� 5Q      $ Client.Patronymic�6&   6A   5R      5T        5U      $
 Email��6%    64   �� *Client.Email+6W     5V      $
 Телефон��6%    66   �� *Client.Phone+6Y     5W      $)
 #Дата и время записи��6%    6B   �� *ServiceTime+6d     5X      $/
 )Время до начала услуги��6G      
Foreground 6%   �� *
Foreground+ 6g   �� *timeToStart+6�   5Z      �� 5[   
   -   5        $��3��5[      $
��Left=�6   $��10q�69   $
��Bold"�6E   $��Comic Sans MS)�6W   ���#04A0FF$��
Назад��6�     StandartButton#��[ 6�   $��20(�6�    � 	Resources 5\       �� 
TargetType �� Property �� Value��%^   '��       �� 5]      " ��6   .�5^      ��  �@��CornerRadius$ 5��65   5_      5`      5a      5b      5c      