using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryManager
{
    public class Entry
    {
        string date;
        string content;

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Content 
        {
            get { return content; }
            set { content = value; }
        }
    }
}
