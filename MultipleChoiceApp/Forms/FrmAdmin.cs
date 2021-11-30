using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleChoiceApp
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            changeControl(new QuestionControl(), "Questions");
            FormHelper.MakeFullScreen(this);
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
        private void changeControl(UserControl control, String title) {
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
    }
}
