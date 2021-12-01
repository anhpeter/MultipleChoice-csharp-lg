﻿using MultipleChoiceApp.Common.Models;
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
            bool result = true;
            if (mainDAO.add(item)==-1) result = false;
            if (answerDAO.addManyForQuestion(item.Answers, item.Id)) result = false;
            return result;
        }
    }
}
