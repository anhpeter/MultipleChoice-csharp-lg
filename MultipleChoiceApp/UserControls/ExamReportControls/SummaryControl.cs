using LiveCharts;
using LiveCharts.Wpf;
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
            chart_correct.Series["s1"].Points.AddXY("40%", "40");
            chart_correct.Series["s1"].Points.AddXY("60%", "60");
            chart_correct.Series["s1"].Points[0].Color = Color.FromArgb(226, 27, 60);
            chart_correct.Series["s1"].Points[0].LegendText = "Correct";
            chart_correct.Series["s1"].Points[0].LabelForeColor = Color.White;
            chart_correct.Series["s1"].Points[1].Color = Color.FromArgb(38, 137, 12);
            chart_correct.Series["s1"].Points[1].LegendText = "Incorrect";
            chart_correct.Series["s1"].Points[1].LabelForeColor = Color.White;

        }
    }
}
