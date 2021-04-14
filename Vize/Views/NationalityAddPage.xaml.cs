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
    /// NationalityAddPage.xaml etkileşim mantığı
    /// </summary>
    public partial class NationalityAddPage : Page
    {
        Nationality nationality;
        public NationalityAddPage()
        {
            InitializeComponent();
            BtnNationalitySave.Click += BtnNationalitySave_Click;
        }

        private void BtnNationalitySave_Click(object sender, RoutedEventArgs e)
        {
            if (nationality == null)
            {
                nationality = new Nationality();
                Data.Nationalities.Add(nationality);
            }
            nationality.Name = TxtNationalityName.Text;
            NavigationService.Source = new Uri($"Views/CvListPage.xaml", UriKind.Relative);
            //NavigationService.Content = new CvListPage(); böyle de gidiyor hiçbir fark yok 
        }
    }
}
