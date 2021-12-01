using MultipleChoiceApp.BLL;
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

        public QuestionControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void QuestionControl_Load(object sender, EventArgs e)
        {
            setupDropLevel();
            //setupDropSubject();
            loadCbxes();
            refreshList();
        }

        private void loadCbxes()
        {
            drop_subject.DataSource = subjectBUS.getAll();
            drop_subject.ValueMember = "Code";
            drop_subject.DisplayMember = "Name";
        }

        private void refreshList()
        {
            gvStatus = "loading";
            List<Question> list = mainBUS.getAllBySubjectCode("MMT");
            for (int i = 0; i < 10; i++)
            {
                foreach (var item in list)
                {
                    gv_main.Rows.Add(new object[] {
                    item.Id, item.Content,
                    item.SubjectCode, item.Chapter, item.Level, item.CreatedAt
                });
                }
            }
            gvStatus = "succeeded";
        }

        private void setupDropLevel()
        {

            // Bind combobox to dictionary
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
                Question item = mainBUS.getDetailsById(id);
                txt_question.Text = item.Content.ToString();
                txt_chapter.Text = item.Chapter.ToString();
                txt_ans1.Text = item.Answers[0].Content.ToString();
                txt_ans2.Text = item.Answers[1].Content.ToString();
                txt_ans3.Text = item.Answers[2].Content.ToString();
                txt_ans4.Text = item.Answers[3].Content.ToString();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
