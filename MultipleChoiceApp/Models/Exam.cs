using MultipleChoiceApp.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp
{
    public class Exam
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Semester { get; set; }
        public int SubjectId { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public int EasyQty { get; set; }
        public int HardQty { get; set; }
        //
        public String SubjectCode { get; set; }
        public int TotalQuestion { get; set; }
        public static Exam fromDR(SqlDataReader dr)
        {
            Exam item = new Exam()
            {
                Id = Util.parseToInt(Util.getDrValue(dr, "Id"), -1),
                Name = Util.getDrValue(dr, "Name"),
                Semester = Util.parseToInt(Util.getDrValue(dr, "Semester"), -1),
                SubjectId = Util.parseToInt(Util.getDrValue(dr, "SubjectId"), -1),
                StartAt = Convert.ToDateTime(Util.getDrValue(dr, "StartAt")),
                EndAt = Convert.ToDateTime(Util.getDrValue(dr, "EndAt")),
                EasyQty = Util.parseToInt(Util.getDrValue(dr, "EasyQty"), 0),
                HardQty = Util.parseToInt(Util.getDrValue(dr, "HardQty"), 0),
                TotalQuestion = Util.parseToInt(Util.getDrValue(dr, "TotalQuestion"), 0),
                SubjectCode = Util.getDrValue(dr, "SubjectCode"),
            };
            return item;
        }
        //
        public Subject Subject { get; set; }
    }
}
