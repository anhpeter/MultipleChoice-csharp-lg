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
    public partial class SubjectControl : UserControl
    {
        public SubjectControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.MaximumSize = new Size(700, 1000);
        }

        private void SubjectControl_Load(object sender, EventArgs e)
        {

        }
    }
}
