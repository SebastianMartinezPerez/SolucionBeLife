﻿#pragma checksum "..\..\AdmiCliente.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8D8E2269009433CEDDD6B990F357E9838DE4CEF2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
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
using WPF;


namespace WPF {
    
    
    /// <summary>
    /// AdmiCliente
    /// </summary>
    public partial class AdmiCliente : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\AdmiCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dg_AdmiCliente;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\AdmiCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Buscar;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\AdmiCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_agregar;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\AdmiCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Modificar;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\AdmiCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Eliminar;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\AdmiCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txb_Rut;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\AdmiCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Limpiar;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AdmiCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbx_FiltraActi;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\AdmiCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbx_FiltraTipo;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\AdmiCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_volver;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF;component/admicliente.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AdmiCliente.xaml"
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
            this.dg_AdmiCliente = ((System.Windows.Controls.DataGrid)(target));
            
            #line 13 "..\..\AdmiCliente.xaml"
            this.dg_AdmiCliente.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Dg_AdmiCliente_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_Buscar = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\AdmiCliente.xaml"
            this.btn_Buscar.Click += new System.Windows.RoutedEventHandler(this.Btn_Buscar_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_agregar = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\AdmiCliente.xaml"
            this.btn_agregar.Click += new System.Windows.RoutedEventHandler(this.Btn_agregar_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_Modificar = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\AdmiCliente.xaml"
            this.btn_Modificar.Click += new System.Windows.RoutedEventHandler(this.Btn_Modificar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_Eliminar = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\AdmiCliente.xaml"
            this.btn_Eliminar.Click += new System.Windows.RoutedEventHandler(this.Btn_Eliminar_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txb_Rut = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\AdmiCliente.xaml"
            this.txb_Rut.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Txb_Rut_TextChanged_1);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_Limpiar = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\AdmiCliente.xaml"
            this.btn_Limpiar.Click += new System.Windows.RoutedEventHandler(this.Btn_Limpiar_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cbx_FiltraActi = ((System.Windows.Controls.ComboBox)(target));
            
            #line 21 "..\..\AdmiCliente.xaml"
            this.cbx_FiltraActi.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Cbx_FiltraActi_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.cbx_FiltraTipo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\AdmiCliente.xaml"
            this.cbx_FiltraTipo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Cbx_FiltraTipo_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btn_volver = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\AdmiCliente.xaml"
            this.btn_volver.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

