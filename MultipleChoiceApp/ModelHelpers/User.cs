using MultipleChoiceApp.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.ModelHelpers
{
    public class User
    {
        public int Id { get; set; }
        public String Code { get; set; }
        public String Password { get; set; }
        public String FullName { get; set; }
        public String Address { get; set; }
        public DateTime DOB { get; set; }
    }
}
