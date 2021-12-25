using MultipleChoiceApp.Bi.Question;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleChoiceApp.UserControls.Utilities
{
    public partial class QuestionStatistic : UserControl
    {
        Question question;
        int no;
        int progressWidth = 195;
        public QuestionStatistic(Question question, int no)
        {
            InitializeComponent();
            this.question = question;
            this.no = no;
        }

        private void QuestionStatistic_Load(object sender, EventArgs e)
        {
            lbl_question.Text = $"{no}. {question.Content}";
            lbl_opt_1.Text = $"A. {question.Answers[0].Content}";
            lbl_opt_2.Text = $"B. {question.Answers[1].Content}";
            lbl_opt_3.Text = $"C. {question.Answers[2].Content}";
            lbl_opt_4.Text = $"D. {question.Answers[3].Content}";

            Label[] countLabels = new Label[] { lbl_opt_count_1, lbl_opt_count_2, lbl_opt_count_3, lbl_opt_count_4 };
            PictureBox[] icons = new PictureBox[] { icon_opt_1, icon_opt_2, icon_opt_3, icon_opt_4 };
            PictureBox[] progresses = new PictureBox[] { progress_opt_1, progress_opt_2, progress_opt_3, progress_opt_4 };

            for (int i = 0; i < 4; i++)
            {
                // PROGRESS
                PictureBox progress = progresses[i];
                Double correctPerent = (double)question.Answers[i].AnswerCount / question.QuestionInExamCount;
                progress.Width = Convert.ToInt32(correctPerent * progressWidth); ;
                if (i + 1 == question.CorrectAnswerNo)
                {
                    progress.BackColor = Color.Green;
                }
                else
                {
                    progress.BackColor = Color.Red;
                }

                // ICON ===
                PictureBox icon = icons[i];
                if (i + 1 == question.CorrectAnswerNo)
                {
                    icon.Image = Properties.Resources.correct;
                }
                else
                {
                    icon.Image = Properties.Resources.incorrect;
                }

                // COUNT
                Label l = countLabels[i];
                l.Text = question.Answers[i].AnswerCount + "";
            }

            // CHART
            int correct = question.Answers[question.CorrectAnswerNo - 1].AnswerCount;
            int incorrect = question.QuestionInExamCount - correct;
            int percent = Convert.ToInt32((double)correct / question.QuestionInExamCount*100);
            lbl_percent.Text = $"{percent}%";
            CorrectChartControl chart = new CorrectChartControl(correct, incorrect, false, false);
            chart.Dock = DockStyle.Fill;
            pnl_chart.Controls.Add(chart);
        }
    }
}
