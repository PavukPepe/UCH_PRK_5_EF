﻿#pragma checksum "..\..\..\Customer\Orders_page.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ED71ED85270CA1A0213AEE735B4AE793D04099CEADB53BED4837D22D7069EA99"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PRACT_LAB_5.Customer;
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


namespace PRACT_LAB_5.Customer {
    
    
    /// <summary>
    /// Orders_page
    /// </summary>
    public partial class Orders_page : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Customer\Orders_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid table_grid;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Customer\Orders_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button get_but;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Customer\Orders_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancel_but;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Customer\Orders_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button check_but;
        
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
            System.Uri resourceLocater = new System.Uri("/PRACT_LAB_5;component/customer/orders_page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Customer\Orders_page.xaml"
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
            return;
            case 2:
            this.get_but = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Customer\Orders_page.xaml"
            this.get_but.Click += new System.Windows.RoutedEventHandler(this.get_but_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cancel_but = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Customer\Orders_page.xaml"
            this.cancel_but.Click += new System.Windows.RoutedEventHandler(this.cancel_but_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.check_but = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Customer\Orders_page.xaml"
            this.check_but.Click += new System.Windows.RoutedEventHandler(this.check_but_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

