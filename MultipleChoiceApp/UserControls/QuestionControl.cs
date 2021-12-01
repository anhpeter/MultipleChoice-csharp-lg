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

        public QuestionControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void QuestionControl_Load(object sender, EventArgs e)
        {
            setupDropLevel();
            setupDropSubject();
            Question item = mainBUS.getDetailsById(2);
            refreshList();
        }

        private void refreshList()
        {
            gvStatus = "loading";
            List<Question> list = mainBUS.getAllBySubjectCode("MMT");
            foreach (var item in list)
            {
                gv_main.Rows.Add(new object[] {
                    item.Id, item.Content,
                    item.SubjectCode, item.Chapter, item.Level, item.CreatedAt
                });
            }
            gvStatus = "succeeded";
        }

        private void setupDropLevel()
        {
            string[] items = { "Easy", "Normal", "Hard" };
            foreach (var item in items)
            {
                drop_level.Items.Add(item);
            }
            drop_level.SelectedIndex = 1;
        }
        private void setupDropSubject()
        {
            string[] items = { "All subjects", "Toán rời rạc", "Mạng máy tính", "Kỹ thuật lập trình nâng cao" };
            foreach (var item in items)
            {
                drop_subject.Items.Add(item);
            }
            drop_subject.SelectedIndex = 0;
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
            }
        }

    }
}
