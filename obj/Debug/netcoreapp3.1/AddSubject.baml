   M S B A M L   `   `   `  ����A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfAppWpfApp  5   	       WpfApp.AddSubject   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WpfApp     5   	     � Title$  Add Subject��5   	   $	��450��6   $	��515��6*   .��5	      � ��5   
   �� 5         AddWindowBackground �� Color# �   6   .+�5   
   � $��30q�6    � RowDefinitions 5      �� 5      $
��Auto �6    60   �� 5      $��* �6    6-   �� 5      $
��Auto �6    60   .+�5      � $��0,0,0,10q�6    � ColumnDefinitions 5      �� 5      $
��Auto �6'   66   �� 5      $��* �6'   63   .+�5      �� $
��Name��6   
���������6:   Z� 6R   �� 5      $��1��6   
�������$��1q�6=   ._�5      �� -   5         ��Name$ nameText��5       �� 
CaretBrush
 �����
�������$��0,3,0,0q�6�   ��60   Z� ��6F   Z� 6�   5      5      � 5      $��1��6    5      �� 5       $
��Auto �6$   64   �� 5!      6&   .+�5#      �� $��1q�6   
�������._�5$      �� $��Description��6   
���������6E   Z� 6]   5%      �� 5'      -   5        $ descriptionText��5'   D    �� AcceptsReturn$
 True��6    �� TextWrapping$
 Wrap=�6#   $��1��67   
����������	#00000000 J� OpacityMask
 �   �
�������$��0,-1,0,0q�6�   $��5q�6�   6�   5)      �� 5*      -   5        $��2��5*      $��5q�6"   
�������$��Right=�6X   $��Bottom=�6t   $��Add Subject��6�   $��0,10,0,0q�6�   ��6.   Z� ��5+      �� 5,        ButtonBrush# �  6&   5.      5/      50      51      