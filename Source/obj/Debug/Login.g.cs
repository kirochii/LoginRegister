﻿#pragma checksum "..\..\Login.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "68D6F77E407E66217D46FFD656318A6458E04A753E08A8E85E9E50A47C86023A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LoginRegister;
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


namespace LoginRegister {
    
    
    /// <summary>
    /// Login
    /// </summary>
    public partial class Login : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LoginRegister.Login window;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock register_txt;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border err_border;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock err_msg;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel grid_username;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox input_username;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox input_password;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border grid_password;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock password_placeholder;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button login_btn;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Main;
        
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
            System.Uri resourceLocater = new System.Uri("/LoginRegister;component/login.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Login.xaml"
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
            this.window = ((LoginRegister.Login)(target));
            
            #line 11 "..\..\Login.xaml"
            this.window.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.register_txt = ((System.Windows.Controls.TextBlock)(target));
            
            #line 27 "..\..\Login.xaml"
            this.register_txt.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.register_txt_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.err_border = ((System.Windows.Controls.Border)(target));
            return;
            case 4:
            this.err_msg = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.grid_username = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.input_username = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\Login.xaml"
            this.input_username.GotFocus += new System.Windows.RoutedEventHandler(this.input_username_GotFocus);
            
            #line default
            #line hidden
            
            #line 37 "..\..\Login.xaml"
            this.input_username.LostFocus += new System.Windows.RoutedEventHandler(this.input_username_LostFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.input_password = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 41 "..\..\Login.xaml"
            this.input_password.GotFocus += new System.Windows.RoutedEventHandler(this.input_password_GotFocus);
            
            #line default
            #line hidden
            
            #line 41 "..\..\Login.xaml"
            this.input_password.LostFocus += new System.Windows.RoutedEventHandler(this.input_password_LostFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            this.grid_password = ((System.Windows.Controls.Border)(target));
            return;
            case 9:
            this.password_placeholder = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.login_btn = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\Login.xaml"
            this.login_btn.Click += new System.Windows.RoutedEventHandler(this.login);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Main = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
