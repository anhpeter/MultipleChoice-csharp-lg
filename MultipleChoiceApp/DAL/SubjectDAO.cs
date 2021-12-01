using MultipleChoiceApp.Common.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.DAL
{
    class SubjectDAO:BaseDAO<Subject>
    {
        public SubjectDAO() : base("Subjects") { }

        // IMPLEMENT ABSTRACTS
        protected override Subject fromDR(SqlDataReader dr)
        {
            return Subject.fromDR(dr);
        }

        // FETCHS

        // UPDATE

        // ADD

        // DELETE

        // HELPER METHODS

    }
}
