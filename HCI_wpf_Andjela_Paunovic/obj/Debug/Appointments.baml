   M S B A M L   `   `   `  ����S  OHCI_wpf_Andjela_Paunovic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:HCI_wpf_Andjela_PaunovicHCI_wpf_Andjela_Paunovic  5   	   +    %HCI_wpf_Andjela_Paunovic.Appointments   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:HCI_wpf_Andjela_Paunovic     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6>   $	��600��5   	   $	��430��6     � WindowStyle$
  None=�6"    � WindowStartupLocation$ CenterScreen=�65    � 	Resources 5	         MenuOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	MenuClose��%�  &	        &	 �     �� 5
   
   .��5      U� $ (FrameworkElement.Width)�6,   $ 	sidePanel��6a   .\�5        $ 0��6'   $ 60Q�63     5      $ 0:0:0.3��6'   $	 300Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ 	sidePanel��6a   .\�5        $ 0��6'   $	 300Q�63     5      $ 0:0:0.3��6'   $ 50Q�69   5      5      5       � Triggers 5      :� 5   
    :� RoutedEvent$ ButtonBase.Click��6   	 :� 
SourceName$
	 Open��66   .[�5      �� #��[  6   5      :� 5!   
   $ ButtonBase.Click��6   $	 Close��66   .[�5"      �� #��[ 6   5$      .��5'      � 
�������.+�5)   
   �� $��Right=�6   $��0,0,10.333,0.333q�61   $	��358��6K   .+�5+      �� 
 �� Orientation$
 
Horizontal=�6   .+�5,      �� -   5        $��appointList��5,      $	��357��6.    �� View 5-      �� 5.      .P�5/      ��  �� Width$	 100��6/   $��
Patient id��6<    �� DisplayMemberBinding 6P   �� *	PatientId+�� 50      $	 100��6/   $��
Start time��6<    6P   �� *Start+51      ��53      �� 54       �� 
TargetType" ��6    .�55      clickedItem��-   5        56      58      59      5:      � 5;   
   -   5         �Name$ 	sidePanel��5;      
���iii�$
��Left=�67   $��50��6R   .+�5<      �� .+�5=      � $��60��6   
���iii�.+�5>      �� -   5         ��Name$ Close��5>      $��60��6-   $��60��68   $	��Top=�6q   $��Right=�6�   $��
0,-8,0,-10q�6�   ��6D   Z� ��6Z   Z� .��5?      '  !MaterialDesignThemes.Wpf.PackIcon  
�������   Kind$
 Menu=�6E   $��25��6Q   5@      �� 5A      -   5        $
 Open��5A      $��60��6,   $��60��67   $	��Top=�6p   $
��Left=�6�   $��
0,-8,0,-10q�6�   ��6C   Z� ��6Y   Z� .��5B        
�������$
 Menu=�6E   $��25��6Q   5C      5D      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  5F      -   5          Name$ TrainsitionigContentSlide��5F   6   $y�	Collapsed=�6�   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6Y   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.2X�.��5G      � -   5        $ 
GridCursor��5G      $��	0 100 0 0q�6/   
���iii�$��10��6W   $
��Left=�6b   $��60��6}   $	��Top=�6�   5H      �� 5J      -   5         ��Name$ ListViewMenu��5J   {   $��0q�6   
���iii�$��Disabled=�6D   
���iii�.@�5K      �� 
���iii�.��5L      �� $
 Vertical=�6%   .+�5N      �� 
���iii�$	��300��6@   $��50��6L   .��5O   "   �� $
 
Horizontal=�6-   .+�5P   &     $ 	DateRange=�6>   
�������$��30��6b   $��30��6m   $��2q�6y   $��Center=�6�   �� 5Q   &   -	   5        
���iii�$��0q�5Q   S   $��Appointments��6g   $��Center=�6~   $��18(�6�   
�������$
��Bold"�6�   5R   #   5S      �� 5W      
���iii�$	��300��6@   $��50��6L   .��5X   "   �� $
 
Horizontal=�6-   .+�5Y   &     $ 
MedicalBag=�6>   
�������$��30��6c   $��30��6n   $��2q�6z   $��Center=�6�   �� 5Z   &   -
   5        
���iii�$��0q�5Z   S   $��Medications��6g   $��Center=�6}   $��18(�6�   
�������$
��Bold"�6�   5[   #   5\      �� 5^      
���iii�$	��300��6@   $��50��6L   .��5_   "   �� $
 
Horizontal=�6-   .+�5`   &     $ QuestionAnswer=�6>   
�������$��30��6g   $��30��6r   $��2q�6~   $��Center=�6�   �� 5a   &   -   5        
���iii�$��0q�5a   S   $��	Questions��6g   $��Center=�6{   $��18(�6�   
�������$
��Bold"�6�   5b   #   5c      �� 5e      
���iii�$	��300��6@   $��50��6L   .��5f   "   �� $
 
Horizontal=�6-   .+�5g   &     $ AccountCircle=�6>   
�������$��30��6f   $��30��6q   $��2q�6}   $��Center=�6�   �� 5h   &   -   5        
���iii�$��0q�5h   T   $��Profile��6h   $��Center=�6z   $��18(�6�   
�������$
��Bold"�6�   5i   #   5j      �� 5l      
���iii�$	��300��6A   $��50��6M   .��5m   "   �� $
 
Horizontal=�6-   .+�5n   &     $ Feedback=�6>   
�������$��30��6a   $��30��6l   $��2q�6x   $��Center=�6�   �� 5o   &   -   5        
���iii�$��0q�5o   X   $��Leave feedback��6l   $��Center=�6�   $��18(�6�   
�������$
��Bold"�6�   5p   #   5q      �� 5s      
���iii�$	��300��6A   $��50��6M   .��5t   "   �� $
 
Horizontal=�6-   .+�5u   &     $ Logout=�6>   
�������$��30��6_   $��30��6j   $��2q�6v   $��Center=�6�   �� 5v   &   -   5        
���iii�$��0q�5v   V   $��Log out��6j   $��Center=�6|   $��18(�6�   
�������$
��Bold"�6�   5w   #   5x      5{      5|      5}      5~      5      5�      5�      