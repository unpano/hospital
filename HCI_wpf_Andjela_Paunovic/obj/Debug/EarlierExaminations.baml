   M S B A M L   `   `   `  ����S  OHCI_wpf_Andjela_Paunovic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:HCI_wpf_Andjela_PaunovicHCI_wpf_Andjela_Paunovic  5   	   2    ,HCI_wpf_Andjela_Paunovic.EarlierExaminations   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:HCI_wpf_Andjela_Paunovic     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6>   $	��600��5   	   $	��430��6     � WindowStyle$
  None=�6"    � WindowStartupLocation$ CenterScreen=�65   .��5	      �� .+�5
   
   '  !MaterialDesignThemes.Wpf.PackIcon  -   5           Kind$ 	ArrowBack=�5
   A   
���iii�$��38��6g   $��38��6r   $��Center=�6~   � 5   
   $��50,0,0.333,0q�6   .+�5      �� -   5         ��Name$ SearchTermTextBox��5   L   $	��370��6   $��18��6"   $��Center=�6/   $	��Top=�6g   �� 5       J� IsHitTestVisible .  $��Find examination...��61   $��Center=�6L   $
��Left=�6g   
�������$��18��6�   $	��245��6�   $��	51,0,0,10q�6�   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � y� �� Value$ 	Collapsed=�67    �� Triggers 5      �� 5      	 �� Binding	 6*   �� *Text+
 �� ElementName$
 SearchTermTextBox�� �� Value  6b   .a�5   "   ��  � y�$ Visible=�6?   5      5      5      5      �� 5   
   -   5        $��earlierExaminationList��5       �� View 5      �� 5      .P�5      ��  �� Width$	 100��6'   $��Intervention type��64    �� DisplayMemberBinding 6O   �� *Type+�� 5      $	 100��6'   $��
Start time��64    6H   �� *Start+5      ��5!      �� 5"      " ��6   .�5#      clickedItem��-   5        5$      5&      5'      5(      