   M S B A M L   `   `   `  ����=  9UL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ULUL  5   	   I Ebe_MiniPOrject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/(clr-namespace:BE;assembly=be_MiniPOrjectBE 5   	       UL.RemoveContract   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:UL     5   	   7BE(clr-namespace:BE;assembly=be_MiniPOrject     5   	     � Title$  RemoveContract��5	   	   $	��300��6    $��384.334��6-    � 	Resources 5
         contractViewSource��%   &	        �� 5   
   6   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��2* �6   �� 5      $��* �6   .+�5   
   �� $��Remove Contract��6   $��25(�6*   �� 5   
   -   5        $��Remove��5      $��25(�6"   $��2��60   ��5      �� 5       �� Triggers 5      �� 5       �� Binding 6&   ��  �� ElementName$ 
idComboBox�� �� Path$
 Text� �� Value  6\   .a�5      ��  �� Property � {�	 �� Value	 .  6A   5      5      5      � 5    
   -   5        
 �Name$
 Remove��5        � DataContext# [  6   $
��Left=�6Q   $��0,51.667,0,0q�6l   $��1��6�   $	��Top=�6�   $��60��6�   $	��378��6�    � ColumnDefinitions 5!      �� 5"      $
��Auto �6#   �� 5#      $
��Auto �6#    5%      �� 5&      $
��Auto �6    .+�5(      �� $��Contract Num to remove :��6   $��0��67   $��Center=�6G   $��3q�6d   $��0��6o   $��Center=�6|   $��20(�6�   �� 5)      -   5         ��Name$ contract_Num1ComboBox��5)      $��1��66   $
��Left=�6F   $��34��6a   $��3,10,0,0q�6m   $��0��6   $��Center=�6�   $	��120��6   �� SelectedValue 6�   �� *Contract_Num1+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 6  5*      5,      5-      