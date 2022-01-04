using MultipleChoiceApp.Bi.Exam;
using MultipleChoiceApp.Bi.Student;
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
    public partial class FrmExamDetails : Form
    {
        Exam exam;
        StudentServiceSoapClient studentS = new StudentServiceSoapClient();
        public FrmExamDetails(Exam exam)
        {
            InitializeComponent();

            this.exam = exam;
            FormHelper.setFormSizeRatioOfScreen(this, 0.8);
            CenterToScreen();
        }

        private void FrmExamDetails_Load(object sender, EventArgs e)
        {

            setupInterface();
            fillInfo();
            refreshLists();
        }

        private void refreshLists()
        {
            refreshStudentList();
            refreshStudentInExamList();
        }

        private void refreshStudentList()
        {
            List<Student> list = studentS.getStudentsNotInExam(exam.Id);
            refreshGridView(gv_students, list);
        }
        private void refreshStudentInExamList()
        {
            List<Student> list = studentS.getStudentInExam(exam.Id);
            refreshGridView(gv_students_in_exam, list);
        }

        private void refreshGridView(DataGridView gv, List<Student> list)
        {
            gv.Rows.Clear();
            foreach (var item in list)
            {
                gv.Rows.Add(new object[] {
                    item.Id, item.Code, item.FullName, item.Major
                });
            }
        }
        //

        private void fillInfo()
        {
            lbl_exam_name.Text = exam.Name;
            lbl_semester.Text = exam.Semester.ToString();
            lbl_subject.Text = exam.Subject.Name;
            lbl_start_at.Text = Util.toMediumDateStr(exam.StartAt);
        }

        private void setupInterface()
        {
            foreach (var control in pnl_map.Controls)
            {
                if (control is Button)
                {
                    Button btn = (Button)control;
                    btn.Width = pnl_map.Width;
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved");
        }

    }
}
