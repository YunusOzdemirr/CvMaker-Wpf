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
    public partial class JobAddPage : Page
    {
        Job selectedJob;
        public JobAddPage()
        {
            InitializeComponent();
            BtnJobSave.Click += BtnJobSave_Click;
        }

        //public JobEkle(Job sJob) : this()
        //{
        //    if (sJob != null)
        //    {
        //        selectedJob = sJob;
        //        TxtJobName.Text = sJob.JobName;
        //    }
        //}

        private void BtnJobSave_Click(object sender, RoutedEventArgs e)
        {
            if (selectedJob == null)
            {
                selectedJob = new Job();
                Data.Jobs.Add(selectedJob);
            }
            selectedJob.JobName = TxtJobName.Text;
            NavigationService.Source = new Uri($"Views/CvListPage.xaml", UriKind.Relative);
            //NavigationService.Content = new CvListPage(); böyle de gidiyor hiçbir fark yok 

        }
    }
}
