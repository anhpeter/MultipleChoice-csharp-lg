using Bunifu.Framework.UI;
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
        StudentResultBUS studentResultBUS = new StudentResultBUS();
        int questionNumber = 1;
        int time;
        Timer timer;
        public FrmTakingExam(Exam exam, Subject subject)
        {
            this.exam = exam;
            this.subject = subject;
            this.time = subject.Duration * 60 * 1000;
            InitializeComponent();
            FormHelper.MakeFullScreen(this);
        }

        private void FrmTakingExam_Load(object sender, EventArgs e)
        {
            setupInterface();
            setupExam();
            timer = new Timer();
            timer.Interval = (subject.Duration * 1000); // 45 mins
            timer.Tick += new EventHandler(MyTimer_Tick);
            timer.Start();
        }

        // SETUP
        private void setupExam()
        {
            studentResponseList = new List<StudentResponse>();
            List<Question> questions = getQuestionList();
            Random rnd = new Random();
            foreach (var question in questions)
            {
                StudentResponse studentResponse = new StudentResponse(question);
                studentResponse.genRandomOrder(rnd);
                studentResponseList.Add(studentResponse);
            }
            if (studentResponseList.Count == subject.TotalQuestion)
            {
                displayQuestion();
                renderAnswerSheet();
            }
            else
            {
                MessageBox.Show("Load enough questions!");

            }
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            this.time -= 1000;
            Util.log($"time: {time}");
            renderTime();
            if (this.time == 0)
            {
                timer.Dispose();
                onExamTimeout();
            }
        }

        private void setupInterface()
        {
            lbl_time.Text = "";
            pnl_answer.Visible = false;
            lbl_time.Left = (pnl_header.Width - lbl_time.Width) / 2;
            pnl_pagination.Left = (pnl_question_sheet.Width - pnl_pagination.Width) / 2;
        }

        private List<Question> getQuestionList()
        {
            int easyQty = exam.EasyQty;
            int hardQty = exam.HardQty;
            int normalQty = subject.TotalQuestion - (easyQty + hardQty);
            List<Question> questions = new List<Question>();
            if (easyQty > 0) questions = questions.Concat(questionBUS.getRandomByLevel("easy", easyQty)).ToList();
            if (normalQty > 0) questions = questions.Concat(questionBUS.getRandomByLevel("normal", easyQty)).ToList();
            if (hardQty > 0) questions = questions.Concat(questionBUS.getRandomByLevel("hard", easyQty)).ToList();
            Util.log($"\nEasy:{easyQty} - Normal:{normalQty} - Hard:{hardQty}");
            return questions;
        }

        private void onExamTimeout()
        {
            MessageBox.Show("TIME'S UP!");
            onExamSubmit();
        }

        // ON EXAM SUBMIT
        private void onExamSubmit()
        {
            // HANDLE SUBMIT
            foreach (var control in pnl_answer.Controls)
            {
                if (control is TableLayoutPanel)
                {
                    TableLayoutPanel answerPanel = (TableLayoutPanel)control;
                    if (answerPanel.Tag != null)
                    {

                        int answerNo = 0;
                        foreach (var c in answerPanel.Controls)
                        {
                            if (c is RadioButton)
                            {
                                RadioButton rdo = (RadioButton)c;
                                if (rdo.Checked)
                                {
                                    answerNo = Util.parseToInt(rdo.Tag.ToString(), answerNo);
                                    break;
                                }
                            }
                        }
                        //
                        int no = Util.parseToInt(answerPanel.Tag.ToString(), 1);
                        StudentResponse studentResponse = studentResponseList[no - 1];
                        studentResponse.setRandomAnswerNo(answerNo);
                    }
                }
            }

            StudentResult studentResult = new StudentResult(studentResponseList, subject, exam, Auth.getIntace().student.Id);
            // SAVE TO DB
            studentResultBUS.add(studentResult);

            //
            FormHelper.replaceForm(this, new FrmExamFinish(studentResult));
        }

        // EVENTS
        private void btn_submit_Click(object sender, EventArgs e)
        {
            timer.Dispose();
            onExamSubmit();
        }
        private void onPaginationBtnClick(object sender, EventArgs e)
        {
            String tag = ((BunifuImageButton)sender).Tag.ToString();
            questionNumber = Util.parseToInt(tag, 1);
            displayQuestion();
        }

        // HELPER METHODS
        private void displayQuestion()
        {
            StudentResponse studentResponse = studentResponseList[questionNumber - 1];
            Question question = studentResponse.Question;
            lbl_question.Text = $"{questionNumber}. {question.Content}";
            int[] answerOrder = studentResponse.AnswerOrder;
            lbl_ans1.Text = question.Answers[answerOrder[0] - 1].Content;
            lbl_ans2.Text = question.Answers[answerOrder[1] - 1].Content;
            lbl_ans3.Text = question.Answers[answerOrder[2] - 1].Content;
            lbl_ans4.Text = question.Answers[answerOrder[3] - 1].Content;
            updatePagination();
        }

        private void updatePagination()
        {
            int first = 1;
            int prev = questionNumber > 1 ? questionNumber - 1 : 1;
            int next = questionNumber < subject.TotalQuestion ? questionNumber + 1 : subject.TotalQuestion;
            int last = subject.TotalQuestion;
            btn_first.Tag = first;
            btn_prev.Tag = prev;
            btn_next.Tag = next;
            btn_last.Tag = last;
        }

        // TEMPLATE
        private void renderTime()
        {
            double h = Math.Floor(this.time / 60 / 60 / 1000.0);
            double m = Math.Floor(this.time / 60 / 1000.0);
            double s = Math.Floor(this.time / 1000.0);

            String hStr = Util.strPad(h + "", 2, "0");
            String mStr = Util.strPad(m + "", 2, "0");
            String sStr = Util.strPad(s + "", 2, "0");
            String timeStr = $"{hStr}:{mStr}:{sStr}";
            lbl_time.Text = timeStr;
        }

        async private void renderAnswerSheet()
        {
            pnl_answer.ColumnCount = subject.TotalQuestion + 1;
            for (int i = 1; i <= subject.TotalQuestion; i++)
            {
                Label lbl = getAnswerLabel(i + "");
                TableLayoutPanel panel = getSingleAnswer(i);
                pnl_answer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
                pnl_answer.Controls.Add(lbl, i, 0);
                pnl_answer.Controls.Add(panel, i, 1);
                pnl_answer.Width = pnl_answer.Width + 36;
            }
            await Task.Delay(100);
            pnl_answer.Visible = true;
        }

        private TableLayoutPanel getSingleAnswer(int questionNo)
        {

            TableLayoutPanel panel = new TableLayoutPanel();
            panel.ColumnCount = 1;
            panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            //
            panel.Controls.Add(getAnswerRadioButton(1), 0, 0);
            panel.Controls.Add(getAnswerRadioButton(2), 0, 1);
            panel.Controls.Add(getAnswerRadioButton(3), 0, 2);
            panel.Controls.Add(getAnswerRadioButton(4), 0, 3);
            //
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
            panel.Tag = questionNo;
            panel.TabIndex = 100 + questionNo;
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

        private RadioButton getAnswerRadioButton(int no)
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
            rdo.Tag = no;
            return rdo;
        }

    }
}
