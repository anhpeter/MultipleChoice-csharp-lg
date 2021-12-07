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
            pnl_answer.ColumnCount = subject.TotalQuestion + 1;
            for (int i = 2; i <= subject.TotalQuestion; i++)
            {
                Label lbl = getAnswerLabel(i + "");
                TableLayoutPanel panel = getSingleAnswer();
                pnl_answer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
                pnl_answer.Controls.Add(lbl, i, 0);
                pnl_answer.Controls.Add(panel, i, 1);
                pnl_answer.Width = pnl_answer.Width +36;
            }
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
            lbl_ans1.Text = question.Answers[answerOrder[0] - 1].Content;
            lbl_ans2.Text = question.Answers[answerOrder[1] - 1].Content;
            lbl_ans3.Text = question.Answers[answerOrder[2] - 1].Content;
            lbl_ans4.Text = question.Answers[answerOrder[3] - 1].Content;
        }

        private TableLayoutPanel getSingleAnswer()
        {

            TableLayoutPanel panel = new TableLayoutPanel();
            panel.ColumnCount = 1;
            panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            panel.Controls.Add(getAnswerRadioButton(), 0, 0);
            panel.Controls.Add(getAnswerRadioButton(), 0, 1);
            panel.Controls.Add(getAnswerRadioButton(), 0, 2);
            panel.Controls.Add(getAnswerRadioButton(), 0, 3);
            panel.Dock = System.Windows.Forms.DockStyle.Fill;
            //panel.Location = new System.Drawing.Point(50, 46);
            panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            //panel.Name = "tableLayoutPanel4";
            panel.RowCount = 4;
            panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            panel.BackColor = Color.Transparent;
            //panel.Size = new System.Drawing.Size(20, 145);
            //panel.TabIndex = 12;
            return panel;
        }
        private Label getAnswerLabel(String text)
        {
            Label lbl = new Label();
            lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl.Text = text;
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lbl.BackColor = Color.Transparent;
            return lbl;
        }

        private RadioButton getAnswerRadioButton()
        {
            RadioButton rdo = new RadioButton();
            rdo.AutoSize = true;
            rdo.Location = new System.Drawing.Point(3, 2);
            rdo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            rdo.Dock = DockStyle.Fill;
            //rdo.Name = "radioButton1";
            rdo.Padding = new System.Windows.Forms.Padding(5);
            //rdo.Size = new System.Drawing.Size(20, 26);
            rdo.TabIndex = 0;
            rdo.TabStop = true;
            rdo.UseVisualStyleBackColor = true;
            return rdo;
        }
    }
}
