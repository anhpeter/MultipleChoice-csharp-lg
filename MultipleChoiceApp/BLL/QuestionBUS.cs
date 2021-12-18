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
    class QuestionBUS : BaseBUS<Question>
    {
        QuestionDAO mainDAO = new QuestionDAO();
        AnswerDAO answerDAO = new AnswerDAO();

        public override BaseDAO<Question> getMainDAO()
        {
            return mainDAO;
        }

        public int countBySubjectId(int id)
        {
            return mainDAO.countBySubjectId(id);
        }
        //FETCH
        public List<Question> getRandomByLevel(int subjectId, String level, int qty)
        {
            List<Question> questions = mainDAO.getRandomByLevel(subjectId, level, qty);
            foreach (var question in questions)
            {
                List<Answer> answers = answerDAO.getAnswersByQuestionId(question.Id);
                question.Answers = answers;
            }
            return questions;
        }
        public List<Question> getAllBySubjectId(int id, Pagination pagination)
        {
            return mainDAO.getAllBySubjectId(id, pagination);
        }

        public List<Question> getAllWithAnswersBySubjectId(int id)
        {
            List<Question> list = mainDAO.getAllBySubjectId(id);
            foreach (var item in list)
            {
                item.Answers = answerDAO.getAnswersByQuestionId(item.Id);
            }
            return list;
        }

        public List<Question> searchByKeyword(int id, String keyword)
        {
            return mainDAO.searchByKeyWord(id, keyword);
        }

        public override Question getDetailsById(int id)
        {
            Debug.WriteLine(id);
            Question item = mainDAO.getByPK(id + "");
            List<Answer> answers = answerDAO.getAnswersByQuestionId(id);
            item.Answers = answers;
            return item;
        }

        public override bool add(Question item)
        {
            int questionId = mainDAO.add(item);
            if (questionId > -1)
            {
                return answerDAO.addManyForQuestion(item.Answers, questionId);
            }
            return false;
        }
        public override int addMany(List<Question> list)
        {
            int count = 0;
            foreach (var item in list)
            {
                if (this.add(item)) count++;
            }
            return count;
        }

        public override bool update(Question item)
        {
            bool updateQuestionResult = mainDAO.update(item);
            bool updateAnswersResult = answerDAO.updateManyForQuestion(item.Answers);
            return updateQuestionResult || updateAnswersResult;
        }

        public override bool delete(int id)
        {
            bool deleteQuestionResult = mainDAO.deleteByPK(id + "");
            if (deleteQuestionResult)
            {
                return true;
            }
            return false;
        }

    }
}
