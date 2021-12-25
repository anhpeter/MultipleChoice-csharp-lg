using MultipleChoiceApp.Bi.Manager;
using MultipleChoiceApp.Bi.Student;
using MultipleChoiceApp.BLL;
using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.Models;
using System;
using System.Windows.Forms;

namespace MultipleChoiceApp.Forms
{
    public partial class FrmLogin : Form
    {
        ManagerServiceSoapClient managerS = new ManagerServiceSoapClient();
        StudentServiceSoapClient studentS = new StudentServiceSoapClient();
        public FrmLogin()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txt_message.Visible = false;
            txt_id.Text = "MNG01";
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
            Bi.Manager.Manager item = managerS.getByCodeAndPassword(id, password);
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
            Bi.Student.Student item = studentS.getByCodeAndPassword(id, password);
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
