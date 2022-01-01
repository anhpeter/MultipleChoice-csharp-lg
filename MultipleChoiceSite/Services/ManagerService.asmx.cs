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
    /// Summary description for ManagerService
    /// </summary>
    [WebService(Namespace =Constant.ServiceNameSpace+"/Manager")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ManagerService : BaseService<Manager>
    {

        ManagerDAO mainDAO = new ManagerDAO();

        public override BaseDAO<Manager> getMainDAO()
        {
            return mainDAO;
        }

        [WebMethod]
        public Manager getByCode(String code)
        {
            return mainDAO.getByCode(code);
        }

        [WebMethod]
        public Manager getByCodeAndPassword(String id, String password)
        {
            return mainDAO.getByCodeAndPassword(id, password);
        }

        [WebMethod]
        public List<Manager> searchByKeyword(String keyword)
        {
            return mainDAO.searchByKeyWord(keyword);
        }
    }
}
