using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleChoiceApp.Common.UtilForms
{
    public partial class Alert : Form
    {
        int duration = 2500;
        String msg;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public Alert(String message, int duration = 2500)
        {
            InitializeComponent();
            this.duration = duration;
            this.msg = message;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            CenterToScreen();
        }

        async private void Alert_Load(object sender, EventArgs e)
        {
            lbl_msg.Text = msg;
            this.Top = 5;
            //this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 15;

            await Task.Delay(duration);
            this.Close();

        }
    }
}
