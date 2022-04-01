﻿#pragma checksum "..\..\..\..\UserControlPage\Employee\RemoveEmployee.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BFF20063E07BA0F06BA0170319509BF46599FA87F95B89B96DC7F7938E60B612"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BusinessSolution;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace BusinessSolution {
    
    
    /// <summary>
    /// RemoveEmployee
    /// </summary>
    public partial class RemoveEmployee : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\UserControlPage\Employee\RemoveEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid AddEmployeePage;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\UserControlPage\Employee\RemoveEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchEmployeeButton;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\UserControlPage\Employee\RemoveEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteEmployeeButton;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\UserControlPage\Employee\RemoveEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmployeeLoginId;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\UserControlPage\Employee\RemoveEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon EmployeeLoginIdMissing;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\UserControlPage\Employee\RemoveEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ConfirmationMessage;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\UserControlPage\Employee\RemoveEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel StackPanelCategory;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\UserControlPage\Employee\RemoveEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridEmployee;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\UserControlPage\Employee\RemoveEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BusinessSolution;component/usercontrolpage/employee/removeemployee.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UserControlPage\Employee\RemoveEmployee.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.AddEmployeePage = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.SearchEmployeeButton = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\UserControlPage\Employee\RemoveEmployee.xaml"
            this.SearchEmployeeButton.Click += new System.Windows.RoutedEventHandler(this.SearchEmployeeButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DeleteEmployeeButton = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\UserControlPage\Employee\RemoveEmployee.xaml"
            this.DeleteEmployeeButton.Click += new System.Windows.RoutedEventHandler(this.DeleteEmployeeButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.EmployeeLoginId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.EmployeeLoginIdMissing = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            case 6:
            this.ConfirmationMessage = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.StackPanelCategory = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            this.DataGridEmployee = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            this.CancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\UserControlPage\Employee\RemoveEmployee.xaml"
            this.CancelButton.Click += new System.Windows.RoutedEventHandler(this.CancelButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
