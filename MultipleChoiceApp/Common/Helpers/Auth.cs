
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
        public Bi.Student.Student student { get; set; }
        public Bi.Manager.Manager manager { get; set; }
    }
}
