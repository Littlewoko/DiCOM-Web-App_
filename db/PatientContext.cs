using DiCOM_Web_App_.db;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiCOM_Web_App_
{
    public class PatientContext : DbContext
    {
        public DbSet<PatientTable> Patients { get; set; }
        public DbSet<StudyTable> Studies { get; set; }
        public DbSet<SeriesTable> Series { get; set; }
        public DbSet<ImageTable> Images { get; set; }
    }
}
