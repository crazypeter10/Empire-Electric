   M S B A M L   `   `   `  ����F  BProiect APB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Proiect_APBProiect_APB  5   	   o<clr-namespace:Proiect_APB.EmpireElectricDataSetTableAdapters.Proiect_APB.EmpireElectricDataSetTableAdapters  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 6q       Proiect_APB.admin_tarrifs   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Proiect_APB     5   	   k"EmpireElectricDataSetTableAdapters<clr-namespace:Proiect_APB.EmpireElectricDataSetTableAdapters     5   	   9System&clr-namespace:System;assembly=mscorlib     6q     � Title$  admin_tarrifs��5	   	   $	��450��6   $	��800��6,   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��0* �6   �� 5      .+�5   
   �� -   5        $
��Back��5      $
��Left=�6    $��695,379,0,0q�6;   $	��Top=�6P   $��90��6h   $��35                 ��6�   $��2��6�    � 	Resources 5       �� 
TargetType �� Property �� Value��%^   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 5��65   5      5      ��5      �� 5       �� EndPoint$ 0.5,1&�6&    � MappingMode$ RelativeToBoundingBox=�67    �� 
StartPoint$ 0.5,0&�6[   .��5      � 	 � Color$	 	#FFCDB839��6#   
 � Offset$
 0Q�65   � 5      $	 	#FFEDF1B6��6#   $
 1Q�65   5      5      �� 5   
   -   5         ��Name$ userText��5      $
��Left=�6&   $��695,334,0,0q�6A   $
��Wrap=�6V   $��	TextBlock��6j   $	��Top=�6{   $��90��6�   $��2��6�   �� 5   
   -   5        $��Insert��5      $
��Left=�6"   $��685,294,0,0q�6=   $	��Top=�6R   $��90��6j   $��35                 ��6�   $��2��6�    5      ��%^   '��       �� 5      " ��6   .�5       ��  �@��CornerRadius$ 5��65   5!      5"      ��5#      �� 5$      $ 0.5,1&�6&   $ RelativeToBoundingBox=�67   $ 0.5,0&�6[   .��5%      � $	 	#FFCDB839��6#   $
 0Q�65   � 5&      $	 	#FFEDF1B6��6#   $
 1Q�65   5'      5)      �� 5*   
   -   5         ��Name$ Text2��5*      $
��Left=�6!   $��678,249,0,0q�6<    �� TextWrapping$
 Wrap=�6Q   $��TextBox��6e   $	��Top=�6t   $	��104��6�   $��2��6�   �� 5+   
   -   5        $ Text1��5+      $
��Left=�6!   $��681,177,0,0q�6<   $
 Wrap=�6Q   $��TextBox��6e   $	��Top=�6t   $	��105��6�   $��2��6�   �� 5,   
   -   5         ��Name$ Label1��5,      $��Price��6    $
��Left=�60   $��681,146,0,0q�6K   $	��Top=�6`   $��2��6x   $��40��6�   �� 5-   
   -   5        $ Label2��5-      $��Tarrif Description��6    $
��Left=�6=   $��681,211,0,0q�6X   $	��Top=�6m   $��2��6�   &   System.Windows.Controls.DataGrid  5.   
   -   5          Name$ Data1��5.      $��2��6"   $��
0,23,161,0q�6a   �� 5/   
   -	   5        $��Delete��5/      $
��Left=�6"   $��678,106,0,0q�6=   $	��Top=�6R   $��90��6j   $��35                 ��6�   $��2��6�    50      ��%^   '��       �� 51      " ��6   .�52      ��  �@��CornerRadius$ 5��65   53      54      ��55      �� 56      $ 0.5,1&�6&   $ RelativeToBoundingBox=�67   $ 0.5,0&�6[   .��57      � $	 	#FFCDB839��6#   $
 0Q�65   � 58      $	 	#FFEDF1B6��6#   $
 1Q�65   59      5;      �� 5<   
   -
   5        $ 
textDelete��5<      $
��Left=�6&   $��
680,64,0,0q�6A   $
 Wrap=�6U   $��TextBox��6i   $	��Top=�6x   $	��105��6�   $��2��6�   �� 5=   
   -   5        $ LAbel��5=      $��Entry to be deleted��6   $
��Left=�6=   $��
680,23,0,0q�6X   $	��Top=�6l   $��2��6�   5?      5@      