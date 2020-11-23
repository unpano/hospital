using System;

namespace Model
{
    public class Patient : User
    {
        private String bloodType;
        private String allergies;
        private char gender;
        private String meritalStatus;
        private String job;
        private int absenceCount;

        public int AbsenceCount
        {
            get { return absenceCount; }
            set { absenceCount = value; }
        }
    }
}
