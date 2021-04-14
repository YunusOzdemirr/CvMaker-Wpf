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
    /// CvAddPage.xaml etkileşim mantığı
    /// </summary>
    public partial class CvAddPage : Page
    {
        Cv selectedCv;
        public CvAddPage()
        {
            InitializeComponent();
            CbGender.ItemsSource = Data.Genders;
            CbJob.ItemsSource = Data.Jobs;
            CbNationality.ItemsSource = Data.Nationalities;
            BtnCvSave.Click += BtnCvSave_Click;
        }

        private void BtnCvSave_Click(object sender, RoutedEventArgs e)
        {

            selectedCv = new Cv();
            Data.Cvs.Add(selectedCv);

            selectedCv.FirstName = TxtFirstName.Text;
            selectedCv.LastName = TxtLastName.Text;
            selectedCv.Age = int.Parse(TxtAge.Text);
            selectedCv.Number = TxtNumber.Text;
            selectedCv.EMail = TxtEmail.Text;
            selectedCv.Address = TxtAddress.Text;
            selectedCv.Description = TxtDescription.Text;
            selectedCv.School = TxtSchool.Text;
            selectedCv.Skills = TxtSkills.Text;
            selectedCv.Hobbies = TxtHobbies.Text;
            selectedCv.Experience = TxtExperience.Text;
            selectedCv.Time = TxtTime.Text;
            selectedCv.Grade = Convert.ToDouble(TxtGrade.Text);
            selectedCv.Nationality = (Nationality)CbNationality.SelectedItem;
            selectedCv.Gender = (Gender)CbGender.SelectedItem;
            selectedCv.JobField = (Job)CbJob.SelectedItem;

            NavigationService.Content = new CvListPage();
        }

        //public void CvEkle(Cv cvAdd) : this()
        //{
        //    if (cvAdd != null)
        //    {
        //        selectedCv = cvAdd;
        //        TxtFirstName.Text = cvAdd.FirstName;
        //        TxtLastName.Text = cvAdd.LastName;
        //        TxtAge.Text = cvAdd.Age.ToString();
        //        TxtNumber.Text = cvAdd.Number;
        //        TxtEmail.Text = cvAdd.EMail;
        //        TxtAddress.Text = cvAdd.Address;
        //        TxtDescription.Text = cvAdd.Description;
        //        TxtSchool.Text = cvAdd.School;
        //        TxtSkills.Text = cvAdd.Skills;
        //        TxtHobbies.Text = cvAdd.Hobbies;
        //        TxtExperience.Text = cvAdd.Experience;
        //        TxtGrade.Text = cvAdd.Grade.ToString();
        //        CbNationality.SelectedItem = cvAdd.Nationality;
        //        CbGender.SelectedItem = cvAdd.Gender;
        //        CbJob.SelectedItem = cvAdd.JobField;
        //    }

        //}
    }
}
