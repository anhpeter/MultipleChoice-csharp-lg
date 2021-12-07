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
    class ExamBUS
    {
        ExamDAO mainDAO = new ExamDAO();

        public Exam getAvailabelBySubjectId(int SubjectId, DateTime d)
        {
            return mainDAO.getAvailabelBySubjectId(SubjectId, d);
        }
        public int countAll()
        {
            return mainDAO.countAll();
        }
        public List<Exam> getAll(Pagination p)
        {
            return mainDAO.getAll(p);
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
