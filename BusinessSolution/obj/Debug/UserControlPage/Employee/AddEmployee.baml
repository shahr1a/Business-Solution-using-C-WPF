   M S B A M L   `   `   `  ����K  GBusinessSolution, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:BusinessSolutionBusinessSolution  5      "    BusinessSolution.AddEmployee   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      *localclr-namespace:BusinessSolution  5      .��5
      � -   5          �Name$  AddEmployeePage��5
      $��
10 70 9 30q�6$   
������ $y�Visible=�6Q   .+�5   
   �� $	��300��6   
�������$��Center=�63    �� Padding$ 30q�6N    �� CornerRadius$ 15��6[   $	��700��6m   $��
0, 1, 0, 0q�6|    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6#      Color$ 	LightGray��63      ShadowDepth$ 0Q�6E   ._�5      �� .+�5      �� $��Welcome��6   $��30(�6+   $
��Bold"�69   $��0 0 0 20q�6K   � 5      $��0 0 0 20q�6   .+�5      �� -   5         ��Name$ RegisterButton��5      $��Register��65   $
��Left=�6H   $	��Top=�6c   6{   �� 5      -   5        $ 
HomeButton��5      $
��Home��61   $��Right=�6@      MaterialDesignFlatButton#��[  6\   6�   5      � 5       � ColumnDefinitions 5      �� 5      $��8* �6+   �� 5      $��* �6+   .+�5      �� -   5        	 ��Name$	 	FirstName��5      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 
First Name��61    % !MaterialDesignFloatingHintTextBox#��[ 6]   $	��0 5q�6�   $�� ��6�   $��0��6�   '  !MaterialDesignThemes.Wpf.PackIcon  5      -   5          Name$ FirstNameMissing��5   �      Kind$ Error=�6.   
���  ��$��Right=�6L   $y�	Collapsed=�6i   $��1��6�   $��
10 20 20 0q�6�   5      � 5!       5"      �� 5#      $��8* �6+   �� 5$      $��* �6+   .+�5&      �� -   5        $	 LastName��5&      $
 	Last Name��60   #��[ 6[   $	��0 5q�6�   $�� ��6�     5'      -   5        $ LastNameMissing��5'   �   $ Error=�6.   
���  ��$��Right=�6L   $y�	Collapsed=�6i   $��1��6�   $��
10 20 20 0q�6�   5(      � 5*       5+      �� 5,      $��8* �6+   �� 5-      $��* �6+   .+�5/      �� -   5        $	 PhoneNumber��5/      $
 Phone Number��63   #��[ 6a   $	��0 5q�6�   $�� ��6�     50      -	   5        $ PhoneNumberMissing��50   �   $ Error=�6.   
���  ��$��Right=�6L   $y�	Collapsed=�6i   $��1��6�   $��
10 20 20 0q�6�   51      � 53       54      �� 55      $��8* �6+   �� 56      $��* �6+   .+�58      �� -
   5        $	 Email��58      $
 Email��6-   #��[ 6T   $	��0 5q�6�   $�� ��6�     59      -   5        $ EmailMissing��59   �   $ Error=�6.   
���  ��$��Right=�6L   $y�	Collapsed=�6i   $��1��6�   $��
10 20 20 0q�6�   5:      � 5<       5=      �� 5>      $��8* �6+   �� 5?      $��* �6+   .+�5A      �� -   5        $	 AddressLine��5A      $
 Address Line��63   #��[ 6a   $	��0 5q�6�   $�� ��6�     5B      -   5        $ AddressLineMissing��5B   �   $ Error=�6.   
���  ��$��Right=�6L   $y�	Collapsed=�6i   $��1��6�   $��
10 20 20 0q�6�   5C      � 5E       5F      �� 5G      $��8* �6+   �� 5H      $��* �6+   .+�5J      �� -   5        $
	 City��5J      $

 City��6,   #��[ 6R   $	��0 5q�6�   $�� ��6�     5K      -   5        $ CityMissing��5K   �   $ Error=�6.   
���  ��$��Right=�6L   $y�	Collapsed=�6i   $��1��6�   $��
10 20 20 0q�6�   5L      � 5N       5O      �� 5P      $��8* �6+   �� 5Q      $��* �6+   .+�5S      �� -   5        $	 Country��5S      $
 Country��6/   #��[ 6X   $	��0 5q�6�   $�� ��6�     5T      -   5        $ CountryMissing��5T   �   $ Error=�6.   
���  ��$��Right=�6L   $y�	Collapsed=�6i   $��1��6�   $��
10 20 20 0q�6�   5U      � 5W       5X      �� 5Y      $��8* �6+   �� 5Z      $��* �6+   .+�5\      G� -   5         G�Name$ Password��5\   "   $
 Password��64    ) %MaterialDesignFloatingHintPasswordBox#��[ 6^   $	��0 5q�6�    G� Password$  ��6�     5]      -   5        $ PasswordMissing��5]   �   $ Error=�6.   
���  ��$��Right=�6L   $y�	Collapsed=�6i   $��1��6�   $��
10 20 20 0q�6�   5^      � 5`       5a      �� 5b      $��8* �6+   �� 5c      $��* �6+   .+�5e      G� -   5        $ ConfirmPassword��5e   "   $
 Confirm Password��6;   #��[ 6m   $	��0 5q�6�   $  ��6�     5f      -   5        $ ConfirmPasswordMissing��5f   �   $ Error=�6.   
���  ��$��Right=�6L   $y�	Collapsed=�6i   $��1��6�   $��
10 20 20 0q�6�   5g      �� 5h      -   5         ��Name$ ConfirmationMessage��5h        MaterialDesignLabel#��[ 65   $�� ��6b   $	��0 5q�6m   $y�	Collapsed=�6z   �� 5i      ._�5j      �� -   5        $ CancelButton��5j      $��Cancel��63   $��Right=�6D   $��	0 0 10 0 q�6`   6s   5k      5l      5m      5n      5o      