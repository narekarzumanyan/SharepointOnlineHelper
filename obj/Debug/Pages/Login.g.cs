﻿#pragma checksum "..\..\..\Pages\Login.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9A3083A5AB62F378028385DE14BC49F9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
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


namespace SharepointHelper {
    
    
    /// <summary>
    /// Login
    /// </summary>
    public partial class Login : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\Pages\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SharepointHelper.Login LoginWindow;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Pages\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUserName;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Pages\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtPassword;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Pages\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogin;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Pages\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox siteNameComboBox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Pages\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox siteURLComboBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Pages\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton siteNameRadioButton;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Pages\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton siteURLRadioButton;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox rememberCheckBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button forgetLinkLabel;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Pages\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label successNotificationLabel;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label errorNotificationLabel;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Pages\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAbout;
        
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
            System.Uri resourceLocater = new System.Uri("/SharepointHelper;component/pages/login.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Login.xaml"
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
            this.LoginWindow = ((SharepointHelper.Login)(target));
            
            #line 7 "..\..\..\Pages\Login.xaml"
            this.LoginWindow.Closing += new System.ComponentModel.CancelEventHandler(this.LoginWindow_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtUserName = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\..\Pages\Login.xaml"
            this.txtUserName.GotFocus += new System.Windows.RoutedEventHandler(this.TxtUserName_GotFocus);
            
            #line default
            #line hidden
            
            #line 16 "..\..\..\Pages\Login.xaml"
            this.txtUserName.LostFocus += new System.Windows.RoutedEventHandler(this.TxtUserName_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.btnLogin = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Pages\Login.xaml"
            this.btnLogin.Click += new System.Windows.RoutedEventHandler(this.BtnLogin_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.siteNameComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 19 "..\..\..\Pages\Login.xaml"
            this.siteNameComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SiteNameComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.siteURLComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 20 "..\..\..\Pages\Login.xaml"
            this.siteURLComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SiteURLComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.siteNameRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 21 "..\..\..\Pages\Login.xaml"
            this.siteNameRadioButton.Checked += new System.Windows.RoutedEventHandler(this.SiteNameRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.siteURLRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 22 "..\..\..\Pages\Login.xaml"
            this.siteURLRadioButton.Checked += new System.Windows.RoutedEventHandler(this.SiteNameRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.rememberCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 10:
            this.forgetLinkLabel = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Pages\Login.xaml"
            this.forgetLinkLabel.Click += new System.Windows.RoutedEventHandler(this.ForgetLinkLabel_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.successNotificationLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            this.errorNotificationLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 13:
            this.btnAbout = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Pages\Login.xaml"
            this.btnAbout.Click += new System.Windows.RoutedEventHandler(this.btnAbout_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

