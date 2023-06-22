using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiCOM_Web_App_.db
{
    public class StudyTable
    {
        [Key]
        public string StudyInstanceUId { get; set; }

        public IList<SeriesTable> StudySeries { get; set; }

        public string PatientId { get; set; }

        [ForeignKey("PatientId")]
        public PatientTable Patient { get; set; }
    }
}
