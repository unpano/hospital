using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class FormRepository
    {
        public Boolean AddForm(Form form)
        {
            String line = "\n" + form.InterventionId + "," + form.FFormType + "," + form.Description + "," + form.ReportOrPrescription;
            File.AppendAllText("C:/Users/Andjela Paunovic/Desktop/HCI_wpf_Andjela_Paunovic/HCI_wpf_Andjela_Paunovic/CSV/forms.csv", line);
            return true;
        }
    }
}
