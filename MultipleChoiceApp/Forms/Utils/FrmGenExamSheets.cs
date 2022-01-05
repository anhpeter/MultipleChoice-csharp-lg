using Microsoft.Reporting.WinForms;
using MultipleChoiceApp.Bi.Exam;
using MultipleChoiceApp.ModelHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog.SelectedPath;
                // ...
                string deviceInfo = "";
                string[] streamIds;
                Warning[] warnings;

                string mimeType = string.Empty;
                string encoding = string.Empty;
                string extension = string.Empty;

                ReportViewer viewer = new ReportViewer();
                viewer.ProcessingMode = ProcessingMode.Local;
                viewer.LocalReport.ReportPath = @"E:\public\projects\HSU\software_app_dev\MultipleChoiceApp\MultipleChoiceApp\Reports\ExamSheet.rdlc";
                //
                List<ExamSheet> examSheets = new List<ExamSheet>()
                {
                    examDatas[0].ExamSheet
                };

                ReportDataSource examSheetDS = new ReportDataSource("ExamSheet", examSheets);
                ReportDataSource questionInExamSheetDS = new ReportDataSource("QuestionInExamSheet", examDatas[0].QuestionInExamSheets);
                viewer.LocalReport.DataSources.Add(examSheetDS);
                viewer.LocalReport.DataSources.Add(questionInExamSheetDS);
                viewer.RefreshReport();
                var bytes = viewer.LocalReport.Render("PDF", deviceInfo, out mimeType, out encoding,
                    out extension, out streamIds, out warnings);
                string filename = string.Format(@"{0}\{1}", folderPath, "sheet1.pdf");
                File.WriteAllBytes(filename, bytes);
                //System.Diagnostics.Process.Start(filename);
                MessageBox.Show("Generated word files");
            }
        }
    }
}
