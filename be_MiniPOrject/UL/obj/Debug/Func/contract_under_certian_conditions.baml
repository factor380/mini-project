   M S B A M L   `   `   `  ����=  9UL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ULUL  5   	   *    $UL.contract_under_certian_conditions   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:UL     5   	     � Title$'  !contract_under_certian_conditions��5   	   $	��300��63   $	��300��6@   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��42* �6   �� 5      $	��30* �6   �� 5      $	��37* �6   �� 5      $
��160* �6   .+�5   
   �� $��Select a condition��6   $
��Left=�6-   $��	10,10,0,0q�6H   $	��Top=�6[   $	��108��6s   �� 5   
   -   5         ��Name$ selectionCondition��5      $
��Left=�6/   $��10,0,0,0q�6J   $	��Top=�6\   $	��123��6t   $��1��6�   $��30��6�   .@�5      �� $	��met��6   �� 5      $��active contact��6   �� 5      $��hour or minute��6   �� 5      $��pay in hour��6   �� 5      $��pay in month��6   5      �� 5   
   -   5         ��Name$ numHiden��5      $
��Left=�6$   $��23��6?   $��	13,10,0,0q�6K   $��2��6^    �� TextWrapping$
 Wrap=�6k   $��please enter number��6   $	��Top=�6�   $	��120��6�   $y�Hidden=�6�   �� 5   
   -   5         ��Name$	 Get��5      $	��Get��6   $
��Left=�6,   $��	182,6,0,0q�6G   $��1��6Z   $	��Top=�6g   $��75��6   ��5      �� 5       �� Triggers 5      �� 5       �� Binding 6&   ��  �� ElementName$ selectionCondition��	 �� Path$
	 Text�
 �� Value
  6d   .a�5      ��  �� Property � {� �� Value .  6A   5       5"      5$      �� 5%   
   -   5         ��Name$
 text��5%      $
��Left=�6"   $��10,4.139,0,0q�6=   $��3��6S   $
��Wrap=�6`   $	��Top=�6t   $	��146��6�   $	��272��6�   5(      5)      