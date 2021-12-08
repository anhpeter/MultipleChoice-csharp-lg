
namespace MultipleChoiceApp.Forms
{
    partial class FrmExamStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExamStart));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_code = new System.Windows.Forms.Label();
            this.lbl_major = new System.Windows.Forms.Label();
            this.lbl_duration = new System.Windows.Forms.Label();
            this.lbl_total_question = new System.Windows.Forms.Label();
            this.drop_subject = new Bunifu.UI.WinForms.BunifuDropdown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_start = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_exit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_exam_end_label = new System.Windows.Forms.Label();
            this.lbl_exam_name_label = new System.Windows.Forms.Label();
            this.lbl_exam_start_label = new System.Windows.Forms.Label();
            this.lbl_exam_name = new System.Windows.Forms.Label();
            this.lbl_exam_start = new System.Windows.Forms.Label();
            this.lbl_exam_end = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(53, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 311);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 246F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_code, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_major, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_duration, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_total_question, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.drop_subject, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(248, 83);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(655, 165);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(3, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 48);
            this.label7.TabIndex = 9;
            this.label7.Text = "Class:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stu. Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 48);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stu. Code";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(297, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 48);
            this.label4.TabIndex = 6;
            this.label4.Text = "Subject:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(297, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 48);
            this.label5.TabIndex = 7;
            this.label5.Text = "Duration:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(297, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 48);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total question";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_name.Location = new System.Drawing.Point(108, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(66, 48);
            this.lbl_name.TabIndex = 10;
            this.lbl_name.Text = "<name>";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_code
            // 
            this.lbl_code.AutoSize = true;
            this.lbl_code.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_code.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_code.ForeColor = System.Drawing.Color.Black;
            this.lbl_code.Location = new System.Drawing.Point(108, 48);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(62, 48);
            this.lbl_code.TabIndex = 10;
            this.lbl_code.Text = "<code>";
            this.lbl_code.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_major
            // 
            this.lbl_major.AutoSize = true;
            this.lbl_major.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_major.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_major.ForeColor = System.Drawing.Color.Black;
            this.lbl_major.Location = new System.Drawing.Point(108, 96);
            this.lbl_major.Name = "lbl_major";
            this.lbl_major.Size = new System.Drawing.Size(69, 48);
            this.lbl_major.TabIndex = 10;
            this.lbl_major.Text = "<major>";
            this.lbl_major.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_duration
            // 
            this.lbl_duration.AutoSize = true;
            this.lbl_duration.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_duration.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_duration.ForeColor = System.Drawing.Color.Black;
            this.lbl_duration.Location = new System.Drawing.Point(412, 48);
            this.lbl_duration.Name = "lbl_duration";
            this.lbl_duration.Size = new System.Drawing.Size(0, 48);
            this.lbl_duration.TabIndex = 10;
            this.lbl_duration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_total_question
            // 
            this.lbl_total_question.AutoSize = true;
            this.lbl_total_question.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_total_question.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_question.ForeColor = System.Drawing.Color.Black;
            this.lbl_total_question.Location = new System.Drawing.Point(412, 96);
            this.lbl_total_question.Name = "lbl_total_question";
            this.lbl_total_question.Size = new System.Drawing.Size(0, 48);
            this.lbl_total_question.TabIndex = 10;
            this.lbl_total_question.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // drop_subject
            // 
            this.drop_subject.BackColor = System.Drawing.Color.White;
            this.drop_subject.BorderRadius = 1;
            this.drop_subject.Color = System.Drawing.Color.Black;
            this.drop_subject.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.drop_subject.DisabledColor = System.Drawing.Color.White;
            this.drop_subject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.drop_subject.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.drop_subject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drop_subject.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.drop_subject.FillDropDown = false;
            this.drop_subject.FillIndicator = true;
            this.drop_subject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drop_subject.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drop_subject.ForeColor = System.Drawing.Color.Black;
            this.drop_subject.FormattingEnabled = true;
            this.drop_subject.Icon = null;
            this.drop_subject.IndicatorColor = System.Drawing.Color.DimGray;
            this.drop_subject.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.drop_subject.ItemBackColor = System.Drawing.Color.White;
            this.drop_subject.ItemBorderColor = System.Drawing.Color.White;
            this.drop_subject.ItemForeColor = System.Drawing.Color.Black;
            this.drop_subject.ItemHeight = 26;
            this.drop_subject.ItemHighLightColor = System.Drawing.Color.WhiteSmoke;
            this.drop_subject.Location = new System.Drawing.Point(409, 6);
            this.drop_subject.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.drop_subject.Name = "drop_subject";
            this.drop_subject.Size = new System.Drawing.Size(243, 32);
            this.drop_subject.TabIndex = 8;
            this.drop_subject.Text = null;
            this.drop_subject.SelectionChangeCommitted += new System.EventHandler(this.drop_subject_SelectionChangeCommitted);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MultipleChoiceApp.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(71, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(381, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student Information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(48, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 28);
            this.label8.TabIndex = 4;
            this.label8.Text = "Exam:";
            // 
            // btn_start
            // 
            this.btn_start.Active = false;
            this.btn_start.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_start.BorderRadius = 0;
            this.btn_start.ButtonText = "Start";
            this.btn_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_start.DisabledColor = System.Drawing.Color.Gray;
            this.btn_start.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_start.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_start.Iconimage")));
            this.btn_start.Iconimage_right = null;
            this.btn_start.Iconimage_right_Selected = null;
            this.btn_start.Iconimage_Selected = null;
            this.btn_start.IconMarginLeft = 0;
            this.btn_start.IconMarginRight = 0;
            this.btn_start.IconRightVisible = true;
            this.btn_start.IconRightZoom = 0D;
            this.btn_start.IconVisible = true;
            this.btn_start.IconZoom = 90D;
            this.btn_start.IsTab = false;
            this.btn_start.Location = new System.Drawing.Point(834, 470);
            this.btn_start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_start.Name = "btn_start";
            this.btn_start.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_start.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_start.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_start.selected = false;
            this.btn_start.Size = new System.Drawing.Size(175, 60);
            this.btn_start.TabIndex = 5;
            this.btn_start.Text = "Start";
            this.btn_start.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_start.Textcolor = System.Drawing.Color.White;
            this.btn_start.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Active = false;
            this.btn_exit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.BorderRadius = 0;
            this.btn_exit.ButtonText = "Exit";
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.DisabledColor = System.Drawing.Color.Gray;
            this.btn_exit.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_exit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_exit.Iconimage")));
            this.btn_exit.Iconimage_right = null;
            this.btn_exit.Iconimage_right_Selected = null;
            this.btn_exit.Iconimage_Selected = null;
            this.btn_exit.IconMarginLeft = 0;
            this.btn_exit.IconMarginRight = 0;
            this.btn_exit.IconRightVisible = true;
            this.btn_exit.IconRightZoom = 0D;
            this.btn_exit.IconVisible = true;
            this.btn_exit.IconZoom = 90D;
            this.btn_exit.IsTab = false;
            this.btn_exit.Location = new System.Drawing.Point(651, 470);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_exit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_exit.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_exit.selected = false;
            this.btn_exit.Size = new System.Drawing.Size(175, 60);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Exit";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Textcolor = System.Drawing.Color.White;
            this.btn_exit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 330F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_exam_end_label, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbl_exam_name_label, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_exam_start_label, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_exam_name, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_exam_start, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_exam_end, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(53, 398);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(458, 132);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // lbl_exam_end_label
            // 
            this.lbl_exam_end_label.AutoSize = true;
            this.lbl_exam_end_label.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exam_end_label.ForeColor = System.Drawing.Color.Black;
            this.lbl_exam_end_label.Location = new System.Drawing.Point(3, 84);
            this.lbl_exam_end_label.Name = "lbl_exam_end_label";
            this.lbl_exam_end_label.Size = new System.Drawing.Size(50, 19);
            this.lbl_exam_end_label.TabIndex = 9;
            this.lbl_exam_end_label.Text = "End at";
            // 
            // lbl_exam_name_label
            // 
            this.lbl_exam_name_label.AutoSize = true;
            this.lbl_exam_name_label.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exam_name_label.ForeColor = System.Drawing.Color.Black;
            this.lbl_exam_name_label.Location = new System.Drawing.Point(3, 0);
            this.lbl_exam_name_label.Name = "lbl_exam_name_label";
            this.lbl_exam_name_label.Size = new System.Drawing.Size(86, 19);
            this.lbl_exam_name_label.TabIndex = 4;
            this.lbl_exam_name_label.Text = "Exam name";
            // 
            // lbl_exam_start_label
            // 
            this.lbl_exam_start_label.AutoSize = true;
            this.lbl_exam_start_label.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exam_start_label.ForeColor = System.Drawing.Color.Black;
            this.lbl_exam_start_label.Location = new System.Drawing.Point(3, 42);
            this.lbl_exam_start_label.Name = "lbl_exam_start_label";
            this.lbl_exam_start_label.Size = new System.Drawing.Size(58, 19);
            this.lbl_exam_start_label.TabIndex = 5;
            this.lbl_exam_start_label.Text = "Start at";
            // 
            // lbl_exam_name
            // 
            this.lbl_exam_name.AutoSize = true;
            this.lbl_exam_name.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exam_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_exam_name.Location = new System.Drawing.Point(131, 0);
            this.lbl_exam_name.Name = "lbl_exam_name";
            this.lbl_exam_name.Size = new System.Drawing.Size(0, 19);
            this.lbl_exam_name.TabIndex = 10;
            // 
            // lbl_exam_start
            // 
            this.lbl_exam_start.AutoSize = true;
            this.lbl_exam_start.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exam_start.ForeColor = System.Drawing.Color.Black;
            this.lbl_exam_start.Location = new System.Drawing.Point(131, 42);
            this.lbl_exam_start.Name = "lbl_exam_start";
            this.lbl_exam_start.Size = new System.Drawing.Size(0, 19);
            this.lbl_exam_start.TabIndex = 10;
            // 
            // lbl_exam_end
            // 
            this.lbl_exam_end.AutoSize = true;
            this.lbl_exam_end.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exam_end.ForeColor = System.Drawing.Color.Black;
            this.lbl_exam_end.Location = new System.Drawing.Point(131, 84);
            this.lbl_exam_end.Name = "lbl_exam_end";
            this.lbl_exam_end.Size = new System.Drawing.Size(0, 19);
            this.lbl_exam_end.TabIndex = 10;
            // 
            // FrmExamStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1071, 556);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmExamStart";
            this.Text = "FrmExamStart";
            this.Load += new System.EventHandler(this.FrmExamStart_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Bunifu.UI.WinForms.BunifuDropdown drop_subject;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_code;
        private System.Windows.Forms.Label lbl_major;
        private System.Windows.Forms.Label lbl_duration;
        private System.Windows.Forms.Label lbl_total_question;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuFlatButton btn_start;
        private Bunifu.Framework.UI.BunifuFlatButton btn_exit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_exam_end_label;
        private System.Windows.Forms.Label lbl_exam_name_label;
        private System.Windows.Forms.Label lbl_exam_start_label;
        private System.Windows.Forms.Label lbl_exam_name;
        private System.Windows.Forms.Label lbl_exam_start;
        private System.Windows.Forms.Label lbl_exam_end;
    }
}