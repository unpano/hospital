using Model;
using System;
using System.Collections.ObjectModel;
using System.IO;

namespace Controller
{
    public class FeedbackController
    {
        Service.FeedbackService feedbackService = new Service.FeedbackService();

        public Feedback CreateFeedback(String text)
        {
            Feedback feedback = new Feedback();

            int count = CountLinesInFile("C:/Users/Andjela Paunovic/Desktop/projekat2/project/zdravoCorporationBackend/HCI_wpf_Andjela_Paunovic/HCI_wpf_Andjela_Paunovic/CSV/feedbacks.csv");
            feedback.Id = count - 1;
            feedback.Date = DateTime.Now;
            feedback.Text = text;

            return feedback;
        }

        static int CountLinesInFile(string f)
        {
            int count = 0;
            using (StreamReader r = new StreamReader(f))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    count++;
                }
            }
            return count;
        }

        public Boolean AddFeedback(Feedback feedback)
        {
            return feedbackService.CreateFeedback(feedback);
        }
    }
}
