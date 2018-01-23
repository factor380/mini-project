﻿#pragma checksum "..\..\..\Contract\ContractWindow.xaml.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9FE32CC9B880AE01AF07527096D1953A041D248A"
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
    /// AddContractWindow
    /// </summary>
    public partial class AddContractWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\..\Contract\ContractWindow.xaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ContractDetails;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Contract\ContractWindow.xaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox activeContractCheckBox;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Contract\ContractWindow.xaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox childIdTextBox;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\Contract\ContractWindow.xaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox horMCheckBox;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\Contract\ContractWindow.xaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox metCheckBox;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\Contract\ContractWindow.xaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox motherIdTextBox;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\Contract\ContractWindow.xaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nannyIdTextBox;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\Contract\ContractWindow.xaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker startDateDatePicker;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\Contract\ContractWindow.xaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker endDateDatePicker;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\Contract\ContractWindow.xaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox payHoursTextBox;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\Contract\ContractWindow.xaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox payMonthTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/UL;component/contract/contractwindow.xaml.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Contract\ContractWindow.xaml.xaml"
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
            
            #line 24 "..\..\..\Contract\ContractWindow.xaml.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ContractDetails = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.activeContractCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 4:
            this.childIdTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.horMCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.metCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.motherIdTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.nannyIdTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.startDateDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 10:
            this.endDateDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 11:
            this.payHoursTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.payMonthTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
