using MultipleChoiceApp.BLL;
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
    public partial class FrmLogin : Form
    {
        ManagerBUS managerBUS = new ManagerBUS();
        StudentBUS studentBUS = new StudentBUS();
        public FrmLogin()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String password = txt_password.Text.ToString();
            String id = txt_id.Text.ToString();
            if (rdo_manager.Checked)
            {
                handleManagerLogin(id, password);
            }
            else
            {
                handleStudentLogin(id, password);
            }
        }
        private void handleManagerLogin(String id, String password)
        {
            password = Util.md5(password);
            User item = managerBUS.getByCodeAndPassword(id, password);
            if (item != null)
            {
                Auth.getIntace().user = item;
                FormHelper.replaceForm(this, new FrmAdmin());
            }
            else
            {
                MessageBox.Show("Your credentials is invalid!");
            }
        }
        private void handleStudentLogin(String id, String password)
        {
            password = Util.md5(password);
            User item = studentBUS.getByCodeAndPassword(id, password);
            if (item != null)
            {
                Auth.getIntace().user = item;
                FormHelper.replaceForm(this, new FrmExamStart());
            }
            else
            {
                MessageBox.Show("Your credentials is invalid!");
            }
        }
    }

}
