   M S B A M L   `   `   `  ����S  OHCI_wpf_Andjela_Paunovic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:HCI_wpf_Andjela_PaunovicHCI_wpf_Andjela_Paunovic  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 6>   )    #HCI_wpf_Andjela_Paunovic.ReportForm   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:HCI_wpf_Andjela_Paunovic     5   	   6sys&clr-namespace:System;assembly=mscorlib     6>   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6q   $	��600��5   	   $	��430��6     � WindowStyle$
  None=�6"    � WindowStartupLocation$ CenterScreen=�65    � 	Resources 5	         ComboBoxTitle  ComboBoxItems �� Type  WindowBackgroundBrush � Offset � Color��%�  &	        &	 !     &	     ��5
   
   	Medicine:��66   �� 5   
   " ��6(   .s�5      ��Abelcet��6"   ��5      Advair Diskus��6(   ��5      Abilify��6"   ��5      Abilify Maintena��6+   ��5      Advair Diskus��6(   ��5      
Amiodarone��6%   ��5      
Ambien��6!   ��5      
Amantadine��6%   ��5      
Alprazolam��6%   ��5      Allopurinol��6&   ��5      Allegra��6"   ��5      	Albuterol��6$   ��5      Advair Diskus��6(   5      �� 5   
   .��5      � $ 0Q�6   $ Silver��6&   � 5      $ 1Q�6   $
 Gray��6&   5      5      .��5!      �� .+�5"   
   '  !MaterialDesignThemes.Wpf.PackIcon  -   5           Kind$ 	ArrowBack=�5"   A   
���iii�$��38��6g   $��38��6r   $��Center=�6~   �� 5#   
   $��15,15,15.333,15q�6   $��22(�6)   $
��Bold"�67   $��Center=�6I   $(��"Report on consumption of medicines��6f   �� 5%   
   $��30q�6   .+�5&      �� $��17(�6   .��6"   From:6)   (  "System.Windows.Controls.DatePicker  5'      6   �� 5(      $��17(�6   .��6"   To:6'     5)      6   5*      �� 5-   
   $��30q�6   .+�5.      �� $��17(�6   #��[  6"   �� 5/       �� 
IsEditable . #��[ 6)   50      �� 53   
   $��Center=�6   $��10q�62   .+�54      �� $��17(�6   .��6%   Select all medicines6;   55      �� 57   
   -   5        $��50q�57      $��30��6@   $��80��6L   $��14(�6W   $
��Bold"�6e   
�������
���iii�$��0q�6�   .��6�   	CONFIRM 58       �� 
TargetType	 �� Property
 �� Value �� 
TargetType ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  '��       '�� T     �� 59      " ��6   .�5:      �� 	 �@��CornerRadius$
 5��65   5;      �� 5<      " ��6   .�5=      �� 	 � ��

 ��ح�63   �� 5>      	 � ��
 5?      �� 5@      " ��6.   .R�5A   "   �� $ Border��6)   #��z��69   ._�5B   &   �� $��Center=�67   $��Center=�6T   5C   #    5D   "   P� 5E   &    �@J�IsMouseOver . . �5F   *   �� $ Border��6U   	 � ��

 �   �5G   '   5I      5K      5L      5M      5N      5P      5Q      