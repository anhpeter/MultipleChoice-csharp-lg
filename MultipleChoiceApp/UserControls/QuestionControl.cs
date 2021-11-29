using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleChoiceApp.UserControls
{
    public partial class QuestionControl : UserControl
    {
        public QuestionControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void QuestionControl_Load(object sender, EventArgs e)
        {
            setupDropLevel();
            setupDropSubject();
        }

        private void setupDropLevel()
        {
            string[] items = { "Easy", "Normal", "Hard"};
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
    }
}
