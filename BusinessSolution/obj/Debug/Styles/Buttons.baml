   M S B A M L   `   `   `  ����K  GBusinessSolution, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:BusinessSolutionBusinessSolution  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962a  �� 
TargetType $   TransparentButtonBackgroundStyle �� Property �� Value   TransparentButtonBorderStyle  	Hoverless �� 
TargetType �� Padding  SystemIconIcon �� BasedOn'   !System.Windows.Shell.WindowChrome  WindowControlButton �� ScaleX �� Triggers P� Property	 P� Value  AdminPanelButton  WindowCloseButton  	BaseStyle  RegularButton
 ��Name �� CornerRadius J� SnapsToDevicePixels �� Triggers :� RoutedEvent	 �� To g� Duration �� TargetProperty �� 
TargetName�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      (localclr-namespace:BusinessSolution  5      ;wpf1http://materialdesigninxaml.net/winfx/xaml/themes  5      %�	  &	        &	 J     &	 �     &	 �    7  &	 C    &	 &    &	 C    7  &	 �    7  �� 5      "  ��6   .�5   
   ��  � ��
 ���� 6'   5      �� 5
      "  ��6   .�5   
   ��  � ��
 ���� 6(   5      �� 5      "  ��6   .�5   
   ��  � ��
 ���� 6'   �� 5   
    � ��$ 0q�6,   �� 5   
    � �� 5      �� 5      " ��6"   .R�5      �� # z��6   #��z��6A   ._�5      �� $��Center=�6+   $��Center=�6F   5      5      5      5      �� 5      "  ��6   8   .�5   
   ��   �@  IsHitTestVisibleInChrome . 6B   �� 5    
    � ��$ 10 0 0 0q�6$   5!      �� 5%      "  ��6   .�5&   
   ��   �@  IsHitTestVisibleInChrome . 6B   �� 5'   
    � ��
 ���� 6'   �� 5(   
    � �� �#425f6d6'   �� 5)   
    � ��$ 10q�6$   �� 5*   
    � ��$ 0q�6,   �� 5+   
    � ��$ Center=�6.   �� 5,   
    �@�LayoutTransform 5-      �� 5.      $	 1.5Q�6!   50       51   
   P� 52       �@J�IsMouseOver	 . . �53      ��  � �� �#bdbdbd6/   54      56      �� 59      "  ��6   6)   �� 5<      "  ��6   8    5>   
   P� 5?       �@J�IsMouseOver	 . . �5@      ��  � ��
 �  ��6/   �� 5A       � ��
 �   �6/   5B      5D      �� 5u      "  ��6   8   .�5v   
   ��  � ��
 ��  �6'   �� 5w   
    � �� �#bdbdbd6'   �� 5x   
    � ��$ 0q�6,   �� 5y   
    � ��$ Cambria)�6'   �� 5z   
    �@�Cursor$
 Hand��6#   �� 5{   
    � �� 5|      �� 5}      " ��6"   .R�5~      �� $
 border��6   $ 10��5      #��z��5�      #��z��5�      #��z��5�       . ._�5�      �� #��z��6$   |�.  #��z��5�   $   #��z��5�   $   # z 5�   $   #��z��5�   $   5�       5�      :� 5�      $ 
MouseEnter��6'   .[�5�      �� .��5�   "   �� .��5�   &   �� $  White X�65   $ 0:0:0.3D�6B   $ Foreground.Color�6V   �� 5�   &   $ #5e6d73X�65   $ 0:0:0.3D�6B   $ border��6U   $ Background.Color�6u   5�   #   5�      5�      :� 5�      $ 
MouseLeave��6'   .[�5�      �� .��5�   "   �� .��5�   &   �� $ #425f6dX�65   $ 0:0:0.1D�6B   $ Foreground.Color�6V   �� 5�   &   $ TransparentX�65   $ 0:0:0.3D�6F   $ border��6Y   $ Background.Color�6y   5�   #   5�      5�      5�      5�      5�      5�      