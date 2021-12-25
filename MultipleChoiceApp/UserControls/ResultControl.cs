using Bunifu.Framework.UI;
using FluentValidation.Results;
using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.Common.Interfaces;
using MultipleChoiceApp.Common.Validators;
using MultipleChoiceApp.Forms;
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

namespace MultipleChoiceApp.UserControls
{
    public partial class ResultControl : UserControl
    {
        public ResultControl(Form form)
        {
            InitializeComponent();
        }
        private void ResultControl_Load(object sender, EventArgs e)
        {
            btn_tab_Click(btn_student, EventArgs.Empty);
        }

        public void btn_tab_Click(object sender, EventArgs e)
        {
            BunifuFlatButton clickedButton = (BunifuFlatButton)sender;
            String tag = clickedButton.Tag.ToString();

            Util.log("TAG: "+tag);
            FormHelper.changeTabButtonLooks(pnl_tabs, tag);
            UserControl control = null;
            switch (tag)
            {
                case "Students":
                    control = new StudentResultControl();
                    break;
                case "Exams":
                    control = new ExamResultControl();
                    break;
            }
            if (control != null)
            {
                control.Dock = DockStyle.Fill;
                pnl_content.Controls.Clear();
                pnl_content.Controls.Add(control);
            }
        }

    }
}
