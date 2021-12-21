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
    public partial class StudentsControl : UserControl
    {
        Exam exam;
        public StudentsControl(Exam exam)
        {
            InitializeComponent();
            this.exam = exam;
        }

        private void SummaryControl_Load(object sender, EventArgs e)
        {
        }
    }
}
