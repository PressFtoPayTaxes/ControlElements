   M S B A M L   `   `   `  ����N  JSecurityApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:SecurityApplicationSecurityApplication  5   	   ,    &SecurityApplication.RegistrationWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:SecurityApplication     5   	     � Title$  Регистрация��5   	   $	��450��6   $	��800��6*   $��Comic Sans MS)�66   ��5	      
� 5
   
   .��5      �  � Color$ White��6    � Offset$ 0Q�6)   � 5      $ 	#FFBBB6B6��6   $ 1Q�6-   5      .��5      � -   5         �Name$ registrationWindow��5       � ColumnDefinitions 5   
   �� 5      $
��200* �6   �� 5      $
��100* �6   �� 5      $
��200* �6    � RowDefinitions 5   
   �� 5      $
��100* �6   �� 5      $
��140* �6   �� 5      $
��100* �6   .+�5   
   ��  �� Orientation$ Vertical=�6   $��1��6,   $��1��6<   .+�5      �� $��Ваш логин:��6    �� TextAlignment$ Center=�6*   �� 5      -   5        $��newLoginTextBox��5      $��0 0 0 10q�6-   �� 5      $��Ваш пароль:��6   $ Center=�6+   G� 5      -   5        $��newPasswordBox��5      $��0 0 0 10q�60   �� 5       $&�� Повторите пароль:��6   $ Center=�61   G� 5!      -   5        $��repeatPasswordBox��5!      $��0 0 0 10q�63   �� 5"      -   5        $��registrateButton��5"      $*��$Зарегистрироваться��6-   6J   5#      5$      5%      