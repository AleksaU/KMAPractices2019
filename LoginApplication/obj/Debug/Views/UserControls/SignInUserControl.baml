   M S B A M L   `   `   `  ����K  GLoginApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:LoginApplication.Views.UserControls#LoginApplication.Views.UserControls  5      ;    5LoginApplication.Views.UserControls.SignInUserControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Clocal1clr-namespace:LoginApplication.Views.UserControls     5      .��5	      �   � ColumnDefinitions  5
   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��Login��6   $��0��6    $��0��60   $��Center=�6=   $��Center=�6Z   �� 5   
   $��Password��6   $��0��6#   $��1��63   $��Center=�6@   $��Center=�6]   �� 5   
   $��0��6   $��1��6   $��10q�6/   ��6;   �� *Login+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   $��1��6   $��1��6   $��10q�6/   ��6;   �� *
Password+$ TwoWay=�$ PropertyChanged=��� 5   
   $��0��6   $��3��6!   $��10q�6.   $��Sign in��6:   ��6L   �� *SignInCommand+�� 5   
   $��1��6   $��3��6!   $��10q�6.   $��Sign up��6:   ��6L   �� *SignUpCommand+�� 5   
   $��0��6   $��4��6!   $��2��6.   $��10q�6B   $��Cancel��6N   5       5!      