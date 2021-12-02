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
    class SubjectBUS
    {
        SubjectDAO mainDAO = new SubjectDAO();

        public List<Subject> getAll()
        {
            return mainDAO.getAll();
        }

        public Subject getDetailsByCode(String code)
        {
            Subject item = mainDAO.getByPK(code);
            return item;
        }

        public List<Subject> searchByKeyword(String keyword)
        {
            return mainDAO.searchByKeyWord(keyword);
        }

        public bool add(Subject item)
        {
            return mainDAO.add(item) > 0;
        }

        public bool update(Subject item)
        {

            return mainDAO.update(item);
        }

        public bool delete(String code)
        {
            return mainDAO.deleteByPK(code);
        }
    }
}
