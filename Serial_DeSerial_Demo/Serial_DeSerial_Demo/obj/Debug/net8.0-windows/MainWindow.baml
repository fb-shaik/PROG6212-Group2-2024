   M S B A M L   `   `   `  ����  Serial_DeSerial_Demo%    Serial_DeSerial_Demo.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Serialization Demo��5   	   $	��450��6$   $	��800��61   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5	      $
��Auto �6   .+�5   
   �� $��0��6   $��10q�6"   .+�5      �� $��Person Information��6   $
��Bold"�62   $��16(�6D   �� 5       �� Orientation$ 
Horizontal=�6   $��0,10,0,0q�62   .+�5      �� $��Name:��6   $��50��6)   �� 5      -   5         ��Name$ NameTextBox��5      $	��200��6/   5      �� 5      $ 
Horizontal=�6   $��0,10,0,0q�62   .+�5      �� $
��Age:��6   $��50��6(   �� 5      -   5        $ 
AgeTextBox��5      $��50��6.   5      5      �� 5   
   -   5        $ OutputTextBox��5      $��1��6)   $��10q�66    �� TextWrapping$
 Wrap=�6B    �� AcceptsReturn$
 True��6V   " �� VerticalScrollBarVisibility$
 Auto=�6k   �� 5   
   $��2��6   $ 
Horizontal=�6"   $��10q�6;   .+�5      �� -   5         ��Name$ SerializeButton��5      $��	Serialize��6.   $	��100��6B   $��0,0,10,0q�6N   6`   �� 5      -   5        $ DeserializeButton��5      $��Deserialize��60   $	��100��6F   $��0,0,10,0q�6R   6d   �� 5      -   5         ��Name$ SerializationTypeComboBox��5      $	��150��6:   	 �� SelectedIndex$	 0��6F   .@�5      �� $��XML Serialization��6   �� 5      $��JSON Serialization��6   5       5!      5"      5#      