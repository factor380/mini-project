   M S B A M L   `   `   `  ����=  9UL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ULUL  5   	   I Ebe_MiniPOrject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/(clr-namespace:BE;assembly=be_MiniPOrjectBE 5   	       UL.print_all_nanny   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:UL     5   	   7BE(clr-namespace:BE;assembly=be_MiniPOrject     5   	   -   5          � Title$  print_all_nanny��5	   	   $	��300��6!   $	��300��6.    � 	Resources 5
         nannyViewSource  nannyWorkHoursViewSource �� Source �� Source��%Z   &	        &	      7   �� 5   
   6   �� 5   
    6@   �� *	WorkHours+8   5      .��5      �  � DataContext# [  6   .+�5   
   �� -   5         ��Name$ nannyListView��5       �� SelectionMode$ Single=�6*    �� DisplayMemberPath$ IsFixedSize��6�    �� SelectedValuePath$ IsFixedSize��6�   ��6A   �� # [ 	 �� View	 5      �� 5      .P�5      �� -   5        addressColumn��
 �� Width$

 auto��5   <   $��Address��6I    �� CellTemplate 5      �� 5      .R�5   "   �� {�.  ��6*   �� *	Address+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 6�   5      5      �� 5      -   5        dateBirthColumn��$

 auto��5   >   $��
Date Birth��6K    5      �� 5      .R�5   "   (  "System.Windows.Controls.DatePicker  {�.     SelectedDate 6-   �� *	DateBirth+$ TwoWay=� .  . 6�   5      5       �� 5!      -   5        daysOOfColumn��$

 auto��5!   <   $��Days OOf��6I    5"      �� 5#      .R�5$   "   �� {�.   d� 	IsChecked 6+   �� *	DaysOOf+$ TwoWay=� .  . 6�   5%      5'      �� 5(      -   5        elevatorColumn��$

 auto��5(   =   $��Elevator��6J    5)      �� 5*      .R�5+   "   �� {�.   6+   �� *
Elevator+$ TwoWay=� .  . 6�   5,      5.      �� 5/      -   5        	expColumn��$

 auto��5/   8   $	��Exp��6E    50      �� 51      .R�52   "   �� {�.  ��6*   �� *Exp+$ TwoWay=� .  . 6�   53      55      �� 56      -   5        floorInBuldingColumn��$

 auto��56   C   $��Floor In Bulding��6P    57      �� 58      .R�59   "   �� {�.  ��6*   �� *FloorInBulding+$ TwoWay=� .  . 6�   5:      5<      �� 5=      -	   5        idColumn��$

 auto��5=   7   $��Id��6D    5>      �� 5?      .R�5@   "   �� {�.  ��6+   �� *Id+$ TwoWay=� .  . 6�   5A      5C      �� 5D      -
   5        lastNameColumn��$

 auto��5D   =   $��	Last Name��6J    5E      �� 5F      .R�5G   "   �� {�.  ��6*   �� *
LastName+$ TwoWay=� .  . 6�   5H      5J      �� 5K      -   5        maxAgeMonthColumn��$

 auto��5K   @   $��Max Age Month��6M    5L      �� 5M      .R�5N   "   �� {�.  ��6*   �� *MaxAgeMonth+$ TwoWay=� .  . 6�   5O      5Q      �� 5R      -   5        maxChildrenColumn��$

 auto��5R   @   $��Max Children��6M    5S      �� 5T      .R�5U   "   �� {�.  ��6*   �� *MaxChildren+$ TwoWay=� .  . 6�   5V      5X      �� 5Y      -   5        minAgeMonthColumn��$

 auto��5Y   @   $��Min Age Month��6M    5Z      �� 5[      .R�5\   "   �� {�.  ��6*   �� *MinAgeMonth+$ TwoWay=� .  . 6�   5]      5_      �� 5`      -   5        
nameColumn��$

 auto��5`   9   $
��Name��6F    5a      �� 5b      .R�5c   "   �� {�.  ��6*   �� *Name+$ TwoWay=� .  . 6�   5d      5f      �� 5g      -   5        payHourColumn��$

 auto��5g   <   $��Pay Hour��6I    5h      �� 5i      .R�5j   "   �� {�.  ��6*   �� *	PayHour+$ TwoWay=� .  . 6�   5k      5m      �� 5n      -   5        payMonthColumn��$

 auto��5n   =   $��	Pay Month��6J    5o      �� 5p      .R�5q   "   �� {�.  ��6*   �� *
PayMonth+$ TwoWay=� .  . 6�   5r      5t      �� 5u      -   5        perHourColumn��$

 auto��5u   <   $��Per Hour��6I    5v      �� 5w      .R�5x   "   �� $��-6,-1q�6�   {�.   6+   �� *	PerHour+$ TwoWay=� .  . 6�   5y      5{      �� 5|      -   5        phoneNumColumn��$

 auto��5|   =   $��	Phone Num��6J    5}      �� 5~      .R�5   "   �� {�.  ��6*   �� *
PhoneNum+$ TwoWay=� .  . 6�   5�      5�      �� 5�      -   5        recommendationsColumn��$

 auto��5�   D   $��Recommendations��6Q    5�      �� 5�      .R�5�   "   �� {�.  ��6*   �� *Recommendations+$ TwoWay=� .  . 6�   5�      5�      �� 5�      -   5        daysAndHoursColumn��$

 auto��5�   A   $��DaysAndHours��6N    5�      �� 5�      .R�5�   "   �� $��2,2,2,2q�6,   ��6=   �� *TimeAndDays+5�      5�      5�      ��5�      �� 5�      .�5�      ��  �� Property � �� �� Value$ Stretch=�6K   �� 5�       � ��$ Stretch=�6I   5�      5�      5�      5�      