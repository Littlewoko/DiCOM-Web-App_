using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiCOM_Web_App_.db
{
    public class SeriesTable
    {
        [Key]
        public string SeriesInstanceUId { get; set; }

        public string StudyInstanceUId { get; set; }

        [ForeignKey("StudyInstanceUId")]
        public StudyTable Study { get; set; }   
    }
}
