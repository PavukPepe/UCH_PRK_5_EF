﻿#pragma checksum "..\..\Kandidate_page.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6466B41695802836ADE374E493F5AF895AE060D2E6843D751CD3F900A286408F"
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
    /// Kandidate_page
    /// </summary>
    public partial class Kandidate_page : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\Kandidate_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid table_grid;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Kandidate_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox roles;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Kandidate_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Alt_but;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Kandidate_page.xaml"
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
            System.Uri resourceLocater = new System.Uri("/PRACT_LAB_5;component/kandidate_page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Kandidate_page.xaml"
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
            
            #line 16 "..\..\Kandidate_page.xaml"
            this.table_grid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.table_grid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.roles = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.Alt_but = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\Kandidate_page.xaml"
            this.Alt_but.Click += new System.Windows.RoutedEventHandler(this.Alt_but_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Del_bat = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\Kandidate_page.xaml"
            this.Del_bat.Click += new System.Windows.RoutedEventHandler(this.Del_bat_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

