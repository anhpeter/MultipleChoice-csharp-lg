using LiveCharts;
using LiveCharts.Wpf;
using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.Forms;
using MultipleChoiceApp.Bi.Exam;
using MultipleChoiceApp.Bi.StudentResult;
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
        private bool loaded = false;
        StudentResultServiceSoapClient studentResultS = new StudentResultServiceSoapClient();
        Bi.Exam.Exam exam;
        List<StudentResult> studentResultList;
        public StudentsControl(Bi.Exam.Exam exam)
        {
            InitializeComponent();
            this.exam = exam;
        }


        private void StudentsControl_Load(object sender, EventArgs e)
        {
            refreshList();
            loaded = true;
        }

        private void refreshList()
        {
            List<StudentResult> list = studentResultS.getAllByExamId(exam.Id);
            studentResultList = list;
            refreshList(list);
        }

        private void refreshList(List<StudentResult> list)
        {
            gv_main.Rows.Clear();
            foreach (var item in list)
            {
                gv_main.Rows.Add(new object[] {
                    item.Student.Id, item.Student.Code, item.Student.FullName,
                    item.Rank, item.UnansweredCount, item.Points, item.CreatedAt
                });
            }
            //handlePagination();
        }

        private void gv_main_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private int getSelectedId()
        {
            try
            {
                return Util.parseToInt(gv_main.SelectedRows[0].Cells[0].Value.ToString(), -1);
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        private void gv_main_SelectionChanged(object sender, EventArgs e)
        {
            if (loaded)
            {
                int id = Util.parseToInt(gv_main.SelectedRows[0].Cells[0].Value.ToString());
                StudentResult selectedItem = studentResultList.Where(x => x.StudentId == id).FirstOrDefault();
                FrmStudentResponse frm = new FrmStudentResponse(exam, selectedItem, studentResultList.Count);
                frm.ShowDialog();
            }
        }
    }
}
