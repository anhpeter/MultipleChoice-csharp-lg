﻿using System;
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
    public partial class StudentControl : UserControl
    {
        public StudentControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.MaximumSize = new Size(1000, 1000);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}