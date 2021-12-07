using MultipleChoiceApp.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp
{
    public class Student
    {
        public int Id { get; set; }
        public String Code { get; set; }
        public String Password { get; set; }
        public String FullName { get; set; }
        public String Address { get; set; }
        public DateTime DOB { get; set; }
        public String Major { get; set; }
        public static Student fromDR(SqlDataReader dr)
        {
            Student item = new Student()
            {
                Id = Util.parseToInt(Util.getDrValue(dr, "Id"), -1),
                Code = Util.getDrValue(dr, "Code"),
                Password = Util.getDrValue(dr, "Password"),
                FullName = Util.getDrValue(dr, "FullName"),
                Address = Util.getDrValue(dr, "Address"),
                Major = Util.getDrValue(dr, "Major"),
                DOB = Convert.ToDateTime(Util.getDrValue(dr, "DOB")),
            };
            return item;
        }
    }
}
