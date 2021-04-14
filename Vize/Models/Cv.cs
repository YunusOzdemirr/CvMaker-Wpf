using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Vize.Models
{
    public class Cv
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Number { get; set; }
        public string EMail { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Time { get; set; }
        public string School { get; set; }
        public string Skills { get; set; }
        public string Hobbies { get; set; }
        public string Experience { get; set; }
        public Double Grade { get; set; }
        public Nationality Nationality { get; set; }
        public Gender Gender { get; set; }
        public Job JobField { get; set; }

        //public List<Gender> Genders { get { return Data.Genders.Where(g => g.Name == this.Gender.Name).ToList(); } }
        //public List<Job> Jobs { get { return Data.Jobs.Where(g => g.JobName == this.JobField.JobName).ToList(); } }
        //public List<Nationality> Nationalities { get { return Data.Nationalities.Where(g => g.Name == this.Nationality.Name).ToList(); } }
        
    }
}
