﻿using MultipleChoiceApp.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.Common.Models
{
    public class Subject
    {
        public String Code { get; set; }
        public String Name { get; set; }
        public int TotalQuestion { get; set; }
        public int Duration { get; set; }
        public String Lecturer { get; set; }
        //
        public static Subject fromDR(SqlDataReader dr)
        {
            Subject item = new Subject()
            {
                Code = Util.getDrValue(dr, "Code"),
                Name = Util.getDrValue(dr, "Name"),
                Lecturer = Util.getDrValue(dr, "Lecturer"),
                TotalQuestion = Util.parseToInt( Util.getDrValue(dr, "Lecturer"), -1),
                Duration = Util.parseToInt( Util.getDrValue(dr, "Duration"), -1),
            };
            return item;
        }
    }
}
