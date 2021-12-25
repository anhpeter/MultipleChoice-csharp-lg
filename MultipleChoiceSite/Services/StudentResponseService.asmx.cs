using MultipleChoiceSite.Common;
using MultipleChoiceSite.DAL;
using MultipleChoiceSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MultipleChoiceSite.Services
{
    /// <summary>
    /// Summary description for StudentResponseService
    /// </summary>
    [WebService(Namespace =Constant.ServiceNameSpace+"/StudentResponse")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class StudentResponseService : BaseService<StudentResponse>
    {
        StudentResponseDAO mainDAO = new StudentResponseDAO();
        AnswerDAO answerDAO = new AnswerDAO();

        public override BaseDAO<StudentResponse> getMainDAO()
        {
            return mainDAO;
        }

        [WebMethod]
        public List<StudentResponse> getAllByExamAndStudentId(int examId, int studentId)
        {
            List<StudentResponse> list = mainDAO.getAllByExamAndStudentId(examId, studentId);
            foreach (var item in list)
            {
                item.Question.Answers = answerDAO.getAnswersByQuestionId(item.Question.Id);
            }
            return list;
        }
    }
}
