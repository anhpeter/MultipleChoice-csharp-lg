using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleChoiceApp.Common.UtilForms
{
    public partial class FormErrorMessages : Form
    {

        String msg;
        public FormErrorMessages(String msg)
        {
            InitializeComponent();
            this.msg = msg;
        }


        private void FormErrorMessages_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            lbl_msg.Text = msg;
        }

        private void btn_close2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
