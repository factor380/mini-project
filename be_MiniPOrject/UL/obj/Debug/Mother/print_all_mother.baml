   M S B A M L   `   `   `  ����=  9UL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ULUL  5   	   I Ebe_MiniPOrject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/(clr-namespace:BE;assembly=be_MiniPOrjectBE 5   	       UL.print_all_mother   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:UL     5   	   7BE(clr-namespace:BE;assembly=be_MiniPOrject     5   	   -   5          � Title$  print_all_mother��5	   	   $	��300��6"   $	��300��6/    � 	Resources 5
         motherViewSource��%   &	        �� 5   
   6   5      .��5      �  � DataContext# [  6   .+�5   
   �� -   5         ��Name$ motherListView��5       �� SelectionMode$ Single=�6+   ��6B   ��  �� View 5      �� 5      .P�5      �� -   5        addressColumn�� �� Width$
 auto��5   <   $��Address��6I    �� CellTemplate 5      �� 5      .R�5   "   �� {�.  ��6*   �� *	Address+ �� Mode$ TwoWay=�	 �� NotifyOnValidationError	 . 
 �� ValidatesOnExceptions
 . 6�   5      5      �� 5      -   5        addressAroundColumn��$
 auto��5   B   $��Address Around��6O    5      �� 5      .R�5   "   �� {�.  ��6*   �� *AddressAround+$ TwoWay=�	 . 
 . 6�   5      5      �� 5       -   5        idColumn��$
 auto��5    7   $��Id��6D    5!      �� 5"      .R�5#   "   �� {�.  ��6*   �� *Id+$ TwoWay=�	 . 
 . 6�   5$      5&      �� 5'      -   5        lastNameColumn��$
 auto��5'   =   $��	Last Name��6J    5(      �� 5)      .R�5*   "   �� {�.  ��6*   �� *
LastName+$ TwoWay=�	 . 
 . 6�   5+      5-      �� 5.      -   5        
nameColumn��$
 auto��5.   9   $
��Name��6F    5/      �� 50      .R�51   "   �� {�.  ��6*   �� *Name+$ TwoWay=�	 . 
 . 6�   52      54      �� 55      -   5        phoneNumColumn��$
 auto��55   =   $��	Phone Num��6J    56      �� 57      .R�58   "   �� {�.  ��6*   �� *
PhoneNum+$ TwoWay=�	 . 
 . 6�   59      5;      �� 5<      -	   5        remarksColumn��$
 auto��5<   <   $��Remarks��6I    5=      �� 5>      .R�5?   "   �� {�.  ��6*   �� *	Remarks+$ TwoWay=�	 . 
 . 6�   5@      5B      �� 5C      -
   5        daysAndHoursColumn��$
 auto��5C   A   $��DaysAndHours��6N    5D      �� 5E      .R�5F   "   �� $��2,2,2,2q�6,   ��6=   �� *TimeAndDays+5G      5I      5J      ��5L      �� 5M      .�5N      ��  �� Property � �� �� Value$ Stretch=�6K   �� 5O       � ��$ Stretch=�6I   5P      5R      5T      5U      