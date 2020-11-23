using System;

namespace Model
{
   public class Doctor : User
   {

        private Specialization specialization;
      
        public Specialization Specialization
        {
            get { return specialization; }
            set { specialization = value; }
        }

        public String Spec
        {
            get { return specialization.SpecName; }
            set { specialization.SpecName = value; }
        }
   }
}