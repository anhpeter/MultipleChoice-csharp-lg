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

        public List<Question> searchByKeyword(String code, String keyword)
        {
            return mainDAO.searchByKeyWord(code, keyword);
        }

        public Question getDetailsById(int id)
        {
            Debug.WriteLine(id);
            Question item = mainDAO.getByPK(id+"");
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

        public bool update(Question item)
        {
            bool updateQuestionResult = mainDAO.update(item);
            if (updateQuestionResult)
            {
                return answerDAO.updateManyForQuestion(item.Answers);
            }
            return false;
        }

        public bool delete(int id)
        {
            bool deleteQuestionResult = mainDAO.deleteById(id);
            if (deleteQuestionResult)
            {
                return true;
            }
            return false;
        }
    }
}
