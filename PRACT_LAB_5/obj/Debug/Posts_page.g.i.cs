﻿#pragma checksum "..\..\Posts_page.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C780825F5561F8220D9AB2D3D35996B80E56EC3D7CC1BD918FC724F127812E26"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PRACT_LAB_5;
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


namespace PRACT_LAB_5 {
    
    
    /// <summary>
    /// Posts_page
    /// </summary>
    public partial class Posts_page : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\Posts_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid table_grid;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Posts_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox post_name;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Posts_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox post_salary;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Posts_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Alt_but;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Posts_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add_but;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Posts_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Del_bat;
        
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
            System.Uri resourceLocater = new System.Uri("/PRACT_LAB_5;component/posts_page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Posts_page.xaml"
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
            this.table_grid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 16 "..\..\Posts_page.xaml"
            this.table_grid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.table_grid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.post_name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.post_salary = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Alt_but = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\Posts_page.xaml"
            this.Alt_but.Click += new System.Windows.RoutedEventHandler(this.Alt_but_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Add_but = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\Posts_page.xaml"
            this.Add_but.Click += new System.Windows.RoutedEventHandler(this.Add_but_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Del_bat = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\Posts_page.xaml"
            this.Del_bat.Click += new System.Windows.RoutedEventHandler(this.Del_bat_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

