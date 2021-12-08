using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.DAL;
using MultipleChoiceApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.BLL
{
    class StudentResultBUS
    {
        StudentResultDAO mainDAO = new StudentResultDAO();
        StudentResponseDAO studentResponseDAO = new StudentResponseDAO();

        public int countAll()
        {
            return mainDAO.countAll();
        }
        public List<StudentResult> getAll(Pagination p)
        {
            return mainDAO.getAll(p);
        }

        public StudentResult getDetailsById(int id)
        {
            StudentResult item = mainDAO.getByPK(id + "");
            return item;
        }

        public bool add(StudentResult item)
        {
            int studentResultId = mainDAO.add(item);
            if (studentResultId > -1)
            {
                return studentResponseDAO.addMany(item.StudentResponses, studentResultId);
            }
            return false;
        }

        public bool update(StudentResult item)
        {

            return mainDAO.update(item);
        }

        public bool delete(int id)
        {
            return mainDAO.deleteByPK(id + "");
        }
    }
}
