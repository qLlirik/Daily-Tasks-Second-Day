﻿#pragma checksum "..\..\..\Windows\AddRouteWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "47AE0D77E350CE1ADEDEE56610F9F293"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using SecondDay.Windows;
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


namespace SecondDay.Windows {
    
    
    /// <summary>
    /// AddRouteWindow
    /// </summary>
    public partial class AddRouteWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 15 "..\..\..\Windows\AddRouteWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxShip;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Windows\AddRouteWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpDepart;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Windows\AddRouteWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpArriv;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Windows\AddRouteWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxParty;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Windows\AddRouteWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvParties;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Windows\AddRouteWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxPorts;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\Windows\AddRouteWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvPorts;
        
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
            System.Uri resourceLocater = new System.Uri("/SecondDay;component/windows/addroutewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\AddRouteWindow.xaml"
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
            
            #line 10 "..\..\..\Windows\AddRouteWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.click_Back);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cbxShip = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.dpDepart = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.dpArriv = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.cbxParty = ((System.Windows.Controls.ComboBox)(target));
            
            #line 33 "..\..\..\Windows\AddRouteWindow.xaml"
            this.cbxParty.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.select_cbxParty);
            
            #line default
            #line hidden
            
            #line 33 "..\..\..\Windows\AddRouteWindow.xaml"
            this.cbxParty.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.click_cbxParties);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lvParties = ((System.Windows.Controls.ListView)(target));
            return;
            case 8:
            this.cbxPorts = ((System.Windows.Controls.ComboBox)(target));
            
            #line 90 "..\..\..\Windows\AddRouteWindow.xaml"
            this.cbxPorts.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.select_cbxPorts);
            
            #line default
            #line hidden
            
            #line 90 "..\..\..\Windows\AddRouteWindow.xaml"
            this.cbxPorts.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.click_cbxPorts);
            
            #line default
            #line hidden
            return;
            case 9:
            this.lvPorts = ((System.Windows.Controls.ListView)(target));
            return;
            case 11:
            
            #line 142 "..\..\..\Windows\AddRouteWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.click_AddRoute);
            
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
            case 7:
            
            #line 76 "..\..\..\Windows\AddRouteWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.click_Delete1);
            
            #line default
            #line hidden
            break;
            case 10:
            
            #line 132 "..\..\..\Windows\AddRouteWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.click_Delete2);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

