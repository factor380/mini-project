﻿#pragma checksum "..\..\..\Mother\print_all_mother.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "75AE62ACC3A5F8A4980D8AA582B92C81"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BE;
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
using UL;


namespace UL {
    
    
    /// <summary>
    /// print_all_mother
    /// </summary>
    public partial class print_all_mother : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Mother\print_all_mother.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView motherListView;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Mother\print_all_mother.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn addressColumn;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Mother\print_all_mother.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn addressAroundColumn;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Mother\print_all_mother.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn idColumn;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Mother\print_all_mother.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn lastNameColumn;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Mother\print_all_mother.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn nameColumn;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Mother\print_all_mother.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn phoneNumColumn;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Mother\print_all_mother.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn remarksColumn;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Mother\print_all_mother.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn daysAndHoursColumn;
        
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
            System.Uri resourceLocater = new System.Uri("/UL;component/mother/print_all_mother.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Mother\print_all_mother.xaml"
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
            
            #line 9 "..\..\..\Mother\print_all_mother.xaml"
            ((UL.print_all_mother)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.motherListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.addressColumn = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 4:
            this.addressAroundColumn = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 5:
            this.idColumn = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 6:
            this.lastNameColumn = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 7:
            this.nameColumn = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 8:
            this.phoneNumColumn = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 9:
            this.remarksColumn = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 10:
            this.daysAndHoursColumn = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
