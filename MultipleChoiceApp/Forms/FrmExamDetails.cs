using MultipleChoiceApp.Bi.Exam;
using MultipleChoiceApp.Bi.Student;
using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.ModelHelpers;
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
        List<Student> studentListDefault;
        List<Student> studentInExamListDefault;
        List<Student> studentList;
        List<Student> studentInExamList;
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
            refreshStudentList(null);
            refreshStudentInExamList(null);
        }

        private void refreshLists(List<Student> studentList, List<Student> studentInExamList)
        {
            refreshStudentList(studentList);
            refreshStudentInExamList(studentInExamList);
        }

        private void refreshStudentList(List<Student> list)
        {
            if (list == null)
            {
                studentList = studentS.getStudentsNotInExam(exam.Id);
                studentListDefault = studentList;
            }
            else
            {
                studentList = list;
            }
            refreshGridView(gv_students, studentList);
        }
        private void refreshStudentInExamList(List<Student> list)
        {
            if (list == null)
            {
                studentInExamList = studentS.getStudentInExam(exam.Id);
                studentInExamListDefault = studentInExamList;
            }
            else
            {
                studentInExamList = list;
            }
            refreshGridView(gv_students_in_exam, studentInExamList);
        }

        private void refreshGridView(DataGridView gv, List<Student> list)
        {
            list = list.OrderBy(x => x.FullName).ToList();
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
            List<int> studentInExamIdsDefault = getIds(studentS.getStudentInExam(exam.Id));
            List<int> studentInExamIds = getIds(studentInExamList);
            List<int> removedIds = studentInExamIdsDefault.Except(studentInExamIds).ToList();
            List<int> addedIds = studentInExamIds.Except(studentInExamIdsDefault).ToList();
            int changesRows = 0;
            if (removedIds.Count > 0)
            {
                studentS.removeStudentsFromExam(StudentHelper.toArrayOfInt(removedIds), exam.Id);
                changesRows = removedIds.Count;
            }
            if (addedIds.Count > 0)
            {
                studentS.addStudentsToExam(StudentHelper.toArrayOfInt(addedIds), exam.Id);
                changesRows = addedIds.Count;
            }
            if (changesRows > 0)
            {
                MessageBox.Show($"Changes saved ({changesRows})");
            }
        }

        // MAP ACTIONS
        private void btn_all_student_exam_Click(object sender, EventArgs e)
        {
            if (studentList.Count > 0)
            {
                studentInExamList = studentInExamList.Concat(studentList).ToList();
                studentList.Clear();
                refreshLists(studentList, studentInExamList);
            }
            else
            {
                MessageBox.Show("No students selected");
            }
        }
        private void btn_all_exam_student_Click(object sender, EventArgs e)
        {
            if (studentInExamList.Count > 0)
            {
                studentList = studentList.Concat(studentInExamList).ToList();
                studentInExamList.Clear();
                refreshLists(studentList, studentInExamList);
            }
            else
            {
                MessageBox.Show("No students selected");
            }
        }
        private void btn_selected_student_exam_Click(object sender, EventArgs e)
        {
            List<int> ids = new List<int>();
            foreach (DataGridViewRow selectedRow in gv_students.SelectedRows)
            {
                ids.Add(getIdByRowIndex(selectedRow.Index, gv_students));
            }
            List<Student> selectedStudents = getStudentListByIds(studentList, ids);
            if (selectedStudents.Count > 0)
            {
                studentInExamList = studentInExamList.Concat(selectedStudents).ToList();
                studentList = studentList.Where(x => !ids.Contains(x.Id)).ToList();
                refreshLists(studentList, studentInExamList);
            }
            else
            {
                MessageBox.Show("No student selected");
            }
        }

        private void btn_selected_exam_student_Click(object sender, EventArgs e)
        {
            List<int> ids = new List<int>();
            foreach (DataGridViewRow selectedRow in gv_students_in_exam.SelectedRows)
            {
                ids.Add(getIdByRowIndex(selectedRow.Index, gv_students_in_exam));
            }
            List<Student> selectedStudents = getStudentListByIds(studentInExamList, ids);
            if (selectedStudents.Count > 0)
            {
                studentList = studentList.Concat(selectedStudents).ToList();
                studentInExamList = studentInExamList.Where(x => !ids.Contains(x.Id)).ToList();
                refreshLists(studentList, studentInExamList);
            }
            else
            {
                MessageBox.Show("No student selected");
            }
        }

        private List<Student> getStudentListByIds(List<Student> list, List<int> ids)
        {
            return list.Where(x => ids.Contains(x.Id)).ToList();
        }


        // HELPER METHODS
        private List<int> getIds(List<Student> list)
        {
            return list.Select(x => x.Id).ToList();
        }

        private int getIdByRowIndex(int rowIndex, DataGridView gv)
        {
            try
            {
                return Util.parseToInt(gv.Rows[rowIndex].Cells[0].Value.ToString(), -1);
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        private void FrmExamDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            int changesRows = getChangesRows();
            if (changesRows > 0)
            {
                MessageBox.Show("Your changes not saved yet. Do you want to exit?");
            }
        }
        private int getChangesRows()
        {
            List<int> studentInExamIdsDefault = getIds(studentS.getStudentInExam(exam.Id));
            List<int> studentInExamIds = getIds(studentInExamList);
            List<int> removedIds = studentInExamIdsDefault.Except(studentInExamIds).ToList();
            List<int> addedIds = studentInExamIds.Except(studentInExamIdsDefault).ToList();
            int changesRows = 0;
            if (removedIds.Count > 0)
            {
                changesRows = removedIds.Count;
            }
            if (addedIds.Count > 0)
            {
                changesRows = addedIds.Count;
            }
            return changesRows;
        }
    }
}
