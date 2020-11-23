using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PatientRepository
    {
        public Patient ViewPatientProfile(int patientId)
        {
            Patient patient = new Patient();
            String[] foundRecord;
            String[] lines = File.ReadAllLines("C:/Users/Andjela Paunovic/Desktop/HCI_wpf_Andjela_Paunovic/HCI_wpf_Andjela_Paunovic/CSV/patients.csv");

            for (int i = 1; i < lines.Length; i++)
            {
                string[] fields = lines[i].Split(',');
                if (Convert.ToInt32(fields[0]).Equals(patientId))
                {
                    foundRecord = lines[i].Split(',');
                    Patient pat = mapPatientData(foundRecord);
                    return pat;
                }
            }
            
            return patient;
        }

        public Patient mapPatientData(String[] foundRecord)
        {
            Patient patient = new Patient();

            patient.ID = Convert.ToInt32(foundRecord[0]);
            patient.FirstName = foundRecord[1];
            patient.LastName = foundRecord[2];
            patient.Username = foundRecord[3];
            patient.Password = foundRecord[4];
            patient.Email = foundRecord[5];
            patient.JMBG = Convert.ToInt64(foundRecord[6]);
            patient.BirthDateTime = Convert.ToDateTime(foundRecord[7]);
            patient.Address = foundRecord[8];
            patient.PhoneNumber = Convert.ToInt64(foundRecord[9]);

            return patient;
        }
        public Boolean NoteAbsence(int patientId)
        {
            //na osnovu id-ja nadji pacijenta i uvecaj mu polje za jedan
            String path = "C:/Users/Andjela Paunovic/Desktop/projekat2/project/zdravoCorporationBackend/HCI_wpf_Andjela_Paunovic/HCI_wpf_Andjela_Paunovic/CSV/patients.csv";
            List<String> lines = new List<String>();

            using (StreamReader reader = new StreamReader(path))
            {
                String line;

                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(","))
                    {
                        String[] split = line.Split(',');

                        if (split[0].Equals(Convert.ToString(patientId)))
                        {
                            split[10] = Convert.ToString(Convert.ToInt32(split[10]) + 1);

                            line = String.Join(",", split);
                        }
                    }

                    lines.Add(line);
                }
            }

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                foreach (String line in lines)
                    writer.WriteLine(line);
            }
            return true;
        }
    }
}
