   M S B A M L   `   `   `  ����S  OHCI_wpf_Andjela_Paunovic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:HCI_wpf_Andjela_PaunovicHCI_wpf_Andjela_Paunovic  5   	   (    "HCI_wpf_Andjela_Paunovic.Questions   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:HCI_wpf_Andjela_Paunovic     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6>   $	��600��5   	   $	��430��6     � WindowStyle$
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
   �� -   5        
 ��Name$
 Question��5)      $��50,0,0.333,0.333q�6<   ��6$   �� ��5*      �� 5,      .R�5-      �� -   5         �� Orientation$ Vertical=�5-   8   $��2q�6O   .+�5/      �� $��2q�6>   ��6$   �� *
dateTime+6>   �� 50      $
��Bold"�6$   $��12(�66   $��2q�6d   ��6E   �� *questionTitle+6d   �� 51      $	��300��6$   $
��Wrap=�60   $��2q�6e   ��6D   �� *questionContent+6e   �� 52      $��Stretch=�6$   
���iii�$��2��6Q   54      55      57      � 59   
   -   5         �Name$ 	sidePanel��59      
���iii�$
��Left=�67   $��50��6R   .+�5:      �� .+�5;      � $��60��6   
���iii�.+�5<      �� -   5         ��Name$ Close��5<      $��60��6-   $��60��68   $	��Top=�6q   $��Right=�6�   $��
0,-8,0,-10q�6�   ��6D   Z� ��6Z   Z� .��5=      '  !MaterialDesignThemes.Wpf.PackIcon  
�������   Kind$
 Menu=�6E   $��25��6Q   5>      �� 5?      -   5        $
 Open��5?      $��60��6,   $��60��67   $	��Top=�6p   $
��Left=�6�   $��
0,-8,0,-10q�6�   ��6C   Z� ��6Y   Z� .��5@        
�������$
 Menu=�6E   $��25��6Q   5A      5B      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  5D      -   5          Name$ TrainsitionigContentSlide��5D   6   $y�	Collapsed=�6�   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6Y   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.2X�.��5E      � -   5        $ 
GridCursor��5E      $��	0 100 0 0q�6/   
���iii�$��10��6W   $
��Left=�6b   $��60��6}   $	��Top=�6�   5F      �� 5H      -   5         ��Name$ ListViewMenu��5H   {   $��0q�6   
���iii�$��Disabled=�6D   
���iii�.@�5I      �� 
���iii�.��5J      �� $ Vertical=�6%   .+�5L      �� 
���iii�$	��300��6@   $��50��6L   .��5M   "   �� $ 
Horizontal=�6-   .+�5N   &     $ 	DateRange=�6>   
�������$��30��6b   $��30��6m   $��2q�6y   $��Center=�6�   �� 5O   &   -	   5        
���iii�$��0q�5O   S   $��Appointments��6g   $��Center=�6~   $��18(�6�   
�������$
��Bold"�6�   5P   #   5Q      �� 5U      
���iii�$	��300��6@   $��50��6L   .��5V   "   �� $ 
Horizontal=�6-   .+�5W   &     $ 
MedicalBag=�6>   
�������$��30��6c   $��30��6n   $��2q�6z   $��Center=�6�   �� 5X   &   -
   5        
���iii�$��0q�5X   S   $��Medications��6g   $��Center=�6}   $��18(�6�   
�������$
��Bold"�6�   5Y   #   5Z      �� 5\      
���iii�$	��300��6@   $��50��6L   .��5]   "   �� $ 
Horizontal=�6-   .+�5^   &     $ QuestionAnswer=�6>   
�������$��30��6g   $��30��6r   $��2q�6~   $��Center=�6�   �� 5_   &   -   5        
���iii�$��0q�5_   S   $��	Questions��6g   $��Center=�6{   $��18(�6�   
�������$
��Bold"�6�   5`   #   5a      �� 5c      
���iii�$	��300��6@   $��50��6L   .��5d   "   �� $ 
Horizontal=�6-   .+�5e   &     $ AccountCircle=�6>   
�������$��30��6f   $��30��6q   $��2q�6}   $��Center=�6�   �� 5f   &   -   5        
���iii�$��0q�5f   T   $��Profile��6h   $��Center=�6z   $��18(�6�   
�������$
��Bold"�6�   5g   #   5h      �� 5j      
���iii�$	��300��6A   $��50��6M   .��5k   "   �� $ 
Horizontal=�6-   .+�5l   &     $ Feedback=�6>   
�������$��30��6a   $��30��6l   $��2q�6x   $��Center=�6�   �� 5m   &   -   5        
���iii�$��0q�5m   X   $��Leave feedback��6l   $��Center=�6�   $��18(�6�   
�������$
��Bold"�6�   5n   #   5o      �� 5q      
���iii�$	��300��6A   $��50��6M   .��5r   "   �� $ 
Horizontal=�6-   .+�5s   &     $ Logout=�6>   
�������$��30��6_   $��30��6j   $��2q�6v   $��Center=�6�   �� 5t   &   -   5        
���iii�$��0q�5t   V   $��Log out��6j   $��Center=�6|   $��18(�6�   
�������$
��Bold"�6�   5u   #   5v      5y      5z      5{      5|      5}      5�      5�      