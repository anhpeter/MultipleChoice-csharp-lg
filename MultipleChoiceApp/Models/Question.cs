﻿using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp
{
    public class Question
    {
        public int Id { get; set; }
        public String Content { get; set; }
        public int SubjectId { get; set; }
        public String SubjectCode { get; set; }
        public String Level { get; set; }
        public int Chapter { get; set; }
        public int CorrectAnswerNo { get; set; }
        public DateTime CreatedAt { get; set; }
        //
        public String Lecturer { get; set; }

        public static Question fromDR(SqlDataReader dr)
        {
            Question item = new Question()
            {
                Id = Convert.ToInt32(Util.getDrValue(dr, "Id")),
                Content = Util.getDrValue(dr, "Content"),
                SubjectId = Util.parseToInt(Util.getDrValue(dr, "SubjedctId"), -1),
                SubjectCode = Util.getDrValue(dr, "SubjectCode"),
                Level = Util.getDrValue(dr, "Level"),
                Chapter = Util.parseToInt(Util.getDrValue(dr, "Chapter"), -1),
                CreatedAt = Convert.ToDateTime(Util.getDrValue(dr, "CreatedAt")),
                Lecturer = Util.getDrValue(dr, "Lecturer"),
                CorrectAnswerNo = Util.parseToInt(Util.getDrValue(dr, "CorrectAnswerNo"), 1),
            };
            return item;
        }
        public List<Answer> Answers { get; set; }

        // 
        public Dictionary<String, String> toDictionary()
        {
            Dictionary<String, String> dic = new Dictionary<string, string>();
            String answersString = "";
            if (this.Answers.Count > 0)
            {
                string[] answerLines = this.Answers.Select(x => x.Content).ToArray();
                answersString = string.Join("\n", answerLines);
            }
            dic.Add("Id", this.Id + "");
            dic.Add("Content", this.Content);
            dic.Add("Answers", answersString);
            dic.Add("Correct Answer No", this.CorrectAnswerNo + "");
            dic.Add("Subject Code", this.SubjectCode);
            dic.Add("Chapter", this.Chapter + "");
            dic.Add("Level", this.Level);
            dic.Add("Created At", Util.toSqlFormattedDate(this.CreatedAt));
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
    }
}

