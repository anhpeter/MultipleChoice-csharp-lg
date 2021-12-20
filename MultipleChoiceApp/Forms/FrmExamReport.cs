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
    public partial class FrmExamReport : Form
    {

        Exam exam;
        public FrmExamReport(Exam exam)
        {
            InitializeComponent();
            //
            this.exam = exam;
            FormHelper.setformSizeRatioOfScreen(this, 0.85);
            CenterToScreen();
        }
    }
}
