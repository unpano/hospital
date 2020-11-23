using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Therapy
    {
        int patientId;
        int dose;
        String medicationName;

        public int PatientId
        {
            get { return patientId; }
            set { patientId = value; }
        }
        public int Dose
        {
            get { return dose; }
            set { dose = value; }
        }
        public String MedicationName
        {
            get { return medicationName; }
            set { medicationName = value; }
        }
    }
}
