using MultipleChoiceApp.Bi.Exam;
using MultipleChoiceApp.Bi.Student;
using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.Common.Interfaces;
using MultipleChoiceApp.Forms.Utils;
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
            Height = screen.Height - 50;
            CenterToScreen();

        }

        private void FrmExamInfo_Load(object sender, EventArgs e)
        {
            setupInterface();
            refreshLists();
        }

        private void setupInterface()
        {
            datepicker_from.CustomFormat = "dd/MM/yyyy";
            datepicker_from.Text = DateTime.Now.AddMonths(-1).ToString();
            datepicker_to.CustomFormat = "dd/MM/yyyy";
            datepicker_to.Text = DateTime.Now.ToString();
        }

        private void refreshLists()
        {
            refreshExamList();
            refreshStudentInExamList();
        }

        private void refreshExamList()
        {
            DateTime from = Convert.ToDateTime(datepicker_from.Value.ToString());
            DateTime to = Convert.ToDateTime(datepicker_to.Value.ToString());
            examList = examS.getAllBetweenDate(from, to);

            gv_exam.Rows.Clear();
            foreach (var item in examList)
            {
                gv_exam.Rows.Add(new object[] {
                    item.Id, item.Name, item.Subject.Name,
                    item.StudentCount,item.Subject.Duration,  item.StartAt,item.EndAt,
                });
            }
            if (examList.Count > 0) gv_exam.Rows[0].Selected = true;
        }
        private void refreshStudentInExamList()
        {
            if (examList.Count > 0)
            {
                int id = getSelectedExamId();
                if (id > 0)
                {
                    List<Student> list = studentS.getStudentInExam(id);
                    gv_student_in_exam.Rows.Clear();
                    int i = 0;
                    foreach (var item in list)
                    {
                        String examStatus = item.ExamStatus == 0 ? "Not Taken" : "Taken";
                        gv_student_in_exam.Rows.Add(
                            new object[] {
                         1, item.Code, item.FullName,
                        item.DOB,  item.Major, examStatus
                        });
                        if (item.ExamStatus == 1)
                        {
                            gv_student_in_exam.Rows[i].Cells[5].Style.ForeColor = Color.Green;
                        }
                        i++;
                    }
                }
            }
            else
            {
                gv_student_in_exam.Rows.Clear();
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


        private void gv_exam_SelectionChanged(object sender, EventArgs e)
        {
            refreshStudentInExamList();
        }


        private void gv_student_in_exam_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            gv_student_in_exam.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refreshLists();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_gen_sheets_Click(object sender, EventArgs e)
        {
            int id = getSelectedExamId();
            if (id > 0)
            {
                Exam exam = examList.Where(x => x.Id == id).SingleOrDefault();
                new FrmGenExamSheets(exam).ShowDialog();
            }
        }
    }
}
