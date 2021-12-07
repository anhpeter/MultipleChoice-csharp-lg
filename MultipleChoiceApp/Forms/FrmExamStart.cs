using MultipleChoiceApp.BLL;
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
        SubjectBUS subjectBUS = new SubjectBUS();
        ExamBUS examBUS = new ExamBUS();
        List<Subject> subjectList;
        Exam exam;
        public FrmExamStart()
        {
            InitializeComponent();
            CenterToScreen();
            fillFormInfo();
        }

        private void fillFormInfo()
        {
            LoadDrops();
            lbl_name.Text = auth.student.FullName;
            lbl_code.Text = auth.student.Code;
            lbl_major.Text = auth.student.Major;
            fillSubjectInfo();
            fillExamInfo();
        }

        private void fillSubjectInfo()
        {
            int subIndex = getSelectedSubjectIndex();
            if (subIndex >= 0)
            {
                Subject subject = subjectList[subIndex];
                lbl_duration.Text = subject.Duration + "";
                lbl_total_question.Text = subject.TotalQuestion + "";
            }
        }

        private void LoadDrops()
        {
            // SUBJECTS
            subjectList = subjectBUS.getAvailableForExam(DateTime.Now);
            drop_subject.DataSource = subjectList;
            drop_subject.ValueMember = "Id";
            drop_subject.DisplayMember = "Name";
            drop_subject.SelectedIndex = 0;
        }

        private void fillExamInfo()
        {
            int subId = getSelectedSubjectId();
            if (subId > -1)
            {
                exam = examBUS.getAvailabelBySubjectId(subId, DateTime.Now);
                lbl_exam_name.Text = exam.Name;
                lbl_exam_start.Text = Util.toExamFormattedDate(exam.StartAt);
                lbl_exam_end.Text = Util.toExamFormattedDate(exam.EndAt);
            }
        }

        // HEPER METHODS

        private int getSelectedSubjectIndex()
        {
            if (drop_subject.SelectedValue != null) return drop_subject.SelectedIndex;
            return -1;
        }
        private int getSelectedSubjectId()
        {
            if (drop_subject.SelectedValue != null) return Util.parseToInt(drop_subject.SelectedValue.ToString(), -1);
            return -1;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            FormHelper.replaceForm(this, new FrmTakingExam());
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
