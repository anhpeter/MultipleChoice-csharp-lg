using Bunifu.Framework.UI;
using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.UserControls.ExamReportControls;
using MultipleChoiceApp.Bi.Exam;
using System;
using System.Windows.Forms;

namespace MultipleChoiceApp.Forms
{
    public partial class FrmExamReport : Form
    {

        Exam exam;
        public FrmExamReport(Exam exam)
        {
            InitializeComponent();
            FormHelper.setFormSizeRatioOfScreen(this, 0.85);
            CenterToScreen();
            this.exam = exam;
        }
        // EVENTS
        private void FrmExamReport_Load(object sender, EventArgs e)
        {
            btn_tab_Click(btn_summary, EventArgs.Empty);
            fillInfo();
        }

        private void fillInfo()
        {
            lbl_exam_name.Text = exam.Name;
        }

        public void btn_tab_Click(object sender, EventArgs e)
        {
            BunifuFlatButton clickedButton = (BunifuFlatButton)sender;
            String tag = clickedButton.Tag.ToString();

            FormHelper.changeTabButtonLooks(pnl_tabs, tag);

            UserControl control = null;
            switch (tag)
            {
                case "Summary":
                    control = new SummaryControl(exam);
                    break;
                case "Students":
                    control = new StudentsControl(exam);
                    break;
                case "Questions":
                    control = new QuestionsControl(exam, pnl_content.Width);
                    break;
            }
            if (control != null)
            {
                control.Dock = DockStyle.Fill;
                pnl_content.Controls.Clear();
                pnl_content.Controls.Add(control);
            }
        }


    }
}
