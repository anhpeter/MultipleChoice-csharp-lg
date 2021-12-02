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
    class ExamBUS
    {
        ExamDAO mainDAO = new ExamDAO();

        public List<Exam> getAll()
        {
            return mainDAO.getAll();
        }

        public Exam getDetailsById(int id)
        {
            Exam item = mainDAO.getByPK(id + "");
            return item;
        }

        public List<Exam> searchByKeyword(String keyword)
        {
            return mainDAO.searchByKeyWord(keyword);
        }

        public bool add(Exam item)
        {
            return mainDAO.add(item) > 0;
        }

        public bool update(Exam item)
        {

            return mainDAO.update(item);
        }

        public bool delete(int id)
        {
            return mainDAO.deleteByPK(id + "");
        }
    }
}
