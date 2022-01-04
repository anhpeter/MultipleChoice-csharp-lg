using MultipleChoiceApp.Bi.Exam;
using MultipleChoiceApp.Bi.StudentResult;
using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.Common.Interfaces;
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
    public partial class FrmExamInfo : Form
    {
        ExamServiceSoapClient examS = new ExamServiceSoapClient();
        StudentResultServiceSoapClient studentResultS = new StudentResultServiceSoapClient();
        public FrmExamInfo(IAdminUserControl parent, Exam exam)
        {
            InitializeComponent();
            //
            FormHelper.setFormSizeRatioOfScreen(this, 0.6);
            CenterToScreen();

        }

        private void FrmExamInfo_Load(object sender, EventArgs e)
        {
            refreshExamList();
        }

        private void refreshLists()
        {
            refreshExamList();
            refreshStudentInExamList();
        }

        private void refreshExamList()
        {
        }
        private void refreshStudentInExamList()
        {

        }
    }
}
