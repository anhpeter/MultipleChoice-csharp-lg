using MultipleChoiceApp.Bi.Exam;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleChoiceApp.Forms.Utils
{
    public partial class FrmGenExamSheets : Form
    {
        Exam exam;
        public FrmGenExamSheets(Exam exam)
        {
            InitializeComponent();
            //
            CenterToScreen();
            this.exam = exam;
        }

        private void FrmGenExamSheets_Load(object sender, EventArgs e)
        {
            fillInfo();
        }

        private void fillInfo()
        {
            lbl_easy_qty.Text = exam.EasyQty.ToString();
            lbl_hard_qty.Text = exam.HardQty.ToString();
            int normal = exam.Subject.TotalQuestion - (exam.EasyQty + exam.HardQty);
            lbl_normal_qty.Text = normal.ToString();
            //
            lbl_exam_name.Text = exam.Name;
            lbl_subject_name.Text = exam.Subject.Name;
            lbl_total_question.Text = exam.Subject.TotalQuestion.ToString();
            lbl_duration.Text = exam.Subject.Duration.ToString();
            lbl_student_count.Text = exam.StudentCount.ToString();

        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            new FrmExamSheet(exam).ShowDialog();
        }
    }
}
