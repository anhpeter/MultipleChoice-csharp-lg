using MultipleChoiceApp.Bi.Question;
using MultipleChoiceApp.Common.Interfaces;
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

namespace MultipleChoiceApp.UserControls.QuestionForm
{
    public partial class ImageAnswersControl : UserControl, IUploadImage
    {
        Question formItem;
        public ImageAnswersControl(Question item)
        {
            InitializeComponent();
            formItem = item;
        }
        public ImageAnswersControl(Question item, int parentWidth)
        {
            InitializeComponent();

            int left = (parentWidth - pnl_pic_container.Width) / 2;
            pnl_pic_container.Left = left;
            pnl_rdo_container.Left = left;
        }

        private void ImageAnswersControl_Load(object sender, EventArgs e)
        {
            UploadImageControl ctr1 = new UploadImageControl(this, "pic_1", null);
            ctr1.Dock = DockStyle.Fill;
            UploadImageControl ctr2 = new UploadImageControl(this, "pic_2", null);
            ctr2.Dock = DockStyle.Fill;
            UploadImageControl ctr3 = new UploadImageControl(this, "pic_3", null);
            ctr3.Dock = DockStyle.Fill;
            UploadImageControl ctr4 = new UploadImageControl(this, "pic_4", null);
            ctr4.Dock = DockStyle.Fill;
            pnl_pic_1.Controls.Add(ctr1);
            pnl_pic_2.Controls.Add(ctr2);
            pnl_pic_3.Controls.Add(ctr3);
            pnl_pic_4.Controls.Add(ctr4);
        }

        public Question getFormQuestion()
        {
            return new Question();
        }

        public void clearForm()
        {
        }


        public void onImageUploaded(string tag, string imgUrl)
        {
            throw new NotImplementedException();
        }

        public void onImageUploading(string tag, int progress)
        {
            throw new NotImplementedException();
        }
    }
}
