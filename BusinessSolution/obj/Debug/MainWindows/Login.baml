   M S B A M L   `   `   `  ����K  GBusinessSolution, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:BusinessSolutionBusinessSolution  5   	       BusinessSolution.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:BusinessSolution     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          � Title$  Login��5	   	   $	��500��6   $	��350��6$   $y�Visible=�60    � WindowStyle$
 None=�6F    � WindowStartupLocation$ CenterScreen=�6Y    � 
ResizeMode$ NoResize=�6~   .��5      � .+�5   
   �� $	��280��6   $	��Top=�6!   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF2281D1��6#   � 5      $ 	#FF34268A��6#    � Offset$ 1Q�65   � 5      $ 	#FF33288B��6#   $	 0.5Q�65   5      5      �� 5   
    �� Orientation$ 
Horizontal=�6   $	��Top=�6.   $��40��6F   $��Right=�6R   $��10q�6n   .+�5      ��  0  ,MaterialDesignFloatingActionMiniAccentButton#��[  6   $��40��6[   $��40��6f   $��0q�6r   
���������6~   Z� ��6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$
	 Bell=�6*   5      �� 5      -   5        
 ��Name$
 
ButtonExit��5      #��[  6)   $��40��6o   $��40��6z   $��0q�6�   
���������6�   Z� ��6�   Z� .��5        $	 Power=�6*   5      5      �� 5   
   $��/Assets/home.png��6   $	��110��6*   $	��Top=�67   $��125,20,120,0q�6O   �� 5   
   $	��280��6   $	��240��6    
�������$��Bottom=�6:   $��0,100q�6U    �� RadiusY$ 20��6d    �� RadiusX$ 20��6q    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5          Color$ 	#FFBBBBBB��6#      	Direction$ 0Q�65      
BlurRadius$ 15Q�6C      RenderingBias$ Quality=�6S      ShadowDepth$ 1Q�6k   5"      � 5#   
   $	��280��6   $	��240��6   $��Bottom=�6(   $��0,100q�6C   .+�5$      �� $��LOGIN��6   $��Center=�6%   $	��Top=�6B   $��5q�6Z   
�������$��18(�6w   �� 5%      $��Center=�6   $��10q�64   .+�5&      �� -   5        $��uName��5&      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ User ID��6'    % !MaterialDesignFloatingHintTextBox#��[ 6P   $
��0,10q�6�   $��Champagne & Limousines)�6�   $��18(�6�   $�� ��6�   G� 5'      -   5        $��uPass��5'      $ Password��6+    ) %MaterialDesignFloatingHintPasswordBox#��[ 6U   $
��0,10q�6�   $��Champagne & Limousines)�6�   $��18(�6�    G� Password$  ��6�   �� 5(      -   5        $��loginErrorMessage��5(        MaterialDesignLabel#��[ 61   $
��0,10q�6^   $�� ��6l   $��Cambria)�6w   $��14(�6�   
���   �6�   5)      5*      �� 5+   
   -   5        $
 loginButton��5+      $��Bottom=�6&   $
��0,85q�6A   $	��150��6O   $��LOGIN��6[   6k   �� 5,   
   $��Forgotten Password��6   $��Center=�6.   $��Bottom=�6K   $��50q�6f   
������� � Cursor$
 Hand��6�   5-      5.      