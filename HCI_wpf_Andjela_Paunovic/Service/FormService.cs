using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class FormService
    {
        Repository.FormRepository formRepository = new Repository.FormRepository();
        public Boolean AddForm(Form form)
        {
            return formRepository.AddForm(form);
        }
    }
}
