   M S B A M L   `   `   `  ����S  OHCI_wpf_Andjela_Paunovic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:HCI_wpf_Andjela_PaunovicHCI_wpf_Andjela_Paunovic  5   	   0    *HCI_wpf_Andjela_Paunovic.ForgottenPassword   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:HCI_wpf_Andjela_Paunovic     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6>   $	��600��5   	   $	��430��6     � WindowStyle$
  None=�6"    � WindowStartupLocation$ CenterScreen=�65   .��5	      �  � Orientation$ Vertical=�6   $��Center=�6'   $��Center=�6B   $	��590��6_   $��3,0,3.333,3.333q�6l   .+�5
   
   '  !MaterialDesignThemes.Wpf.PackIcon  -   5           Kind$ 	ArrowBack=�5
   :   
���iii�$��38��6`   $��38��6k   $��Center=�6w   �� 5   
   $��Center=�6   $
��Bold"�6-   $��21(�6?   
���iii�$	��100q�6b   $��Forgotten password?��6o   � 5   
   $	��240��6   .+�5      �� $
��Bold"�6   $��14(�6&   
���iii�.��6J   " Please enter your e-mail adress:6l   �� 5      $��14(�6   $
��Bold"�6#   
�������$��20��6H   .��6S   ? � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType	 ��Name
 �� Triggers P� Property P� Value �� 
TargetName��%�  '��       '�� U     �� 5      " ��6   .�5      ��  �@��CornerRadius$ 20��69   5      �� 5      " ��6   .�5      ��  � ��
 ��ح�67   �� 5       � �� 5      �� 5   "   " ��62   .R�5   &   �� $	 Border��6-   #��z��6=   ._�5   *   �� $��Center=�6;   $��Center=�6X   5   '   
 5   &   P� 5   *    �@J�IsMouseOver . . �5   .   �� $ Border��6]    � ��
 �����5   +   5    #   5"      5#      5$       � ToolTip 5%      �� 5&      .+�5'      �� $
��Bold"�6$   $��14(�66   $��0,0,0,5q�6D   Enter e-mail address6k   �� 5(      )'We will send you link for reseting your�� 5*      " password to your e-mail address.5,      �� 5-      
�������$��0,1,0,0q�66   $	��0,8q�6P   5.      51      52      �� 53   
   -   5         ��Name$ TextBox1��53      $��Center=�6$   $��20��6A   $	��270��6N   $��20q�6Z   
 � Tag$ EmailAddress��6f   6{   �� 54   
   -   5        $��50q�54      $��30��6   $��80��6)   
���iii�
�������
�������$��14(�6p   $
��Bold"�6~   .��55   %   Submit 56      ��%�  '��       '�� U     �� 57      " ��6   .�58      ��  �@��CornerRadius$ 20��65   59      �� 5:      " ��6   .�5;      ��  � ��
 ��ح�63   �� 5<       � �� 5=      �� 5>      " ��6.   .R�5?   "   �� $	 Border��6)   #��z��69   ._�5@   &   �� $��Center=�67   $��Center=�6T   5A   #   
 5B   "   P� 5C   &    �@J�IsMouseOver . . �5D   *   �� $ Border��6U    � ��
 �   �5E   '   5G      5I      5J      5K      5L      5M      5N      