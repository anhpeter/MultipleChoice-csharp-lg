using MultipleChoiceApp.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.ModelHelpers
{
    public class ExamOverview
    {
        public int TakenStudentCount { get; set; }
        public Double AveragePoints { get; set; }
        public int Duration { get; set; }
        public int TotalQuestion { get; set; }
        public static ExamOverview fromDR(SqlDataReader dr)
        {
            ExamOverview item = new ExamOverview()
            {
                TakenStudentCount = Util.parseToInt(Util.getDrValue(dr, "TakenStudentCount"), -1),
                AveragePoints = Util.parseToDouble( Util.getDrValue(dr, "AveragePoints")),
                Duration = Util.parseToInt(Util.getDrValue(dr, "Duration")),
                TotalQuestion = Util.parseToInt(Util.getDrValue(dr, "TotalQuestion"), -1),
            };
            return item;
        }
    }
}
