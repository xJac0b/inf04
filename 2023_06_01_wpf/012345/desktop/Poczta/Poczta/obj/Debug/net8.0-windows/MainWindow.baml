   M S B A M L   `   `   `  ����A  =Poczta, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PocztaPoczta  5   	       Poczta.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Poczta     5   	     � Title$&   Nadaj Przesyłkę, PESEL: 012345��5   	   $	��450��60   $	��800��6=   .��5	      � .+�5
   
   �� $��Rodzaj przesyłki��6   $��78,55,488,258q�6-   .��5      �� $��74��6   .+�5      	� -   5         	�Name$ 	pocztowka��5      $��5q�61    d� 	IsChecked$
 TrueY�6<   .��6M   
Pocztówka6X   	� 5      -   5        $
 list��5      $��5q�6,   .��67   List6=   	� 5      -   5        $ paczka��5      $��5q�6.   .��69   Paczka6A   5      5      �� 5   
   -   5        $��Sprawdź Cenę��5      $
��Left=�6=   $��
78,185,0,0q�6X   $	��Top=�6l   $��25��6�   $	��234��6�   �� 5   
   $��Rodzaj przesyłki��6   $��438,55,92,144q�6-   .��5      �� $��10,0,0,0q�6   $	��170��6+   .+�5      �� $��2q�6   .��6#   Ulica z numerem64   �� 5      $��4q�6   6(   �� 5      $��2q�6   .��6#   Kod pocztowy61   �� 5      -   5         ��Name$ kodPocztowy��5      $��4q�6/   $
��Left=�6:   $��80��6U   6b   �� 5      $��2q�6   .��6#   Miasto6+   �� 5      $��4q�6   6'   5      5      �� 5   
   -   5         ��Name$ obraz��5      $��pocztowka.png��6   $
��Left=�66   $��53��6Q   $��
78,238,0,0q�6]   $	��Top=�6q   $��82��6�   �� 5   
   -   5         ��Name$
 cena��5      $��Cena: 1 zł��6   $
��Bold"�63   $��20(�6E   $
��Left=�6T   $��195,238,0,0q�6o   $	��Top=�6�    J� RenderTransformOrigin$ 
-0.5,0.644&�6�   �� 5    
   -   5        $��
Zatwierdź��5       $
��Left=�6<   $��
78,339,0,0q�6W   $	��Top=�6k   $��28��6�   $	��630��6�   5#      5$      