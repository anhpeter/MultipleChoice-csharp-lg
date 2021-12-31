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
    /// Summary description for StudentService
    /// </summary>
    [WebService(Namespace =Constant.ServiceNameSpace+"/Student")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class StudentService : BaseService<Student>
    {
        StudentDAO mainDAO = new StudentDAO();

        public override BaseDAO<Student> getMainDAO()
        {
            return mainDAO;
        }

        [WebMethod]
        public Student getByCodeAndPassword(String id, String password)
        {
            return mainDAO.getByCodeAndPassword(id, password);
        }

        [WebMethod]
        public List<Student> searchByKeyword(String keyword)
        {
            return mainDAO.searchByKeyWord(keyword);
        }
        [WebMethod]
        public Student getByCode(String code)
        {
            return mainDAO.getByCode(code);
        }
    }
}
