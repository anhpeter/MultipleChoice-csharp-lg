
namespace MultipleChoiceApp.UserControls
{
    partial class ResultControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.savefiledialog_excel = new System.Windows.Forms.SaveFileDialog();
            this.pnl_tabs = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_student = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnl_content = new System.Windows.Forms.Panel();
            this.pnl_tabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // savefiledialog_excel
            // 
            this.savefiledialog_excel.Filter = "Excel 2007|*.xlsx";
            // 
            // pnl_tabs
            // 
            this.pnl_tabs.Controls.Add(this.pictureBox1);
            this.pnl_tabs.Controls.Add(this.bunifuFlatButton2);
            this.pnl_tabs.Controls.Add(this.pictureBox3);
            this.pnl_tabs.Controls.Add(this.btn_student);
            this.pnl_tabs.Location = new System.Drawing.Point(0, 0);
            this.pnl_tabs.Name = "pnl_tabs";
            this.pnl_tabs.Size = new System.Drawing.Size(532, 58);
            this.pnl_tabs.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(196, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 5);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "border_bottom_Exams";
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Active = false;
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Exams";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 30;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 70D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(196, 0);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4, 20, 4, 4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(196, 58);
            this.bunifuFlatButton2.TabIndex = 5;
            this.bunifuFlatButton2.Tag = "Exams";
            this.bunifuFlatButton2.Text = "Exams";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.btn_tab_Click);
            // 
            // btn_student
            // 
            this.btn_student.Active = false;
            this.btn_student.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.btn_student.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_student.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_student.BorderRadius = 0;
            this.btn_student.ButtonText = "Students";
            this.btn_student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_student.DisabledColor = System.Drawing.Color.Black;
            this.btn_student.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_student.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_student.Iconimage = null;
            this.btn_student.Iconimage_right = null;
            this.btn_student.Iconimage_right_Selected = null;
            this.btn_student.Iconimage_Selected = null;
            this.btn_student.IconMarginLeft = 30;
            this.btn_student.IconMarginRight = 0;
            this.btn_student.IconRightVisible = true;
            this.btn_student.IconRightZoom = 0D;
            this.btn_student.IconVisible = true;
            this.btn_student.IconZoom = 70D;
            this.btn_student.IsTab = false;
            this.btn_student.Location = new System.Drawing.Point(0, 0);
            this.btn_student.Margin = new System.Windows.Forms.Padding(4, 20, 4, 4);
            this.btn_student.Name = "btn_student";
            this.btn_student.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btn_student.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btn_student.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_student.selected = false;
            this.btn_student.Size = new System.Drawing.Size(196, 58);
            this.btn_student.TabIndex = 4;
            this.btn_student.Tag = "Students";
            this.btn_student.Text = "Students";
            this.btn_student.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_student.Textcolor = System.Drawing.Color.DodgerBlue;
            this.btn_student.TextFont = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_student.Click += new System.EventHandler(this.btn_tab_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox3.Location = new System.Drawing.Point(3, 53);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(196, 5);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "border_bottom_Students";
            // 
            // pnl_content
            // 
            this.pnl_content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_content.Location = new System.Drawing.Point(0, 65);
            this.pnl_content.Name = "pnl_content";
            this.pnl_content.Size = new System.Drawing.Size(829, 399);
            this.pnl_content.TabIndex = 16;
            // 
            // ResultControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pnl_content);
            this.Controls.Add(this.pnl_tabs);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ResultControl";
            this.Size = new System.Drawing.Size(829, 464);
            this.Load += new System.EventHandler(this.ResultControl_Load);
            this.pnl_tabs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog savefiledialog_excel;
        private System.Windows.Forms.Panel pnl_tabs;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_student;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnl_content;
    }
}
