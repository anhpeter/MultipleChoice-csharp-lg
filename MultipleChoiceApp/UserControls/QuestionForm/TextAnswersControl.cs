using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuTextbox;
using MultipleChoiceApp.Bi.Question;
using MultipleChoiceApp.Common.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleChoiceApp.UserControls.QuestionForm
{
    public partial class TextAnswersControl : UserControl
    {
        Question formItem;
        public TextAnswersControl(Question question)
        {
            InitializeComponent();
            formItem = question;
        }

        private Question getFormQuestion()
        {
            // ANSWER LIST
            List<Answer> answerList = new List<Answer>();
            int questionId = formItem != null ? formItem.Id : -1;
            BunifuTextBox[] ansTxts = { txt_ans1, txt_ans2, txt_ans3, txt_ans4 };
            for (int i = 0; i < ansTxts.Length; i++)
            {
                answerList.Add(new Answer()
                {
                    QuestionId = questionId,
                    No = i + 1,
                    Content = ansTxts[i].Text.ToString(),
                });
            }

            int correctAnsNo = getCorrectAnsNo();

            Question item = new Question()
            {
                Id = questionId,
                Answers = answerList,
                CorrectAnswerNo = correctAnsNo,
            };
            return item;
        }

        private int getCorrectAnsNo()
        {
            BunifuRadioButton radio = pnl_correct_ans_no.Controls.OfType<BunifuRadioButton>()
                .FirstOrDefault(r => r.Checked);

            return Util.parseToInt(radio.Tag.ToString(), 1);
        }
    }
}
