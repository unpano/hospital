using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class PatientController
    {
        Service.PatientService patientService = new Service.PatientService();
        public Patient ViewPatientProfile(int patientId)
        {
            return patientService.ViewPatientProfile(patientId);
        }
        public Boolean NoteAbsence(int patientId)
        {
            return patientService.NoteAbsence(patientId);
        }
    }
}
