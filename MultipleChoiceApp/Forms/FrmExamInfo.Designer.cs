
namespace MultipleChoiceApp.Forms
{
    partial class FrmExamInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_header = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.datepicker_from = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.datepicker_to = new System.Windows.Forms.DateTimePicker();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_gen_sheets = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.gv_exam = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.gv_student_in_exam = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_header.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_exam)).BeginInit();
            this.bunifuShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_student_in_exam)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_header.BorderColor = System.Drawing.Color.Gainsboro;
            this.pnl_header.Controls.Add(this.flowLayoutPanel1);
            this.pnl_header.Controls.Add(this.gv_exam);
            this.pnl_header.Location = new System.Drawing.Point(12, 12);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.PanelColor = System.Drawing.Color.Empty;
            this.pnl_header.ShadowDept = 2;
            this.pnl_header.ShadowTopLeftVisible = false;
            this.pnl_header.Size = new System.Drawing.Size(994, 290);
            this.pnl_header.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.datepicker_from);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.datepicker_to);
            this.flowLayoutPanel1.Controls.Add(this.btn_refresh);
            this.flowLayoutPanel1.Controls.Add(this.btn_gen_sheets);
            this.flowLayoutPanel1.Controls.Add(this.btn_exit);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(748, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(227, 259);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // datepicker_from
            // 
            this.datepicker_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepicker_from.Location = new System.Drawing.Point(3, 26);
            this.datepicker_from.Name = "datepicker_from";
            this.datepicker_from.Size = new System.Drawing.Size(200, 22);
            this.datepicker_from.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "To:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // datepicker_to
            // 
            this.datepicker_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepicker_to.Location = new System.Drawing.Point(3, 77);
            this.datepicker_to.Name = "datepicker_to";
            this.datepicker_to.Size = new System.Drawing.Size(200, 22);
            this.datepicker_to.TabIndex = 14;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(3, 122);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(211, 36);
            this.btn_refresh.TabIndex = 16;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_gen_sheets
            // 
            this.btn_gen_sheets.Location = new System.Drawing.Point(3, 164);
            this.btn_gen_sheets.Name = "btn_gen_sheets";
            this.btn_gen_sheets.Size = new System.Drawing.Size(211, 36);
            this.btn_gen_sheets.TabIndex = 18;
            this.btn_gen_sheets.Text = "Gen test sheets";
            this.btn_gen_sheets.UseVisualStyleBackColor = true;
            this.btn_gen_sheets.Click += new System.EventHandler(this.btn_gen_sheets_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(3, 206);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(211, 36);
            this.btn_exit.TabIndex = 19;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // gv_exam
            // 
            this.gv_exam.AllowUserToAddRows = false;
            this.gv_exam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_exam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_exam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_exam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5,
            this.Column13});
            this.gv_exam.Location = new System.Drawing.Point(12, 12);
            this.gv_exam.Name = "gv_exam";
            this.gv_exam.ReadOnly = true;
            this.gv_exam.RowHeadersWidth = 51;
            this.gv_exam.RowTemplate.Height = 24;
            this.gv_exam.Size = new System.Drawing.Size(715, 259);
            this.gv_exam.TabIndex = 0;
            this.gv_exam.SelectionChanged += new System.EventHandler(this.gv_exam_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Exam Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Subject";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "No. Of Student";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Duration";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = "dd/MM/yyyy";
            this.Column5.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column5.HeaderText = "Start At";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column13
            // 
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = "dd/MM/yyyy";
            this.Column13.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column13.HeaderText = "End At";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuShadowPanel1.Controls.Add(this.label3);
            this.bunifuShadowPanel1.Controls.Add(this.gv_student_in_exam);
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(12, 319);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.Empty;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(994, 192);
            this.bunifuShadowPanel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Student List";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gv_student_in_exam
            // 
            this.gv_student_in_exam.AllowUserToAddRows = false;
            this.gv_student_in_exam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_student_in_exam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_student_in_exam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_student_in_exam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column10,
            this.Column8,
            this.Column9,
            this.Column11,
            this.Column12});
            this.gv_student_in_exam.Location = new System.Drawing.Point(12, 44);
            this.gv_student_in_exam.Name = "gv_student_in_exam";
            this.gv_student_in_exam.ReadOnly = true;
            this.gv_student_in_exam.RowHeadersWidth = 51;
            this.gv_student_in_exam.RowTemplate.Height = 24;
            this.gv_student_in_exam.Size = new System.Drawing.Size(963, 129);
            this.gv_student_in_exam.TabIndex = 0;
            this.gv_student_in_exam.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gv_student_in_exam_RowPostPaint);
            // 
            // Column7
            // 
            this.Column7.HeaderText = "#";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Student Code";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Full Name";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.Column9.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column9.HeaderText = "DOB";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Major";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Status";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // FrmExamInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 526);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.Controls.Add(this.pnl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmExamInfo";
            this.Text = "Exam Information";
            this.Load += new System.EventHandler(this.FrmExamInfo_Load);
            this.pnl_header.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_exam)).EndInit();
            this.bunifuShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_student_in_exam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel pnl_header;
        private System.Windows.Forms.DataGridView gv_exam;
        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel bunifuShadowPanel1;
        private System.Windows.Forms.DataGridView gv_student_in_exam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datepicker_from;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datepicker_to;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.Button btn_gen_sheets;
        private System.Windows.Forms.Button btn_exit;
    }
}