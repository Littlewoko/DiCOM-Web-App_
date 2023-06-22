using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiCOM_Web_App_.db
{
    public class PatientTable
    {
        [Key]
        public string PatientId { get; set; }
        public string PatientName { get; set;}
        public DateTime DOB { get; set; }

        public IList<StudyTable> PatientStudies { get; set; }

        public IList<ImageTable> PatientImages { get; set; }
    }
}
