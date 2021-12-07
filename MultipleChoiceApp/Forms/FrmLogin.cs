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
            txt_message.Visible = false;
            txt_id.Text = "2180617";
            txt_password.Text = "loveguitar";
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
            Manager item = managerBUS.getByCodeAndPassword(id, password);
            if (item != null)
            {
                Auth.getIntace().manager = item;
                FormHelper.replaceForm(this, new FrmAdmin());
            }
            else
            {
                clearForm();
                showMessage("Your credentials is invalid!");
            }
        }
        private void handleStudentLogin(String id, String password)
        {
            password = Util.md5(password);
            Student item = studentBUS.getByCodeAndPassword(id, password);
            if (item != null)
            {
                Auth.getIntace().student = item;
                FormHelper.replaceForm(this, new FrmExamStart());
            }
            else
            {
                clearForm();
                showMessage("Your credentials is invalid!");
            }
        }

        private void clearForm()
        {
            //txt_id.Text = "";
            txt_password.Text = "";
        }
        private void showMessage(String message)
        {
            txt_message.Text = message;
            txt_message.Visible = true;
        }
    }

}
