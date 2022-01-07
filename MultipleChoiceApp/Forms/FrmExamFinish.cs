using MultipleChoiceApp.Bi.StudentResult;
using MultipleChoiceApp.Common.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleChoiceApp.Forms
{
    public partial class FrmExamFinish : Form
    {

        StudentResult studentResult;

        public FrmExamFinish(StudentResult studentResult)
        {
            this.studentResult = studentResult;
            InitializeComponent();
            CenterToScreen();
            fillResultInfo();
        }

        private void fillResultInfo()
        {
            lbl_name.Text = studentResult.Exam.Name;
            lbl_correct_qty.Text = studentResult.CorrectAnswerCount + "";
            lbl_incorrect_qty.Text = studentResult.IncorrectAnswerCount + "";
            lbl_mark.Text = studentResult.Points+"";
        }
        private void btn_done_Click(object sender, EventArgs e)
        {
            FormHelper.replaceForm(this, new FrmExamStart());
        }

    }
}
