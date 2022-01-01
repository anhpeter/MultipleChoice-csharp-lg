using Bunifu.UI.WinForms;
using MultipleChoiceApp.Bi.Question;
using MultipleChoiceApp.UserControls.QuestionForm;
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
    public partial class FrmQuestionForm : Form
    {
        Question question;
        String answerType = "text";
        TextAnswersControl textAnswersControl;
        ImageAnswersControl imageAnswersControl;
        public FrmQuestionForm(Question question)
        {
            InitializeComponent();
            CenterToParent();
            textAnswersControl = new TextAnswersControl();
            textAnswersControl.Dock = DockStyle.Fill;
            imageAnswersControl = new ImageAnswersControl();
            imageAnswersControl.Dock = DockStyle.Fill;

        }

        private void FrmQuestionForm_Load(object sender, EventArgs e)
        {
            refreshAnswerType();
            refreshAnswerSheet();
        }


        private void refreshAnswerSheet()
        {
            pnl_answers.Controls.Clear();
            if (answerType.Equals("text")){
                pnl_answers.Controls.Add(textAnswersControl);
            }
            else
            {
                pnl_answers.Controls.Add(imageAnswersControl);
            }
        }

        private void refreshAnswerType()
        {
            foreach (var control in pnl_answer_type.Controls)
            {
                if (control is BunifuRadioButton)
                {
                    BunifuRadioButton rdoButton = (BunifuRadioButton)control;
                    String tag = rdoButton.Tag.ToString();
                    if (tag.Equals(answerType)) rdoButton.Checked = true;
                }
            }
        }

        private void rdo_answer_type_Click(object sender, EventArgs e)
        {
            String tag = ((BunifuRadioButton)sender).Tag.ToString();
            if (!answerType.Equals(tag))
            {
                answerType = tag;
                refreshAnswerSheet();
            }
        }
    }
}
