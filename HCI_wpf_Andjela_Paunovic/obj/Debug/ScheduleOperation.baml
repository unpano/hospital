   M S B A M L   `   `   `  ����S  OHCI_wpf_Andjela_Paunovic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:HCI_wpf_Andjela_PaunovicHCI_wpf_Andjela_Paunovic  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 6�   0    *HCI_wpf_Andjela_Paunovic.ScheduleOperation   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:HCI_wpf_Andjela_Paunovic     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6>   0sys&clr-namespace:System;assembly=mscorlib  6�   $	��600��5   	   $	��430��6     � WindowStyle$
  None=�6"    � WindowStartupLocation$ CenterScreen=�65    � 	Resources 5	      �� 5
   
      KeyinterventionType   �� Type" ��6+   .s�5      ��examination��6&   ��5      surgery��6"   ��5      stationaryTreatment��6.   5      .��5      �� $��0,0,0.333,-6.667q�6   .+�5   
   '  !MaterialDesignThemes.Wpf.PackIcon  -   5           Kind$ 	ArrowBack=�5   A   
���iii�$��38��6g   $��38��6r   $��Center=�6~   �� 5   
   $��27,-3,10.333,45.333q�6   $	��523��62   .+�5      �� $��30(�6   $
��Bold"�6"   $��Center=�64   $��33,10,21,10q�6Q   $��Schedule intervention��6f   $��46��6�   $	��332��6�   2  ,MaterialDesignThemes.Wpf.MaterialDateDisplay  5      $��Center=�62   $��59��6O   $��107,0,101,0q�6[   $	��178��6p   6~   (  "System.Windows.Controls.DatePicker  5      -   5        $
��date��5      $��45,40,44.333,0q�6%   6?   )  #MaterialDesignThemes.Wpf.TimePicker  5      -   5        $
��time��5   (   $��	45,10,0,0q�64   $
��Left=�6G   $	��297��6b   �� 5      $��17(�6   $��Intervetion type:��6"   $��	45,0,44,0q�6>   �� 5      -   5        $��interventionComboBox��5       �� 
IsEditable .   interventionType#��[ 6E   $��	45,0,44,0q�6u   �� 5      $��45,20,44.333,0q�6   .+�5      �� $��17(�6   $��
Speciality��6&   �� 5      -   5        $��specComboBox��5       .  �� DisplayMemberPath$ SpecName��6�   ��6A   �� *Specializations+ �� SelectedItem 6i   ��  �� Path$ ShowSpec�6�   �� 5      -   5        $��0 30 0 0q�5      .��6@   Filter doctors by speciality6^   5      �� 5       $��45,10,44.333,0q�6   .+�5!      �� $��17(�6   $��Doctors��6&   �� 5"      -   5        $��doctorComboBox��5"       . $ 	FirstName��6�   ��6C   �� *	Doctors+ 6c   �� $ 
ShowDoctor�6�   5#      �� 5$      -   5        $��0 20 0 0q�5$      $��30��6'   $��80��63   
���iii�
�������
�������$��14(�6z   $
��Bold"�6�   $��Submit��5%   %    5&      	 �� 
TargetType
 �� Property �� Value �� 
TargetType ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  '��       '�� T     �� 5'      "	 ��6   .�5(      �� 
 �@��CornerRadius$ 5��69   5)      �� 5*      "	 ��6   .�5+      �� 
 � ��
 ��ح�67   �� 5,      
 � �� 5-      �� 5.   "   " ��62   .R�5/   &   �� $ Border��6-   #��z��6=   ._�50   *   �� $��Center=�6;   $��Center=�6X   51   '    52   &   P� 53   *    �@J�IsMouseOver . . �54   .   �� $ Border��6Y   
 � ��
 �   �55   +   57   #   59      5:      5;      5<      5>      5?      5@      