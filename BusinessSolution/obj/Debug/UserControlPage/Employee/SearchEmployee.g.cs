﻿#pragma checksum "..\..\..\..\UserControlPage\Employee\SearchEmployee.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "610239B56FC3C522A32554F0087D6E75C84EFF09180AD77A2342C22388090097"
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
    /// SearchEmployee
    /// </summary>
    public partial class SearchEmployee : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\UserControlPage\Employee\SearchEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid AddEmployeePage;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\UserControlPage\Employee\SearchEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchEmployeeButton;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\UserControlPage\Employee\SearchEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HomeButton;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\UserControlPage\Employee\SearchEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FirstName;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\UserControlPage\Employee\SearchEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LastName;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\UserControlPage\Employee\SearchEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ConfirmationMessage;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\UserControlPage\Employee\SearchEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel StackPanelCategory;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\UserControlPage\Employee\SearchEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridEmployee;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\UserControlPage\Employee\SearchEmployee.xaml"
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
            System.Uri resourceLocater = new System.Uri("/BusinessSolution;component/usercontrolpage/employee/searchemployee.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UserControlPage\Employee\SearchEmployee.xaml"
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
            
            #line 20 "..\..\..\..\UserControlPage\Employee\SearchEmployee.xaml"
            this.SearchEmployeeButton.Click += new System.Windows.RoutedEventHandler(this.SearchEmployeeButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.HomeButton = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\UserControlPage\Employee\SearchEmployee.xaml"
            this.HomeButton.Click += new System.Windows.RoutedEventHandler(this.HomeButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.FirstName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.LastName = ((System.Windows.Controls.TextBox)(target));
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
            
            #line 33 "..\..\..\..\UserControlPage\Employee\SearchEmployee.xaml"
            this.CancelButton.Click += new System.Windows.RoutedEventHandler(this.CancelButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

