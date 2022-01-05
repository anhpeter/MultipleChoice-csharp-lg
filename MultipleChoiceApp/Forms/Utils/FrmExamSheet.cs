using Microsoft.Reporting.WinForms;
using MultipleChoiceApp.Bi.Exam;
using MultipleChoiceApp.Bi.Question;
using MultipleChoiceApp.Bi.StudentResult;
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
    public partial class FrmExamSheet : Form
    {

        List<ExamData> examDatas;
        int examDataIndex = 0;
        public FrmExamSheet(List<ExamData> examDatas)
        {
            InitializeComponent();
            //
            Rectangle screen = Screen.FromControl(this).Bounds;
            Width = Convert.ToInt32(screen.Width * 0.6);
            Height = screen.Height - 50;
            CenterToScreen();
            this.examDatas = examDatas;
        }

        private void FrmExamSheet_Load(object sender, EventArgs e)
        {
            loadReportData(examDatas[0]);
            handlePagiButtonStyle();

        }
        private void loadReportData(ExamData examData)
        {
            txt_sheet_code.Text = (examDataIndex + 1).ToString();
            List<ExamSheet> examSheets = new List<ExamSheet>()
            {
                examData.ExamSheet
            };

            ReportDataSource examSheetDS = new ReportDataSource("ExamSheet", examSheets);
            ReportDataSource questionInExamSheetDS = new ReportDataSource("QuestionInExamSheet", examData.QuestionInExamSheets);
            report.Reset();
            report.LocalReport.DataSources.Clear();
            report.LocalReport.ReportPath = @"E:\public\projects\HSU\software_app_dev\MultipleChoiceApp\MultipleChoiceApp\Reports\ExamSheet.rdlc";
            report.LocalReport.DataSources.Add(examSheetDS);
            report.LocalReport.DataSources.Add(questionInExamSheetDS);
            report.RefreshReport();
        }


        private void btn_prev_Click(object sender, EventArgs e)
        {
            examDataIndex--;
            loadReportData(examDatas[examDataIndex]);
            handlePagiButtonStyle();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            examDataIndex++;
            loadReportData(examDatas[examDataIndex]);
            handlePagiButtonStyle();
        }

        private void handlePagiButtonStyle()
        {
            if (examDataIndex == examDatas.Count - 1)
            {
                btn_prev.Enabled = true;
                btn_first.Enabled = true;
                btn_next.Enabled = false;
                btn_last.Enabled = false;
            }
            else if (examDataIndex == 0)
            {
                btn_prev.Enabled = false;
                btn_first.Enabled = false;
                btn_next.Enabled = true;
                btn_last.Enabled = true;
            }
            else
            {
                btn_prev.Enabled = true;
                btn_first.Enabled = true;
                btn_next.Enabled = true;
                btn_last.Enabled = true;
            }
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            examDataIndex = examDatas.Count - 1;
            loadReportData(examDatas[examDataIndex]);
            handlePagiButtonStyle();
        }

        private void btn_first_Click(object sender, EventArgs e)
        {

            examDataIndex = 0;
            loadReportData(examDatas[examDataIndex]);
            handlePagiButtonStyle();
        }
    }
}
