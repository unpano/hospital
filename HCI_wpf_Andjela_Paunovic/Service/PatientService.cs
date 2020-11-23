using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class PatientService
    {
        PatientRepository patientRepository = new PatientRepository();

        public Patient ViewPatientProfile(int patientId)
        {
            return patientRepository.ViewPatientProfile(patientId);
        }
        public Boolean NoteAbsence(int patientId)
        {
            return patientRepository.NoteAbsence(patientId);
        }
    }
}
