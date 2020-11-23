using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class MedicationController
    {
        Service.MedicationService medicationService = new Service.MedicationService();

        public ObservableCollection<Medication> ViewMedicationList()
        {
            ObservableCollection<Medication> medList = medicationService.ViewMedicationList();
            return medList;
        }

        public Medication ViewMedication(String medName)
        {
            Medication medication = medicationService.ViewMedication(medName);
            return medication;
        }

        public Boolean ApproveMedication(int medId)
        {
            Boolean isApproved = medicationService.ApproveMedication(medId);
            return isApproved;
        }
    }
}
