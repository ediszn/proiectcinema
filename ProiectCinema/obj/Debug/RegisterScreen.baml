   M S B A M L   `   `   `  ����H  DProiectCinema, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ProiectCinemaProiectCinema  5   	   "    ProiectCinema.RegisterScreen   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:ProiectCinema     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Cinema IESC��5	   	   $	��660��6   $	��480��6*   $	��480��66   $	��620��6E    � Icon$ cinemaproiect.png��6U   ��5
      �� 5   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ Black��6    � Offset$ 0Q�6)   � 5      $ 	#FF0D213E��6   $ 1Q�6-   5      .��5      � $��Center=�6   $��Center=�6(    � ColumnDefinitions 5   
   �� 5      $	��280��6   $��* �6.    � RowDefinitions 5   
   �� 5      $��* �6   $	��160��6'   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5        $��LogoR��5      $
��Auto��6   $
��Auto��6+   $��logocinemaalb.png��68   $��0��6S   $��Center=�6`   �� 5   
   -   5        $��
UserLabelR��5      $��33��6"   $	��160��61   $
��Left=�6@   $��
-55,25,0,0q�6[   $��1��6o   $��	Username:��6|   
�������$��20(�6�   �� 5   
   -   5        $��UserTxtBoxR��5      $	��150��6%   $��33��64   $	��210��6C   $��Right=�6R   $��20,30,-55,0q�6n   $��1��6�   	 J� Opacity$		 0.6Q�6�   $��20(�6�   �� 5!   
   -   5        $��
PassLabelR��5!      $��33��6"   $	��160��61   $
��Left=�6@   $��
-55,10,0,0q�6[   $��2��6o   $��	Password:��6|   
�������$��20(�6�   G� 5"   
   -   5        $��PassTxtBoxR��5"      $	��150��6)   $��33��68   $	��210��6G   $��Right=�6V   $��20,10,-55,0q�6r   $��2��6�   $		 0.6Q�6�   $��20(�6  �� 5$   
   -   5        $��ConfirmPass��5$      $��33��6#   $	��160��62   $
��Left=�6A   $��
-55,10,0,0q�6\   $��3��6p   $��Confirm password:��6}   
�������$��20(�6�   G� 5%   
   -   5        $��ConfirmPassBox��5%      $	��150��6,   $��33��6;   $	��210��6J   $��Right=�6Y   $��20,10,-55,0q�6u   $��3��6�   $		 0.6Q�6�   $��20(�6  �� 5'   
   -   5        $��RegisterButton��5'      $
��Auto��6'   $
��Auto��65   $��40��6B   $	��150��6Q   $��Center=�6`   $��
40,30,40,0q�6}   $��Register��6�   $��Center=�6�   $��Center=�6�   $��20(�6�   $��4��6�   
����������	#FF3399CC
 �� 	IsDefault
 . ��6/  Z� 6W  5(      5)      