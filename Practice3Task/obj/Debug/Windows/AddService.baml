   M S B A M L   `   `   `  ����H  DPractice3Task, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Practice3Task.WindowsPractice3Task.Windows  5   	   &     Practice3Task.Windows.AddService   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:Practice3Task.Windows     5   	     � Title$'  !Добавление услуги��5   	   $	��550��6#   $	��600��60   ���#E7FABF � Icon$6 0pack://application:,,,/Resources/school_logo.png��6Q    � WindowStartupLocation$ CenterScreen=�6�    � 
ResizeMode$ CanMinimize=�6�   .��5	      �  � RowDefinitions 5
   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      $	��120 �6   6+   �� 5      $	��120 �6   6+   �� 5      $��70 �6   6*    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   �� $��2��6   6'   �� 5   
   -   5         ��Name$ AddRedTextBlock��5      $��2��6-      StandartTextBlock#��[  6A   $'��!Добавление услуги��6l   6�   �� 5   
   $��1��6   #��[  6!   $��Наименование��6L   6b   �� 5   
   -   5        $
��Name��5        StandartTextBox#��[ 6   $��1��6G   $��1��6T   $��5q�6d   $��Center=�6o   6�   �� 5   
   $��2��6   #��[  6!   $��Длительность��6L   6b   �� 5   
   -   5        $��Duration��5      #��[ 6"   $��2��6K   $��1��6X   $��5q�6h   $��Center=�6s   6�   �� 5   
   $��3��6   #��[  6!   $��Стоимость��6L   6_   �� 5   
   -   5        $
��Cost��5      #��[ 6   $��3��6G   $��1��6T   $��5q�6d   $��Center=�6o   6�   �� 5    
   $��4��6   #��[  6!   $��Скидка��6L   6\   �� 5!   
   -   5        $��Discount��5!      #��[ 6"   $��4��6K   $��1��6X   $��5q�6h   $��Center=�6s   6�   �� 5"   
   -   5          StandartButton#��[ 5"      $��Выбор фото��69   $��5��6N   $��10,10,10,10q�6\   $
��Bold"�6q   $��Comic Sans MS)�6�   ���#04A0FF$��Stretch=�6�    � 	Resources 5#       �� 
TargetType	 �� Property
 �� Value��%_   '��       �� 5$      " ��6   .�5%      �� 	 �@��CornerRadius$
 10��65   5&      5'      5(      �� 5)   
   -   5         ��Name$ ImageChoosedPhoto��5)      $��5q�6+   $��5��66   $��1��6C   6U   �� 5*   
   -   5        $��additionalImages��5*      $��6��6+   $��1��68   $��5q�6H   $��Disabled=�6S   ��.  ��5,      �� 5-      .R�5.      ��  �� Orientation$ 
Horizontal=�6!   6<   5/      ��51      �� 52      .R�53      � .+�54      �� $ Vertical=�6%   $��10,0,0,0q�6<   .+�55      �� $	��200��6=   ��6$   �� *Image+6K   56      57      58      5:      �� 5;   
   -	   5        #��[ 5;      $!��Выбор доп. фото��69   $��6��6S   $��0��6`   $��10q�6p   $
��Bold"�6|   ���#04A0FF$��Stretch=�6�    5<      ��%_   '��       �� 5=      " ��6   .�5>      �� 	 �@��CornerRadius$
 10��65   5?      5@      5A      �� 5B   
   -
   5         ��Name$ 	AddRedBtn��5B      #��[ 6$   $#��Добавить услугу��6L   $	��300��6f   $��7��6r   $��2��6   $��10,10,10,10q�6�   $��20(�6�   $
��Bold"�6�   $��Comic Sans MS)�6�   ���#04A0FF$��Stretch=�6   5C      ��%_   '��       �� 5D      " ��6   .�5E      �� 	 �@��CornerRadius$
 10��65   5F      5G      5H      5I      5J      