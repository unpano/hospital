   M S B A M L   `   `   `  ����S  OHCI_wpf_Andjela_Paunovic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:HCI_wpf_Andjela_PaunovicHCI_wpf_Andjela_Paunovic  5   	   -    'HCI_wpf_Andjela_Paunovic.MedicationList   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   2local&clr-namespace:HCI_wpf_Andjela_Paunovic  5   	   $	��600��5	   	   $	��430��6     � WindowStyle$
  None=�6"    � WindowStartupLocation$ CenterScreen=�65    � 	Resources 5         MenuOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	MenuClose��%�  &	        &	 �     �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ 	sidePanel��6a   .\�5        $ 0��6'   $ 60Q�63     5      $ 0:0:0.3��6'   $	 300Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ 	sidePanel��6a   .\�5        $ 0��6'   $	 300Q�63     5      $ 0:0:0.3��6'   $ 50Q�69   5      5      5       � Triggers 5      :� 5   
    :� RoutedEvent$ ButtonBase.Click��6   	 :� 
SourceName$
	 Open��66   .[�5       �� #��[  6   5"      :� 5$   
   $ ButtonBase.Click��6   $	 Close��66   .[�5%      �� #��[ 6   5'      .��5,      � 
�������.+�5.   
   �� -   5        $��medList��5.      $��50,32,0.333,71.333q�6"   
 �� View
 5/      �� 50      .P�51      ��  �� Width$	 300��6'   $��Medication list��64    �� DisplayMemberBinding 6M   �� *Name+52      ��54      �� 55       �� 
TargetType" ��6   .�56      clickedItem��-   5        57      59      � 5<   
   .+�5=      �� -   5         ��Name$ SearchTermTextBox��5=   f   $	��371��6   $��28��6"   $��Center=�6.   $��Center=�6I   $��52,0,0.333,565.333q�6�   �� 5>       J� IsHitTestVisible .  $��Search medication...��61   $��Center=�6M   $
��Left=�6h   
�������$��18��6�   $	��269��6�   $��69,10,0,565.333q�6�   ��5?      �� 5@      " ��6   .�5A      ��  �� Property � y� �� Value$ 	Collapsed=�67    �� Triggers 5B      �� 5C       �� Binding 6*   �� *Text+ �� ElementName$ SearchTermTextBox�� �� Value  6b   .a�5D   "   ��  � y�$ Visible=�6?   5E      5G      5I      5J      �� 5K   
   -   5        $��17(�5K   )   $
��Bold"�67   
���iii�
�������$��0q�6q   $��GENERATE REPORT��6�   $��59,540,10.333,10.333q�6�    5L       �� 
TargetType ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  '��       '�� T     �� 5M      " ��6   .�5N      ��  �@��CornerRadius$ 5��65   5O      �� 5P      " ��6   .�5Q      ��  � ��
 �   �63   �� 5R       � �� 5S      �� 5T      " ��6.   .R�5U   "   �� $ Border��6)   #��z��69   ._�5V   &   �� $��Center=�67   $��Center=�6T   5W   #    5X   "   P� 5Y   &    �@J�IsMouseOver . . �5Z   *   �� $ Border��6U    � ��
 �   �5[   '   5]      5_      5`      5a      5b      � 5c   
   -   5         �Name$ 	sidePanel��5c      
���iii�$
��Left=�67   $��50��6R   .+�5d      �� .+�5e      � $��60��6   
���iii�.+�5f      �� -   5         ��Name$ Close��5f      $��60��6-   $��60��68   $	��Top=�6q   $��Right=�6�   $��
0,-8,0,-10q�6�   ��6D   Z� ��6Z   Z� .��5g      '  !MaterialDesignThemes.Wpf.PackIcon  
�������   Kind$
 Menu=�6E   $��25��6Q   5h      �� 5i      -   5        $
 Open��5i      $��60��6,   $��60��67   $	��Top=�6p   $
��Left=�6�   $��
0,-8,0,-10q�6�   ��6C   Z� ��6Y   Z� .��5j        
�������$
 Menu=�6E   $��25��6Q   5k      5l      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  5n      -   5          Name$ TrainsitionigContentSlide��5n   6   $y�	Collapsed=�6�   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase    OpeningEffect  6Y   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+!   Duration$! 0:0:0.2X�.��5o      � -	   5        $ 
GridCursor��5o      $��	0 100 0 0q�6/   
���iii�$��10��6W   $
��Left=�6b   $��60��6}   $	��Top=�6�   5p      �� 5r      -
   5        " ��Name$" ListViewMenu��5r   {   $��0q�6   
���iii�$��Disabled=�6D   
���iii�.@�5s      �� 
���iii�.��5t      �� # �� Orientation$# Vertical=�6%   .+�5v      �� 
���iii�$	��300��6@   $��50��6L   .��5w   "   �� $# 
Horizontal=�6-   .+�5x   &     $ 	DateRange=�6>   
�������$��30��6b   $��30��6m   $��2q�6y   $��Center=�6�   �� 5y   &   -   5        
���iii�$��0q�5y   S   $��Appointments��6g   $��Center=�6~   $��18(�6�   
�������$
��Bold"�6�   5z   #   5{      �� 5      
���iii�$	��300��6@   $��50��6L   .��5�   "   �� $# 
Horizontal=�6-   .+�5�   &     $ 
MedicalBag=�6>   
�������$��30��6c   $��30��6n   $��2q�6z   $��Center=�6�   �� 5�   &   -   5        
���iii�$��0q�5�   S   $��Medications��6g   $��Center=�6}   $��18(�6�   
�������$
��Bold"�6�   5�   #   5�      �� 5�      
���iii�$	��300��6@   $��50��6L   .��5�   "   �� $# 
Horizontal=�6-   .+�5�   &     $ QuestionAnswer=�6>   
�������$��30��6g   $��30��6r   $��2q�6~   $��Center=�6�   �� 5�   &   -   5        
���iii�$��0q�5�   S   $��	Questions��6g   $��Center=�6{   $��18(�6�   
�������$
��Bold"�6�   5�   #   5�      �� 5�      
���iii�$	��300��6@   $��50��6L   .��5�   "   �� $# 
Horizontal=�6-   .+�5�   &     $ AccountCircle=�6>   
�������$��30��6f   $��30��6q   $��2q�6}   $��Center=�6�   �� 5�   &   -   5        
���iii�$��0q�5�   T   $��Profile��6h   $��Center=�6z   $��18(�6�   
�������$
��Bold"�6�   5�   #   5�      �� 5�      
���iii�$	��300��6A   $��50��6M   .��5�   "   �� $# 
Horizontal=�6-   .+�5�   &     $ Feedback=�6>   
�������$��30��6a   $��30��6l   $��2q�6x   $��Center=�6�   �� 5�   &   -   5        
���iii�$��0q�5�   X   $��Leave feedback��6l   $��Center=�6�   $��18(�6�   
�������$
��Bold"�6�   5�   #   5�      �� 5�      
���iii�$	��300��6A   $��50��6M   .��5�   "   �� $# 
Horizontal=�6-   .+�5�   &     $ Logout=�6>   
�������$��30��6_   $��30��6j   $��2q�6v   $��Center=�6�   �� 5�   &   -   5        
���iii�$��0q�5�   V   $��Log out��6j   $��Center=�6|   $��18(�6�   
�������$
��Bold"�6�   5�   #   5�      5�      5�      5�      5�      5�      5�      5�      