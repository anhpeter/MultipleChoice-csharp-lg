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
    class StudentResponseBUS : BaseBUS<StudentResponse>
    {
        StudentResponseDAO mainDAO = new StudentResponseDAO();
        AnswerDAO answerDAO = new AnswerDAO();

        public override BaseDAO<StudentResponse> getMainDAO()
        {
            return mainDAO;
        }

        public List<StudentResponse> getAllByExamAndStudentId(int examId, int studentId)
        {
            List<StudentResponse> list = mainDAO.getAllByExamAndStudentId(examId, studentId);
            foreach (var item in list)
            {
                item.Question.Answers = answerDAO.getAnswersByQuestionId(item.Question.Id);
            }
            return list;
        }
    }
}
