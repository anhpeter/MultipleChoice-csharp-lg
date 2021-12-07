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
    class SubjectBUS
    {
        SubjectDAO mainDAO = new SubjectDAO();

        public int countAll()
        {
            return mainDAO.countAll();
        }


        public List<Subject> getAvailableForExam(DateTime d)
        {
            return mainDAO.getAvailableForExam(d);
        }
        public List<Subject> getAllForSelectData()
        {
            return mainDAO.getAllForSelectData();
        }
        public List<Subject> getAll(Pagination pagination)
        {
            return mainDAO.getAll(pagination);
        }

        public Subject getDetailsById(int id)
        {
            Subject item = mainDAO.getByPK(id+"");
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

        public bool delete(int id)
        {
            return mainDAO.deleteByPK(id+"");
        }
    }
}
