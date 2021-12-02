using MultipleChoiceApp.Common.Models;
using MultipleChoiceApp.DAL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.BLL
{
    class ManagerBUS
    {
        ManagerDAO mainDAO = new ManagerDAO();

        public List<Manager> getAll()
        {
            return mainDAO.getAll();
        }

        public Manager getDetailsById(int id)
        {
            Manager item = mainDAO.getByPK(id + "");
            return item;
        }

        public List<Manager> searchByKeyword(String keyword)
        {
            return mainDAO.searchByKeyWord(keyword);
        }

        public bool add(Manager item)
        {
            return mainDAO.add(item) > 0;
        }

        public bool update(Manager item)
        {

            return mainDAO.update(item);
        }

        public bool delete(int id)
        {
            return mainDAO.deleteByPK(id + "");
        }
    }
}
