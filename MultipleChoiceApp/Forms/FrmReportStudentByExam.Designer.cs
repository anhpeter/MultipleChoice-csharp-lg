
namespace MultipleChoiceApp.Forms
{
    partial class FrmReportStudentByExam
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
            this.report = new Microsoft.Reporting.WinForms.ReportViewer();
            this.drop_exam = new Bunifu.UI.WinForms.BunifuDropdown();
            this.drop_sort = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // report
            // 
            this.report.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.report.Location = new System.Drawing.Point(16, 49);
            this.report.Margin = new System.Windows.Forms.Padding(4);
            this.report.Name = "report";
            this.report.ServerReport.BearerToken = null;
            this.report.Size = new System.Drawing.Size(849, 734);
            this.report.TabIndex = 0;
            // 
            // drop_exam
            // 
            this.drop_exam.BackColor = System.Drawing.SystemColors.Control;
            this.drop_exam.BorderRadius = 1;
            this.drop_exam.Color = System.Drawing.Color.Black;
            this.drop_exam.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.drop_exam.DisabledColor = System.Drawing.Color.White;
            this.drop_exam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.drop_exam.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.drop_exam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drop_exam.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.drop_exam.FillDropDown = false;
            this.drop_exam.FillIndicator = true;
            this.drop_exam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drop_exam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drop_exam.ForeColor = System.Drawing.Color.Black;
            this.drop_exam.FormattingEnabled = true;
            this.drop_exam.Icon = null;
            this.drop_exam.IndicatorColor = System.Drawing.Color.DimGray;
            this.drop_exam.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.drop_exam.ItemBackColor = System.Drawing.Color.White;
            this.drop_exam.ItemBorderColor = System.Drawing.Color.White;
            this.drop_exam.ItemForeColor = System.Drawing.Color.Black;
            this.drop_exam.ItemHeight = 26;
            this.drop_exam.ItemHighLightColor = System.Drawing.Color.WhiteSmoke;
            this.drop_exam.Location = new System.Drawing.Point(129, 11);
            this.drop_exam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drop_exam.Name = "drop_exam";
            this.drop_exam.Size = new System.Drawing.Size(211, 32);
            this.drop_exam.TabIndex = 2;
            this.drop_exam.Text = null;
            this.drop_exam.SelectionChangeCommitted += new System.EventHandler(this.drop_exam_SelectionChangeCommitted);
            // 
            // drop_sort
            // 
            this.drop_sort.BackColor = System.Drawing.SystemColors.Control;
            this.drop_sort.BorderRadius = 1;
            this.drop_sort.Color = System.Drawing.Color.Black;
            this.drop_sort.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.drop_sort.DisabledColor = System.Drawing.Color.White;
            this.drop_sort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.drop_sort.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.drop_sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drop_sort.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.drop_sort.FillDropDown = false;
            this.drop_sort.FillIndicator = true;
            this.drop_sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drop_sort.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drop_sort.ForeColor = System.Drawing.Color.Black;
            this.drop_sort.FormattingEnabled = true;
            this.drop_sort.Icon = null;
            this.drop_sort.IndicatorColor = System.Drawing.Color.DimGray;
            this.drop_sort.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.drop_sort.ItemBackColor = System.Drawing.Color.White;
            this.drop_sort.ItemBorderColor = System.Drawing.Color.White;
            this.drop_sort.ItemForeColor = System.Drawing.Color.Black;
            this.drop_sort.ItemHeight = 26;
            this.drop_sort.ItemHighLightColor = System.Drawing.Color.WhiteSmoke;
            this.drop_sort.Location = new System.Drawing.Point(472, 11);
            this.drop_sort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drop_sort.Name = "drop_sort";
            this.drop_sort.Size = new System.Drawing.Size(211, 32);
            this.drop_sort.TabIndex = 3;
            this.drop_sort.Text = null;
            this.drop_sort.SelectionChangeCommitted += new System.EventHandler(this.drop_sort_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Exam name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sort";
            // 
            // FrmReportStudentByExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 796);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drop_sort);
            this.Controls.Add(this.drop_exam);
            this.Controls.Add(this.report);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmReportStudentByExam";
            this.Text = "Report Student By Exam";
            this.Load += new System.EventHandler(this.FrmReportStudentBySubject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer report;
        private Bunifu.UI.WinForms.BunifuDropdown drop_exam;
        private Bunifu.UI.WinForms.BunifuDropdown drop_sort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}