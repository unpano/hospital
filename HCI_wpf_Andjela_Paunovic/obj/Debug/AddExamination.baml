   M S B A M L   `   `   `  ����S  OHCI_wpf_Andjela_Paunovic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:HCI_wpf_Andjela_PaunovicHCI_wpf_Andjela_Paunovic  5   	   -    'HCI_wpf_Andjela_Paunovic.AddExamination   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:HCI_wpf_Andjela_Paunovic     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6>   $	��600��5   	   $	��430��6     � WindowStyle$
  None=�6"    � WindowStartupLocation$ CenterScreen=�65   .��5	      �� .+�5
   
   '  !MaterialDesignThemes.Wpf.PackIcon  -   5           Kind$ 	ArrowBack=�5
   8   
���iii�$��38��6^   $��38��6i   $��Center=�6u   2  ,MaterialDesignThemes.Wpf.MaterialDateDisplay  5   
   $��63,10,0.333,0q�6-   6F   �� 5   
   $��Right=�6   $��50��61    �� Orientation$ 
Horizontal=�6=   $��63,20,61.333,0q�6V   .+�5        $ AddBox=�6&   $��50��64   �� 5      -   5        $��0q�5   *   
�������
���   �$��	Prescribe��6d   5      � 5   
   .+�5      �� -   5         ��Name$ descript��5   g   $	��300��6   $	��170��6"   $��Center=�6/   $��Center=�6J   $��62,0,61.333,-70q�6y   �� 5       J� IsHitTestVisible .  $��Enter symptoms...��61   $��Center=�6J   $
��Left=�6e   
�������$��23��6�   $	��265��6�   $��
70,10,0,67q�6�   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � y� �� Value$ 	Collapsed=�67   	 �� Triggers	 5      �� 5      
 �� Binding
 6*   �� *Text+ �� ElementName$ SearchTermTextBox�� �� Value  6b   .a�5   "   ��  � y�$ Visible=�6?   5      5      5      5      �� 5   
   -   5         ��Name$ Placeholder��5   A   $��171.666,100q�6   $��Bottom=�6&   $��30��6V   $��80��6b   
���iii�
�������
�������$��14(�6�   $
��Bold"�6�   $��Submit��5        � 	Resources 5"       �� 
TargetType ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  '��       '�� T     �� 5#      " ��6   .�5$      ��  �@��CornerRadius$ 5��65   5%      �� 5&      " ��6   .�5'      ��  � ��
 ��ح�63   �� 5(       � �� 5)      �� 5*      " ��6.   .R�5+   "   �� $ Border��6)   #��z��69   ._�5,   &   �� $��Center=�67   $��Center=�6T   5-   #    5.   "   P� 5/   &    �@J�IsMouseOver . . �50   *   �� $ Border��6U    � ��
 �   �51   '   53      55      56      57      58      5:      5;      