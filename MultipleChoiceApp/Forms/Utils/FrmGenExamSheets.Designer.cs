
namespace MultipleChoiceApp.Forms.Utils
{
    partial class FrmGenExamSheets
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
            this.table_wrapper = new System.Windows.Forms.TableLayoutPanel();
            this.table_info = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_student_count = new System.Windows.Forms.Label();
            this.lbl_duration = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_exam_name = new System.Windows.Forms.Label();
            this.lbl_subject_name = new System.Windows.Forms.Label();
            this.lbl_total_question = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.table_info_and_action = new System.Windows.Forms.TableLayoutPanel();
            this.table_question_types = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_easy_qty = new System.Windows.Forms.Label();
            this.lbl_normal_qty = new System.Windows.Forms.Label();
            this.lbl_hard_qty = new System.Windows.Forms.Label();
            this.pnl_action = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_preview = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.table_wrapper.SuspendLayout();
            this.table_info.SuspendLayout();
            this.table_info_and_action.SuspendLayout();
            this.table_question_types.SuspendLayout();
            this.pnl_action.SuspendLayout();
            this.bunifuShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // table_wrapper
            // 
            this.table_wrapper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_wrapper.ColumnCount = 2;
            this.table_wrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_wrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_wrapper.Controls.Add(this.table_info, 0, 1);
            this.table_wrapper.Controls.Add(this.label1, 0, 0);
            this.table_wrapper.Controls.Add(this.label2, 1, 0);
            this.table_wrapper.Controls.Add(this.table_info_and_action, 1, 1);
            this.table_wrapper.Location = new System.Drawing.Point(12, 13);
            this.table_wrapper.Name = "table_wrapper";
            this.table_wrapper.RowCount = 2;
            this.table_wrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.table_wrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_wrapper.Size = new System.Drawing.Size(857, 213);
            this.table_wrapper.TabIndex = 0;
            // 
            // table_info
            // 
            this.table_info.ColumnCount = 2;
            this.table_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.3617F));
            this.table_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.6383F));
            this.table_info.Controls.Add(this.lbl_student_count, 1, 4);
            this.table_info.Controls.Add(this.lbl_duration, 1, 3);
            this.table_info.Controls.Add(this.label13, 0, 4);
            this.table_info.Controls.Add(this.label12, 0, 3);
            this.table_info.Controls.Add(this.label6, 0, 0);
            this.table_info.Controls.Add(this.label7, 0, 1);
            this.table_info.Controls.Add(this.label8, 0, 2);
            this.table_info.Controls.Add(this.lbl_exam_name, 1, 0);
            this.table_info.Controls.Add(this.lbl_subject_name, 1, 1);
            this.table_info.Controls.Add(this.lbl_total_question, 1, 2);
            this.table_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_info.Location = new System.Drawing.Point(3, 62);
            this.table_info.Name = "table_info";
            this.table_info.RowCount = 5;
            this.table_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table_info.Size = new System.Drawing.Size(422, 148);
            this.table_info.TabIndex = 4;
            // 
            // lbl_student_count
            // 
            this.lbl_student_count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_student_count.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_student_count.Location = new System.Drawing.Point(169, 120);
            this.lbl_student_count.Name = "lbl_student_count";
            this.lbl_student_count.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbl_student_count.Size = new System.Drawing.Size(250, 30);
            this.lbl_student_count.TabIndex = 10;
            this.lbl_student_count.Text = "<data>";
            this.lbl_student_count.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_duration
            // 
            this.lbl_duration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_duration.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_duration.Location = new System.Drawing.Point(169, 90);
            this.lbl_duration.Name = "lbl_duration";
            this.lbl_duration.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbl_duration.Size = new System.Drawing.Size(250, 30);
            this.lbl_duration.TabIndex = 9;
            this.lbl_duration.Text = "<data>";
            this.lbl_duration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 120);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label13.Size = new System.Drawing.Size(160, 30);
            this.label13.TabIndex = 8;
            this.label13.Text = "Students:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 90);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label12.Size = new System.Drawing.Size(160, 30);
            this.label12.TabIndex = 8;
            this.label12.Text = "Duration:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label6.Size = new System.Drawing.Size(160, 30);
            this.label6.TabIndex = 2;
            this.label6.Text = "Exam name:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 30);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label7.Size = new System.Drawing.Size(160, 30);
            this.label7.TabIndex = 3;
            this.label7.Text = "Subject:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 60);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(160, 30);
            this.label8.TabIndex = 4;
            this.label8.Text = "Total question:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_exam_name
            // 
            this.lbl_exam_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_exam_name.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exam_name.Location = new System.Drawing.Point(169, 0);
            this.lbl_exam_name.Name = "lbl_exam_name";
            this.lbl_exam_name.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbl_exam_name.Size = new System.Drawing.Size(250, 30);
            this.lbl_exam_name.TabIndex = 5;
            this.lbl_exam_name.Text = "<data>";
            this.lbl_exam_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_subject_name
            // 
            this.lbl_subject_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_subject_name.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subject_name.Location = new System.Drawing.Point(169, 30);
            this.lbl_subject_name.Name = "lbl_subject_name";
            this.lbl_subject_name.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbl_subject_name.Size = new System.Drawing.Size(250, 30);
            this.lbl_subject_name.TabIndex = 6;
            this.lbl_subject_name.Text = "<data>";
            this.lbl_subject_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_total_question
            // 
            this.lbl_total_question.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_total_question.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_question.Location = new System.Drawing.Point(169, 60);
            this.lbl_total_question.Name = "lbl_total_question";
            this.lbl_total_question.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbl_total_question.Size = new System.Drawing.Size(250, 30);
            this.lbl_total_question.TabIndex = 7;
            this.lbl_total_question.Text = "<data>";
            this.lbl_total_question.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exam Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(431, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 59);
            this.label2.TabIndex = 2;
            this.label2.Text = "Question Types";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // table_info_and_action
            // 
            this.table_info_and_action.ColumnCount = 1;
            this.table_info_and_action.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_info_and_action.Controls.Add(this.table_question_types, 0, 0);
            this.table_info_and_action.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_info_and_action.Location = new System.Drawing.Point(431, 62);
            this.table_info_and_action.Name = "table_info_and_action";
            this.table_info_and_action.RowCount = 1;
            this.table_info_and_action.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_info_and_action.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.table_info_and_action.Size = new System.Drawing.Size(423, 148);
            this.table_info_and_action.TabIndex = 4;
            // 
            // table_question_types
            // 
            this.table_question_types.ColumnCount = 2;
            this.table_question_types.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.74869F));
            this.table_question_types.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.25131F));
            this.table_question_types.Controls.Add(this.label3, 0, 0);
            this.table_question_types.Controls.Add(this.label4, 0, 1);
            this.table_question_types.Controls.Add(this.label5, 0, 2);
            this.table_question_types.Controls.Add(this.lbl_easy_qty, 1, 0);
            this.table_question_types.Controls.Add(this.lbl_normal_qty, 1, 1);
            this.table_question_types.Controls.Add(this.lbl_hard_qty, 1, 2);
            this.table_question_types.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_question_types.Location = new System.Drawing.Point(3, 3);
            this.table_question_types.Name = "table_question_types";
            this.table_question_types.RowCount = 4;
            this.table_question_types.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table_question_types.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table_question_types.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.table_question_types.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_question_types.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_question_types.Size = new System.Drawing.Size(417, 142);
            this.table_question_types.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(109, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Easy:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 30);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(109, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Normal:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 60);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(109, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hard:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_easy_qty
            // 
            this.lbl_easy_qty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_easy_qty.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_easy_qty.Location = new System.Drawing.Point(118, 0);
            this.lbl_easy_qty.Name = "lbl_easy_qty";
            this.lbl_easy_qty.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbl_easy_qty.Size = new System.Drawing.Size(296, 30);
            this.lbl_easy_qty.TabIndex = 5;
            this.lbl_easy_qty.Text = "<data>";
            this.lbl_easy_qty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_normal_qty
            // 
            this.lbl_normal_qty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_normal_qty.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_normal_qty.Location = new System.Drawing.Point(118, 30);
            this.lbl_normal_qty.Name = "lbl_normal_qty";
            this.lbl_normal_qty.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbl_normal_qty.Size = new System.Drawing.Size(296, 30);
            this.lbl_normal_qty.TabIndex = 6;
            this.lbl_normal_qty.Text = "<data>";
            this.lbl_normal_qty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_hard_qty
            // 
            this.lbl_hard_qty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_hard_qty.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hard_qty.Location = new System.Drawing.Point(118, 60);
            this.lbl_hard_qty.Name = "lbl_hard_qty";
            this.lbl_hard_qty.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbl_hard_qty.Size = new System.Drawing.Size(296, 30);
            this.lbl_hard_qty.TabIndex = 7;
            this.lbl_hard_qty.Text = "<data>";
            this.lbl_hard_qty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_action
            // 
            this.pnl_action.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_action.Controls.Add(this.button3);
            this.pnl_action.Controls.Add(this.btn_preview);
            this.pnl_action.Controls.Add(this.button1);
            this.pnl_action.Location = new System.Drawing.Point(644, 259);
            this.pnl_action.Name = "pnl_action";
            this.pnl_action.Size = new System.Drawing.Size(222, 171);
            this.pnl_action.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(10, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "Print to words";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_preview
            // 
            this.btn_preview.Location = new System.Drawing.Point(10, 77);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(202, 37);
            this.btn_preview.TabIndex = 1;
            this.btn_preview.Text = "Preview";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate Random Sheets";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuShadowPanel1.BackColor = System.Drawing.Color.White;
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuShadowPanel1.Controls.Add(this.table_wrapper);
            this.bunifuShadowPanel1.Controls.Add(this.pnl_action);
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(12, 12);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.Empty;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(886, 449);
            this.bunifuShadowPanel1.TabIndex = 5;
            // 
            // FrmGenExamSheets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 473);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmGenExamSheets";
            this.Text = "Generate Exam Sheets";
            this.Load += new System.EventHandler(this.FrmGenExamSheets_Load);
            this.table_wrapper.ResumeLayout(false);
            this.table_info.ResumeLayout(false);
            this.table_info_and_action.ResumeLayout(false);
            this.table_question_types.ResumeLayout(false);
            this.pnl_action.ResumeLayout(false);
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel table_wrapper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel table_question_types;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_easy_qty;
        private System.Windows.Forms.Label lbl_normal_qty;
        private System.Windows.Forms.Label lbl_hard_qty;
        private System.Windows.Forms.TableLayoutPanel table_info;
        private System.Windows.Forms.Label lbl_student_count;
        private System.Windows.Forms.Label lbl_duration;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_exam_name;
        private System.Windows.Forms.Label lbl_subject_name;
        private System.Windows.Forms.Label lbl_total_question;
        private System.Windows.Forms.TableLayoutPanel table_info_and_action;
        private System.Windows.Forms.Panel pnl_action;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_preview;
        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel bunifuShadowPanel1;
    }
}