   M S B A M L   `   `   `  ����  OfficeEquipmentInventory)    #OfficeEquipmentInventory.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$   Office Equipment Inventory��5   	   $	��600��6,   $	��800��69   ���#F0F0F0 � 	Resources 5       �� 
TargetType �� Property �� Value��%J  '��       '�� �     '�� (    �� 5	   
   " ��6   .�5
      ��  � ��$	 5,2q�6(   �� 5       � ��$ 5q�6'   �� 5       � ��$ Center=�69   5      �� 5   
   " ��6   .�5      ��  � ��$	 5,2q�6(   �� 5       � ��$ 5q�6'   �� 5       � ��$ Center=�69   5      �� 5   
   " ��6   .�5      ��  � ��$
 10,5q�6(   �� 5       � ��$ 5q�6'   �� 5       � �� �#007ACC6+   �� 5       � ��
 �����6+   �� 5       � ��$ 0q�60   �� 5       � ��$ 80��6&   5      5      .��5       �  � RowDefinitions 5!   
   �� 5"      $
��Auto �6   �� 5$      $
��Auto �6   �� 5&      $��* �6   .+�5+   
   �� $��0��6   
����������#CCCCCC$��0,0,0,1q�6G    �� Padding$ 10q�6a   ._�5,      �  � ColumnDefinitions 5-      �� 5.      $��* �6'   �� 50      $
��Auto �6'   .+�54      �� $��0��6    �� Orientation$ Vertical=�6-   .+�55      �� $��Add/Edit Equipment��6    $
��Bold"�6:   $��0,0,0,10q�6L   � 56      .+�57      �� -   5        	 ��Name$	 txtName��57   "   $	��150��63   
 � ToolTip$
 Equipment Name��6?   $��Equipment Name��6X   �� 58      -   5        $	 txtCategory��58   "   $	��150��67   $
 Category��6C   $��Category��6V   �� 59      -   5        $	 txtQuantity��59   "   $��80��67   $
 Quantity��6B   $��Quantity��6U   �� 5:      -   5         ��Name$ 	cmbStatus��5:   #   $	��120��66   $
 Status��6B    �� SelectedIndex$ 0��6S   .@�5;      �� .��6+   In Use63   �� 5<      .��6+   	Available66   �� 5=      .��6+   Maintenance68   5>      5?      5@      �� 5B      $��1��6   $ Vertical=�6-   $��Bottom=�6D   .+�5C      �� -   5         ��Name$ btnAdd��5C      $	��Add��6-   6;   �� 5D      -   5        $ 	btnUpdate��5D      $��Update��60   ${�False��6Y   �� 5E      -   5        $ 	btnDelete��5E      $��Delete��60   ���#D9534F${�False��6n   �� 5F      -   5        $ btnClear��5F      $��Clear��6/   ���#F0AD4E6V   5G      5H      5I      �� 5L   
   $��1��6   ���#E6E6E6���#CCCCCC$��0,0,0,1q�6I   $ 10q�6c   ._�5M      � .+�5N      �� -	   5        $	 	txtSearch��5N      $	��200��6-   $
 Search��69   $��	Search...��6J   �� 5O      -
   5        $ 	btnSearch��5O      $��Search��6,   6=   �� 5P      -   5        $ cmbSort��5P      $	��150��6,   $ 0��6d   .@�5Q      �� .��6#   Sort by Name61   �� 5R      .��6#   Sort by Category65   �� 5S      .��6#   Sort by Quantity65   �� 5T      .��6#   Sort by Date Added67   5U      5V      5W      &   System.Windows.Controls.DataGrid  5Z   
   -   5          Name$ dgEquipment��5Z      $��2��6(   $��10q�65      AutoGenerateColumns$ False��5[         
IsReadOnly$
 True��6/      AlternatingRowBackground �#F5F5F5   RowBackground
 �����   HeadersVisibility$ Column=�5]         GridLinesVisibility$ 
Horizontal=�5^         HorizontalGridLinesBrush �#E0E0E0   Columns 5`      0  *System.Windows.Controls.DataGridTextColumn  5a      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6H     5b      $
 Name��6%   $ * 6L    63   �� *Name+6L     5c      $ Category��6%   $ * 6T    67   �� *
Category+6T     5d      $ Quantity��6%   $
 Auto 6T    67   �� *
Quantity+6T     5e      $ Status��6%   $
 Auto 6P    65   �� *Status+6P     5f      $ 
Date Added��6%   $
 Auto 6W    69   �� *	DateAdded+6W   5h      5i      5j      