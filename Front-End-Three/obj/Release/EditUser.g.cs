﻿#pragma checksum "..\..\EditUser.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A24136DDB94C54436A70CB8D8C5A0701F98B7BE442E616ADB853C2C6A2F31889"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Front_End_Three;
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


namespace Front_End_Three {
    
    
    /// <summary>
    /// EditUser
    /// </summary>
    public partial class EditUser : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\EditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LoginInput;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\EditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image UserImage;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\EditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UserLogin;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\EditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock UserStatus;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\EditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock UserLastOnline;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\EditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LeftArrow;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\EditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RightArrow;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\EditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Submit;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\EditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu MainMenuFind;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\EditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem TopMenuItem;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\EditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem FindByLogin;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\EditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ShowAll;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\EditUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GoBack;
        
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
            System.Uri resourceLocater = new System.Uri("/Front-End-Three;component/edituser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EditUser.xaml"
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
            this.LoginInput = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\EditUser.xaml"
            this.LoginInput.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.DataInput_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 29 "..\..\EditUser.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.FindUser_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.UserImage = ((System.Windows.Controls.Image)(target));
            
            #line 41 "..\..\EditUser.xaml"
            this.UserImage.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.UserImage_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.UserLogin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.UserStatus = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.UserLastOnline = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.LeftArrow = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\EditUser.xaml"
            this.LeftArrow.Click += new System.Windows.RoutedEventHandler(this.LeftArrow_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.RightArrow = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\EditUser.xaml"
            this.RightArrow.Click += new System.Windows.RoutedEventHandler(this.RightArrow_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Submit = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\EditUser.xaml"
            this.Submit.Click += new System.Windows.RoutedEventHandler(this.Submit_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 71 "..\..\EditUser.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveUser_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.MainMenuFind = ((System.Windows.Controls.Menu)(target));
            return;
            case 12:
            this.TopMenuItem = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 13:
            this.FindByLogin = ((System.Windows.Controls.MenuItem)(target));
            
            #line 79 "..\..\EditUser.xaml"
            this.FindByLogin.Click += new System.Windows.RoutedEventHandler(this.FindByLogin_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.ShowAll = ((System.Windows.Controls.MenuItem)(target));
            
            #line 82 "..\..\EditUser.xaml"
            this.ShowAll.Click += new System.Windows.RoutedEventHandler(this.ShowAll_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.GoBack = ((System.Windows.Controls.Button)(target));
            
            #line 88 "..\..\EditUser.xaml"
            this.GoBack.Click += new System.Windows.RoutedEventHandler(this.GoBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

