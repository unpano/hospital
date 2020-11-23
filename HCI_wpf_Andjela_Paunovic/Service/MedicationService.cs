using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class MedicationService
    {
        Repository.MedicationRepository medicationRepository = new Repository.MedicationRepository();

        public ObservableCollection<Medication> ViewMedicationList()
        {
            ObservableCollection<Medication> medList = medicationRepository.ViewMedicationList();
            return medList;
        }

        public Medication ViewMedication(String medName)
        {
            Medication medication = medicationRepository.ViewMedication(medName);
            return medication;
        }
        public Boolean ApproveMedication(int medId)
        {
            Boolean isApproved = medicationRepository.ApproveMedication(medId);
            return isApproved;
        }
    }
}
