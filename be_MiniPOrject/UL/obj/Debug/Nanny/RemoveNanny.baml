   M S B A M L   `   `   `  ����=  9UL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ULUL  5   	   I Ebe_MiniPOrject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/(clr-namespace:BE;assembly=be_MiniPOrjectBE 5   	       UL.RemoveNanny   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:UL     5   	   7BE(clr-namespace:BE;assembly=be_MiniPOrject     5   	     � Title$  RemoveNanny��5	   	   $	��300��6   $��329.252��6*    � 	Resources 5
         nannyViewSource��%   &	        �� 5   
   6   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��2* �6   �� 5      $��* �6   .+�5   
   �� $��REMOVE NANNY��6   $��30(�6'   �� 5   
   -   5        $��REMOVE��5      $��30(�6"   $��2��60   ��5      �� 5       �� Triggers 5      �� 5       �� Binding 6&   ��  �� ElementName$ 
idComboBox�� �� Path$
 Text� �� Value  6\   .a�5      ��  �� Property � {�	 �� Value	 .  6A   5      5      5      � 5    
   -   5        
 �Name$
 Remove��5        � DataContext# [  6   $
��Left=�6N   $��0,50,0,0q�6i   $��1��6{   $	��Top=�6�   $	��317��6�    � ColumnDefinitions 5!      �� 5"      $
��Auto �6#   �� 5#      $
��Auto �6#    5%      �� 5&      $
��Auto �6    .+�5(      �� $��nanny Id to remove:��6   $��0��62   $
��Left=�6B   $��3q�6]   $��0��6h   $��Center=�6u   $��20(�6�   �� 5)      -   5         ��Name$ 
idComboBox��5)      $��1��6+   $
��Left=�6;   $��30��6V   $��3,10,0,3q�6b   $��0��6t   $��Center=�6  $	��120��6   �� SelectedValue 6�   �� *Id+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions .  �� ValidatesOnDataErrors . 6  5*      5,      5-      