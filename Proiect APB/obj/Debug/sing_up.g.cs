#pragma checksum "..\..\sing_up.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E7B83083F1AC34F0EAD7BA2F7B46B94113D4B80CA1F77D9939AA8769E6C5B845"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Proiect_APB;
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


namespace Proiect_APB {
    
    
    /// <summary>
    /// sign_up
    /// </summary>
    public partial class sign_up : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 51 "..\..\sing_up.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameTxt;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\sing_up.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox account_typeTxt;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\sing_up.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox adressTxt;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\sing_up.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox stateTxt;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\sing_up.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox cityTxt;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\sing_up.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox pincodeTxt;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\sing_up.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox emailTxt;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\sing_up.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox passwordTxt;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\sing_up.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox cnpTxt;
        
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
            System.Uri resourceLocater = new System.Uri("/Proiect APB;component/sing_up.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\sing_up.xaml"
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
            
            #line 14 "..\..\sing_up.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 27 "..\..\sing_up.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.nameTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.account_typeTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.adressTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.stateTxt = ((System.Windows.Controls.TextBox)(target));
            
            #line 56 "..\..\sing_up.xaml"
            this.stateTxt.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.stateTxt_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cityTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.pincodeTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.emailTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.passwordTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.cnpTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

