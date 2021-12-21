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
    class StudentResultBUS:BaseBUS<StudentResult>
    {
        StudentResultDAO mainDAO = new StudentResultDAO();
        StudentResponseDAO studentResponseDAO = new StudentResponseDAO();

        public override BaseDAO<StudentResult> getMainDAO()
        {
            return mainDAO;
        }

        //
        public bool isExamTaken(int studentId, int examId)
        {
            return mainDAO.isExamTaken(studentId, examId);
        }
        //

        public StudentResult getDetailByExamAndStudentId(int examId, int studentId)
        {
            return mainDAO.getDetailByExamAndStudentId(examId, studentId);
        }

        public List<StudentResult> getAllByExamId(int id)
        {
            return mainDAO.getAllByExamId(id);
        }
        public List<StudentResult> searchByKeyword(String keyword)
        {
            return mainDAO.searchByKeyWord(keyword);
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

    }
}
