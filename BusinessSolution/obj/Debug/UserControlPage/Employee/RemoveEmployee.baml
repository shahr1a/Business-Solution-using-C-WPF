   M S B A M L   `   `   `  ����K  GBusinessSolution, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:BusinessSolutionBusinessSolution  5      %    BusinessSolution.RemoveEmployee   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      *localclr-namespace:BusinessSolution  5      .��5
      � -   5          �Name$  AddEmployeePage��5
      $��
10 70 9 30q�6$   
������ .+�5   
   �� $	��300��6   
�������$��Center=�63    �� Padding$ 30q�6N    �� CornerRadius$ 15��6[   $	��700��6m   $��
0, 1, 0, 0q�6|    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6#      Color$ 	LightGray��63      ShadowDepth$ 0Q�6E   ._�5      �� .+�5      �� $��Welcome��6   $��30(�6+   $
��Bold"�69   $��0 0 0 20q�6K   � 5      $��0 0 0 20q�6   .+�5      �� -   5         ��Name$ SearchEmployeeButton��5      $��Search��6;   $
��Left=�6L   6g   �� 5      -   5        $ DeleteEmployeeButton��5      $��Delete��6;   $
��Left=�6L   $y�	Collapsed=�6�   �� 5      $
��Home��6   $��Right=�6,      MaterialDesignFlatButton#��[  6H   5      � 5       � ColumnDefinitions 5      �� 5      $��8* �6+   �� 5      $��* �6+   .+�5      �� -   5        	 ��Name$	 EmployeeLoginId��5      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Employee Login ID��67    % !MaterialDesignFloatingHintTextBox#��[ 6j   $	��0 5q�6�   $��0��6�   '  !MaterialDesignThemes.Wpf.PackIcon  5       -   5          Name$ EmployeeLoginIdMissing��5    �      Kind$ Error=�6.   
���  ��$��Right=�6L   $y�	Collapsed=�6i   $��1��6�   $��
10 20 20 0q�6�   5!      �� 5"      -   5         ��Name$ ConfirmationMessage��5"        MaterialDesignLabel#��[ 65   $�� ��6b   $	��0 5q�6m   $y�	Collapsed=�6z   �� 5$      -   5         ��Name$ StackPanelCategory��5$      .+�5%      &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridEmployee��5%         AutoGenerateColumns . $
��Auto��6T   $
��Auto��6b   $y�	Collapsed=�6o   5&      �� 5(      ._�5)      �� -	   5        $ CancelButton��5)      $��Cancel��63   $��Right=�6D   $��	0 0 10 0 q�6`   6s   5*      5+      5,      5-      5.      