using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class TherapyController
    {
        Service.TherapyService therapyService = new Service.TherapyService();

        public ObservableCollection<Therapy> ViewTherapies(int patientId)
        {
            return therapyService.ViewTherapies(patientId);
        }

        public Boolean RemoveTherapy(Therapy therapy)
        {
            return therapyService.RemoveTherapy(therapy);
        }

        public Boolean AddTherapy(Therapy therapy)
        {
            return therapyService.AddTherapy(therapy);
        }
    }
}
