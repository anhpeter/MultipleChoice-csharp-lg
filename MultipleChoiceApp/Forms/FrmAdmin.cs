using Bunifu.Framework.UI;
using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.Common.UtilForms;
using MultipleChoiceApp.Forms;
using MultipleChoiceApp.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleChoiceApp
{
    public partial class FrmAdmin : Form
    {
        Dictionary<String, Bitmap> iconDict = new Dictionary<string, Bitmap>();
        public FrmAdmin()
        {
            InitializeComponent();
            iconDict.Add("Questions", Properties.Resources.Questions);
            iconDict.Add("Questions_active", Properties.Resources.Question_active);
            iconDict.Add("Subjects", Properties.Resources.Subjects);
            iconDict.Add("Subjects_active", Properties.Resources.Subjects_active);
            iconDict.Add("Students", Properties.Resources.Students);
            iconDict.Add("Students_active", Properties.Resources.Students_active);
            iconDict.Add("Managers", Properties.Resources.Managers);
            iconDict.Add("Managers_active", Properties.Resources.Managers_active);
            iconDict.Add("Results", Properties.Resources.Results);
            iconDict.Add("Results_active", Properties.Resources.Results_active);
            iconDict.Add("Exams", Properties.Resources.Exams);
            iconDict.Add("Exams_active", Properties.Resources.Exams_active);
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            changeControl(new QuestionControl(), "Questions");
            FormHelper.MakeFullScreen(this);
            lbl_id.Text = Auth.getIntace().manager.FullName;
        }

        private void btn_questions_Click(object sender, EventArgs e)
        {
            changeControl(new QuestionControl(), "Questions");
        }

        private void btn_subject_Click(object sender, EventArgs e)
        {
            changeControl(new SubjectControl(), "Subjects");
        }

        // HELPER METHODS
        private void changeControl(UserControl control, String title)
        {
            foreach (BunifuFlatButton c in pnl_nav.Controls)
            {
                if (c.Tag.Equals(title))
                {
                    c.Textcolor = Color.DodgerBlue;
                    c.Iconimage = iconDict[c.Tag.ToString() + "_active"];
                }
                else
                {
                    c.Textcolor = Color.DimGray;
                    try
                    {
                        c.Iconimage = iconDict[c.Tag.ToString()];
                    }
                    catch (Exception ex) { }
                }
            }
            control.Dock = DockStyle.Fill;
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(control);
            lbl_title.Text = title;
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            changeControl(new StudentControl(), "Students");
        }

        private void btn_manager_Click(object sender, EventArgs e)
        {
            changeControl(new ManagerControl(), "Managers");
        }

        private void btn_exam_Click(object sender, EventArgs e)
        {
            changeControl(new ExamControl(), "Exams");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            FormHelper.replaceForm(this, new FrmLogin());
        }

        private void btn_result_Click(object sender, EventArgs e)
        {

            changeControl(new ResultControl(), "Results");
        }
    }
}
