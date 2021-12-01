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

        public Subject getDetailsById(int id)
        {
            Debug.WriteLine(id);
            Subject item = mainDAO.getById(id);
            return item;
        }
    }
}
