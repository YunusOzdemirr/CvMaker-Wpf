using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vize.Models
{
    public static class Data
    {
        public static ObservableCollection<Cv> Cvs = new ObservableCollection<Cv>();
        public static ObservableCollection<Job> Jobs = new ObservableCollection<Job>();
        public static ObservableCollection<Gender> Genders = new ObservableCollection<Gender>();
        public static ObservableCollection<Nationality> Nationalities = new ObservableCollection<Nationality>();

        static Data()
        {
            #region Gender
            Genders.Add(new Gender()
            {
                Name = "Erkek"
            });
            Genders.Add(new Gender()
            {
                Name = "Kadın"
            });
            #endregion
            #region Nationality
            Nationalities.Add(new Nationality()
            {
                Name = "Asian"
            });
            Nationalities.Add(new Nationality()
            {
                Name = "Turkish"
            });
            Nationalities.Add(new Nationality()
            {
                Name = "Chinese"
            });
            Nationalities.Add(new Nationality()
            {
                Name = "American"
            });
            Nationalities.Add(new Nationality()
            {
                Name = "British"
            });
            Nationalities.Add(new Nationality()
            {
                Name = "Russian"
            });
            #endregion
            #region Job
            Jobs.Add(new Job()
            {
                JobName = "Doktor"
            });
            Jobs.Add(new Job()
            {
                JobName = "Mühendis"
            });
            Jobs.Add(new Job()
            {
                JobName = "Hemşire"
            });
            Jobs.Add(new Job()
            {
                JobName = "Polis"
            });
            Jobs.Add(new Job()
            {
                JobName = "Pilot"
            });
            Jobs.Add(new Job()
            {
                JobName = "Asker"
            });
            Jobs.Add(new Job()
            {
                JobName = "Emlak Danışmanı"
            });
            #endregion

            Cvs.Add(new Cv()
            {
                Id = 1,
                FirstName = "Yunus",
                LastName = "Özdemir",
                Age = 18,
                EMail = "yunusozdemir468@gmail.com",
                JobField = Jobs[1],
                Experience = "MakasApp",
                Gender = Genders[0],
                Hobbies = "Bisiklet Sürmek",
                Nationality = Nationalities[1],
                Number = "05554443322",
                School = "Profilo Meslek Lisesi",
                Skills = ".net, c#, Angular",
                Address = "İstanbul/Sarıyer",
                Grade = 71.80,
                Time="5 Ay",
                Description="Kaliteli Yazılımcıyım"
            });


        }
    }
}
