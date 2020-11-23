using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HCI_wpf_Andjela_Paunovic
{
    public partial class QuestionList : Window
    {

        public class Question
        {
            public string questionTitle { get; set; }
            public string questionContent { get; set; }
            public string dateTime { get; set; }



        }

        
    }
}
