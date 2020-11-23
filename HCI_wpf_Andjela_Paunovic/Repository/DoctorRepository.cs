using Model;
using Syncfusion.Pdf;
using System;
using System.IO;

namespace Repository
{
   public class DoctorRepository
   {
        public Doctor findOneByUsernameAndPassword(String username, String password)
        {
            String [] foundRecord;
            String [] lines = File.ReadAllLines("C:/Users/Andjela Paunovic/Desktop/HCI_wpf_Andjela_Paunovic/HCI_wpf_Andjela_Paunovic/CSV/doctors.csv");
            
            for (int i = 1; i < lines.Length; i++)
            {
                string[] fields = lines[i].Split(',');
                if (fields[3].Equals(username) && fields[4].Equals(password))
                {
                    foundRecord = lines[i].Split(',');
                    Doctor doctor = mapDoctorData(foundRecord);
                    return doctor;
                }
            }
            return null;

        }

        public Doctor mapDoctorData(String [] foundRecord)
        {
            Doctor doctor = new Doctor();
            doctor.Specialization = new Specialization();

            doctor.ID = Convert.ToInt32(foundRecord[0]);
            doctor.FirstName = foundRecord[1];
            doctor.LastName = foundRecord[2];
            doctor.Username = foundRecord[3];
            doctor.Password = foundRecord[4];
            doctor.Email = foundRecord[5];
            doctor.JMBG = Convert.ToInt64(foundRecord[6]);
            doctor.BirthDateTime = Convert.ToDateTime(foundRecord[7]);
            doctor.Address = foundRecord[8];
            doctor.PhoneNumber = Convert.ToInt64(foundRecord[9]);
            doctor.Specialization.SpecName = foundRecord[12];

            return doctor;
        }
   }
}