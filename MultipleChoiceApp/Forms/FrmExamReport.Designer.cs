
namespace MultipleChoiceApp.Forms
{
    partial class FrmExamReport
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_header = new System.Windows.Forms.Panel();
            this.pnl_tabs = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_students = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_summary = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbl_exam_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_content = new System.Windows.Forms.Panel();
            this.pnl_header.SuspendLayout();
            this.pnl_tabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.White;
            this.pnl_header.Controls.Add(this.pnl_tabs);
            this.pnl_header.Controls.Add(this.lbl_exam_name);
            this.pnl_header.Controls.Add(this.label1);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(969, 180);
            this.pnl_header.TabIndex = 0;
            // 
            // pnl_tabs
            // 
            this.pnl_tabs.Controls.Add(this.pictureBox3);
            this.pnl_tabs.Controls.Add(this.bunifuFlatButton1);
            this.pnl_tabs.Controls.Add(this.pictureBox2);
            this.pnl_tabs.Controls.Add(this.pictureBox1);
            this.pnl_tabs.Controls.Add(this.btn_students);
            this.pnl_tabs.Controls.Add(this.btn_summary);
            this.pnl_tabs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_tabs.Location = new System.Drawing.Point(0, 104);
            this.pnl_tabs.Name = "pnl_tabs";
            this.pnl_tabs.Size = new System.Drawing.Size(969, 76);
            this.pnl_tabs.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(392, 71);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(196, 5);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "border_bottom_Questions";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Questions";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 30;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 70D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(392, 0);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 20, 4, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(196, 76);
            this.bunifuFlatButton1.TabIndex = 8;
            this.bunifuFlatButton1.Tag = "Questions";
            this.bunifuFlatButton1.Text = "Questions";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.btn_tab_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(196, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(196, 5);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "border_bottom_Students";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.Location = new System.Drawing.Point(0, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 5);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "border_bottom_Summary";
            // 
            // btn_students
            // 
            this.btn_students.Active = false;
            this.btn_students.Activecolor = System.Drawing.Color.White;
            this.btn_students.BackColor = System.Drawing.Color.White;
            this.btn_students.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_students.BorderRadius = 0;
            this.btn_students.ButtonText = "Students";
            this.btn_students.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_students.DisabledColor = System.Drawing.Color.Black;
            this.btn_students.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_students.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_students.Iconimage = null;
            this.btn_students.Iconimage_right = null;
            this.btn_students.Iconimage_right_Selected = null;
            this.btn_students.Iconimage_Selected = null;
            this.btn_students.IconMarginLeft = 30;
            this.btn_students.IconMarginRight = 0;
            this.btn_students.IconRightVisible = true;
            this.btn_students.IconRightZoom = 0D;
            this.btn_students.IconVisible = true;
            this.btn_students.IconZoom = 70D;
            this.btn_students.IsTab = false;
            this.btn_students.Location = new System.Drawing.Point(196, 0);
            this.btn_students.Margin = new System.Windows.Forms.Padding(4, 20, 4, 4);
            this.btn_students.Name = "btn_students";
            this.btn_students.Normalcolor = System.Drawing.Color.White;
            this.btn_students.OnHovercolor = System.Drawing.Color.White;
            this.btn_students.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_students.selected = false;
            this.btn_students.Size = new System.Drawing.Size(196, 76);
            this.btn_students.TabIndex = 5;
            this.btn_students.Tag = "Students";
            this.btn_students.Text = "Students";
            this.btn_students.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_students.Textcolor = System.Drawing.Color.Black;
            this.btn_students.TextFont = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_students.Click += new System.EventHandler(this.btn_tab_Click);
            // 
            // btn_summary
            // 
            this.btn_summary.Active = false;
            this.btn_summary.Activecolor = System.Drawing.Color.White;
            this.btn_summary.BackColor = System.Drawing.Color.White;
            this.btn_summary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_summary.BorderRadius = 0;
            this.btn_summary.ButtonText = "Summary";
            this.btn_summary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_summary.DisabledColor = System.Drawing.Color.Black;
            this.btn_summary.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_summary.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_summary.Iconimage = null;
            this.btn_summary.Iconimage_right = null;
            this.btn_summary.Iconimage_right_Selected = null;
            this.btn_summary.Iconimage_Selected = null;
            this.btn_summary.IconMarginLeft = 30;
            this.btn_summary.IconMarginRight = 0;
            this.btn_summary.IconRightVisible = true;
            this.btn_summary.IconRightZoom = 0D;
            this.btn_summary.IconVisible = true;
            this.btn_summary.IconZoom = 70D;
            this.btn_summary.IsTab = false;
            this.btn_summary.Location = new System.Drawing.Point(0, 0);
            this.btn_summary.Margin = new System.Windows.Forms.Padding(4, 20, 4, 4);
            this.btn_summary.Name = "btn_summary";
            this.btn_summary.Normalcolor = System.Drawing.Color.White;
            this.btn_summary.OnHovercolor = System.Drawing.Color.White;
            this.btn_summary.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_summary.selected = false;
            this.btn_summary.Size = new System.Drawing.Size(196, 76);
            this.btn_summary.TabIndex = 4;
            this.btn_summary.Tag = "Summary";
            this.btn_summary.Text = "Summary";
            this.btn_summary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_summary.Textcolor = System.Drawing.Color.DodgerBlue;
            this.btn_summary.TextFont = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_summary.Click += new System.EventHandler(this.btn_tab_Click);
            // 
            // lbl_exam_name
            // 
            this.lbl_exam_name.AutoSize = true;
            this.lbl_exam_name.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exam_name.Location = new System.Drawing.Point(12, 41);
            this.lbl_exam_name.Name = "lbl_exam_name";
            this.lbl_exam_name.Size = new System.Drawing.Size(207, 38);
            this.lbl_exam_name.TabIndex = 1;
            this.lbl_exam_name.Text = "<exam_name>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report";
            // 
            // pnl_content
            // 
            this.pnl_content.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_content.Location = new System.Drawing.Point(0, 180);
            this.pnl_content.Name = "pnl_content";
            this.pnl_content.Padding = new System.Windows.Forms.Padding(10);
            this.pnl_content.Size = new System.Drawing.Size(969, 373);
            this.pnl_content.TabIndex = 1;
            // 
            // FrmExamReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 553);
            this.Controls.Add(this.pnl_content);
            this.Controls.Add(this.pnl_header);
            this.MinimizeBox = false;
            this.Name = "FrmExamReport";
            this.Text = "Exam Report ";
            this.Load += new System.EventHandler(this.FrmExamReport_Load);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.pnl_tabs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Panel pnl_tabs;
        private System.Windows.Forms.Label lbl_exam_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_content;
        private Bunifu.Framework.UI.BunifuFlatButton btn_summary;
        private Bunifu.Framework.UI.BunifuFlatButton btn_students;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}