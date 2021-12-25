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
    /// Summary description for SubjectService
    /// </summary>
    [WebService(Namespace = Constant.ServiceNameSpace+"/Subject")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SubjectService : BaseService<Subject>
    {
        SubjectDAO mainDAO = new SubjectDAO();

        public override BaseDAO<Subject> getMainDAO()
        {
            return mainDAO;
        }

        [WebMethod]
        public List<Subject> getAvailableForExam(DateTime d)
        {
            return mainDAO.getAvailableForExam(d);
        }

        [WebMethod]
        public List<Subject> searchByKeyword(String keyword)
        {
            return mainDAO.searchByKeyWord(keyword);
        }

    }
}
