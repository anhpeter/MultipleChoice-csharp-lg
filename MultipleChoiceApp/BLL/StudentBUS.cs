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
    class StudentBUS:BaseBUS<Student>
    {
        StudentDAO mainDAO = new StudentDAO();

        public override BaseDAO<Student> getMainDAO()
        {
            return mainDAO;
        }


        public Student getByCodeAndPassword(String id, String password)
        {
            return mainDAO.getByCodeAndPassword(id, password);
        }

        public List<Student> searchByKeyword(String keyword)
        {
            return mainDAO.searchByKeyWord(keyword);
        }

    }
}
