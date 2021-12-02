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
    public partial class ExamControl : UserControl
    {
        public ExamControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void ExamControl_Load(object sender, EventArgs e)
        {

            datepicker_start_at.Format = DateTimePickerFormat.Custom;
            datepicker_start_at.CustomFormat = "dd/MM/yyyy hh:mm";
            datepicker_end_at.Format = DateTimePickerFormat.Custom;
            datepicker_end_at.CustomFormat = "dd/MM/yyyy hh:mm";
        }
    }
}
