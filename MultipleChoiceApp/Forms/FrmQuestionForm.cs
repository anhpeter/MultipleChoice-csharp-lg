using Bunifu.UI.WinForms;
using FluentValidation.Results;
using MultipleChoiceApp.Bi.Question;
using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.Common.Interfaces;
using MultipleChoiceApp.Common.Validators;
using MultipleChoiceApp.UserControls;
using MultipleChoiceApp.UserControls.QuestionForm;
using MultipleChoiceApp.UserControls.Utilities;
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
    public partial class FrmQuestionForm : Form, IUploadImage
    {
        QuestionServiceSoapClient mainS = new QuestionServiceSoapClient();
        QuestionControl parent;
        Question formItem;
        int subjectId;
        String questionImgUrl;
        TextAnswersControl textAnswersControl;
        UploadImageControl questionImageControl;

        public FrmQuestionForm(QuestionControl parent, Question question, int subjectId)
        {
            InitializeComponent();
            CenterToParent();
            formItem = question;
            this.subjectId = subjectId;
            this.parent = parent;
        }

        private void FrmQuestionForm_Load(object sender, EventArgs e)
        {
            textAnswersControl = new TextAnswersControl(formItem);
            textAnswersControl.Dock = DockStyle.Fill;
            pnl_answers.Controls.Add(textAnswersControl);
            initForm();
        }

        private void initForm()
        {
            initDrops();
            pnl_question_pic.Controls.Clear();
            questionImageControl = new UploadImageControl(this, "question", formItem?.ImgUrl ?? null);
            questionImageControl.Dock = DockStyle.Fill;
            pnl_question_pic.Controls.Add(questionImageControl);
            lbl_id.Text = formItem != null ? "#" + formItem.Id.ToString() : "";
            txt_question.Text = formItem?.Content.ToString() ?? "";
            txt_chapter.Text = formItem?.Chapter.ToString() ?? "1";
            drop_level.SelectedValue = formItem?.Level ?? "easy";
        }

        private void initDrops()
        {

            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("easy", "Easy");
            test.Add("normal", "Normal");
            test.Add("hard", "Hard");
            drop_level.DataSource = new BindingSource(test, null);
            drop_level.DisplayMember = "Value";
            drop_level.ValueMember = "Key";
        }



        private Question getFormQuestion()
        {
            // ANSWER LIST
            Question item = textAnswersControl.getFormQuestion();

            String level = drop_level.SelectedValue.ToString();
            int chapter = Util.parseToInt(txt_chapter.Text.ToString(), -1);

            int questionId = formItem != null ? formItem.Id : -1;
            item.Id = questionId;
            item.Content = txt_question.Text.ToString();
            item.SubjectId = subjectId;
            item.Level = level;
            item.Chapter = chapter;
            item.ImgUrl = questionImgUrl;
            return item;
        }


        private void clearForm()
        {
            lbl_id.Text = "";
            txt_question.Text = "";
            txt_chapter.Text = "1";
            drop_level.SelectedIndex = 0;
            questionImgUrl = null;
            textAnswersControl.clearForm();
            parent.clearForm();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {

            Question item = getFormQuestion();
            if (formItem != null)
            {
                if (handleValidation())
                {
                    bool result = mainS.update(item);
                    if (result)
                    {
                        parent.refreshList();
                        FormHelper.notify(Msg.UPDATED);
                    }
                }
            }
            else
            {
                item.CreatedBy = Auth.getIntace().manager.Id;
                if (handleValidation())
                {
                    bool result = mainS.add(item);
                    if (result)
                    {
                        clearForm();
                        parent.refreshList();
                        FormHelper.notify(Msg.INSERTED);
                    }
                }
            }
        }

        private bool handleValidation()
        {
            Question item = getFormQuestion();
            QuestionValidator validator = new QuestionValidator();
            ValidationResult results = validator.Validate(item);
            if (results.IsValid)
            {
                return true;
            }
            else
            {
                FormHelper.showValidatorError(results.Errors);
            }
            return false;
        }

        public void onImageUploaded(string tag, string imgUrl)
        {
            pic_progress.Width = 0;
            questionImageControl.setImgUrl(imgUrl);
            questionImgUrl = imgUrl;
        }

        public void onImageUploading(string tag, int percent)
        {
            pic_progress.Width = Convert.ToInt32(Math.Floor(Width * (percent / 100.0)));
        }

        public void onImageDeleted(string tag)
        {
            throw new NotImplementedException();
        }
    }
}
