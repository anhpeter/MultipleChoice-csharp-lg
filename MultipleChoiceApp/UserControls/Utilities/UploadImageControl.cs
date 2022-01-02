using MultipleChoiceApp.Common.Helpers;
using MultipleChoiceApp.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleChoiceApp.UserControls.Utilities
{
    public partial class UploadImageControl : UserControl
    {
        IUploadImage parent;
        String tag;
        String imgUrl;
        public UploadImageControl(IUploadImage parent, String tag, String imgUrl)
        {
            InitializeComponent();
            //
            this.parent = parent;
            this.tag = tag;
            setImgUrl(imgUrl);
        }

        private void UploadImageControl_Load(object sender, EventArgs e)
        {
        }

        public void setImgUrl(String url)
        {
            imgUrl = url;
            if (String.IsNullOrEmpty(imgUrl))
            {
                pic.Image = Properties.Resources.empty_image;
            }
            else
            {
                pic.Load(url);
            }
            initPicContextMenu();
        }

        // CHANGE IMAGE
        async private void pic_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;
                FileUpload fileUpload = new FileUpload(tag);
                String url = await fileUpload.upload("Questions", selectedFile, parent);
                parent.onImageUploaded(tag, url);
            }
        }

        private void menuItemClick(object sender, EventArgs e)
        {

        }


        private void initPicContextMenu()
        {

            if (!String.IsNullOrEmpty(imgUrl))
            {
                ContextMenuStrip menuStrip = new ContextMenuStrip();
                ToolStripMenuItem menuItem = new ToolStripMenuItem("Remove");
                menuItem.Click += new EventHandler(menuItemClick);
                menuItem.Name = "Remove";
                menuStrip.Items.Add(menuItem);
                pic.ContextMenuStrip = menuStrip;
            }
            else
            {
                pic.ContextMenuStrip = null;
            }
        }
    }
}
