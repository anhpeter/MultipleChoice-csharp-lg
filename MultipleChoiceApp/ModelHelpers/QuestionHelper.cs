using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.Bi.Question;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MultipleChoiceApp.ModelHelpers
{
    public class QuestionHelper
    {

        public static List<Question> genQuestionListForExam(int easyQty, int normalQty, int hardQty, int subjectId)
        {
            QuestionServiceSoapClient questionS = new QuestionServiceSoapClient();
            List<Bi.Question.Question> questions = new List<Bi.Question.Question>();
            List<Bi.Question.Question> easyList = new List<Bi.Question.Question>();
            List<Bi.Question.Question> normalList = new List<Bi.Question.Question>();
            List<Bi.Question.Question> hardList = new List<Bi.Question.Question>();
            if (easyQty > 0) easyList = questionS.getRandomByLevel(subjectId, "easy", easyQty);
            if (normalQty > 0) normalList = questionS.getRandomByLevel(subjectId, "normal", normalQty);
            if (hardQty > 0) hardList = questionS.getRandomByLevel(subjectId, "hard", hardQty);
            questions = questions.Concat(easyList).ToList();
            questions = questions.Concat(normalList).ToList();
            questions = questions.Concat(hardList).ToList();
            Util.log($"\nEasy:{easyList.Count} - Normal:{normalList.Count} - Hard:{hardList.Count}");
            return questions;
        }
        public static Dictionary<String, String> toDictionary(Question question)
        {
            Dictionary<String, String> dic = new Dictionary<string, string>();
            String answersString = "";
            if (question.Answers.Count > 0)
            {
                string[] answerLines = question.Answers.Select(x => x.Content).ToArray();
                answersString = string.Join("\n", answerLines);
            }
            dic.Add("Id", question.Id + "");
            dic.Add("Content", question.Content);
            dic.Add("Image Url", question.ImgUrl);
            dic.Add("Answers", answersString);
            dic.Add("Correct Answer No", question.CorrectAnswerNo + "");
            dic.Add("Subject Code", question.SubjectCode);
            dic.Add("Chapter", question.Chapter + "");
            dic.Add("Level", question.Level);
            dic.Add("Created At", Util.toSqlFormattedDate(question.CreatedAt));
            return dic;
        }
        public static Question fromDictionary(Dictionary<String, String> dic)
        {
            Question item = new Question()
            {
                Id = Util.parseToInt(Util.getDicValue(dic, "Id")),
                Content = Util.getDicValue(dic, "Content"),
                SubjectCode = Util.getDicValue(dic, "Subject Code"),
                CorrectAnswerNo = Util.parseToInt(Util.getDicValue(dic, "Correct Answer No")),
                Chapter = Util.parseToInt(Util.getDicValue(dic, "Chapter")),
                Level = Util.getDicValue(dic, "Level"),
                CreatedAt = Util.parseToDatetime(Util.getDicValue(dic, "Created At")),
            };
            return item;
        }
        public static bool idDictionaryKeysValid(String[] inputKeys)
        {
            string[] keys = new string[] { "Content", "Answers", "Correct Answer No", "Chapter", "Level" };
            return Util.isSubArray(keys, inputKeys);
        }

        public static List<Question> genListByDicList(List<Dictionary<String, String>> dicList, int subjectId)
        {
            List<Question> list = new List<Question>();
            foreach (var dic in dicList)
            {
                Question item = QuestionHelper.fromDictionary(dic);
                String answersString = dic["Answers"];
                if (answersString != null)
                {
                    string[] lines = answersString.Split(new String[] { "\n" }, StringSplitOptions.None);
                    lines = lines.Where(x => !x.Trim().Equals("")).ToArray();
                    List<Answer> answers = lines.Select(x => new Answer() { Content = x.Trim() }).ToList();
                    item.Answers = answers;
                }
                item.SubjectId = subjectId;
                item.CreatedBy = Auth.getIntace().manager.Id;
                list.Add(item);
            }
            return list;
        }
    }
}


