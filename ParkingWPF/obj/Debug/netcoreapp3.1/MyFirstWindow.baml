   M S B A M L   `   `   `  ����d  `DotNetProjects.Input.Toolkit, Version=6.1.94.0, Culture=neutral, PublicKeyToken=79778c5f2eed289bgKclr-namespace:System.Windows.Controls;assembly=DotNetProjects.Input.ToolkitSystem.Windows.Controls  5   *    
ParkingWPF   ParkingWPF.MyFirstWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   M IFluent, Version=9.0.0.0, Culture=neutral, PublicKeyToken=3e436e32a8c5546fFluenturn:fluent-ribbon  5   	   ZcontrolsKclr-namespace:System.Windows.Controls;assembly=DotNetProjects.Input.Toolkit  6*   $	��900��5      $
��1366��6   $	��500��6!   $	��900��61   
�����p�  � WindowStyle$  SingleBorderWindow=�6W    � WindowStartupLocation$ CenterScreen=�6y   $��0q�6�   ���	#FF1F1F00 � 	Resources 5	       3  /Fluent.Ribbon.Brushes.Button.Pressed.Background �� Color 4 0Fluent.Ribbon.Brushes.Button.Pressed.BorderBrush 2 .Fluent.Ribbon.Brushes.RibbonTabItem.Foreground 5 1Fluent.Ribbon.Brushes.RibbonTabControl.Background > :Fluent.Ribbon.Brushes.RibbonTabControl.TabsGrid.Background = 9Fluent.Ribbon.Brushes.RibbonTabControl.Content.Background 5 1Fluent.Ribbon.Brushes.BackstageTabItem.Background : 6Fluent.Ribbon.Brushes.RibbonGroupBox.Header.Foreground 3 /Fluent.Ribbon.Brushes.GroupSeparator.Background 5	 1Fluent.Ribbon.Brushes.Button.MouseOver.Background 6
 2Fluent.Ribbon.Brushes.Button.MouseOver.BorderBrush 3 /Fluent.Ribbon.Brushes.RibbonTabItem.BorderBrush A =Fluent.Ribbon.Brushes.WindowCommands.CaptionButton.Foreground I EFluent.Ribbon.Brushes.WindowCommands.CaptionButton.Pressed.Background K GFluent.Ribbon.Brushes.WindowCommands.CaptionButton.MouseOver.Background  mosGrayHighlight 
 mosRed  mosRedOpacity  mosHighlightGray  mosGray1  mosGray2  mosGray3  mosGray4  mosGray5  mosTransparent  StandardBorderBrush  StandardBackgroundBrush  HoverBorderBrush  SelectedBackgroundBrush  SelectedForegroundBrush  DisabledForegroundBrush  
GlyphBrush   NormalBrush ! NormalBorderBrush " HorizontalNormalBrush # HorizontalNormalBorderBrush��%)  &	        &	 %     &	 J     &	 i     &	 �     &	 �     &	 �     &	 �     &	     &		 ;    &	
 ^    &	 �    &	 �    &	 �    &	 �    &	 	    &	 ,    &	 O    &	 r    &	 �    &	 �    &	 �    &	 �    &	     &	 B    &	 g    &	 �    &	 �    &	 �    &	 �    &	     &	 &    &	  D    &	! b    &	" �    &	# �    �� 5
   
   $ Transparent��6R   �� 5   
   $ Transparent��6S   �� 5   
   $ White��6Q   �� 5   
   $ 	#FFD73D2C��6T   �� 5   
   $ 	#FFD73D2C��6]   �� 5   
   $ 	#FF272727��6\   �� 5   
   $ 	#FF474747��6T   �� 5   
   $ 	#FFD73D2C��6Y   �� 5   
   $ 	#FFD73D2C��6R   �� 5   
   $ 	#FF8D8D8D��6T   �� 5   
   $ 	#FF8D8D8D��6U   �� 5   
   $ 	#FFD73D2C��6R   �� 5   
   $ White��6a   �� 5   
   $ 	#FFD73D2C��6h   �� 5   
   $ 	#FF797979��6j   �� 5   
   $ 	#FF8D8D8D��63   �� 5   
   $ 	#FFD73D2C��6)   �� 5   
   $ 	#59D73D2C��60   �� 5   
   $ 	#238d8d8d��63   �� 5   
   $ 	#FF1F1F1F��6+   �� 5   
   $ 	#FF2D2D2D��6+   �� 5   
   $ 	#FF3C3C3C��6+   �� 5    
   $ DimGray��6+   �� 5!   
   $ 	#FF8D8D8D��6+   �� 5"   
   $ Transparent��61   �� 5#   
   $
 #888��66   �� 5$   
   $ Black��6:   �� 5%   
   $ 	#FF414141��63   �� 5&   
   $
 Gray��6:   �� 5'   
   $ 	#FF414141��6:   �� 5(   
   $
 #888��6:   �� 5)   
   $
 #444��6-   �� 5*   
   $
 #888��6.   �� 5+   
   $
 #888��64   �� 5,   
   $ 	#FF686868��68   �� 5-   
   $
 #888��6>   5.      .��5/      � .+�50   
   ]� $
��True��6   .+�51        Fluent.Ribbon  -   5          Name$ myRibbonMenu��51   1   $	��Top=�6   $	��150��6G   $	��Top=�6T   $��0q�6l   ���	#FF272727$��	Segoue UI)�6�   $��10(�6�   ���	#FF1F1F1F   Tabs. 52        Fluent.RibbonTabItem  -   5          Name$ fluentRibbonTabItem��52   '      Header$ Parking��6D   $��	Segoue UI)�6U   $��13(�6l   
���   �$��0q�6�      Groups. 53        Fluent.RibbonGroupBox  -   5        	  Name$	 fluentGroupBox��53   ,   $��Center=�6D   $	��150��6h   .@�54        Fluent.Button  -   5        
  Name$
 btnAddNewCar��54   (   
�������$��15(�6R      Header$ Add New Car��6`   $��0,0,2,0q�6u   6�     55      -   5        $
 btnDeleteCar��55   (   
�������$��15(�6Q   $ 
Remove Car��6_   $��2,0,0,0q�6s   6�   56        58      -   5        $	 fluentGroupBox2��58   ,   $��Center=�6E   $	��200��6i   .@�59        -   5        $
 btnSave��59   (   
�������$��15(�6L   $
 Save��6Z   $��0,0,5,0q�6h   ${�False��6�     5:      -   5        $
 	btnRemove��5:   (   
�������$��15(�6N   $ Remove��6\   $��0,0,0,0q�6l   ${�False��6�     5;      -	   5        $
 
btnDiscard��5;   (   
�������$��15(�6O   $ Discard��6]   $��5,0,0,0q�6n   ${�False��6�   5<      5=      5?      �� 5A      $	��150��6   $
��Left=�6%   ���	#FF272727.+�5B      �� -
   5         ��Name$ 
btnParking��5B      $��Parking��6-   $��15(�6?   ���	#FF272727���	#FFD73D2C
�������$��0,10,0,0q�6�   $��0q�6�   6�   �� 5C      -   5         ��Name$ capacity��5C      $��- / -��6.    �� TextAlignment$ Center=�6;   $��15(�6R   ���	#FF272727
�������$��0,10,0,0q�6�   $��Italic$�6�   6�   �� 5D      -   5        $ btnClear��5D      $��Clear��6+   $��15(�6;   ���	#FF272727
�������$��0,10,0,0q�6s   $��0q�6�   6�   5E      �� 5G      -   5         ��Name$ myTabControl��5G      ���	#FF2D2D2D$��0q�6F   
�������$��20(�6m   $��Stretch=�6{   $��Stretch=�6�   .@�5I      �� -   5         ��Name$ carsTabItem��5I      $
��Cars��6/   $
��Left=�6=   $��13(�6X    �� 
IsSelected$
 True��6f   ${�False��6x   $��23��6�   $	��Top=�6�   $y�	Collapsed=�6�   .��5J      &   System.Windows.Controls.DataGrid  -   5          Name$ carsInTheParking��5J      ���	#FF2D2D2D$��10,10,10,10q�6P      
IsReadOnly$
 True��6e      AutoGenerateColumns$ False��6w      AlternatingRowBackground
 �����$
��Bold"�6�      Columns 5K      0  *System.Windows.Controls.DataGridTextColumn  5L      -   5        numberColumn��,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 70 5L   b      Header$ Number��6m      
FontWeight$ DemiBold"�6}   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 6G   �� *Number+6}     5M      -   5        modelColumn��$	 130 5M   `   $ Model��6l   $ DemiBold"�6{    6F   �� *Model+6{     5N      -   5        colorColumn��$ 70 5N   `   $ Color��6k   $ DemiBold"�6z    6F   �� *Color+6z     5O      -   5        startTimeColumn��$	 150 5O   h   $ 
Start Time��6t   $ DemiBold"�6�    6J   �� *	StartTime+6�     5P      -   5        endTimeColumn��$	 150 5P   d   $ End Time��6p   $ DemiBold"�6�    6H   �� *	EndTime+6�     5Q      -   5        
costColumn��$ 40 5Q   ^   $
 Cost��6j   $ DemiBold"�6x    6E   �� *Cost+6x     5R      -   5        statusColumn��$	 100 5R   b   $ Status��6n   $ DemiBold"�6~    6G   �� *Status+6~   5T      5U      �� 5W      -   5        $ addCarTabItem��5W      $��Add car��61   $
��Left=�6B   $��13(�6]   ${�False��6k   $y�	Collapsed=�6}   .��5X      �� $	��Top=�6!   .+�5Y      �� $'��! Adding a new car to the parking:��6$   $��15(�6M   $��30��6[   ���	#FF2D2D2D
�������$��0,10,0,0q�6�   6�   ]� 5Z      $��Center=�6$   $��0,20,0,0q�6A   .+�5[      �� $��Model:��6(   $ Right=�66   $��15(�6L   $��30��6Z   $��80��6f   ���	#FF2D2D2D
�������$��	0,10,10,0q�6�   6�   �� 5\      -   5         ��Name$ modelBox��5\   &   $��30��68   $	��200��6D   ���#888
���   �$��15(�6u    �� TextAlignment$ Center=�6�   $
��Bold"�6�    �� 	MaxLength$ 20��6�   6�   5]      ]� 5^      $��Center=�6$   $��0,20,0,0q�6A   .+�5_      �� $��Color:��6(   $ Right=�66   $��15(�6L   $��30��6Z   $��80��6f   ���	#FF2D2D2D
�������$��	0,10,10,0q�6�   6�   �� 5`      -   5        $ colorBox��5`   &   $��30��68   $	��200��6D   ���#888
���   �$��15(�6u   $ Center=�6�   $
��Bold"�6�   $ 10��6�   6�   5a      ]� 5b      $��Center=�6$   $��0,20,0,0q�6A   .+�5c      �� $��Number:��6(   $ Right=�67   $��15(�6M   $��30��6[   $��80��6g   ���	#FF2D2D2D
�������$��	0,10,10,0q�6�   6�   �� 5d      -   5        $ 	numberBox��5d   &   $��30��69   $	��200��6E   ���#888
���   �$��15(�6v   $ Center=�6�   $
��Bold"�6�   $ 7��6�   6�   5e      ]� 5f      $��Center=�6$   $��0,20,0,0q�6A   .+�5g      �� $��Start Time:��6(   $ Right=�6;   $��15(�6Q   $��30��6_   $��80��6k   ���	#FF2D2D2D
�������$��	0,10,10,0q�6�   6�   �� 5h      -   5        $ dateTimeNow��5h   (   $��30��6=   $	��200��6I   ���#888
���   �$��15(�6z   $ Center=�6�   $
��Bold"�6�   6�   5i      5j      5k      �� 5m      -   5        $ removeCarTabItem��5m      $��Remove Car car��64   $
��Left=�6L   $��13(�6g   ${�False��6u   $y�	Collapsed=�6�   .��5n      �� $	��Top=�6!   .+�5o      �� $%�� Removing car from the parking:��6$   $��15(�6K   $��30��6Y   ���	#FF2D2D2D
�������$��0,10,0,0q�6�   6�   ]� 5p      $��Center=�6$   $��0,20,0,0q�6A   .+�5q      �� $��Number:��6(   $ Right=�67   $��15(�6M   $��30��6[   $��80��6g   ���	#FF2D2D2D
�������$��	0,10,10,0q�6�   6�   -
   'System.Windows.Controls.AutoCompleteBox
  5r      -   5         
 Name$ numberRemoveBox��5r   7   $��30��6P   $	��200��6\   ���#888
���   �$��15(�6�   $
��Bold"�6�   6�   5s      5t      5u      5v      5w      5x      5y      