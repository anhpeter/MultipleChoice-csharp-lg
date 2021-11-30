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
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            FrmExamStart startFrm = new FrmExamStart();
            startFrm.Show();
            this.Hide();
        }
    }
}
