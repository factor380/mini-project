   M S B A M L   `   `   `  ����=  9UL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ULUL  5   	   4    .UL.Nannys_acoording_to_the_age_of_the_children   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:UL     5   	     � Title$1  +Nannys_acoording_to_the_age_of_the_children��5   	   $	��300��6=   $	��300��6J   .��5
      �  � RowDefinitions 5   
   �� 5      $	��51* �6   �� 5      $	��54* �6   �� 5      $
��164* �6   .+�5   
   �� $��age min or max��6   $��9(�6)   $
��Left=�67   $��	10,17,0,0q�6R   $	��Top=�6e   $��76��6}   �� 5   
   -   5         ��Name$	 age��5      $
��Left=�6!   $��	98,17,0,0q�6<   $	��Top=�6O   $	��120��6g   .@�5      �� $	��MAX��6   �� 5      $	��MIN��6   5      �� 5   
   $��arranged��6   $
��Left=�6#   $��10,2,0,0q�6>   $��1��6P   $	��Top=�6]   $��76��6u   �� 5   
   -   5        $ arranged��5      $
��Left=�6&   $��98,2,0,0q�6A   $	��Top=�6S   $	��120��6k   $��1��6w   $��31��6�   .@�5      �� $	��yes��6   �� 5      $��no��6   5      �� 5   
   -   5        $	��GET��5      $
��Left=�6   $��	53,33,0,0q�6:   $��1��6M   $	��Top=�6Z   $	��185��6r   ��5      �� 5       �� Triggers 5      �� 5        �� Binding 6&   ��  �� ElementName$ arranged�� �� Path$
 Text� �� Value  6Z   .a�5!      ��  �� Property � {�	 �� Value	 .  6A   5"      �� 5$       6&   �� $	 age��$
 Text�  6U   .a�5%      ��  � {�	 .  6A   5&      5(      5*      �� 5+   
   -   5        
 ��Name$

 text��5+      $��Stretch=�6"   $��18,4,5,5q�6@   $��2��6R   $
��Wrap=�6_   $��Center=�6s   $	��155��6�   $	��269��6�    J� RenderTransformOrigin$ 0.495,0.479&�6�   5-      5.      