using Bunifu.Framework.UI;
using MultipleChoiceApp.Bi.Question;
using MultipleChoiceApp.Bi.Subject;
using MultipleChoiceApp.Bi.Exam;
using MultipleChoiceApp.Bi.StudentResult;
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
using MultipleChoiceApp.ModelHelpers;

namespace MultipleChoiceApp.Forms
{
    public partial class FrmTakingExam : Form
    {
        Bi.Exam.Exam exam;
        Bi.Subject.Subject subject;
        List<StudentResponse> studentResponseList;

        //
        QuestionServiceSoapClient questionS = new QuestionServiceSoapClient();
        StudentResultServiceSoapClient studentResultS = new StudentResultServiceSoapClient();
        int questionNumber = 1;
        int time;
        Timer timer;
        public FrmTakingExam(Bi.Exam.Exam exam, Bi.Subject.Subject subject)
        {
            this.exam = exam;
            this.subject = subject;
            this.time = subject.Duration * 60 * 1000;
            InitializeComponent();
            FormHelper.MakeFullScreen(this);
            lbl_question.MaximumSize = new Size(pnl_table_answer.Width, 0);
            lbl_question.AutoSize = true;
        }

        private void FrmTakingExam_Load(object sender, EventArgs e)
        {
            setupInterface();
            setupExam();
            timer = new Timer();
            timer.Interval = 1000; // 45 mins
            timer.Tick += new EventHandler(MyTimer_Tick);
            timer.Start();
        }

        // SETUP
        private void setupExam()
        {
            studentResponseList = new List<StudentResponse>();
            List<Bi.Question.Question> questions = QuestionHelper.genQuestionListForExam(exam.EasyQty, ExamHelper.getNormalQty(exam, subject.TotalQuestion), exam.HardQty, subject.Id);
            studentResponseList = StudentResponseHelper.genStudentResponseList(questions);
            if (studentResponseList.Count == subject.TotalQuestion)
            {
                displayQuestion();
                renderAnswerSheet();
            }
            else
            {
                Util.log("Questions count " + studentResponseList.Count);
                MessageBox.Show("Not load enough questions! ");

            }
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            this.time -= 1000;
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
                        StudentResponseHelper.setRandomAnswerNo(answerNo, studentResponse);
                    }
                }
            }

            Bi.StudentResult.Subject stuResultSubject = Util.cvtObj<Bi.Subject.Subject, Bi.StudentResult.Subject>(subject);
            Bi.StudentResult.Exam stuResultExam = Util.cvtObj<Bi.Exam.Exam, Bi.StudentResult.Exam>(exam);
            StudentResult studentResult = StudentResultHelper.genStudentResult(studentResponseList, stuResultSubject, stuResultExam, Auth.getIntace().student.Id);
            // SAVE TO DB
            studentResultS.add(studentResult);

            //
            FormClosing -= FrmTakingExam_FormClosing;
            FormHelper.replaceForm(this, new FrmExamFinish(studentResult));
        }

        // EVENTS
        private void btn_submit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(Msg.SUBMIT_EXAM_CONFIRM, "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                timer.Dispose();
                onExamSubmit();
            }
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
            Bi.StudentResult.Question question = studentResponse.Question;
            lbl_question.Text = $"{questionNumber}. {question.Content}";
            int[] answerOrder = studentResponse.AnswerOrder.ToArray();
            lbl_ans1.Text = question.Answers[answerOrder[0] - 1].Content;
            lbl_ans2.Text = question.Answers[answerOrder[1] - 1].Content;
            lbl_ans3.Text = question.Answers[answerOrder[2] - 1].Content;
            lbl_ans4.Text = question.Answers[answerOrder[3] - 1].Content;
            updatePagination();
            if (String.IsNullOrEmpty(question.ImgUrl))
            {
                pic_question.Image = null;
            }
            else
            {
                pic_question.Load(question.ImgUrl);
            }
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
            double h = Math.Floor(this.time / 60 / 60 / 1000.0) % 60;
            double m = Math.Floor(this.time % (1000 * 60 * 60) / (1000 * 60 * 1.0));
            double s = Math.Floor((this.time % (1000 * 60)) / 1000 * 1.0);

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
            pnl_answer.Left = (pnl_answer_sheet.Width - pnl_answer.Width) / 2;
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
            lbl.Cursor = Cursors.Hand;
            lbl.Tag = text;
            lbl.Click += this.questionNumber_Click;
            lbl.MouseEnter += this.questionNumber_MouseEnter;
            lbl.MouseLeave += this.questionNumber_MouseLeave;
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

        private void FrmTakingExam_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            int newQUestionNumber = questionNumber;
            if (keyData == Keys.Right)
            {
                newQUestionNumber = newQUestionNumber < subject.TotalQuestion ? newQUestionNumber + 1 : subject.TotalQuestion;
            }
            else if (keyData == Keys.Left)
            {
                newQUestionNumber = newQUestionNumber > 1 ? newQUestionNumber - 1 : 1;
            }
            if (newQUestionNumber != questionNumber)
            {
                questionNumber = newQUestionNumber;
                displayQuestion();
            }
            return true;
            //return base.ProcessCmdKey(ref msg, keyData);
        }

        private void questionNumber_Click(object sender, EventArgs e)
        {
            int newQuestionNumber = Util.parseToInt(((Label)sender).Tag.ToString());
            if (newQuestionNumber != questionNumber)
            {
                questionNumber = newQuestionNumber;
                displayQuestion();
            }
        }

        void questionNumber_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.DodgerBlue;
        }
        void questionNumber_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.Black;
        }

        private void FrmTakingExam_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Your exam not finished yet. Do you want to Exit?", "Confirmation", MessageBoxButtons.YesNo);
            e.Cancel = (result == DialogResult.No);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(Msg.CANCEL_EXAM_CONFIRM, "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                FormClosing -= FrmTakingExam_FormClosing;
                timer.Dispose();
                FormHelper.replaceForm(this, new FrmLogin());
            }
        }
    }
}
