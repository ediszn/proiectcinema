   M S B A M L   `   `   `  ����H  DProiectCinema, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ProiectCinemaProiectCinema  5   	       ProiectCinema.LoginScreen   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:ProiectCinema     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Cinema IESC��5	   	   $	��520��6   $	��380��6*   $	��380��66   $	��520��6E    � Icon$ cinemaproiect.png��6U    � 	Resources 5
         TransparentButton �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius	 �� Triggers
 P� Property P� Value �� 
TargetName��%m  &	        �� 5   
   " ��6*   .�5      ��  �@J�SnapsToDevicePixels . 64   �� 5       �@�OverridesDefaultStyle . 66   �� 5       � ��$ 23��6*   �� 5       � ��$ 75��6)   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��Border��6!   $ 2��6/   $��1q�6@   ��5      Z� ��5      Z� ._�5      �� $��2q�6/   $��Center=�5   "   $��Center=�5   "   ��. 5   "   5      	 5      P� 5      
 � �� . . �5   "   �� $ Border��6)    � �� �	#FF3399CC5   =   5      5!      5#      5$      5%      ��5&      �� 5'   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5(      �  � Color$ Black��6    � Offset$ 0Q�6)   � 5)      $ 	#FF0D213E��6   $ 1Q�6-   5*      .��5,      � $��Center=�6   $��Center=�6(    � ColumnDefinitions 5-   
   �� 5.      $��* �6    � RowDefinitions 50   
   �� 51      $��* �6   $	��160��6'   �� 52      $��* �6   �� 53      $��* �6   �� 54      $��* �6   �� 55      $��* �6   .+�58   
   �� -   5        $
��Logo��58      $
��Auto��6   $
��Auto��6*   $��logocinemaalb.png��67   $��0��6R   $��Center=�6_   �� 5:   
   -   5        $��	UserLabel��5:      $��33��6!   $	��160��60   $
��Left=�6?   $��0,25,0,0q�6Z   $��1��6l   $��	Username:��6y   
�������$��20(�6�   �� 5;   
   -   5        $��
UserTxtBox��5;      $	��150��6$   $��33��63   $	��150��6B   $��Right=�6Q   $��
20,30,10,0q�6m   $��1��6�    J� Opacity$	 0.6Q�6�   $��20(�6�   �� 5=   
   -   5        $��	PassLabel��5=      $��33��6!   $	��160��60   $
��Left=�6?   $��0,10,0,0q�6Z   $��2��6l   $��	Password:��6y   
�������$��20(�6�   G� 5>   
   -   5        $��
PassTxtBox��5>      $	��150��6(   $��33��67   $	��150��6F   $��Right=�6U   $��
20,10,10,0q�6q   $��2��6�   $	 0.6Q�6�   $��20(�6   �� 5@   
   -   5        $��LoginButton��5@      $
��Auto��6>   $
��Auto��6L   $��40��6Y   $	��100��6h   $��Center=�6w   $��
40,20,40,0q�6�   $��Login��6�   $��Center=�6�   $��Center=�6�   $��20(�6�   $��3��6  
����������	#FF3399CC �� 	IsDefault . ��6C  Z� 6Z  �� 5A   
   -   5        $��RegisterText��5A      #��[  6%   $��30��6P   $	��120��6_   $��Center=�6n   $��
15,40,15,0q�6�   $(��"Don't have an account? Click here!��6�   $��Center=�6�   $��Center=�6�   $��15(�6  $��4��6   
������� � Cursor$
 Hand��6�  ��6@  Z� ��6V  Z� 6�  5B      5C      