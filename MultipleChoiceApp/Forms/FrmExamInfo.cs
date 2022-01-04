using MultipleChoiceApp.Bi.Exam;
using MultipleChoiceApp.Bi.Student;
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
        List<Exam> examList;
        ExamServiceSoapClient examS = new ExamServiceSoapClient();
        StudentServiceSoapClient studentS = new StudentServiceSoapClient();
        public FrmExamInfo(IAdminUserControl parent)
        {
            InitializeComponent();
            //
            Rectangle screen = Screen.FromControl(this).Bounds;
            Width = Convert.ToInt32(screen.Width * 0.6);
            Height = screen.Height -50;
            CenterToScreen();

        }

        private void FrmExamInfo_Load(object sender, EventArgs e)
        {
            refreshExamList();
            if (examList.Count > 0) gv_exam.Rows[0].Selected = true;
            refreshStudentInExamList();
        }

        private void refreshLists()
        {
            refreshExamList();
            refreshStudentInExamList();
        }

        private void refreshExamList()
        {
            examList = examS.getAllBetweenDate(new DateTime(2021, 01, 01), new DateTime(2022, 12, 31));

            gv_exam.Rows.Clear();
            foreach (var item in examList)
            {
                gv_exam.Rows.Add(new object[] {
                    item.Id, item.Name, item.Subject.Name,
                    item.StudentCount,  item.StartAt, item.Subject.Duration
                });
            }
        }
        private void refreshStudentInExamList()
        {
            int id = getSelectedExamId();
            if (id > 0)
            {
                List<Student> list = studentS.getStudentInExam(id);
                gv_student_in_exam.Rows.Clear();
                foreach (var item in list)
                {
                    String examStatus = item.ExamStatus == 0 ? "Not Taken" : "Taken";
                    gv_student_in_exam.Rows.Add(new object[] {
                     item.Code, item.FullName,
                    item.DOB,  item.Major, examStatus
                });
                }
            }
        }
        private int getSelectedExamId()
        {
            try
            {
                return Util.parseToInt(gv_exam.SelectedRows[0].Cells[0].Value.ToString(), -1);
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        private void gv_student_in_exam_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            //(sender as DataGridView).Rows[e.Row.Index].Cells[0].Value = e.Row.Index + 1;
        }

        private void gv_exam_SelectionChanged(object sender, EventArgs e)
        {
            refreshStudentInExamList();
        }
    }
}
