   M S B A M L   `   `   `  ���� A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfAppWpfApp      WpfApp.AddProfessor   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     &localclr-namespace:WpfApp       � Title$  Add Professor��$	��364��$	��409��$	��304��$	��245�� � WindowStyle$
 None=� � AllowsTransparency$
 True�� � WindowStartupLocation$ CenterScreen=�$
��Left=�$	��Top=�����    AddWindowBackground �� Color# �   .��� ���	#FF2A2A2E � RowDefinitions �� $��* ��� $
��Auto �.+�� $��
30,60,30,0q� �� $
��Auto ��� $
��Auto �.+��� $��0,0,0,0q�.+�� $��0,5,0,5q� � ColumnDefinitions �� $
��Auto ��� $��* �.+��� $
��Name��
��������� -    ��Name$ nameText��$��1��
�������
�������$��0,4,0,0q���Z� � $��0,5,0,5q� �� $
��Auto ��� $��* �.+��� $	��Age��
��������� -   $ ageText��$��1��
�������
�������$��0,4,0,0q� �� 
CaretBrush
 �������Z� �� -   	 ��Name$	 subjects��  ComboBoxStyle#���  
 �� SelectedIndex$
 0��
�������$��25.96��$��0,5,0,10q�.@��� .��Select Subject� $��1�� �� $
��Auto ��� $��* �.+�� $��0,0,0,-1q� �� $��* ��� $��* �.+��� $��1q�
�������._��� $��Schedule��
��������� -   $	��Add��$��1��
�������
����������� # �   �� -    ��Name$ scheduleList��$��1��$
��True�� �� CanVerticallyScroll$
 True��$��Visible=� K� ZIndex$ 1�� � UseLayoutRounding$
 True��$��Visible=� �� CanHorizontallyScroll$
 True�� � IsSharedSizeScope$
 True��$��LeftToRight=� �� Orientation$ 
Horizontal=�.+�� -    �Name$ scheduleNameItem��$
��True��$
��Auto=� �� $
��Auto ��� $��* �.+��� $��00:00:00��
��������� -   $	 scheduleDropDown��$��1��$��10,0,0,0q�
�������#���  $
 0��.@��� .��Select Classroom�� -   $��1��$��5q�$��Add Professor��
�������$��Bottom=�$��Right=�$��	0,0,30,30q���Z� ���� $ 	#FF00A2FF���� -	   $��	0,0,0,216q�$	��Top=�$��30������   TitleBarColor# �  �� -
   $�� ��$��Right=�$	��Top=�$��29��$��31����Z� ����  �� ImageSource$ 
/close.png�� j� Stretch$ Uniform=�