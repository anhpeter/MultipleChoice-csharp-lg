using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.ModelHelpers
{
    public class ExamSheet
    {
        public int SheetCode { get; set; }
        public String ExamName { get; set; }
        public String Subject { get; set; }
        public String TotalQuestion { get; set; }
        public String Duration { get; set; }
        public String Semester { get; set; }
    }
}
