using MultipleChoiceSite.Common;
using MultipleChoiceSite.Common.Helpers;
using MultipleChoiceSite.DAL;
using MultipleChoiceSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MultipleChoiceSite.Services
{
    /// <summary>
    /// Summary description for QuestionService
    /// </summary>
    [WebService(Namespace =Constant.ServiceNameSpace+"/Question")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class QuestionService : BaseService<Question>
    {
        QuestionDAO mainDAO = new QuestionDAO();
        AnswerDAO answerDAO = new AnswerDAO();

        public override BaseDAO<Question> getMainDAO()
        {
            return mainDAO;
        }

        [WebMethod]
        public int countBySubjectId(int id)
        {
            return mainDAO.countBySubjectId(id);
        }
        //FETCH
        [WebMethod]
        public List<Question> getAllWithAnswerCountByExamId(int id)
        {
            List<Question> list = mainDAO.getAllByExamId(id);
            foreach (var item in list)
            {
                item.Answers = answerDAO.getAnswersWithAnswerCountByExamAndQuestionId(id, item.Id);
            }
            return list;
        }

        [WebMethod]
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
        [WebMethod]
        public List<Question> getAllBySubjectId(int id, int itemsPerPage, int currentPage)
        {
            return mainDAO.getAllBySubjectId(id, itemsPerPage, currentPage);
        }

        [WebMethod]
        public List<Question> getAllWithAnswersBySubjectId(int id)
        {
            List<Question> list = mainDAO.getAllBySubjectId(id);
            foreach (var item in list)
            {
                item.Answers = answerDAO.getAnswersByQuestionId(item.Id);
            }
            return list;
        }

        [WebMethod]
        public List<Question> searchByKeyword(int id, String keyword)
        {
            return mainDAO.searchByKeyWord(id, keyword);
        }

        [WebMethod]
        public override Question getDetailsById(int id)
        {
            Question item = mainDAO.getByPK(id + "");
            List<Answer> answers = answerDAO.getAnswersByQuestionId(id);
            item.Answers = answers;
            return item;
        }

        [WebMethod]
        public override bool add(Question item)
        {
            int questionId = mainDAO.add(item);
            if (questionId > -1)
            {
                return answerDAO.addManyForQuestion(item.Answers, questionId);
            }
            return false;
        }
        [WebMethod]
        public override int addMany(List<Question> list)
        {
            int count = 0;
            foreach (var item in list)
            {
                if (this.add(item)) count++;
            }
            return count;
        }

        [WebMethod]
        public bool updateImage(int id, String filename, String url)
        {
            bool result = mainDAO.updateImage(id, filename, url);
            return result;
        }
        [WebMethod]
        public override bool update(Question item)
        {
            bool updateQuestionResult = mainDAO.update(item);
            bool updateAnswersResult = answerDAO.updateManyForQuestion(item.Answers);
            return updateQuestionResult || updateAnswersResult;
        }

        [WebMethod]
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
