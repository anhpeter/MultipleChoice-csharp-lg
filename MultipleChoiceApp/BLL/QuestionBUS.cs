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
    class QuestionBUS
    {
        QuestionDAO mainDAO = new QuestionDAO();
        AnswerDAO answerDAO = new AnswerDAO();

        public List<Question> getAllBySubjectCode(String code)
        {
            return mainDAO.getAllBySubjectCode(code);
        }

        public Question getDetailsById(int id)
        {
            Debug.WriteLine(id);
            Question item = mainDAO.getById(id);
            List<Answer> answers = answerDAO.getAnswersByQuestionId(id);
            item.Answers = answers;
            return item;
        }

        public bool add(Question item)
        {
            int questionId = mainDAO.add(item);
            if (questionId > -1)
            {
                return answerDAO.addManyForQuestion(item.Answers, questionId);
            }
            return false;
        }
    }
}
