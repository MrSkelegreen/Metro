   M S B A M L   `   `   `  ����@  <Metro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MetroMetro  5   	       Metro.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Metro     5   	     � Title$  СибМетро��5   	   $	��255��6   $	��325��6'    � WindowState$ Normal=�63    � WindowStyle$ ThreeDBorderWindow=�6H    � Icon$ 	/logo.png��6i   $	��255��6z   $	��325��6�   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��6 �6   �� 5      $��94 �6   �� 5      $	��100 �6   �� 5      $	��100 �6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��35 �6   �� 5      $��9 �6   �� 5      $��35 �6   �� 5      $��35 �6   �� 5      $��45 �6   .+�5   
   �� $��0��6   $��22(�6$   $��4��62   $��Verdana)�6F   $��Авторизация��6[    �� TextAlignment$ Center=�6n   �� 5   
   $��1��6   $��22(�6$   $��3��62   $��Verdana)�6F   $��1��6[   $��Логин:��6h   �� 5   
   -   5        $��LoginBox��5   C   $��2��6   $��2��6"   $��1��66   6U   �� 5   
   $��1��6   $��22(�6$   $��Verdana)�62   $��3��6G   $��Пароль:��6T   $��2��6c   $��2��6w   �� 5   
   -   5        $��PasswordBox��5   D   $��2��6   $��2��6"   $��3��67   6D   �� 5   
   -   5        $��RegBtn��5   [   
�������$��Регистрация��6(   $��1��6>   $��5��6N    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5       5"      �� 5#   
   -   5        $��LgnBtn��5#   U   
�������$��
Логин��6(   $��5��68   $��3��6E    5$        5%      5'      5(      5)      