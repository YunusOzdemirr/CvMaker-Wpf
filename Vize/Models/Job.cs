using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vize.Models
{
    public class Job
    {
        public string JobName { get; set; }
        //Combobox'larda görüntülemek için override yapmak gerekiyor.
        public override string ToString()
        {
            return $"{JobName}";
        }
    }
}
