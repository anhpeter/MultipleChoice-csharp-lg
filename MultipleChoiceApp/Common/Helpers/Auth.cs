using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.Common.Helpers
{
    class Auth
    {
        private static Auth intance;
        private Auth() { }
        public static Auth getIntace()
        {
            if (intance == null)
            {
                intance = new Auth();
            }
            return intance;
        }
        //
        public Student student { get; set; }
        public Manager manager { get; set; }
    }
}
