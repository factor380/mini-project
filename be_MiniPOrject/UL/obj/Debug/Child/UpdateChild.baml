   M S B A M L   `   `   `  ����=  9UL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ULUL  5   	   I Ebe_MiniPOrject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/(clr-namespace:BE;assembly=be_MiniPOrjectBE 5   	       UL.UpdateChild   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:UL     5   	   7BE(clr-namespace:BE;assembly=be_MiniPOrject     5   	     � Title$  UpdateChild��5	   	   $	��430��6   $	��400��6*    � 	Resources 5
         childViewSource��%   &	        �� 5   
   6   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��UPDATE CHILD��6   $��40(�6'   $
��Bold"�65   �� 5   
   -   5        $��UPDATE��5      $��40(�6"   $��2��60   $��0,0,0.333,-0.333q�6R   � 5   
   -   5         �Name$ UPDATE��5       � DataContext# [  6   $
��Left=�6N   $��0,0.333,0,0q�6i   $��1��6~   $	��Top=�6�   $	��274��6�   $	��279��6�    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5       �� $	��Id:��6   $��0��6"   $
��Left=�62   $��3q�6M   $��0��6X   $��Center=�6e   $��20(�6�   �� 5!      -   5         ��Name$ 
idComboBox��5!      $��1��6+   $
��Left=�6;   $��34��6V   $��3,10,0,0q�6b   $��0��6t   $��Center=�6  $	��120��6   �� SelectedValue 6�   �� *Id+ �� Mode$ OneWay=�	 �� NotifyOnValidationError	 . 
 �� ValidatesOnExceptions
 .  �� ValidatesOnDataErrors . 6(  �� 5"      $��Name:��6   $��0��6$   $
��Left=�64   $��3q�6O   $��1��6Z   $��Center=�6g   $��20(�6�   �� 5#      -   5         ��Name$ nameTextBox��5#      $��1��6+   $
��Left=�6;   $��23��6V   $��3q�6b   $��1��6m   $��Center=�6�   $	��120��6�   ��6z   �� *Name+$ TwoWay=�	 . 
 . 6�   �� 5$      $��Special Needs:��6   $��0��6-   $
��Left=�6=   $��3q�6X   $��2��6c   $��Center=�6p   $��20(�6�   �� 5%      -   5         ��Name$ specialNeedsCheckBox��5%      $�� ��65   $��1��6@   $
��Left=�6P   $��7,15,0,14.667q�6�   $��2��6�   $��Center=�6�    d� 	IsChecked 6k   �� *SpecialNeeds+$ TwoWay=�	 . 
 . 6�   �� 5&      $��What He Need:��6   $��0��6,   $
��Left=�6<   $��3q�6W   $��3��6b   $��Center=�6o   $��20(�6�   �� 5'      -   5        $ whatHeNeedTextBox��5'      $��1��61   $
��Left=�6A   $��23��6\   $��3q�6h   $��3��6s   $��Center=�6�   $	��120��6�   ��6�   �� *
WhatHeNeed+$ TwoWay=�	 . 
 . {�6
  ��  �� ElementName$ specialNeedsCheckBox�� �� Path$ 	IsChecked�5(      5)      5*      