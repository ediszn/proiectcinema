   M S B A M L   `   `   `  ����H  DProiectCinema, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ProiectCinemaProiectCinema  5   	       ProiectCinema.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:ProiectCinema     5   	   X TXceed.Wpf.Toolkit, Version=3.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Cinema IESC��5
   	   $	��680��6   $
��1000��6*   $	��680��67   $
��1000��6G    � Icon$ cinemaproiect.png��6W   ��5      �� 5   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ Black��6    � Offset$ 0Q�6)   � 5      $ 	#FF0D213E��6   $ 1Q�6-   5      .��5      � $��20,30,20,30q�6    � ColumnDefinitions 5   
   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   $	��160��6'   $	��196��67   �� 5      $��* �6   .+�5   
   � $��0��6    5      �� 5      $��* �6#   �� 5      $	��530 �6#   �� 5      $��* �6#   .+�5!      �� -   5        	 ��Name$	 
HeaderText��5!      $��0,10,0,0q�6(   $
��Auto��6:   $
��Auto��6H   $��cinemaheadertext.png��6U   $��1��6s   $��Center=�6�   $��Center=�6�   �� 5"      -   5        $	 
CameraLogo��5"      $��0,10,0,0q�6(   $
��Auto��6:   $
��Auto��6H   $��cameralogo.png��6U   $��0��6m   $
��Left=�6}   �� 5$      -   5        $��rezervationsButton��5$      $��2��60   $
��Auto��6@   $
��Auto��6N   $��40��6[   $	��160��6j   $��50��6y   $��	0,150,0,0q�6�   $��Right=�6�   $��My Bookings��6�   $��20(�6�   
����������	#FF3399CC��6  Z� 6  #  Xceed.Wpf.Toolkit.SplitButton  5&      -   5        
  Name$
 loggeduserbutton��5&      $��2��6X   $
��Auto��6i   $
��Auto��6w   $��Center=�6�   $��Center=�6�   $��Right=�6�   $	��Top=�6�   $��
0,30,0,100q�6�   $��20(�6  
���������69   �� *
Loggeduser+&   Xceed.Wpf.Toolkit.DropDownButton    DropDownContentBackground 5'      �� 5(      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5)      � $ Black��6'   $ 0Q�65   � 5*      $ 	#FF0D213E��6'   $ 1Q�69   5+      ��5-      �� 5.      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5/      � $ Black��6'   $ 0Q�65   � 50      $ 	#FF0D213E��6'   $ 1Q�69   51      ��53      �� 54      $ 0.5,1&�6*   $ 0.5,0&�6;   .��55      � $ Black��6'   $ 0Q�65   � 56      $ 	#FF0D213E��6'   $ 1Q�69   57         DropDownContent 59      �� 5:      -   5        $��logoutbutton��5:      $	��100��61   $��Log out��6@   $��15(�6R   
���������6s   Z� ��6�   Z� 6�   5<      5=      �� 5>   
   $��1��6   $	��Top=�6!   $��0,20,0,0q�69   
�������z�5?      �� 5@       �� ScaleY$ 1Q�6!   5B      �� 5C   
   $��1��6   $��0,40,0,0q�6$   .��5D      �� -   5        $��
filmeStack��5D      5F      5G      5H      5I      