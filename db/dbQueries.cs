using DiCOM_Web_App_.db;
using DicomObjects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiCOM_Web_App_
{
    
    public static class dbQueries
    {
        // Should have broken out some of what is done here into seperate methods/ classes. 
        // Adding parent/ child relationship for example is redundantly done multiple times and could
        // have been a method call. 
        public static void digest(DicomImageCollection images)
        {
            

            // Unfortunately Does not work as intended. 
            // Only saves some of the data (Maybe single Dicom Image holds Multi
            // Ids at each level? This is not accounted for here obviously. 
            // From the DicomImages folder provided only two images stored in db
            // Do some share a SOPId and if so how to differentiate? unsure
            using (var db = new PatientContext())
            {
                
                var patientId = "";
                var studyInstanceUID = "";
                var seriesInstanceUID = "";
                var imageUID = "";
                
                // Iterate through all images currently received and attempt to
                // store to db
                foreach (DicomImage image in images)
                {
                    patientId = image.PatientID;
                    studyInstanceUID = image.StudyUID;
                    seriesInstanceUID = image.SeriesUID;
                    imageUID = image.SOPClass;


                    PatientTable patient;
                    patient = new PatientTable
                    {
                        PatientId = patientId,
                        PatientName = image.Name,
                        DOB = image.DateOfBirth,

                    };

                    // Probably a better way to compare keys? 
                    if (!db.Patients.Any(p => p.PatientId.Equals(patientId))) 
                    {        
                        db.Patients.Add(patient);
                        db.SaveChanges();
                    }

                    


                    StudyTable study;
                    study = new StudyTable
                    {
                        StudyInstanceUId = studyInstanceUID,
                        PatientId = patientId,
                    };



                    if (!db.Studies.Any(s => s.StudyInstanceUId.Equals(studyInstanceUID)))
                    {
                        
                        db.Patients.Attach(patient);
                        db.Studies.Add(study);
                        patient.PatientStudies.Add(study);
                        db.SaveChanges();
                    }

                    


                    SeriesTable series;
                    series = new SeriesTable
                    {
                        SeriesInstanceUId = seriesInstanceUID,
                        StudyInstanceUId = studyInstanceUID,
                    };

                    if (!db.Series.Any(s => s.SeriesInstanceUId.Equals(seriesInstanceUID)))
                    {
                        db.Studies.Attach(study);
                        db.Series.Add(series);
                        study.StudySeries.Add(series);
                        db.SaveChanges();
                    }

                    // Set filename to SopId, will cause problems if conflicting which seems 
                    // to be the case at present
                    var dir = Directory.GetCurrentDirectory();
                    var fileName = imageUID;
                    

                    ImageTable dicomImage;
                    dicomImage = new ImageTable
                    {
                        SOPInstanceUId = imageUID,
                        PatientId = patientId,
                        DicomImageFileName = fileName,
                        
                    };
                    Console.Write(imageUID);
                   
                    if (!db.Images.Any(s => s.SOPInstanceUId.Equals(imageUID) ))
                    {
                        image.Write(dir + @"\" + fileName);
                        db.Patients.Attach(patient);
                        db.Images.Add(dicomImage);
                        patient.PatientImages.Add(dicomImage);
                        db.SaveChanges();
                    }

                    

                    
                }
            }
        }
    }
}
