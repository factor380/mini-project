   M S B A M L   `   `   `  ����=  9UL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ULUL  5   	   I Ebe_MiniPOrject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/(clr-namespace:BE;assembly=be_MiniPOrjectBE 5   	       UL.print_all_contract   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:UL     5   	   7BE(clr-namespace:BE;assembly=be_MiniPOrject     5   	   -   5          � Title$  print_all_contract��5	   	   $	��300��6$   $	��300��61    � 	Resources 5
         contractViewSource��%   &	        �� 5   
   6   5      .��5      �  � DataContext# [  6   .+�5   
   �� -   5         ��Name$ contractListView��5       �� SelectionMode$ Single=�6-   {�. ��6D   ��  �� View 5      �� 5      .P�5      �� -   5        activeContractColumn�� �� Width$
 auto��5   C   $��Active Contract��6P    �� CellTemplate 5      �� 5      .R�5   "   �� {�.   d� 	IsChecked 6+   �� *ActiveContract+	 �� Mode$	 TwoWay=�
 �� NotifyOnValidationError
 .  �� ValidatesOnExceptions . 6�   5      5      �� 5      -   5        childIdColumn��$
 auto��5   <   $��Child Id��6I    5      �� 5      .R�5   "   �� $��-6,-1q�6*   {�.  ��69   �� *	ChildId+$	 TwoWay=�
 .  . 6�   5      5      �� 5       -   5        contract_Num1Column��$
 auto��5    B   $��Contract Num 1��6O    5!      �� 5"      .R�5#   "   �� $��-6,-1q�6*   {�.  ��69   �� *Contract_Num1+$	 TwoWay=�
 .  . 6�   5$      5&      �� 5'      -   5        endDateColumn��$
 auto��5'   <   $��End Date��6I    5(      �� 5)      .R�5*   "   (  "System.Windows.Controls.DatePicker  $��-6,-1q�6-   {�.     SelectedDate 6<   �� *	EndDate+$	 TwoWay=�
 .  . 6�   5+      5-      �� 5.      -   5        horM1Column��$
 auto��5.   :   $��Hor M 1��6G    5/      �� 50      .R�51   "   �� {�.   6+   �� *HorM1+$	 TwoWay=�
 .  . 6�   52      54      �� 55      -   5        	metColumn��$
 auto��55   8   $	��Met��6E    56      �� 57      .R�58   "   �� {�.   6+   �� *Met+$	 TwoWay=�
 .  . 6�   59      5;      �� 5<      -	   5        motherIdColumn��$
 auto��5<   =   $��	Mother Id��6J    5=      �� 5>      .R�5?   "   �� $��-6,-1q�6*   {�.  ��69   �� *
MotherId+$	 TwoWay=�
 .  . 6�   5@      5B      �� 5C      -
   5        nannyIdColumn��$
 auto��5C   <   $��Nanny Id��6I    5D      �� 5E      .R�5F   "   �� $��-6,-1q�6*   {�.  ��69   �� *	NannyId+$	 TwoWay=�
 .  . 6�   5G      5I      �� 5J      -   5        payHoursColumn��$
 auto��5J   =   $��	Pay Hours��6J    5K      �� 5L      .R�5M   "   �� $��-6,-1q�6*   {�.  ��69   �� *
PayHours+$	 TwoWay=�
 .  . 6�   5N      5P      �� 5Q      -   5        payMonthColumn��$ 80��5Q   =   $��	Pay Month��6H    5R      �� 5S      .R�5T   "   �� $��-6,-1q�6*   {�.  ��69   �� *
PayMonth+$	 TwoWay=�
 .  . 6�   5U      5W      �� 5X      -   5        startDateColumn��$ 80��5X   >   $��
Start Date��6I    5Y      �� 5Z      .R�5[   "     $��-6,-1q�6-   {�.   6<   �� *	StartDate+$	 TwoWay=�
 .  . 6�   5\      5^      5_      ��5a      �� 5b      .�5c      ��  �� Property � �� �� Value$ Stretch=�6K   �� 5d       � ��$ Stretch=�6I   5e      5g      5i      5j      