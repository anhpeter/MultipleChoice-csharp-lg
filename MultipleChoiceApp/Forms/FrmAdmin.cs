using Bunifu.Framework.UI;
using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.Forms;
using MultipleChoiceApp.ModelHelpers;
using MultipleChoiceApp.UserControls;
using MultipleChoiceApp.Bi.Student;
using MultipleChoiceApp.Bi.Exam;
using MultipleChoiceApp.Bi.Subject;
using MultipleChoiceApp.Bi.Question;
using MultipleChoiceApp.Bi.StudentResult;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MultipleChoiceApp.Bi.Manager;

namespace MultipleChoiceApp
{
    public partial class FrmAdmin : Form
    {
        Dictionary<String, Bitmap> iconDict = new Dictionary<string, Bitmap>();
        StudentServiceSoapClient studentS = new StudentServiceSoapClient();
        ExamServiceSoapClient examS = new ExamServiceSoapClient();
        SubjectServiceSoapClient subjectS = new SubjectServiceSoapClient();
        QuestionServiceSoapClient questionS = new QuestionServiceSoapClient();
        StudentResultServiceSoapClient studentResultS = new StudentResultServiceSoapClient();
        ManagerServiceSoapClient managerS = new ManagerServiceSoapClient();
        public FrmAdmin()
        {
            InitializeComponent();
            iconDict.Add("Questions", Properties.Resources.Questions);
            iconDict.Add("Questions_active", Properties.Resources.Question_active);
            iconDict.Add("Subjects", Properties.Resources.Subjects);
            iconDict.Add("Subjects_active", Properties.Resources.Subjects_active);
            iconDict.Add("Students", Properties.Resources.Students);
            iconDict.Add("Students_active", Properties.Resources.Students_active);
            iconDict.Add("Managers", Properties.Resources.Managers);
            iconDict.Add("Managers_active", Properties.Resources.Managers_active);
            iconDict.Add("Results", Properties.Resources.Results);
            iconDict.Add("Results_active", Properties.Resources.Results_active);
            iconDict.Add("Exams", Properties.Resources.Exams);
            iconDict.Add("Exams_active", Properties.Resources.Exams_active);
        }

        async private void FrmAdmin_Load(object sender, EventArgs e)
        {
            changeControl(new QuestionControl(), "Questions");
            FormHelper.MakeFullScreen(this);
            lbl_id.Text = Auth.getIntace().manager.FullName;
            //
        }

        private void btn_questions_Click(object sender, EventArgs e)
        {
            changeControl(new QuestionControl(), "Questions");
        }

        private void btn_subject_Click(object sender, EventArgs e)
        {
            changeControl(new SubjectControl(), "Subjects");
        }

        // HELPER METHODS
        private void changeControl(UserControl control, String title)
        {
            foreach (Control c in pnl_nav.Controls)
            {
                if (c is BunifuFlatButton)
                {
                    BunifuFlatButton button = (BunifuFlatButton)c;
                    if (button.Tag.Equals(title))
                    {
                        button.Textcolor = Color.DodgerBlue;
                        button.Iconimage = iconDict[c.Tag.ToString() + "_active"];
                    }
                    else
                    {
                        button.Textcolor = Color.DimGray;
                        try
                        {
                            button.Iconimage = iconDict[button.Tag.ToString()];
                        }
                        catch (Exception ex) { }
                    }
                }
            }
            control.Dock = DockStyle.Fill;
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(control);
            lbl_title.Text = title;
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            changeControl(new StudentControl(), "Students");
        }

        private void btn_manager_Click(object sender, EventArgs e)
        {
            changeControl(new ManagerControl(), "Managers");
        }

        private void btn_exam_Click(object sender, EventArgs e)
        {
            changeControl(new ExamControl(), "Exams");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            FormHelper.replaceForm(this, new FrmLogin());
        }

        private void btn_result_Click(object sender, EventArgs e)
        {

            changeControl(new ResultControl(this), "Results");
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            //FrmExamReport frmExamReport = new FrmExamReport(new Exam());
            //frmExamReport.Show();
            //FormHelper.replaceForm(this, new FrmExamReport(new Exam()));
            //FrmTest form = new FrmTest();
            //form.Show();
            int successCount = 0;
            for (int c = 2; c <= 3; c++)
            {
                // subject // exam
                Bi.Subject.Subject subject = subjectS.getDetailsById(c);
                Bi.Exam.Exam exam = examS.getDetailsById(c);
                Random rnd = new Random();
                for (int i = 4; i <= 23; i++)
                {
                    // student
                    Bi.Student.Student student = studentS.getDetailsById(i);
                    List<Bi.StudentResult.StudentResponse> studentResponseList = new List<Bi.StudentResult.StudentResponse>();
                    List<Bi.Question.Question> questions = getQuestionList(exam, subject);
                    foreach (var question in questions)
                    {
                        //Bi.StudentResult.StudentResponse studentResponse = new Bi.StudentResult.StudentResponse(question);
                        //studentResponse.genRandomOrder(rnd);
                        //studentResponseList.Add(studentResponse);
                    }
                    //
                    //for (int j = 0; j < studentResponseList.Count; j++)
                    //{
                    //    StudentResponse stuRes = studentResponseList[j];
                    //    stuRes.RandomAnswerNo = 1;
                    //    if (Util.getRandom(rnd, 1, 2) % 2 == 0)
                    //    {
                    //        int answerNo = stuRes.Question.CorrectAnswerNo;
                    //        stuRes.AnswerNO = answerNo;
                    //    }
                    //    else
                    //    {
                    //        int answerNo = stuRes.Question.CorrectAnswerNo;
                    //        if (answerNo == 1)
                    //            answerNo = 2;
                    //        else
                    //            answerNo -= 1;
                    //        stuRes.AnswerNO = answerNo;
                    //    }
                    //}

                    //Bi.StudentResult.StudentResult studentResult = new Bi.StudentResult.StudentResult(studentResponseList, subject, exam, student.Id);
                    // SAVE TO DB
                    //bool result = studentResultS.add(studentResult);
                    //if (result) successCount++;
                }
                MessageBox.Show($"Add success: {successCount}");
            }
        }


        private List<Bi.Question.Question> getQuestionList(Bi.Exam.Exam exam, Bi.Subject.Subject subject)
        {
            int easyQty = exam.EasyQty;
            int hardQty = exam.HardQty;
            int normalQty = subject.TotalQuestion - (easyQty + hardQty);
            List<Bi.Question.Question> questions = new List<Bi.Question.Question>();
            List<Bi.Question.Question> easyList = new List<Bi.Question.Question>();
            List<Bi.Question.Question> normalList = new List<Bi.Question.Question>();
            List<Bi.Question.Question> hardList = new List<Bi.Question.Question>();
            if (easyQty > 0) easyList = questionS.getRandomByLevel(subject.Id, "easy", easyQty);
            if (normalQty > 0) normalList = questionS.getRandomByLevel(subject.Id, "normal", normalQty);
            if (hardQty > 0) hardList = questionS.getRandomByLevel(subject.Id, "hard", hardQty);
            questions = questions.Concat(easyList).ToList();
            questions = questions.Concat(normalList).ToList();
            questions = questions.Concat(hardList).ToList();
            Util.log($"\nEasy:{easyQty} - Normal:{normalQty} - Hard:{hardQty}");
            Util.log($"\nEasy:{easyList.Count} - Normal:{normalList.Count} - Hard:{hardList.Count}");
            return questions;
        }
    }
}

