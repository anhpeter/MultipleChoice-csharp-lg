using MultipleChoiceApp.Bi.Exam;
using MultipleChoiceApp.Bi.StudentResult;
using MultipleChoiceApp.Bi.Subject;
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

namespace MultipleChoiceApp.Forms
{
    public partial class FrmExamStart : Form
    {
        Auth auth = Auth.getIntace();

        SubjectServiceSoapClient subjectS = new SubjectServiceSoapClient();
        ExamServiceSoapClient examS = new ExamServiceSoapClient();
        StudentResultServiceSoapClient studentResultS = new StudentResultServiceSoapClient();
        List<Bi.Subject.Subject> subjectList;
        //
        Bi.Exam.Exam exam;
        public FrmExamStart()
        {
            InitializeComponent();
            CenterToScreen();
            fillFormInfo();
        }

        private void FrmExamStart_Load(object sender, EventArgs e)
        {
            setupInterface();
        }

        private void setupInterface()
        {
            lbl_exam_name_label.Visible = false;
            lbl_exam_start_label.Visible = false;
            lbl_exam_end_label.Visible = false;
        }

        private void fillFormInfo()
        {
            LoadDrops();
            lbl_name.Text = auth.student.FullName;
            lbl_code.Text = auth.student.Code;
            lbl_major.Text = auth.student.Major;
            fillSubjectInfo();
        }

        private void fillSubjectInfo()
        {
            int subIndex = getSelectedSubjectIndex();
            if (subIndex >= 0)
            {
                Bi.Subject.Subject subject = subjectList[subIndex];
                lbl_duration.Text = subject.Duration + "";
                lbl_total_question.Text = subject.TotalQuestion + "";
            }
        }

        private void LoadDrops()
        {
            // SUBJECTS
            subjectList = subjectS.getAvailableForExam(DateTime.Now);
            if (subjectList.Count > 0)
            {
                drop_subject.DataSource = subjectList;
                drop_subject.ValueMember = "Id";
                drop_subject.DisplayMember = "Name";
                drop_subject.SelectedIndex = 0;
            }
        }

        private void fillExamInfo()
        {
            int subId = getSelectedSubjectId();
            if (subId > -1)
            {
                exam = examS.getAvailableBySubjectId(subId, DateTime.Now);
                lbl_exam_name.Text = exam.Name;
                lbl_exam_start.Text = Util.toExamFormattedDate(exam.StartAt);
                lbl_exam_end.Text = Util.toExamFormattedDate(exam.EndAt);
            }
            lbl_exam_name_label.Visible = true;
            lbl_exam_start_label.Visible = true;
            lbl_exam_end_label.Visible = true;
        }

        // HEPER METHODS

        private int getSelectedSubjectIndex()
        {
            if (drop_subject.SelectedValue != null) return drop_subject.SelectedIndex;
            return -1;
        }
        private Bi.Subject.Subject getSelectedSubject()
        {
            int selectedSubIndex = getSelectedSubjectIndex();
            if (selectedSubIndex > -1) return subjectList[selectedSubIndex];
            return null;
        }
        private int getSelectedSubjectId()
        {
            if (drop_subject.SelectedValue != null) return Util.parseToInt(drop_subject.SelectedValue.ToString(), -1);
            return -1;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (exam != null)
            {
                bool isTaken = studentResultS.isExamTaken(Auth.getIntace().student.Id, exam.Id);
                if (!isTaken)
                {
                    FormHelper.replaceForm(this, new FrmTakingExam(exam, getSelectedSubject()));
                }
                else
                {
                    MessageBox.Show(Msg.TAKEN_EXAM_ALREADY);
                }
            }
            else
            {
                    MessageBox.Show(Msg.CHOOSE_AN_EXAM);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            FormHelper.replaceForm(this, new FrmLogin());

        }

        private void drop_subject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fillSubjectInfo();
            fillExamInfo();
        }

    }
}
