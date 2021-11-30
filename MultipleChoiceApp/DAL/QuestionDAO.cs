using MultipleChoiceApp.Common.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.DAL
{
    class QuestionDAO :BaseDAO
    {
        String conStr = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;

        // FETCHS
        public List<Question> getAllBySubjectCode(String code)
        {
            List<Question> list = new List<Question>();
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            SqlCommand com = new SqlCommand("prc_ques_getAllBySubjectCode", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@code", code);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                list.Add(Question.fromDR(dr));
            }
            return list;
        }

        
        // UPDATE

        // ADD

        // DELETE

        // HELPER METHODS
    }
}
