   M S B A M L   `   `   `  ����K  GBusinessSolution, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:BusinessSolutionBusinessSolution  5           BusinessSolution.Inventory   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      *localclr-namespace:BusinessSolution  5      .��5
      � -   5          �Name$  AddEmployeePage��5
      $��
10 70 9 30q�6$   
������ $y�Visible=�6Q   .+�5   
   �� $	��300��6   
�������$��Center=�63    �� Padding$ 30q�6N    �� CornerRadius$ 15��6[   $	��700��6m   $��
0, 1, 0, 0q�6|    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6#      Color$ 	LightGray��63      ShadowDepth$ 0Q�6E   ._�5      �� .+�5      � .+�5      �� $��Category List��6    $��30(�65   $
��Bold"�6C   $��0 0 0 20q�6U   �� 5      -   5         ��Name$ button��5      $��Right=�6-      MaterialDesignFlatButton#��[  6I   $��70��6{   ���#425f6d$��	0,4,10,20q�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $
��Auto��6�   ��6�   Z� z�5      V� 5      .~�5   "   �� �� 5   "   �� 5   "   T� 5   "   5      ��5      �� 5      	 �� ImageSource$>	 8/Assets/0e2ea8b5-b142-482b-bea5-16a60c8249cd_200x200.png��6)   
 j� Stretch$
 UniformToFill=�6p   5      5!      �� 5"      -   5         ��Name$ StackPanelCategory��5"      .+�5#      �� -   5         ��Name$ ProductBrand��5#      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Enter Brand Name��64    % !MaterialDesignFloatingHintTextBox#��[ 6f   $	��0 5q�6�   $�� ��6�   &   System.Windows.Controls.DataGrid  5$      -   5          Name$ DataGridCategory��5$         AutoGenerateColumns . $
��Auto��6T   $
��Auto��6b   $y�	Collapsed=�6o   5%      �� 5'      .+�5(      �� $��Right=�6   ._�5)      �� -   5        $ ShowAllInventoryButton��5)   !   $��Show All��6A   $��
0 10 10 0 q�6T   6h   5*      �� 5+      $��Right=�6   ._�5,      �� -   5        $ UpdateButton��5,   !   $��Update��67   $��
0 10 10 0 q�6H   6\   5-      �� 5.      $��Right=�6   ._�5/      �� -   5        $ ExportExcelButton��5/   !   $��Export��6<   $��
0 10 10 0 q�6M   6a   50      �� 51      $��Right=�6   ._�52      �� -	   5        $ CancelButton��52   !   $��Cancel��67   $��
0 10 10 0 q�6H   6\   53      54      56      57      58      59      