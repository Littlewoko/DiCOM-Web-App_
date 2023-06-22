using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DicomObjects;

namespace DiCOM_Web_App_.db
{
    public class ImageTable
    {
        [Key]
        public string SOPInstanceUId { get; set; }
        public string DicomImageFileName { get; set; }
        public string PatientId { get; set; }
        
        [ForeignKey("PatientId")]
        public virtual PatientTable Patient { get; set; }    
    }
}
