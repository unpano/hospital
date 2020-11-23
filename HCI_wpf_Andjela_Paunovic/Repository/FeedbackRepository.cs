using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class FeedbackRepository
    {
        public Boolean AddFeedback(Feedback feedback)
        {
            String line = feedback.Id + "," + feedback.Date + "," + feedback.Text + "\n";
            File.AppendAllText("C:/Users/Andjela Paunovic/Desktop/HCI_wpf_Andjela_Paunovic/HCI_wpf_Andjela_Paunovic/CSV/feedbacks.csv", line);

            return true;
        }
    }
}
