using MultipleChoiceApp.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.Common.Models
{
    public class Manager
    {
        public int Id { get; set; }
        public String Code { get; set; }
        public String FullName { get; set; }
        public String Address { get; set; }
        public DateTime DOB { get; set; }
        public String PhoneNumber { get; set; }
        public String Position { get; set; }
        public static Manager fromDR(SqlDataReader dr)
        {
            Manager item = new Manager()
            {
                Id = Util.parseToInt(Util.getDrValue(dr, "Id"), -1),
                Code = Util.getDrValue(dr, "Code"),
                FullName = Util.getDrValue(dr, "FullName"),
                Address = Util.getDrValue(dr, "Address"),
                DOB = Convert.ToDateTime(Util.getDrValue(dr, "DOB")),
                PhoneNumber = Util.getDrValue(dr, "PhoneNumber"),
                Position = Util.getDrValue(dr, "Position"),
            };
            return item;
        }
    }
}
