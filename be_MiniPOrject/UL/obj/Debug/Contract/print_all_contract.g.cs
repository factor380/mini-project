﻿#pragma checksum "..\..\..\Contract\print_all_contract.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3CEFE25F06946F0CD6730FF2543A290DB11E5999"
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
    /// print_all_contract
    /// </summary>
    public partial class print_all_contract : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Contract\print_all_contract.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView contractListView;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Contract\print_all_contract.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn activeContractColumn;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Contract\print_all_contract.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn childIdColumn;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Contract\print_all_contract.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn contract_Num1Column;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Contract\print_all_contract.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn endDateColumn;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Contract\print_all_contract.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn horM1Column;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Contract\print_all_contract.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn metColumn;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Contract\print_all_contract.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn motherIdColumn;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Contract\print_all_contract.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn nannyIdColumn;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\Contract\print_all_contract.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn payHoursColumn;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Contract\print_all_contract.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn payMonthColumn;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\Contract\print_all_contract.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn startDateColumn;
        
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
            System.Uri resourceLocater = new System.Uri("/UL;component/contract/print_all_contract.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Contract\print_all_contract.xaml"
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
            
            #line 9 "..\..\..\Contract\print_all_contract.xaml"
            ((UL.print_all_contract)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.contractListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.activeContractColumn = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 4:
            this.childIdColumn = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 5:
            this.contract_Num1Column = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 6:
            this.endDateColumn = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 7:
            this.horM1Column = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 8:
            this.metColumn = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 9:
            this.motherIdColumn = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 10:
            this.nannyIdColumn = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 11:
            this.payHoursColumn = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 12:
            this.payMonthColumn = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 13:
            this.startDateColumn = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

