   M S B A M L   `   `   `  ���� A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfAppWpfApp      WpfApp.AddStudent   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     &localclr-namespace:WpfApp       � Title$  Add Student��$	��282��$	��530�� � WindowStyle$
 None=� � AllowsTransparency$
 True�� � WindowStartupLocation$ CenterScreen=�����    AddWindowBackground �� Color# �   .��� ���� # �   .+�� $��30,60,30,30q� � RowDefinitions �� $��* ��� $
��Auto �.+�� $��0q� � ColumnDefinitions �� $��* ��� $��* �.+���  �� Orientation$ Vertical=�$��Stretch=�$��Stretch=�$��0,0,5,0q�.+�� $
��Auto��$��0q�$��Stretch=�$	��Top=�$
��Auto�� �� $
��Auto ��� $��* �.+��� $
��Name��$��0��$
��Left=�$��Center=�
��������� -    ��Name$ nameText��$��1��$��Stretch=�$��TextBox��$��Stretch=�
�������
�������$��0,4,0,4q�$
��Left=�$��Center=���Z� � � $
��Auto��$��0,5,0,0q�$��Stretch=�$	��Top=� �� $
��Auto ��� $��* �.+��� $	��Age��$��0��$
��Left=�$��Center=�
��������� -   $ ageText��$��Stretch=�$��31,0,0,0q�$��TextBox��$��Stretch=�
�������
�������$��2��$��Center=�$��0,4,0,4q���Z� � � $��0,5,0,0q�$��Stretch=� �� $
��Auto ��� $��* �.+��� 
�������$��1,1,1,0q�$��0,0,0,0q�$
��Left=�._��� $��	Classroom��
�������
����������	#00000000$��-1,0,0,0q�$��Center=��� -   	 ��Name$	 
classrooms��$��	0,0,0,-62q�$��1��
�������
�������$��64����Z� ���� .R�� 
 K� IsItemsHost$

 True��� $��1��$��5,0,0,0q� �� $
��Auto ��� .+��� -   $	 	schedules��$��1��$��0q�
�������
���������Z� �� $
��Left=�$��0q�$	��Top=�
�������$��1,1,1,0q�$��0��._��� $��Classroom Schedule��
��������� -   $��1��$��0,10,0,0q�$��5q����	#FF00A2FF
�������$��Add student��$��Right=�$��Bottom=���Z� �� -   $��30��$	��Top=�����   TitleBarColor# �  �� -   $�� ��$��Right=�$	��Top=�$��29��$��31����Z� ����  �� ImageSource$ 
/close.png�� j� Stretch$ Uniform=�