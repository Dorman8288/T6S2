#pragma checksum "..\..\..\LoginPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "783AF8EA8AD24C41343F7496217BF75751903A25"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using tamrin_6_2_final;


namespace tamrin_6_2_final {
    
    
    /// <summary>
    /// LoginPage
    /// </summary>
    public partial class LoginPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SellerNameTB;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SellerPassTB;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CustomerNameTB;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CustomerPassTB;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TeacherNameTB;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TeacherWorkplaceTB;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StudentNameTB;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StudentNumberTB;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.16.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/tamrin 6 2 final_b0yjtdir_wpftmp;component/loginpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\LoginPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.16.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.SellerNameTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.SellerPassTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            
            #line 37 "..\..\..\LoginPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SellerLoginClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CustomerNameTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.CustomerPassTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            
            #line 66 "..\..\..\LoginPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CustomerLoginClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TeacherNameTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.TeacherWorkplaceTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 95 "..\..\..\LoginPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.TeacherLoginClick);
            
            #line default
            #line hidden
            return;
            case 10:
            this.StudentNameTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.StudentNumberTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            
            #line 124 "..\..\..\LoginPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.StudentLoginClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

