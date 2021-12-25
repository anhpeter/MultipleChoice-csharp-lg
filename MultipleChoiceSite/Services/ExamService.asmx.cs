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
    /// Summary description for ExamService
    /// </summary>
    [WebService(Namespace =Constant.ServiceNameSpace+"/Exam")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ExamService : BaseService<Exam>
    {
        ExamDAO mainDAO = new ExamDAO();
        // OVERRIDE
        public override BaseDAO<Exam> getMainDAO()
        {
            return mainDAO;
        }
        [WebMethod]
        public bool isAvailableBetweenDate(DateTime start, DateTime end, int subjectId)
        {
            return mainDAO.isAvailableBetweenDate(start, end, subjectId);
        }

        // FETCH
        [WebMethod]
        public ExamOverview getExamOverviewById(int id)
        {
            return mainDAO.getExamOverviewById(id);
        }
        [WebMethod]
        public List<Exam> getAllForReport()
        {
            return mainDAO.getAllForReport();
        }
        [WebMethod]
        public Exam getExamReportById(int id)
        {
            return mainDAO.getExamReportById(id);
        }
        [WebMethod]
        public Exam getAvailableBySubjectId(int SubjectId, DateTime d)
        {
            return mainDAO.getAvailableBySubjectId(SubjectId, d);
        }

        [WebMethod]
        public List<Exam> searchByKeyword(String keyword)
        {
            return mainDAO.searchByKeyWord(keyword);
        }
    }
}
