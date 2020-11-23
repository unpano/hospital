using HCI_wpf_Andjela_Paunovic;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class FormController
    {
        Service.FormService formService = new Service.FormService();
        public Boolean AddForm(Form form)
        {
            return formService.AddForm(form);
        }
    }
}
