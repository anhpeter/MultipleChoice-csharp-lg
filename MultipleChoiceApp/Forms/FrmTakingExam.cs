using MultipleChoiceApp.BLL;
using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleChoiceApp.Forms
{
    public partial class FrmTakingExam : Form
    {
        Exam exam;
        Subject subject;
        List<StudentResponse> studentResponseList;
        //
        QuestionBUS questionBUS = new QuestionBUS();
        int questionNumber = 1;
        public FrmTakingExam(Exam exam, Subject subject)
        {
            this.exam = exam;
            this.subject = subject;
            InitializeComponent();
            FormHelper.MakeFullScreen(this);
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            FormHelper.replaceForm(this, new FrmExamFinish());
        }

        private void FrmTakingExam_Load(object sender, EventArgs e)
        {
            setupExam();
        }

        private void setupExam()
        {
            renderAnswerSheet();
            studentResponseList = new List<StudentResponse>();
            List<Question> questions = getQuestionList();
            foreach (var question in questions)
            {
                StudentResponse studentResponse = new StudentResponse() { Question = question };
                studentResponse.genRandomOrder();
                studentResponseList.Add(studentResponse);
            }
            displayQuestion();
        }

        private void renderAnswerSheet()
        {

        }

        private List<Question> getQuestionList()
        {
            int easyQty = exam.EasyQty;
            int hardQty = exam.HardQty;
            int normalQty = subject.TotalQuestion - (easyQty + hardQty);
            List<Question> questions = new List<Question>();
            if (easyQty > 0) questions = questions.Concat(questionBUS.getRandomByLevel("easy", easyQty)).ToList();
            if (hardQty > 0) questions = questions.Concat(questionBUS.getRandomByLevel("hard", easyQty)).ToList();
            if (normalQty > 0) questions = questions.Concat(questionBUS.getRandomByLevel("normal", easyQty)).ToList();
            Util.log($"\nEasy:{easyQty} - Normal:{normalQty} - Hard:{hardQty}");
            return questions;
        }

        private void displayQuestion()
        {
            StudentResponse studentResponse = studentResponseList[questionNumber];
            Question question = studentResponse.Question;
            lbl_question.Text = question.Content;
            int[] answerOrder = studentResponse.AnswerOrder;
            lbl_ans1.Text = question.Answers[answerOrder[0]-1].Content;
            lbl_ans2.Text = question.Answers[answerOrder[1]-1].Content;
            lbl_ans3.Text = question.Answers[answerOrder[2]-1].Content;
            lbl_ans4.Text = question.Answers[answerOrder[3]-1].Content;
        }
    }
}
