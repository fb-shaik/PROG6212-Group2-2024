   M S B A M L   `   `   `  ����  WeatherDashboardWPF$    WeatherDashboardWPF.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Weather Dashboard��5   	   $	��450��6#   $	��400��60   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ RefreshButton��5      $��Refresh Weather��6(   $��10q�5      $
��10,5q�6   �� 5   
   $��1��6   $
��Auto=�6$   .��5      �� -   5         ��Name$ WeatherItemsControl��5      ��5      �� 5      .R�5      �� 
�������$��0,0,0,1q�69    �� Padding$ 10q�6S   ._�5      �  � ColumnDefinitions 5   "   �� 5   &   $��* �67   �� 5   &   $
��Auto �67   .+�5   "   �� $
��Bold"�6B   ��6,   �� *City+6B   �� 5   "   $��1��6-    �� Orientation$ 
Horizontal=�6=   .+�5   &   �� $
��Bold"�6M   ��60   �� *Temperature+6M   �� 5   &   $��°C, ��60   $��0,0,5,0q�6<   �� 5   &   ��60   �� *	Condition+5   #   5      5      5       5"      5#      5$      5%      