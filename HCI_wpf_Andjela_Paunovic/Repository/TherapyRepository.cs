using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class TherapyRepository
    {
        public ObservableCollection<Therapy> ViewTherapies(int patientId)
        {
            ObservableCollection<Therapy> therapyList = new ObservableCollection<Therapy>();

            String[] foundRecordTher;
            String[] linesTher = File.ReadAllLines("C:/Users/Andjela Paunovic/Desktop/HCI_wpf_Andjela_Paunovic/HCI_wpf_Andjela_Paunovic/CSV/therapies.csv");

            for (int i = 1; i < linesTher.Length; i++)
            {
                Therapy therapy = new Therapy();
                foundRecordTher = linesTher[i].Split(',');

                
                if (Convert.ToInt32(foundRecordTher[0]) == patientId)
                    {
                        Therapy mappedTherapy = mapTherapyData(foundRecordTher, therapy);
                        therapyList.Add(mappedTherapy);
                    }
                
            }

            return therapyList;
        }
        public Therapy mapTherapyData(String[] foundRecord, Therapy therapy)
        {
            therapy.PatientId = Convert.ToInt32(foundRecord[0]);
            therapy.MedicationName = foundRecord[1];
            therapy.Dose = Convert.ToInt32(foundRecord[2]);


            return therapy; ;
        }
        public Boolean RemoveTherapy(Therapy therapy)
        {
                String path = "C:/Users/Andjela Paunovic/Desktop/projekat2/project/zdravoCorporationBackend/HCI_wpf_Andjela_Paunovic/HCI_wpf_Andjela_Paunovic/CSV/therapies.csv";
                List<String> lines = new List<String>();

                using (StreamReader reader = new StreamReader(path))
                {
                    String line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains(","))
                        {
                            String[] split = line.Split(',');

                            if (split[0].Equals(Convert.ToString(therapy.PatientId)) && split[1]==therapy.MedicationName)
                            {
                            split[0] = "099";
                            split[1] = "099";
                            split[2] = "099";

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
        public Boolean AddTherapy(Therapy therapy)
        {
            String line = "\n" + therapy.PatientId + "," + therapy.MedicationName + "," + therapy.Dose;
            File.AppendAllText("C:/Users/Andjela Paunovic/Desktop/projekat2/project/zdravoCorporationBackend/HCI_wpf_Andjela_Paunovic/HCI_wpf_Andjela_Paunovic/CSV/therapies.csv", line);

            return true;
        }
    }
    }

