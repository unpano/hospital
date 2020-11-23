using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Feedback
    {
        private int id;
        private DateTime date;
        private String text;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public String Text
        {
            get { return text; }
            set { text = value; }
        }
    }
}
