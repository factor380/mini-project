﻿#pragma checksum "..\..\..\Contract\ContractWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8D486398A0FC7C0CF147DFAB0B3DBBAAF81C1927"
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
        
        
        #line 48 "..\..\..\Contract\ContractWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ContractDetails;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Contract\ContractWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox activeContractCheckBox;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Contract\ContractWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox childIdComboBox;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Contract\ContractWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox horMCheckBox;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Contract\ContractWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox metCheckBox;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\Contract\ContractWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox idTextBox;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\Contract\ContractWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox nannyIdComboBox;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\Contract\ContractWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker startDateDatePicker;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Contract\ContractWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker endDateDatePicker;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\Contract\ContractWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox payHoursTextBox;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\Contract\ContractWindow.xaml"
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
            System.Uri resourceLocater = new System.Uri("/UL;component/contract/contractwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Contract\ContractWindow.xaml"
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
            
            #line 25 "..\..\..\Contract\ContractWindow.xaml"
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
            this.childIdComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 68 "..\..\..\Contract\ContractWindow.xaml"
            this.childIdComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.childIdComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.horMCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.metCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.idTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.nannyIdComboBox = ((System.Windows.Controls.ComboBox)(target));
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

