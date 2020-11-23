using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class FeedbackService
    {
        Repository.FeedbackRepository feedbackRepository = new FeedbackRepository();
        
        public Boolean CreateFeedback (Feedback feedback)
        {
            return feedbackRepository.AddFeedback(feedback);
        }
    }
}
