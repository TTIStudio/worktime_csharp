   M S B A M L   `   `   `  ����N  Jworktime_wpf_csharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:worktime_wpf_csharpworktime_wpf_csharp  5   	   $    worktime_wpf_csharp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:worktime_wpf_csharp     5   	     � Title$  
MainWindow��5   	   $��344.656��6   $��297.233��6-   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��135* �6   �� 5      $
��154* �6    � RowDefinitions 5   
   �� 5      $��25 �6   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$ Textbox_Log��5       �� TextWrapping$
 Wrap=�6'   $�� ��6;   $��2��6C   $��2��6P   �� 5   
   -   5         ��Name$ TextBlock_TimerDisplay��5      $��17.069,0,1,1q�64   $
��Wrap=�6J   $��TextBlock_TimerDisplay��6^   $��1��6|   �� 5   
   -   5         ��Name$ CheckBox_WorkingState��5      $��CheckBox_WorkingState��62   $
��Left=�6R   $	��147��6m   $��0,0,0,1q�6�   $��2��6�   �� 5   
   -   5        $ TextBlock_TotalTime��5      $��3��61   $
��Wrap=�6>   $,��&how many works do you thing you can do��6R   �� 5   
   -   5        $ TextBox_eventlog��5      $��0,4,41,5q�6,   $��1��6>   $
 Wrap=�6K   $�� ��6_   $��2��6�   6�   �� 5   
   -   5        $  TextBlock_TotalnothingTime��5      $��3��68   $
��Wrap=�6E   $��Do not wasting your time��6Y   $��1��6y   $��5,0,0,0q�6�   �� 5   
   -   5         ��Name$ Setting��5      $��S��6"   $��1��6.   $��Right=�6>   $��0,4,1,5q�6Z   $��1��6k   $��21��6x   5      5      