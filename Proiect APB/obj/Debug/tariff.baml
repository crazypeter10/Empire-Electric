   M S B A M L   `   `   `  ����F  BProiect APB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Proiect_APBProiect_APB  5   	       Proiect_APB.tariff   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Proiect_APB     5   	   -   5          � Title$  Tarrifs��5   	   $	��450��6   $	��800��6&    � 	Resources 5	      '   !Proiect_APB.EmpireElectricDataSet   empireElectricDataSet  tariffViewSource �� Source �� Source��%W   &	        &	      7     5
   
   6&   �� 5   
    68   �� *tariff+8   5      .��5      �  � DataContext# [ 6   ���	#FF062536 � ColumnDefinitions 5   
   �� 5      $
��161* �6   �� 5      $
��235* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ tariffDataGrid��5         AutoGenerateColumns .     EnableRowVirtualization . $��72,23,126,20q�6f   	   RowDetailsVisibilityMode$	 VisibleWhenSelected=�6|   $��2��6�   ���	#FF0E3C55���	#FFE2E2E2
   RowStyle
 5      �� 5       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6   .�5      ��  �� Property � �� �� Value �	#FF0E3C5563   5       5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn��%c   '        7 �� 5      8   "  6Q   .�5      ��  � �� �	#FF0F324663   5      5      ��5      �� 5       �� Path$ tariff�6   # [  6(      Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      -   5        tariff_idColumn��,  &System.Windows.Controls.DataGridColumn   Header$ ID��5!   \      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6z   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *	tariff_id+6z     5"      -   5        tariff_typeColumn��$
 Type��5"   `   $ 3* 6n    6@   �� *tariff_type+6n     5#      -   5        twariff_descriptionColumn��$ Description��5#   o   $ 5* 6�    6H   �� *tariff_description+6�     5$      -   5        statusColumn��$ Status��5$   V   $ 2* 6f    6;   �� *status+6f   5&      �� 5'   
   -   5        $
��Back��5'      $
��Left=�6    $��370,374,0,0q�6;   $	��Top=�6P   $��90��6h   $��35                 ��6�   $��1��5(       5)      ��%^   '��       �� 5*      " ��6   .�5+      ��  �@��CornerRadius$ 5��65   5,      5-      ��5.      �� 5/       �� EndPoint$ 0.5,1&�6&    � MappingMode$ RelativeToBoundingBox=�67    �� 
StartPoint$ 0.5,0&�6[   .��50      �  � Color$ 	#FFCDB839��6#    � Offset$ 0Q�65   � 51      $ 	#FFEDF1B6��6#   $ 1Q�65   52      54      �� 55   
   -   5         ��Name$ userText��55      $��1��6&   $
��Left=�66   $��370,334,0,0q�6Q   $
��Wrap=�6f   $��	TextBlock��6z   $	��Top=�6�   $��90��6�   57      58      