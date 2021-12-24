using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.Models
{
    class ExamReport
    {
        public String Name { get; set; }
        public String Subject { get; set; }
        public String StartAt { get; set; }
        public String EndAt { get; set; }
        public String Duration { get; set; }
        public String TotalQuestion { get; set; }
    }
}
