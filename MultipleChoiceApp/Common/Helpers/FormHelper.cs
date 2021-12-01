using MultipleChoiceApp.Common.UtilForms;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Top = 0;
            frm.Left = 0;
            frm.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height - 8);
        }

        public static void notify(String msg)
        {
            Alert alert = new Alert(msg);
            alert.Show();
        }
    }
}
