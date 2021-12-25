using System;

namespace MultipleChoiceSite.Models
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
