using MultipleChoiceApp.Bi.Exam;
using MultipleChoiceApp.ModelHelpers;
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
        List<ExamData> examDatas;
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
            new FrmExamSheet(examDatas).ShowDialog();
        }

        private void btn_gen_Click(object sender, EventArgs e)
        {

            examDatas = new List<ExamData>();
            for (int i = 0; i < exam.StudentCount; i++)
            {
                ExamSheet examSheet = ExamHelper.genExamSheet(exam);
                examSheet.SheetCode = i + 1;
                List<QuestionInExamSheet> questionInExamSheets = ExamHelper.genQuestionInExamList(exam);
                examDatas.Add(new ExamData()
                {
                    ExamSheet = examSheet,
                    QuestionInExamSheets = questionInExamSheets
                });
            }
            //
            MessageBox.Show($"Generated {exam.StudentCount} exam sheets");
            btn_preview.Enabled = true;
            btn_print_to_files.Enabled = true;
        }

        private void btn_print_to_files_Click(object sender, EventArgs e)
        {

        }
    }
}
