using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Vize.Models;

namespace Vize.Views
{
    /// <summary>
    /// CvListPage.xaml etkileşim mantığı
    /// </summary>
    public partial class CvListPage : Page
    {
        public CvListPage()
        {
            InitializeComponent();
            LbCvBilgiler.ItemsSource = Data.Cvs;
            LbCvAkademikBilgiler.ItemsSource = Data.Cvs;
            LbCvTecrubeBilgiler.ItemsSource = Data.Cvs;
        }

        private void TbCvAra_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void Lb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        
        }
        private void MiDuzenle(object sender, RoutedEventArgs e)
        {

        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
        private void MiSil(object sender, RoutedEventArgs e)
        {
        }
    }
}
