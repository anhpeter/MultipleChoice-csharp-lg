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
    class ExamBUS : BaseBUS<Exam>
    {
        ExamDAO mainDAO = new ExamDAO();
        // OVERRIDE
        public override BaseDAO<Exam> getMainDAO()
        {
            return mainDAO;
        }
        public bool isAvailableBetweenDate(DateTime start, DateTime end, int subjectId)
        {
            return mainDAO.isAvailableBetweenDate(start, end, subjectId);
        }

        //
        public Exam getAvailabelBySubjectId(int SubjectId, DateTime d)
        {
            return mainDAO.getAvailabelBySubjectId(SubjectId, d);
        }

        public List<Exam> searchByKeyword(String keyword)
        {
            return mainDAO.searchByKeyWord(keyword);
        }
    }
}
