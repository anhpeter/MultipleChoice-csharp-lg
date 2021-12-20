using LiveCharts;
using LiveCharts.Wpf;
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
        Exam exam;
        public SummaryControl(Exam exam)
        {
            InitializeComponent();
            this.exam = exam;
        }

        private void SummaryControl_Load(object sender, EventArgs e)
        {
            CorrectChartControl control = new CorrectChartControl(55, 45, true);
            control.Dock = DockStyle.Fill;
            pnl_correct_chart.Controls.Add(control);
        }
    }
}
