﻿#pragma checksum "..\..\..\LoginScreen.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3EE9A4122CA6A8CED65CA50BA606AC58DADA9287"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ProiectCinema;
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


namespace ProiectCinema {
    
    
    /// <summary>
    /// LoginScreen
    /// </summary>
    public partial class LoginScreen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 57 "..\..\..\LoginScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Logo;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\LoginScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label UserLabel;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\LoginScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UserTxtBox;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\LoginScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label PassLabel;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\LoginScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PassTxtBox;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\LoginScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoginButton;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\LoginScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RegisterText;
        
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
            System.Uri resourceLocater = new System.Uri("/ProiectCinema;component/loginscreen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\LoginScreen.xaml"
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
            this.Logo = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.UserLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.UserTxtBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 60 "..\..\..\LoginScreen.xaml"
            this.UserTxtBox.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.OpCTxtBox_GotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 60 "..\..\..\LoginScreen.xaml"
            this.UserTxtBox.LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.OpCTxtBox_LostKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PassLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.PassTxtBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 63 "..\..\..\LoginScreen.xaml"
            this.PassTxtBox.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.OpCPassBox_GotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 63 "..\..\..\LoginScreen.xaml"
            this.PassTxtBox.LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.OpCPassBox_LostKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.LoginButton = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\..\LoginScreen.xaml"
            this.LoginButton.Click += new System.Windows.RoutedEventHandler(this.LoginButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.RegisterText = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\LoginScreen.xaml"
            this.RegisterText.Click += new System.Windows.RoutedEventHandler(this.RegisterText_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

