using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class TherapyService
    {
        Repository.TherapyRepository therapyRepository = new Repository.TherapyRepository();

        public ObservableCollection<Therapy> ViewTherapies(int patientId)
        {
            return therapyRepository.ViewTherapies(patientId);
        }
        public Boolean RemoveTherapy(Therapy therapy)
        {
            return therapyRepository.RemoveTherapy(therapy);
        }
        public Boolean AddTherapy(Therapy therapy)
        {
            return therapyRepository.AddTherapy(therapy);
        }
    }
}
