   M S B A M L   `   `   `  ����=  9UL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ULUL  5   	   I Ebe_MiniPOrject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/(clr-namespace:BE;assembly=be_MiniPOrjectBE 5   	       UL.print_all_child   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:UL     5   	   7BE(clr-namespace:BE;assembly=be_MiniPOrject     5   	   -   5          � Title$  print_all_child��5	   	   $	��300��6!   $��461.64��6.    � 	Resources 5
         childViewSource��%   &	        �� 5   
   6   5      .��5      �  � DataContext# [  6   .+�5   
   �� -   5         ��Name$ childListView��5       �� SelectionMode$ Single=�6*   ��6A   ��  �� View 5      �� 5      .P�5      �� -   5        dateBirthColumn�� �� Width$
 auto��5   >   $��
Date Birth��6K    �� CellTemplate 5      �� 5      .R�5   "   (  "System.Windows.Controls.DatePicker  {�.     SelectedDate 6-   �� *	DateBirth+	 �� Mode$	 TwoWay=�
 �� NotifyOnValidationError
 .  �� ValidatesOnExceptions . 6�   5      5      �� 5      -   5        idColumn��$
 auto��5   7   $��Id��6D    5      �� 5      .R�5   "   �� {�.  ��6*   �� *Id+$	 TwoWay=�
 .  . 6�   5      5      �� 5       -   5        motherIdColumn��$
 Auto��5    =   $��	Mother Id��6J    5!      �� 5"      .R�5#   "   �� {�.  ��6*   �� *
MotherId+$	 TwoWay=�
 .  . 6�   5$      5&      �� 5'      -   5        
nameColumn��$
 Auto��5'   9   $
��Name��6F    5(      �� 5)      .R�5*   "   �� {�.  ��6*   �� *Name+$	 TwoWay=�
 .  . 6�   5+      5-      �� 5.      -   5        specialNeedsColumn��$
 auto��5.   A   $��Special Needs��6N    5/      �� 50      .R�51   "   �� {�.   d� 	IsChecked 6+   �� *SpecialNeeds+$	 TwoWay=�
 .  . 6�   52      54      �� 55      -   5        whatHeNeedColumn��$
 Auto��55   ?   $��What He Need��6L    56      �� 57      .R�58   "   �� $
��auto��6*   {�.  ��67   �� *
WhatHeNeed+$	 TwoWay=�
 .  . 6�   59      5;      5<      ��5>      �� 5?      .�5@      ��  �� Property � �� �� Value$ Stretch=�6K   �� 5A       � ��$ Stretch=�6I   5B      5D      5E      5F      