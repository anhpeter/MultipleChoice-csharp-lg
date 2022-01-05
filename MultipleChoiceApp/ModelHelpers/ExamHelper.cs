using MultipleChoiceApp.Bi.Exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.ModelHelpers
{
    class ExamHelper
    {
        public static int getNormalQty(Exam ex, int totalQuestion)
        {
            int qty = totalQuestion - (ex.EasyQty + ex.HardQty);
            return qty;
        }
        public static int getNormalQty(Exam ex)
        {
            int qty = ex.Subject.TotalQuestion - (ex.EasyQty + ex.HardQty);
            return qty;
        }
    }
}
