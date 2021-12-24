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
    class SubjectBUS:BaseBUS<Subject>
    {
        SubjectDAO mainDAO = new SubjectDAO();

        public override BaseDAO<Subject> getMainDAO()
        {
            return mainDAO;
        }

        public List<Subject> getAvailableForExam(DateTime d)
        {
            return mainDAO.getAvailableForExam(d);
        }
        public List<Subject> getAllForSelectData()
        {
            return mainDAO.getAllForSelectData();
        }
        public List<Subject> searchByKeyword(String keyword)
        {
            return mainDAO.searchByKeyWord(keyword);
        }

    }
}
