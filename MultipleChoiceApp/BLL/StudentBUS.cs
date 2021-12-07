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
    class StudentBUS
    {
        StudentDAO mainDAO = new StudentDAO();

        public int countAll()
        {
            return mainDAO.countAll();
        }
        public Student getByCodeAndPassword(String id, String password)
        {
            return mainDAO.getByCodeAndPassword(id, password);
        }
        public List<Student> getAll(Pagination p)
        {
            return mainDAO.getAll(p);
        }

        public Student getDetailsById(int id)
        {
            Student item = mainDAO.getByPK(id + "");
            return item;
        }

        public List<Student> searchByKeyword(String keyword)
        {
            return mainDAO.searchByKeyWord(keyword);
        }

        public bool add(Student item)
        {
            return mainDAO.add(item) > 0;
        }

        public bool update(Student item)
        {

            return mainDAO.update(item);
        }

        public bool delete(int id)
        {
            return mainDAO.deleteByPK(id + "");
        }
    }
}
