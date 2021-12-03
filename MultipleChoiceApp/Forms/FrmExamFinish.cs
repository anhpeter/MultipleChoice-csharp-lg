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
    public partial class FrmExamFinish : Form
    {
        public FrmExamFinish()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            FormHelper.replaceForm(this, new FrmExamStart());
        }
    }
}
