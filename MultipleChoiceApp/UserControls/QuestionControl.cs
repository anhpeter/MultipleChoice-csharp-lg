using Bunifu.UI.WinForms;
using MultipleChoiceApp.BLL;
using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleChoiceApp.UserControls
{
    public partial class QuestionControl : UserControl
    {
        String gvStatus = "idle";

        QuestionBUS mainBUS = new QuestionBUS();
        SubjectBUS subjectBUS = new SubjectBUS();

        //
        Question formItem;
        List<Subject> subjectList;

        public QuestionControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void QuestionControl_Load(object sender, EventArgs e)
        {
            LoadDrops();
            refreshList();
        }

        private void LoadDrops()
        {
            // SUBJECTS
            if (subjectList == null) subjectList = subjectBUS.getAll();
            drop_subject.DataSource = subjectList;
            drop_subject.ValueMember = "Code";
            drop_subject.DisplayMember = "Name";

            // LEVELS
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("easy", "Easy");
            test.Add("normal", "Normal");
            test.Add("hard", "Hard");
            drop_level.DataSource = new BindingSource(test, null);
            drop_level.DisplayMember = "Value";
            drop_level.ValueMember = "Key";
        }

        private void grid_main_SizeChanged(object sender, EventArgs e)
        {
            gv_main.Columns[0].Width = (int)(50);
            gv_main.Columns[1].Width = (int)(gv_main.Width * 0.5);
        }

        private void grid_main_SelectionChanged(object sender, EventArgs e)
        {
            if (gvStatus.Equals("succeeded"))
            {
                int id = int.Parse(gv_main.SelectedRows[0].Cells[0].Value.ToString());
                formItem = mainBUS.getDetailsById(id);
                txt_question.Text = formItem.Content.ToString();
                txt_chapter.Text = formItem.Chapter.ToString();
                txt_ans1.Text = formItem.Answers[0].Content.ToString();
                txt_ans2.Text = formItem.Answers[1].Content.ToString();
                txt_ans3.Text = formItem.Answers[2].Content.ToString();
                txt_ans4.Text = formItem.Answers[3].Content.ToString();
            }
        }

        // ACTIONS
        private void btn_add_Click(object sender, EventArgs e)
        {
            Question question = getFormQuestion();
            bool result = mainBUS.add(question);
            if (result)
            {
                clearForm();
                refreshList();
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        // GET FORM DATA
        private Question getFormQuestion()
        {
            List<Answer> answerList = new List<Answer>();
            int questionId = formItem != null ? formItem.Id : -1;
            answerList.Add(new Answer()
            {
                QuestionId = questionId,
                No = 1,
                Content = txt_ans1.Text.ToString(),
            });
            answerList.Add(new Answer()
            {
                QuestionId = questionId,
                No = 2,
                Content = txt_ans1.Text.ToString(),
            });
            answerList.Add(new Answer()
            {
                QuestionId = questionId,
                No = 3,
                Content = txt_ans1.Text.ToString(),
            });
            answerList.Add(new Answer()
            {
                QuestionId = questionId,
                No = 4,
                Content = txt_ans1.Text.ToString(),
            });

            String level = drop_level.SelectedValue.ToString();
            int correctAnsNo = getCorrectAnsNo();
            int chapter = Util.parseToInt(txt_chapter.Text.ToString(), -1);

            Question item = new Question()
            {
                Id = questionId,
                Answers = answerList,
                Content = txt_question.Text.ToString(),
                SubjectCode = getFormSubjectCode(),
                Level = level,
                CorrectAnswerNo = correctAnsNo,
                Chapter = chapter
            };
            return item;
        }

        private String getFormSubjectCode()
        {
            return drop_subject.SelectedValue.ToString();
        }
        //

        private int getCorrectAnsNo()
        {
            BunifuRadioButton radio = pnl_correct_ans_no.Controls.OfType<BunifuRadioButton>()
                .FirstOrDefault(r => r.Checked);

            return Util.parseToInt(radio.Tag.ToString(), 1);
        }

        // HELPER METHODS
        private void refreshList()
        {
            gvStatus = "loading";
            List<Question> list = mainBUS.getAllBySubjectCode(getFormSubjectCode());
            gv_main.Rows.Clear();
            foreach (var item in list)
            {
                gv_main.Rows.Add(new object[] {
                    item.Id, item.Content,
                    item.SubjectCode, item.Chapter, item.Level, item.CreatedAt
                });
            }
            gvStatus = "succeeded";
        }

        private void clearForm()
        {
            txt_question.Text = "";
            txt_ans1.Text = "";
            txt_ans2.Text = "";
            txt_ans3.Text = "";
            txt_ans4.Text = "";
            txt_chapter.Text = "-1";
            drop_level.SelectedIndex = 0;

        }

        private void drop_subject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            refreshList();
        }
    }
}
