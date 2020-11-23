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
    public class MedicationRepository
    {
        public ObservableCollection<Medication> ViewMedicationList()
        {
            ObservableCollection<Medication> medList = new ObservableCollection<Medication>();

            String[] foundRecordInterv;
            String[] linesInterv = File.ReadAllLines("C:/Users/Andjela Paunovic/Desktop/HCI_wpf_Andjela_Paunovic/HCI_wpf_Andjela_Paunovic/CSV/medications.csv");

            for (int i = 1; i < linesInterv.Length; i++)
            {

                Medication med = new Medication();
                foundRecordInterv = linesInterv[i].Split(',');

                Medication mappedMedication = mapMedicationData(foundRecordInterv, med);
                medList.Add(mappedMedication);
                
            }

            return medList;
        }
        public Medication mapMedicationData(String[] foundRecord, Medication med)
        {
            med.Id = Convert.ToInt32(foundRecord[0]);
            med.Name = foundRecord[1];
            med.Ingridients = foundRecord[2];
            med.Uses = foundRecord[3];
            med.Approved = Convert.ToBoolean(foundRecord[4]);
            med.ApprovingCounter = Convert.ToInt32(foundRecord[5]);
            med.Quantity = Convert.ToInt32(foundRecord[6]);
            med.Dose = Convert.ToInt32(foundRecord[7]);

            return med;
        }

        public Medication ViewMedication(String medName)
        {
            Medication medication = new Medication();
            String[] foundRecordMed;
            String[] linesMed = File.ReadAllLines("C:/Users/Andjela Paunovic/Desktop/HCI_wpf_Andjela_Paunovic/HCI_wpf_Andjela_Paunovic/CSV/medications.csv");

            for (int i = 1; i < linesMed.Length; i++)
            {
                foundRecordMed = linesMed[i].Split(',');
                if (medName.Equals(foundRecordMed[1])) 
                {
                    medication = mapMedicationData(foundRecordMed, medication);
                }
            }

            return medication;
        }

        public Boolean ApproveMedication(int medId)
        {
            //treba uvecati naci lek po Id-ju i uvecati approvingCounter
            Medication medication = new Medication();

            String path = "C:/Users/Andjela Paunovic/Desktop/HCI_wpf_Andjela_Paunovic/HCI_wpf_Andjela_Paunovic/CSV/medications.csv";
            List<String> lines = new List<String>();

            using (StreamReader reader = new StreamReader(path))
                {
                    String line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains(","))
                        {
                            String[] split = line.Split(',');

                            if (split[0].Equals(Convert.ToString(medId)))
                            {
                            split[5] = Convert.ToString(Convert.ToInt32(split[5])+1);
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
