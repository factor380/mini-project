   M S B A M L   `   `   `  ����=  9UL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ULUL  5   	        UL.nannies_close_to_mother   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:UL     5   	     � Title$  nannies_close_to_mother��5   	   $	��300��6)   $	��300��66   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��69* �6   �� 5      $
��122* �6   �� 5      $
��101* �6    � RowDefinitions 5   
   �� 5      $	��50* �6   �� 5      $	��29* �6   �� 5      $
��190* �6   .+�5   
   �� $��Enter distance:��6   $��8(�6*   $
��Left=�67   $��	10,17,0,0q�6R   $	��Top=�6e   $��23��6}   $��64��6�   $��2��6�   �� 5   
   -   5         ��Name$ distance��5      $��2��6$   $��1��68   $
��Left=�6H   $��23��6c   $��	10,17,0,0q�6o    �� TextWrapping$
 Wrap=�6�   $��number��6�   $	��Top=�6�   $	��120��6�   �� 5   
   $	��Id:��6   $��Center=�6   $��center=�6;   $��0��6V   $��	10,0,16,3q�6f   $��43��6y   $��26��6�    J� RenderTransformOrigin$ 0.504,0.333&�6�   $��1��6�   �� 5   
   -   5         ��Name$ idMother��5      $
��Left=�6%   $��0,6,0,0q�6@   $��Center=�6Q   $	��120��6l   $��1��6x   $��23��6�   $��1��6�   �� 5   
   -   5         ��Name$
 find��5      $��find  ��6   $��2��60   $��Center=�6A   $��	10,0,41,3q�6^   $��1��6q   $��Bottom=�6~   $��50��6�   $��20��6�   ��5      �� 5       �� Triggers 5      �� 5      	 �� Binding	 6&   �� 
 �� ElementName$
 idMother�� �� Path$
 Text� �� Value  6Z   .a�5      ��  �� Property � {� �� Value .  6A   5      �� 5       	 6&   �� $
 distance��$
 Text�
 number6Z   .a�5!      ��  � {� .  6A   5"      5$      5&      �� 5'   
   -   5         ��Name$
 text��5'      $
��Left=�6"   $��	10,10,0,0q�6=   $��2��6P   $
��Wrap=�6]   $	��Top=�6q   $��3��6�   $	��163��6�   $	��272��6�   5(      5)      