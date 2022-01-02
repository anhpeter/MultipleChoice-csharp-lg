﻿using MultipleChoiceApp.Common.Helpers;
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
            this.imgUrl = imgUrl;
            setImage(imgUrl);
        }

        private void setImage(String url)
        {
            if (imgUrl == null)
            {
                pic.Image = Properties.Resources.empty_image;
            }
            else
            {
                pic.Load(url);
            }
        }

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

        public void setImgUrl(String url)
        {
            imgUrl = url;
            pic.Load(url);
        }
    }
}
