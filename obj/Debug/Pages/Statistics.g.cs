﻿#pragma checksum "..\..\..\Pages\Statistics.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "933166330E2B7809360FEC05357916F7"
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


namespace SharepointHelper.Pages {
    
    
    /// <summary>
    /// Statistics
    /// </summary>
    public partial class Statistics : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\Pages\Statistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblItemsLastUpdateDate;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\Statistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGenerateItemCount;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Pages\Statistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOpenItemCount;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Pages\Statistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblWordsLastUpdate;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Pages\Statistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGenerateWordsCount;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pages\Statistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOpenWordsCount;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Pages\Statistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid itemCountGrid;
        
        #line default
        #line hidden
        
        
        #line 159 "..\..\..\Pages\Statistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid resultGrid;
        
        #line default
        #line hidden
        
        
        #line 263 "..\..\..\Pages\Statistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grdCreateExcel;
        
        #line default
        #line hidden
        
        
        #line 275 "..\..\..\Pages\Statistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblInclude;
        
        #line default
        #line hidden
        
        
        #line 276 "..\..\..\Pages\Statistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRowCount;
        
        #line default
        #line hidden
        
        
        #line 277 "..\..\..\Pages\Statistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblRowCount;
        
        #line default
        #line hidden
        
        
        #line 278 "..\..\..\Pages\Statistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCreateExcel;
        
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
            System.Uri resourceLocater = new System.Uri("/SharepointHelper;component/pages/statistics.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Statistics.xaml"
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
            
            #line 7 "..\..\..\Pages\Statistics.xaml"
            ((SharepointHelper.Pages.Statistics)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblItemsLastUpdateDate = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.btnGenerateItemCount = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Pages\Statistics.xaml"
            this.btnGenerateItemCount.Click += new System.Windows.RoutedEventHandler(this.btnGenerateItemCount_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnOpenItemCount = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Pages\Statistics.xaml"
            this.btnOpenItemCount.Click += new System.Windows.RoutedEventHandler(this.btnOpenItemCount_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lblWordsLastUpdate = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.btnGenerateWordsCount = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Pages\Statistics.xaml"
            this.btnGenerateWordsCount.Click += new System.Windows.RoutedEventHandler(this.btnGenerateWordsCount_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnOpenWordsCount = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\Pages\Statistics.xaml"
            this.btnOpenWordsCount.Click += new System.Windows.RoutedEventHandler(this.btnOpenWordsCount_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.itemCountGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            this.resultGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 10:
            this.grdCreateExcel = ((System.Windows.Controls.Grid)(target));
            return;
            case 11:
            this.lblInclude = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            this.txtRowCount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.lblRowCount = ((System.Windows.Controls.Label)(target));
            return;
            case 14:
            this.btnCreateExcel = ((System.Windows.Controls.Button)(target));
            
            #line 278 "..\..\..\Pages\Statistics.xaml"
            this.btnCreateExcel.Click += new System.Windows.RoutedEventHandler(this.btnCreateExcel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

