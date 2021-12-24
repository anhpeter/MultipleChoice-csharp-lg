﻿using LiveCharts;
using LiveCharts.Wpf;
using MultipleChoiceApp.BLL;
using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.Models;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace MultipleChoiceApp.UserControls.ExamReportControls
{
    public partial class QuestionsControl : UserControl
    {
        ExamBUS examBUS = new ExamBUS();
        QuestionBUS questionBUS = new QuestionBUS();
        ExamOverview exOverview;
        Exam exam;
        int containerWidth;
        List<Question> questionList;
        bool loading = false;
        int offset = 0;
        int limit = 10;
        int bottomOffset = 1000;
        public QuestionsControl(Exam exam, int containerWidth)
        {
            InitializeComponent();
            this.containerWidth = containerWidth;
            this.exam = exam;
            exOverview = examBUS.getExamOverviewById(exam.Id);
            questionList = questionBUS.getAllWithAnswerCountByExamId(exam.Id);
        }

        private void QuestionsControl_Load(object sender, EventArgs e)
        {
            pnl_container.MouseWheel += new System.Windows.Forms.MouseEventHandler(pnl_container_MouseWheel);
            pnl_container.Controls.Clear();
            render();
        }


        private void render()
        {
            int end = offset + limit > questionList.Count + 1 ? questionList.Count + 1 : offset + limit;
            for (int i = offset; i < end; i++)
            {
                Question question = questionList[i];
                QuestionStatistic questionStatistic = new QuestionStatistic(question, i + 1);
                int left = (containerWidth - questionStatistic.Width) / 2;
                questionStatistic.Margin = new Padding(left, 0, 0, 20);
                pnl_container.Controls.Add(questionStatistic);
            }
            offset = end;
        }

        private void pnl_container_Scroll(object sender, ScrollEventArgs e)
        {
            handlePanelScroll();
        }

        private void pnl_container_MouseWheel(object sender, MouseEventArgs e)
        {
            handlePanelScroll();
        }
        private void handlePanelScroll()
        {
            int scrollPos = pnl_container.VerticalScroll.Value;
            if (scrollPos >= pnl_container.VerticalScroll.Maximum - pnl_container.VerticalScroll.LargeChange + 1 - bottomOffset)
            {
                if (!loading && offset < questionList.Count)
                {
                    loading = true;
                    render();
                    loading = false;
                }
            }
        }
        private void pnl_container_MouseEnter(object sender, EventArgs e)
        {
        }
    }
}
