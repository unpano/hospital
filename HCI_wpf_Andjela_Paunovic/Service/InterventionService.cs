using Model;
using Repository;
using System;
using System.Collections.ObjectModel;

namespace Service
{
   public class InterventionService
   {
        InterventionRepository interventionRepository = new InterventionRepository(); 

        public Intervention ScheduleIntervention(Intervention intervention)
        {
            Intervention scheduledIntervention = interventionRepository.AddIntervention(intervention);
            return scheduledIntervention;
        }
        public ObservableCollection<Intervention> ViewScheduledInterventions(int doctorId)
        {
            ObservableCollection<Intervention> interventions = interventionRepository.ViewScheduledInterventions(doctorId);
            return interventions;
        }
        public ObservableCollection<Intervention> ViewEarlierInterventions(int patientId)
        {
            ObservableCollection<Intervention> interventions = interventionRepository.ViewEarlierInterventions(patientId);
            return interventions;
        }
        public Intervention ViewIntervention(int interventionId)
        {
            Intervention intervention = interventionRepository.ViewIntervention(interventionId);
            return intervention;
        }
        public ObservableCollection<Intervention> ViewAllInterventions(int patientId)
        { 
            ObservableCollection<Intervention> interventions = interventionRepository.ViewScheduledInterventions(patientId);
            return interventions;
        }
        public int AddDescription(int patientId, String description)
        {
            return interventionRepository.AddDescription(patientId, description);
        }
    }
}