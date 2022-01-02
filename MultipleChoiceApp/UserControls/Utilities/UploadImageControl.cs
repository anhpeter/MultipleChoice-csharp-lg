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
        String imgFilename;
        String imgUrl;
        public UploadImageControl(IUploadImage parent, String tag, String imgFilename, String imgUrl)
        {
            InitializeComponent();
            //
            this.parent = parent;
            this.tag = tag;
            setImg(imgFilename, imgUrl);
        }

        private void UploadImageControl_Load(object sender, EventArgs e)
        {
        }
        public void setImg(String filename, String url = null)
        {
            imgFilename = filename;
            imgUrl = url;
            if (String.IsNullOrEmpty(filename))
            {
                pic.Image = Properties.Resources.empty_image;
            }
            else
            {
                pic.Load(imgUrl);
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
                string[] result = await fileUpload.upload(selectedFile, parent, imgFilename);
                parent.onImageUploaded(tag, result[0], result[1]);
            }
        }

        async private void deleteMenuItem_Click(object sender, EventArgs e)
        {
            if (await FileUpload.deleteFile(imgFilename))
            {
                parent.onImageDeleted(tag);
            }
            else
            {
                FormHelper.showErrorMsg(Msg.FAILED_TO_DELETE);
            }
        }


        private void initPicContextMenu()
        {

            if (!String.IsNullOrEmpty(imgFilename))
            {
                ContextMenuStrip menuStrip = new ContextMenuStrip();
                ToolStripMenuItem menuItem = new ToolStripMenuItem("Remove");
                menuItem.Click += new EventHandler(deleteMenuItem_Click);
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
