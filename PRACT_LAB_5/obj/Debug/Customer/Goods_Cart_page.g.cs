﻿#pragma checksum "..\..\..\Customer\Goods_Cart_page.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D03E2AC8681E29A3176EC5A80952D4637304A616C53C2C2B3BEEF3FE4E18DDB7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PRACT_LAB_5.Properties;
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


namespace PRACT_LAB_5.Properties {
    
    
    /// <summary>
    /// Goods_Cart_page
    /// </summary>
    public partial class Goods_Cart_page : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\Customer\Goods_Cart_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button order_but;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Customer\Goods_Cart_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clear_cart_but;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Customer\Goods_Cart_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button add_good_but;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Customer\Goods_Cart_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button del_good_but;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Customer\Goods_Cart_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid goods_grid;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Customer\Goods_Cart_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid cart_grid;
        
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
            System.Uri resourceLocater = new System.Uri("/PRACT_LAB_5;component/customer/goods_cart_page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Customer\Goods_Cart_page.xaml"
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
            this.order_but = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Customer\Goods_Cart_page.xaml"
            this.order_but.Click += new System.Windows.RoutedEventHandler(this.order_but_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.clear_cart_but = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Customer\Goods_Cart_page.xaml"
            this.clear_cart_but.Click += new System.Windows.RoutedEventHandler(this.clear_cart_but_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.add_good_but = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Customer\Goods_Cart_page.xaml"
            this.add_good_but.Click += new System.Windows.RoutedEventHandler(this.add_good_but_Click_1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.del_good_but = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Customer\Goods_Cart_page.xaml"
            this.del_good_but.Click += new System.Windows.RoutedEventHandler(this.del_good_but_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.goods_grid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 31 "..\..\..\Customer\Goods_Cart_page.xaml"
            this.goods_grid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.goods_grid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cart_grid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

