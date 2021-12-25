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
    /// Summary description for StudentResultService
    /// </summary>
    [WebService(Namespace =Constant.ServiceNameSpace)]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class StudentResultService : BaseService<StudentResult>
    {

        StudentResultDAO mainDAO = new StudentResultDAO();
        StudentResponseDAO studentResponseDAO = new StudentResponseDAO();

        public override BaseDAO<StudentResult> getMainDAO()
        {
            return mainDAO;
        }

        [WebMethod]
        public bool isExamTaken(int studentId, int examId)
        {
            return mainDAO.isExamTaken(studentId, examId);
        }

        [WebMethod]
        public StudentResult getDetailByExamAndStudentId(int examId, int studentId)
        {
            return mainDAO.getDetailByExamAndStudentId(examId, studentId);
        }

        [WebMethod]

        public List<StudentResult> getAllByExamId(int id)
        {
            return mainDAO.getAllByExamId(id);
        }

        [WebMethod]
        public List<StudentResult> searchByKeyword(String keyword)
        {
            return mainDAO.searchByKeyWord(keyword);
        }

        [WebMethod]
        public override bool add(StudentResult item)
        {
            int studentResultId = mainDAO.add(item);
            if (studentResultId > -1)
            {
                return studentResponseDAO.addMany(item.StudentResponses, studentResultId);
            }
            return false;
        }

    }
}
