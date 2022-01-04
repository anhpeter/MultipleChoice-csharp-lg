
namespace MultipleChoiceApp.Forms
{
    partial class FrmExamDetails
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
            this.pnl_header = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_start_at = new System.Windows.Forms.Label();
            this.lbl_semester = new System.Windows.Forms.Label();
            this.lbl_subject = new System.Windows.Forms.Label();
            this.lbl_exam_name = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_student_exam = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.table_exam_student = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gv_students = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv_students_in_exam = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_map = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_all_student_exam = new System.Windows.Forms.Button();
            this.btn_selected_student_exam = new System.Windows.Forms.Button();
            this.btn_selected_exam_student = new System.Windows.Forms.Button();
            this.btn_all_exam_student = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.pnl_header.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnl_student_exam.SuspendLayout();
            this.table_exam_student.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_students_in_exam)).BeginInit();
            this.pnl_map.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_header.BorderColor = System.Drawing.Color.Gainsboro;
            this.pnl_header.Controls.Add(this.tableLayoutPanel1);
            this.pnl_header.Location = new System.Drawing.Point(12, 12);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.PanelColor = System.Drawing.Color.Empty;
            this.pnl_header.ShadowDept = 2;
            this.pnl_header.ShadowTopLeftVisible = false;
            this.pnl_header.Size = new System.Drawing.Size(978, 157);
            this.pnl_header.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.76596F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.51064F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.23404F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.70213F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_start_at, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_semester, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_subject, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_exam_name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(940, 111);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_start_at
            // 
            this.lbl_start_at.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_start_at.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_start_at.Location = new System.Drawing.Point(456, 55);
            this.lbl_start_at.Name = "lbl_start_at";
            this.lbl_start_at.Size = new System.Drawing.Size(481, 56);
            this.lbl_start_at.TabIndex = 35;
            this.lbl_start_at.Text = "02/01/2022";
            this.lbl_start_at.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_semester
            // 
            this.lbl_semester.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_semester.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_semester.Location = new System.Drawing.Point(122, 55);
            this.lbl_semester.Name = "lbl_semester";
            this.lbl_semester.Size = new System.Drawing.Size(214, 56);
            this.lbl_semester.TabIndex = 34;
            this.lbl_semester.Text = "2131";
            this.lbl_semester.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_subject
            // 
            this.lbl_subject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_subject.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subject.Location = new System.Drawing.Point(456, 0);
            this.lbl_subject.Name = "lbl_subject";
            this.lbl_subject.Size = new System.Drawing.Size(481, 55);
            this.lbl_subject.TabIndex = 33;
            this.lbl_subject.Text = "Kiến Trúc Máy Tính";
            this.lbl_subject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_exam_name
            // 
            this.lbl_exam_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_exam_name.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exam_name.Location = new System.Drawing.Point(122, 0);
            this.lbl_exam_name.Name = "lbl_exam_name";
            this.lbl_exam_name.Size = new System.Drawing.Size(214, 55);
            this.lbl_exam_name.TabIndex = 32;
            this.lbl_exam_name.Text = "EX_KTMT_Ca1";
            this.lbl_exam_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 55);
            this.label6.TabIndex = 28;
            this.label6.Text = "Exam name:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 56);
            this.label1.TabIndex = 29;
            this.label1.Text = "Semester:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 55);
            this.label2.TabIndex = 30;
            this.label2.Text = "Subject:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 56);
            this.label3.TabIndex = 31;
            this.label3.Text = "Start at:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_student_exam
            // 
            this.pnl_student_exam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_student_exam.BorderColor = System.Drawing.Color.Gainsboro;
            this.pnl_student_exam.Controls.Add(this.table_exam_student);
            this.pnl_student_exam.Location = new System.Drawing.Point(12, 175);
            this.pnl_student_exam.Name = "pnl_student_exam";
            this.pnl_student_exam.PanelColor = System.Drawing.Color.Empty;
            this.pnl_student_exam.ShadowDept = 2;
            this.pnl_student_exam.ShadowTopLeftVisible = false;
            this.pnl_student_exam.Size = new System.Drawing.Size(978, 439);
            this.pnl_student_exam.TabIndex = 1;
            // 
            // table_exam_student
            // 
            this.table_exam_student.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_exam_student.ColumnCount = 3;
            this.table_exam_student.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.table_exam_student.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.table_exam_student.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.table_exam_student.Controls.Add(this.label9, 0, 0);
            this.table_exam_student.Controls.Add(this.label10, 2, 0);
            this.table_exam_student.Controls.Add(this.gv_students, 0, 1);
            this.table_exam_student.Controls.Add(this.gv_students_in_exam, 2, 1);
            this.table_exam_student.Controls.Add(this.pnl_map, 1, 1);
            this.table_exam_student.Location = new System.Drawing.Point(19, 13);
            this.table_exam_student.Name = "table_exam_student";
            this.table_exam_student.RowCount = 2;
            this.table_exam_student.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.776536F));
            this.table_exam_student.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.22346F));
            this.table_exam_student.Size = new System.Drawing.Size(940, 408);
            this.table_exam_student.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(417, 39);
            this.label9.TabIndex = 29;
            this.label9.Text = "All students";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(520, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(417, 39);
            this.label10.TabIndex = 30;
            this.label10.Text = "Students in the exam";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gv_students
            // 
            this.gv_students.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_students.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.gv_students.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_students.Location = new System.Drawing.Point(3, 42);
            this.gv_students.Name = "gv_students";
            this.gv_students.RowHeadersWidth = 51;
            this.gv_students.RowTemplate.Height = 24;
            this.gv_students.Size = new System.Drawing.Size(417, 363);
            this.gv_students.TabIndex = 31;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Student Code";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Full Name";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Major";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // gv_students_in_exam
            // 
            this.gv_students_in_exam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_students_in_exam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_students_in_exam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.gv_students_in_exam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_students_in_exam.Location = new System.Drawing.Point(520, 42);
            this.gv_students_in_exam.Name = "gv_students_in_exam";
            this.gv_students_in_exam.RowHeadersWidth = 51;
            this.gv_students_in_exam.RowTemplate.Height = 24;
            this.gv_students_in_exam.Size = new System.Drawing.Size(417, 363);
            this.gv_students_in_exam.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Student Code";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Full Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Major";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // pnl_map
            // 
            this.pnl_map.Controls.Add(this.btn_all_student_exam);
            this.pnl_map.Controls.Add(this.btn_selected_student_exam);
            this.pnl_map.Controls.Add(this.btn_selected_exam_student);
            this.pnl_map.Controls.Add(this.btn_all_exam_student);
            this.pnl_map.Controls.Add(this.btn_save);
            this.pnl_map.Controls.Add(this.btn_back);
            this.pnl_map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_map.Location = new System.Drawing.Point(426, 42);
            this.pnl_map.Name = "pnl_map";
            this.pnl_map.Size = new System.Drawing.Size(88, 363);
            this.pnl_map.TabIndex = 33;
            // 
            // btn_all_student_exam
            // 
            this.btn_all_student_exam.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_all_student_exam.Location = new System.Drawing.Point(0, 50);
            this.btn_all_student_exam.Margin = new System.Windows.Forms.Padding(0, 50, 0, 3);
            this.btn_all_student_exam.Name = "btn_all_student_exam";
            this.btn_all_student_exam.Size = new System.Drawing.Size(88, 35);
            this.btn_all_student_exam.TabIndex = 0;
            this.btn_all_student_exam.Text = ">>";
            this.btn_all_student_exam.UseVisualStyleBackColor = true;
            this.btn_all_student_exam.Click += new System.EventHandler(this.btn_all_student_exam_Click);
            // 
            // btn_selected_student_exam
            // 
            this.btn_selected_student_exam.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_selected_student_exam.Location = new System.Drawing.Point(0, 91);
            this.btn_selected_student_exam.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btn_selected_student_exam.Name = "btn_selected_student_exam";
            this.btn_selected_student_exam.Size = new System.Drawing.Size(88, 35);
            this.btn_selected_student_exam.TabIndex = 1;
            this.btn_selected_student_exam.Text = ">";
            this.btn_selected_student_exam.UseVisualStyleBackColor = true;
            this.btn_selected_student_exam.Click += new System.EventHandler(this.btn_selected_student_exam_Click);
            // 
            // btn_selected_exam_student
            // 
            this.btn_selected_exam_student.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_selected_exam_student.Location = new System.Drawing.Point(0, 132);
            this.btn_selected_exam_student.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btn_selected_exam_student.Name = "btn_selected_exam_student";
            this.btn_selected_exam_student.Size = new System.Drawing.Size(88, 35);
            this.btn_selected_exam_student.TabIndex = 2;
            this.btn_selected_exam_student.Text = "<";
            this.btn_selected_exam_student.UseVisualStyleBackColor = true;
            this.btn_selected_exam_student.Click += new System.EventHandler(this.btn_selected_exam_student_Click);
            // 
            // btn_all_exam_student
            // 
            this.btn_all_exam_student.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_all_exam_student.Location = new System.Drawing.Point(0, 173);
            this.btn_all_exam_student.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btn_all_exam_student.Name = "btn_all_exam_student";
            this.btn_all_exam_student.Size = new System.Drawing.Size(88, 35);
            this.btn_all_exam_student.TabIndex = 3;
            this.btn_all_exam_student.Text = "<<";
            this.btn_all_exam_student.UseVisualStyleBackColor = true;
            this.btn_all_exam_student.Click += new System.EventHandler(this.btn_all_exam_student_Click);
            // 
            // btn_save
            // 
            this.btn_save.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_save.Location = new System.Drawing.Point(0, 231);
            this.btn_save.Margin = new System.Windows.Forms.Padding(0, 20, 0, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(88, 35);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_back
            // 
            this.btn_back.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_back.Location = new System.Drawing.Point(0, 272);
            this.btn_back.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(88, 35);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // FrmExamDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 626);
            this.Controls.Add(this.pnl_student_exam);
            this.Controls.Add(this.pnl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmExamDetails";
            this.Text = "Exam Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmExamDetails_FormClosing);
            this.Load += new System.EventHandler(this.FrmExamDetails_Load);
            this.pnl_header.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnl_student_exam.ResumeLayout(false);
            this.table_exam_student.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_students_in_exam)).EndInit();
            this.pnl_map.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel pnl_header;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_start_at;
        private System.Windows.Forms.Label lbl_semester;
        private System.Windows.Forms.Label lbl_subject;
        private System.Windows.Forms.Label lbl_exam_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel pnl_student_exam;
        private System.Windows.Forms.TableLayoutPanel table_exam_student;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView gv_students;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridView gv_students_in_exam;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.FlowLayoutPanel pnl_map;
        private System.Windows.Forms.Button btn_all_student_exam;
        private System.Windows.Forms.Button btn_selected_student_exam;
        private System.Windows.Forms.Button btn_selected_exam_student;
        private System.Windows.Forms.Button btn_all_exam_student;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_back;
    }
}