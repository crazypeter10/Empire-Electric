   M S B A M L   `   `   `  ����F  BProiect APB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Proiect_APBProiect_APB  5   	       Proiect_APB.admin_mo_pay   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Proiect_APB     5   	     � Title$  admin_mo_pay��5   	   $	��450��6   $	��800��6+   .��5	      � $��0,0,0,-6q�6   .+�5
   
   �� -   5         ��Name$ 
electricID��5
      $
��Left=�6&   $��
42,288,0,0q�6A    �� TextWrapping$
 Wrap=�6U   $��TextBox��6i   $	��Top=�6x   $	��120��6�   �� 5   
   -   5        $ accID��5      $
��Left=�6!   $��188,288,0,0q�6<   $
 Wrap=�6Q   $��TextBox��6e   $	��Top=�6t   $	��120��6�   �� 5   
   -   5        $ tarrifID��5      $��Center=�6$   $��	0,288,0,0q�6A   $
 Wrap=�6T   $��TextBox��6h   $	��Top=�6w   $	��120��6�   �� 5   
   -   5        $ bil_nombreTxt��5      $
��Left=�6)   $��496,288,0,0q�6D   $
 Wrap=�6Y   $��TextBox��6m   $	��Top=�6|   $	��120��6�   �� 5   
   -   5        $ reading��5      $
��Left=�6#   $��662,288,0,0q�6>   $
 Wrap=�6S   $��TextBox��6g   $	��Top=�6v   $	��120��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Data3��5      $��18,10,18,176q�6M   �� 5   
   -   5        $ prevReading��5      $
��Left=�6'   $��
42,340,0,0q�6B   $
 Wrap=�6V   $��TextBox��6j   $	��Top=�6y   $	��120��6�   �� 5   
   -   5        $ 	cons_unit��5      $
��Left=�6%   $��187,339,0,0q�6@   $
 Wrap=�6U   $��TextBox��6i   $	��Top=�6x   $	��120��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   .��6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.695Q�6&   T� 5      5      .��5   '   5      �� 5   
   -	   5        $ fixedChargeTxt��5      $��Center=�6*   $��	0,340,0,0q�6G   $
 Wrap=�6Z   $��TextBox��6n   $	��Top=�6}   $	��120��6�   �� 5   
   -
   5        $ energy_chargeTxt��5      $
��Left=�6,   $��496,340,0,0q�6G   $
 Wrap=�6\   $��TextBox��6p   $	��Top=�6   $	��120��6�   �� 5   
   -   5        $ taxTxt��5      $
��Left=�6"   $��662,340,0,0q�6=   $
 Wrap=�6R   $��TextBox��6f   $	��Top=�6u   $	��120��6�   �� 5   
   -   5        $��Send Invoice��5      $
��Left=�6(   $��690,368,0,0q�6C   $	��Top=�6X   $��92��6p   6{   �� 5   
   $��Electricity board ID��6   $
��Left=�6/   $��
42,258,0,0q�6J   $	��Top=�6^   �� 5    
   $��
account_id��6   $
��Left=�6%   $��188,257,0,0q�6@   $	��Top=�6U   �� 5!   
   $��
tarriff_id��6   $
��Left=�6%   $��338,258,0,0q�6@   $	��Top=�6U   �� 5"   
   $��bill_no��6   $
��Left=�6"   $��494,253,0,0q�6=   $	��Top=�6R   �� 5#   
   $��present_reading��6   $
��Left=�6*   $��660,261,0,0q�6E   $	��Top=�6Z   �� 5$   
   $
��Left=�6   $��
42,309,0,0q�6+   $	��Top=�6?   �� 5%   
   $��consumpton unit��6   $
��Left=�6*   $��188,311,0,0q�6E   $	��Top=�6Z   �� 5&   
   $��fixed charge��6   $
��Left=�6'   $��340,311,0,0q�6B   $	��Top=�6W   �� 5'   
   $��energy charge��6   $
��Left=�6(   $��494,306,0,0q�6C   $	��Top=�6X   �� 5(   
   $	��tax��6   $
��Left=�6   $��662,309,0,0q�69   $	��Top=�6N   �� 5)   
   -   5        $ bill_amountTxt��5)      $
��Left=�6*   $��
42,396,0,0q�6E   $
 Wrap=�6Y   $��TextBox��6m   $	��Top=�6|   $	��120��6�   �� 5*   
   $��bill amount ��6   $
��Left=�6'   $��
47,357,0,0q�6B   $	��Top=�6V   �� 5+   
   $��previous reading ��6   $
��Left=�6,   $��
42,309,0,0q�6G   $	��Top=�6[   �� 5,   
   -   5        $ dueDate_TXT��5,      $
��Left=�6'   $��188,396,0,0q�6B   $
 Wrap=�6W   $��TextBox��6k   $	��Top=�6z   $	��120��6�   $ 20.278,67.931&�6�   �� 5-   
   $��	due date ��6   $
��Left=�6$   $��188,365,0,0q�6?   $	��Top=�6T   �� 5.   
   -   5         ��Name$ userText��5.      $
��Left=�6&   $��504,362,0,0q�6A   $
��Wrap=�6V   $��	TextBlock��6j   $	��Top=�6{   $	��104��6�   �� 5/   
   -   5        $
��Back��5/      $
��Left=�6    $��690,399,0,0q�6;   $	��Top=�6P   $��92��6h   6s   �� 50   
   -   5         ��Name$	 L23��50      $3��-Type here to update the invoice that was paid��6   $
��Left=�6U   $��339,373,0,0q�6p   $	��Top=�6�   �� 51   
   -   5        $ paidTxt��51      $
��Left=�6#   $��345,406,0,0q�6>   $
 Wrap=�6S   $��TextBox��6g   $	��Top=�6v   $	��120��6�   $ 20.278,67.931&�6�   �� 52   
   -   5        $
��Paid��52      $
��Left=�6    $��583,404,0,0q�6;   $	��Top=�6P   $��92��6h   6s   �� 53   
   -   5        $
��Late��53      $
��Left=�6    $��486,404,0,0q�6;   $	��Top=�6P   $��92��6h   6s   55      56      