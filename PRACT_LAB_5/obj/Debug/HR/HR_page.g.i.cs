﻿#pragma checksum "..\..\..\HR\HR_page.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "359482FD55084BBC12EEB7AC8CF22A1F824096FD85632B0A33D0AD212D367C82"
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
    /// HR_page
    /// </summary>
    public partial class HR_page : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\HR\HR_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exit_but;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\HR\HR_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button candedats_but;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\HR\HR_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button role_but;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\HR\HR_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button employeers_but;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\HR\HR_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame teble_frame;
        
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
            System.Uri resourceLocater = new System.Uri("/PRACT_LAB_5;component/hr/hr_page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\HR\HR_page.xaml"
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
            this.exit_but = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\HR\HR_page.xaml"
            this.exit_but.Click += new System.Windows.RoutedEventHandler(this.exit_but_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.candedats_but = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\HR\HR_page.xaml"
            this.candedats_but.Click += new System.Windows.RoutedEventHandler(this.candedats_but_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.role_but = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\HR\HR_page.xaml"
            this.role_but.Click += new System.Windows.RoutedEventHandler(this.role_but_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.employeers_but = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\HR\HR_page.xaml"
            this.employeers_but.Click += new System.Windows.RoutedEventHandler(this.employeers_but_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.teble_frame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

