﻿#pragma checksum "..\..\..\AddClassroom.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78A26588ED02AE3E188ABD1FF4147471C6BB2B58"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
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
using WpfApp;


namespace WpfApp {
    
    
    /// <summary>
    /// AddClassroom
    /// </summary>
    public partial class AddClassroom : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\AddClassroom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox numberText;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\AddClassroom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox capacityText;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\AddClassroom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addSchedule;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\AddClassroom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel scheduleList;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\AddClassroom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid scheduleStamp;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\AddClassroom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox schtex;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\AddClassroom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sendBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp;component/addclassroom.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddClassroom.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 16 "..\..\..\AddClassroom.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.MoveWindow);
            
            #line default
            #line hidden
            return;
            case 2:
            this.numberText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.capacityText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.addSchedule = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\AddClassroom.xaml"
            this.addSchedule.Click += new System.Windows.RoutedEventHandler(this.AddTimeStamp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.scheduleList = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.scheduleStamp = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.schtex = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.sendBtn = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\..\AddClassroom.xaml"
            this.sendBtn.Click += new System.Windows.RoutedEventHandler(this.Send);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 84 "..\..\..\AddClassroom.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Close);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

