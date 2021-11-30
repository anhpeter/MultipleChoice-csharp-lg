﻿using MultipleChoiceApp.Common.Helpers;
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
    public partial class FrmTakingExam : Form
    {
        public FrmTakingExam()
        {
            InitializeComponent();
            FormHelper.MakeFullScreen(this);
        }

        private void pnl_answer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            FrmExamFinish frm = new FrmExamFinish();
            frm.Show();
            this.Hide();
        }
    }
}
