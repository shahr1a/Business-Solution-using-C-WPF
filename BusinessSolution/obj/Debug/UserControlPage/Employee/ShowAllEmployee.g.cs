﻿#pragma checksum "..\..\..\..\UserControlPage\Employee\ShowAllEmployee.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9A3D75591EA2DAE55360695C71B65F4CE9AF8C1965ED7C8F813FFB65F2C32E29"
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
    /// ShowAllEmployee
    /// </summary>
    public partial class ShowAllEmployee : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\UserControlPage\Employee\ShowAllEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid AddEmployeePage;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\UserControlPage\Employee\ShowAllEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\UserControlPage\Employee\ShowAllEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel StackPanelEmployee;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\UserControlPage\Employee\ShowAllEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridEmployee;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\UserControlPage\Employee\ShowAllEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowAllEmployeeButton;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\UserControlPage\Employee\ShowAllEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateButton;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\UserControlPage\Employee\ShowAllEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExportExcelButton;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\UserControlPage\Employee\ShowAllEmployee.xaml"
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
            System.Uri resourceLocater = new System.Uri("/BusinessSolution;component/usercontrolpage/employee/showallemployee.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UserControlPage\Employee\ShowAllEmployee.xaml"
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
            this.button = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.StackPanelEmployee = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.DataGridEmployee = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.ShowAllEmployeeButton = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\..\UserControlPage\Employee\ShowAllEmployee.xaml"
            this.ShowAllEmployeeButton.Click += new System.Windows.RoutedEventHandler(this.ShowAllEmployeeButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.UpdateButton = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\..\UserControlPage\Employee\ShowAllEmployee.xaml"
            this.UpdateButton.Click += new System.Windows.RoutedEventHandler(this.UpdateButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ExportExcelButton = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\..\UserControlPage\Employee\ShowAllEmployee.xaml"
            this.ExportExcelButton.Click += new System.Windows.RoutedEventHandler(this.ExportExcelButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\..\UserControlPage\Employee\ShowAllEmployee.xaml"
            this.CancelButton.Click += new System.Windows.RoutedEventHandler(this.CancelButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

