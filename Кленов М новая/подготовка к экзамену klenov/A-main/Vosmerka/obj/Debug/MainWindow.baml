   M S B A M L   `   `   `  ����C  ?Vosmerka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:VosmerkaVosmerka  5   	       Vosmerka.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Vosmerka     5   	     � Title$  ProductWindow��5   	   $	��450��6   $	��800��6,   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��152 �6   �� 5      $��* �6   .+�5   
   �� $��5q�5   	   $��./Logo/Logo.png��5   	   $	��Top=�5   	   �� 5   
   $��Bottom=�6   $��0,0,0,5q�60   .+�5      	� -   5         	� 	GroupName$ Price��5      
 � Tag$ 1��5      $!��по возрастанию��5       d� 	IsChecked$
 TrueY�5      $��Center=�5      	� 5      -   5        $ Price��5      $ 2��5       $��по убыванию��5!      $��Center=�5#      �� 5$      $&�� Фильтр по скидке: ��6   $��10,0,0,0q�5%   	   $��Center=�5&   	   �� 5'      -   5        $��DiscountFilterComboBox��5(       �� SelectedIndex$ 0��5)      ��5+      �� *FilterByDiscountNamesList+�� 5,      $��
Поиск��6   �� 5-      -   5         ��Name$ SearchFilterTextBox��5.      $��Center=�5/      50   +   �� 52      -   5         ��Name$ OrderProvid��52       $��5q�6   $��Материалы��65   6b   �� 54      -   5        $ ExitBtn��54       $��5q�6   $��
Выход��61   6[   55      �� 56   
   $��5q�57   	   $��./Logo/Logo.png��58   	   $	��Top=�59   	   �� 5:   
   -   5         ��Name$ ProductListView��5>      $��1��5;      $��1��5<      ��5=      �� *ServiceList+��5?      �� 5@      	 �� 
TargetType"	 ��5A      
 �� Triggers
 5C      �� 5D       �� Binding 5E      �� *
MinPrice+ �� Value True5F      .a�5G      ��  �� Property � �� �� Value
 ��� �5I   !   5J      .�5L      ��  � ��$ Stretch=�5N      5O      ��5Q      �� 5R      .R�5S      �� $��1q�5T      
���   � �� CornerRadius$ 5��5V      ._�5W      � $��10q�5X      $��Stretch=�5Y       5Z      �� 5[   "   $��64 �63   �� 5\   "   $��* �63   �� 5]   "   $	��100 �63   .+�5_      �� $��64��5`      $��64��5a      ��5b      ��  �� Path$ ImagePreview��� 5c      $��2��5e      $��Right=�5f      $��10q�5g      ��5d      �� *MinCostForAgent+5g      � 5i      $��1��6#   $��5q�63    � RowDefinitions 5j   "   �� 5k   &   $��20 �64   �� 5l   &   $��20 �64   �� 5m   &   $��* �64   .+�5o   "   ��  �� Orientation$ 
Horizontal=�5p      .+�5r   &   �� ��5s   !   �� *Title+5t   #   5u      5v      5w      5x      5z      �� 5{   
   $ 
Horizontal=�5|      $��Bottom=�5}      $��1��5~      $��2��5      .+�5�      �� ��6   �� *FilteredProductCount+�� 5�      $��/��6   �� 5�      ��6   �� *ProductCount+5�      5�      5�      