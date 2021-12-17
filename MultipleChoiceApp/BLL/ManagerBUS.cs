using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.DAL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.BLL
{
    class ManagerBUS:BaseBUS<Manager>
    {
        ManagerDAO mainDAO = new ManagerDAO();

        public override BaseDAO<Manager> getMainDAO()
        {
            return mainDAO;
        }


        public Manager getByCodeAndPassword(String id, String password)
        {
            return mainDAO.getByCodeAndPassword(id, password);
        }

        public List<Manager> searchByKeyword(String keyword)
        {
            return mainDAO.searchByKeyWord(keyword);
        }
    }
}
