﻿using Bunifu.Framework.UI;
using MultipleChoiceApp.BLL;
using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.Models;
using MultipleChoiceApp.UserControls.ExamReportControls;
using MultipleChoiceApp.UserControls.Utilities;
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
    public partial class FrmStudentResponse : Form
    {

        Exam exam;
        Subject subject;
        StudentResult studentResult;
        StudentResponseBUS studentResponseBUS = new StudentResponseBUS();
        StudentResultBUS studentResultBUS = new StudentResultBUS();
        SubjectBUS subjectBUS = new SubjectBUS();
        //
        int studentCount;
        public FrmStudentResponse(Exam exam, StudentResult studentResult, int studentCount)
        {
            InitializeComponent();
            FormHelper.setFormSizeRatioOfScreen(this, 0.85);
            CenterToScreen();
            this.exam = exam;
            this.studentCount = studentCount;
            this.subject = subjectBUS.getDetailsById(exam.SubjectId);
            this.studentResult = studentResult;
        }
        // EVENTS
        private void FrmStudentResponse_Load(object sender, EventArgs e)
        {
            CorrectChartControl chart = new CorrectChartControl(studentResult.Points);
            chart.Dock = DockStyle.Fill;
            pnl_chart.Controls.Add(chart);
            gv_main.Columns[1].Width = 60;
            gv_main.Columns[4].Width = 200;
            //
            lbl_fullname.Text = studentResult.Student.FullName;
            lbl_rank.Text = $"{studentResult.Rank} of {studentCount}";
            lbl_points.Text = studentResult.Points.ToString();
            int answeredCount = subject.TotalQuestion - studentResult.UnansweredCount;
            lbl_answered.Text = $"{answeredCount} of {subject.TotalQuestion}";
            lbl_code.Text = studentResult.Student.Code;
            //
            List<StudentResponse> list = studentResponseBUS.getAllByExamAndStudentId(exam.Id, studentResult.Student.Id);
            refreshList(list);
        }

        private void gv_main_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void refreshList(List<StudentResponse> list)
        {
            gv_main.Rows.Clear();
            int i = 0;
            foreach (var item in list)
            {
                String correctAns = item.Question.Answers[item.Question.CorrectAnswerNo - 1].Content;
                String answered = "No answer";
                if (item.AnswerNO > 0) answered = item.Question.Answers[item.AnswerNO - 1].Content;
                String resultStr = item.AnswerNO == item.Question.CorrectAnswerNo ? "Correct" : "Incorrect";
                gv_main.Rows.Add(new object[] {
                    item.Id, item.No, item.Question.Content,
                     answered, resultStr
                });
                gv_main.Rows[i].Cells[4].Style.ForeColor = item.AnswerNO == item.Question.CorrectAnswerNo? Color.Green : Color.Red;
                i++;
            }
        }
    }
}