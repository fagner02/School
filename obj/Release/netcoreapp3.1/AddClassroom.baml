   M S B A M L   `   `   `  ���� A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfAppWpfApp      WpfApp.AddClassroom   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     &localclr-namespace:WpfApp       � Title$  Add Classroom��$	��358��$	��621�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � SizeToContent$ Width=� � AllowsTransparency$
 True������    AddWindowBackground �� Color# �   .��� $��Stretch=����	#FF2A2A2E � RowDefinitions �� $��* ��� $	��12* �.+��� -   $	��Top=�$��30������   TitleBarColor# �  � $��Stretch=�$��1�� � ColumnDefinitions �� $��* � �� $
��Auto �.+��� $��Stretch=�$��15,14,24,-314q�$��Stretch=�	 �� Orientation$	 Vertical=�.+�� $��Stretch=�$
��0, 5q� �� $
��Auto ��� $��* �.+��� $��0��
�������$��Stretch=�.��Number�� -   
 ��Name$
 
numberText��$��1��
�������
�������$��5,3,0,0q���Z� .��
Capacity� $��Stretch=�$
��0, 5q� �� $
��Auto ��� $��* �.+��� $��0��
�������.��
Capacity�� -   $
 capacityText��
�������
�������$��5,0,0,0q�$��5,3,0,0q�$��1����Z� .��
Capacity� $
��0, 5q�$��Stretch=�$��Stretch=� �� $
��Auto ��� $��* � �� $��* �.+�� $��Stretch=� �� �� $��* �.+��� $��1q�
�������$��1,0,-1,0q�._��� $��0��
�������
�������$��0,0,0,-1q�.��
Schedule�� -    ��Name$ addSchedule��$��1��
�������
�������$��0,0,1,0q���Z� .��Add�� $��1,-1,1,0q�$��1��
�������$��1q�$��Stretch=�$��Stretch=�$	��145��._��� -    ��Name$ scheduleList��$��Stretch=�$��1,0,-1,0q�.+�� -    �Name$ scheduleStamp��$��Stretch=�$��5,5,10,5q� �� $
��Auto ��� $��* �.+��� 
�������.��
00:00:00�� -   $
 schtex��
�������
�������$��1,0,0,0q�$��1��$��5,3,0,0q���Z� .��
Capacity� $��Stretch=�.+��� -   $ sendBtn�����	#FF00A2FF$��5q�
�������$��Add Classroom��$��287,10,-2,0q�$	��Top=�$��Right=���Z� �� -	   $�� ��$��Right=�$��	375,0,0,0q�$	��Top=�$��29��$��31����Z� ����  �� ImageSource$ 
/close.png�� j� Stretch$ Uniform=�