using MultipleChoiceSite.Common;
using MultipleChoiceSite.Common.Helpers;
using MultipleChoiceSite.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MultipleChoiceSite.Services
{
    /// <summary>
    /// Summary description for BaseService
    /// </summary>
    [WebService(Namespace =Constant.ServiceNameSpace)]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public abstract class BaseService <T>: System.Web.Services.WebService
    {

        public abstract BaseDAO<T> getMainDAO();

        //FETCHES
        [WebMethod]
        public List<T> getAllForSelectData()
        {
            return getMainDAO().getAllForSelectData();
        }
        [WebMethod]
        public List<T> getAll(int itemsPerPage, int currentPage)
        {
            return getMainDAO().getAll(itemsPerPage, currentPage);
        }
        [WebMethod]
        public virtual int countAll()
        {
            return getMainDAO().countAll();
        }
        [WebMethod]
        public virtual T getDetailsById(int id)
        {
            T item = getMainDAO().getByPK(id + "");
            return item;
        }

        //WRITE
        [WebMethod]
        public virtual bool add(T item)
        {
            return getMainDAO().add(item) > 0;
        }
        [WebMethod]
        public virtual int addMany(List<T> list)
        {
            int count = 0;
            foreach (var item in list)
            {
                if (add(item)) count++;
            }
            return count;
        }

        [WebMethod]
        public virtual bool update(T item)
        {

            return getMainDAO().update(item);
        }

        [WebMethod]
        public virtual bool delete(int id)
        {
            return getMainDAO().deleteByPK(id + "");
        }
    }
}
