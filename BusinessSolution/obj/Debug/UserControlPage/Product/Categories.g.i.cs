﻿#pragma checksum "..\..\..\..\UserControlPage\Product\Categories.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6AD68A6ED1CB959EE54FC9878B47C6B104AD507E89A658A3B19F554A607F8B64"
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
    /// Categories
    /// </summary>
    public partial class Categories : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\UserControlPage\Product\Categories.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid AddEmployeePage;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\UserControlPage\Product\Categories.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\UserControlPage\Product\Categories.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel StackPanelCategory;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\UserControlPage\Product\Categories.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridCategory;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\UserControlPage\Product\Categories.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowAllCategoryButton;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\UserControlPage\Product\Categories.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateButton;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\UserControlPage\Product\Categories.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExportExcelButton;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\UserControlPage\Product\Categories.xaml"
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
            System.Uri resourceLocater = new System.Uri("/BusinessSolution;component/usercontrolpage/product/categories.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UserControlPage\Product\Categories.xaml"
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
            this.StackPanelCategory = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.DataGridCategory = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.ShowAllCategoryButton = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\..\UserControlPage\Product\Categories.xaml"
            this.ShowAllCategoryButton.Click += new System.Windows.RoutedEventHandler(this.ShowAllCategoryButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.UpdateButton = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\..\UserControlPage\Product\Categories.xaml"
            this.UpdateButton.Click += new System.Windows.RoutedEventHandler(this.UpdateButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ExportExcelButton = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\..\UserControlPage\Product\Categories.xaml"
            this.ExportExcelButton.Click += new System.Windows.RoutedEventHandler(this.ExportExcelButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\..\UserControlPage\Product\Categories.xaml"
            this.CancelButton.Click += new System.Windows.RoutedEventHandler(this.CancelButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

