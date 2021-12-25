using MultipleChoiceApp.Bi.StudentResponse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleChoiceApp.Common.UtilForms
{
    public partial class StudentQuestionAnswer : Form
    {
        StudentResponse studentResponse;
        public StudentQuestionAnswer(StudentResponse studentResponse)
        {
            InitializeComponent();
            CenterToScreen();
            this.studentResponse = studentResponse;
        }

        private void frm_student_question_answer_Load(object sender, EventArgs e)
        {
            int correctNo = studentResponse.Question.CorrectAnswerNo;
            int studentAnsNo = studentResponse.AnswerNO;
            String[] orderAlphabet = new string[] { "A", "B", "C", "D" };
            Label[] lblAnswers = new Label[] { lbl_opt_1, lbl_opt_2, lbl_opt_3, lbl_opt_4 };
            // Question
            lbl_question.Text = studentResponse.No+". "+studentResponse.Question.Content;
            // Answers
            for (int i = 0; i < studentResponse.Question.Answers.Count; i++)
            {
                int ansNo = studentResponse.AnswerOrder[i];
                String prefix = orderAlphabet[ansNo-1] + ". ";
                Label ansLabel = lblAnswers[ansNo - 1];
                Answer ans = studentResponse.Question.Answers[ansNo - 1];
                ansLabel.Text = prefix+ans.Content;

                // CORRECT
                if (ansNo == correctNo)
                {
                    ansLabel.ForeColor = Color.Green;
                }

                // INCORRECT
                if (ansNo == studentAnsNo)
                {
                    if (ansNo != correctNo)
                    {
                        ansLabel.ForeColor = Color.Red;
                    }
                }
            }
        }
    }
}
