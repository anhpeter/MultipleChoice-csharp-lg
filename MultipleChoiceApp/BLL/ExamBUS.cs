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

        // FETCH
        public ExamOverview getExamOverviewById(int id)
        {
            return mainDAO.getExamOverviewById(id);
        }
        public List<Exam> getAllForReport()
        {
            return mainDAO.getAllForReport();
        }

        public Exam getExamReportById(int id)
        {
            return mainDAO.getExamReportById(id);
        }
        public Exam getAvailableBySubjectId(int SubjectId, DateTime d)
        {
            return mainDAO.getAvailableBySubjectId(SubjectId, d);
        }

        public List<Exam> searchByKeyword(String keyword)
        {
            return mainDAO.searchByKeyWord(keyword);
        }
    }
}
