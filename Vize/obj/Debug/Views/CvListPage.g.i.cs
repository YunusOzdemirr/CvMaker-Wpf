#pragma checksum "..\..\..\Views\CvListPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E419DBFCA41B6CDA271B7DF27A96E220E0885BF31BE080B9D765BD3A11C11D3E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
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
using Vize.Views;


namespace Vize.Views {
    
    
    /// <summary>
    /// CvListPage
    /// </summary>
    public partial class CvListPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Views\CvListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbCvAra;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Views\CvListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox LbCvBilgiler;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\Views\CvListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbAkademikAra;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\Views\CvListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox LbCvAkademikBilgiler;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\Views\CvListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbTecrubeAra;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\Views\CvListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox LbCvTecrubeBilgiler;
        
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
            System.Uri resourceLocater = new System.Uri("/Vize;component/views/cvlistpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\CvListPage.xaml"
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
            this.TbCvAra = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\..\Views\CvListPage.xaml"
            this.TbCvAra.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TbCvAra_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LbCvBilgiler = ((System.Windows.Controls.ListBox)(target));
            
            #line 18 "..\..\..\Views\CvListPage.xaml"
            this.LbCvBilgiler.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Lb_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 68 "..\..\..\Views\CvListPage.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MiDuzenle);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 70 "..\..\..\Views\CvListPage.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MiSil);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TbAkademikAra = ((System.Windows.Controls.TextBox)(target));
            
            #line 75 "..\..\..\Views\CvListPage.xaml"
            this.TbAkademikAra.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TbCvAra_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.LbCvAkademikBilgiler = ((System.Windows.Controls.ListBox)(target));
            
            #line 76 "..\..\..\Views\CvListPage.xaml"
            this.LbCvAkademikBilgiler.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Lb_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 105 "..\..\..\Views\CvListPage.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MiDuzenle);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 107 "..\..\..\Views\CvListPage.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MiSil);
            
            #line default
            #line hidden
            return;
            case 9:
            this.TbTecrubeAra = ((System.Windows.Controls.TextBox)(target));
            
            #line 112 "..\..\..\Views\CvListPage.xaml"
            this.TbTecrubeAra.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TbCvAra_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.LbCvTecrubeBilgiler = ((System.Windows.Controls.ListBox)(target));
            
            #line 113 "..\..\..\Views\CvListPage.xaml"
            this.LbCvTecrubeBilgiler.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Lb_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 142 "..\..\..\Views\CvListPage.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MiDuzenle);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 144 "..\..\..\Views\CvListPage.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MiSil);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

