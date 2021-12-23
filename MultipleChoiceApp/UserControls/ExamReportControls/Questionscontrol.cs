using LiveCharts;
using LiveCharts.Wpf;
using MultipleChoiceApp.BLL;
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
    public partial class QuestionsControl : UserControl
    {
        ExamBUS examBUS = new ExamBUS();
        QuestionBUS questionBUS = new QuestionBUS();
        ExamOverview exOverview;
        Exam exam;
        int containerWidth;
        List<Question> questionList;
        public QuestionsControl(Exam exam, int containerWidth)
        {
            InitializeComponent();
            this.containerWidth = containerWidth;
            this.exam = exam;
            exOverview = examBUS.getExamOverviewById(exam.Id);
            questionList = questionBUS.getAllWithAnswerCountByExamId(exam.Id);
        }

        private void QuestionsControl_Load(object sender, EventArgs e)
        {
            pnl_container.Controls.Clear();
            int i = 1;
            foreach (var question in questionList)
            {
                QuestionStatistic questionStatistic = new QuestionStatistic(question, i);
                int left = (containerWidth - questionStatistic.Width) / 2;
                questionStatistic.Margin = new Padding(left, 0, 0, 20);
                pnl_container.Controls.Add(questionStatistic);
                i++;
            }
        }

    }
}
