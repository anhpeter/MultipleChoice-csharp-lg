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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (rdo_manager.Checked)
            {
            FrmAdmin adminFrm = new FrmAdmin();
            adminFrm.Show();
            }
            else
            {
                FrmExamStart examStartFrm = new FrmExamStart();
                examStartFrm.Show();
            }
            this.Hide();
        }
    }
}
