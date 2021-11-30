using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleChoiceApp.Common.Helpers
{
    class FormHelper
    {
        public static void MakeFullScreen(Form frm)
        {
            frm.TopMost = true;
            frm.WindowState = FormWindowState.Maximized;
        }
    }
}
