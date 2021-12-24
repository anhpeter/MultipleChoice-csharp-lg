using LiveCharts;
using LiveCharts.Wpf;
using MultipleChoiceApp.BLL;
using MultipleChoiceApp.Models;
using MultipleChoiceApp.UserControls.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MultipleChoiceApp.UserControls.ExamReportControls
{
    public partial class SummaryControl : UserControl
    {
        ExamBUS examBUS = new ExamBUS();
        ExamOverview exOverview;
        Exam exam;
        public SummaryControl(Exam exam)
        {
            InitializeComponent();
            this.exam = exam;
            exOverview = examBUS.getExamOverviewById(exam.Id);
        }

        private void SummaryControl_Load(object sender, EventArgs e)
        {
            fillInfo();
        }

        private void fillInfo()
        {
            CorrectChartControl control = new CorrectChartControl(exOverview.AveragePoints, true);
            control.Dock = DockStyle.Fill;
            pnl_correct_chart.Controls.Add(control);
            lbl_student_count.Text = exOverview.TakenStudentCount.ToString();
            lbl_total_question.Text = exOverview.TotalQuestion.ToString();
            lbl_duration.Text = exOverview.Duration.ToString();
        }
    }
}
