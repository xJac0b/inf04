   M S B A M L   `   `   `  ����C  ?Paszport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PaszportPaszport  5   	       Paszport.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Paszport     5   	     � Title$8  2Wprowadzenie danych do paszportu. Wykonał: 012345��5   	   $	��370��6C   $	��800��6P   ���#5F9EA0.��5	      � $	��340��6   $	��Top=�6   .+�5
   
   �� $��Numer��6   $
��Left=�6    $��	50,60,0,0q�6;   $	��Top=�6N   �� 5   
   $��Imię��6   $
��Left=�6   $��	50,91,0,0q�6:   $	��Top=�6M   �� 5   
   $��Nazwisko��6   $
��Left=�6#   $��
50,122,0,0q�6>   $	��Top=�6R   �� 5   
   -   5         ��Name$ 	poleNumer��5      ���#F0FFFF$
��Left=�6:   $��
149,64,0,0q�6U    �� TextWrapping$
 Wrap=�6i   $�� ��6}   $	��Top=�6�   $	��160��6�   6�   �� 5   
   -   5        $ poleImie��5      ���#F0FFFF$
��Left=�69   $��
149,95,0,0q�6T   $
 Wrap=�6h   $�� ��6|   $	��Top=�6�   $	��160��6�   �� 5   
   -   5        $ poleNazwisko��5      ���#F0FFFF$
��Left=�6=   $��149,126,0,0q�6X   $
 Wrap=�6m   $�� ��6�   $	��Top=�6�   $	��160��6�   �� 5   
   $��
Kolor oczu��6   $��50,172,491,63q�6'   .��5      �� $��74��6   .+�5      	� -   5         	�Name$ 
niebieskie��5      $��
Niebieskie��62    d� 	IsChecked$
 TrueY�6G   $��24��6Y   $	��198��6e   	� 5      -   5        $ zielone��5      $��Zielone��6/   $��24��6B   $	��198��6N   	� 5      -   5        $ piwne��5      $��Piwne��6.   $��24��6?   $	��198��6K   5      5      �� 5   
   -   5         ��Name$ zdjecie��5      $��000-zdjecie.jpg��6!   $
��Fill=�6:   $
��Left=�6J   $	��180��6e   $��
400,64,0,0q�6r   $	��Top=�6�   $	��152��6�   �� 5   
   -   5        $ odcisk��5      $��000-odcisk.jpg��6    $
��Fill=�68   $
��Left=�6H   $	��180��6c   $��
601,64,0,0q�6p   $	��Top=�6�   $	��152��6�   �� 5   
   -	   5        $��OK��5      ���#F0FFFF$
��Left=�63   $��476,276,0,0q�6N   $	��Top=�6c   $	��201��6{   $��40��6�   6�   5      5      