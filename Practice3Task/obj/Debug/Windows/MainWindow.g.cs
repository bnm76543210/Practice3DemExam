﻿#pragma checksum "..\..\..\Windows\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E0DE4986B677256B145EC11990B38B867F07FE657AE4119E7122C32BCD6CDAA1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Practice3Task;
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


namespace Practice3Task {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 22 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Filtering;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Search;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Quantity;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView myList;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SortingBy;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddService;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NearestEntry;
        
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
            System.Uri resourceLocater = new System.Uri("/Practice3Task;component/windows/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\MainWindow.xaml"
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
            this.Filtering = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\..\Windows\MainWindow.xaml"
            this.Filtering.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FilteringComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Search = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\..\Windows\MainWindow.xaml"
            this.Search.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Search_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Quantity = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.myList = ((System.Windows.Controls.ListView)(target));
            return;
            case 8:
            this.SortingBy = ((System.Windows.Controls.ComboBox)(target));
            
            #line 93 "..\..\..\Windows\MainWindow.xaml"
            this.SortingBy.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SortingComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.AddService = ((System.Windows.Controls.Button)(target));
            
            #line 98 "..\..\..\Windows\MainWindow.xaml"
            this.AddService.Click += new System.Windows.RoutedEventHandler(this.AddService_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.NearestEntry = ((System.Windows.Controls.Button)(target));
            
            #line 105 "..\..\..\Windows\MainWindow.xaml"
            this.NearestEntry.Click += new System.Windows.RoutedEventHandler(this.NearestEntry_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 5:
            
            #line 58 "..\..\..\Windows\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClickChange);
            
            #line default
            #line hidden
            break;
            case 6:
            
            #line 65 "..\..\..\Windows\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClickRemove);
            
            #line default
            #line hidden
            break;
            case 7:
            
            #line 72 "..\..\..\Windows\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClickAddClientToService);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

