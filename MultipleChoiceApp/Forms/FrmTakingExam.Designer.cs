
namespace MultipleChoiceApp.Forms
{
    partial class FrmTakingExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTakingExam));
            this.pnl_header = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.lbl_time = new System.Windows.Forms.Label();
            this.pnl_pagination = new System.Windows.Forms.Panel();
            this.btn_last = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_next = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_prev = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_first = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnl_question_sheet = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_ans4 = new System.Windows.Forms.Label();
            this.lbl_ans3 = new System.Windows.Forms.Label();
            this.lbl_ans2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_ans1 = new System.Windows.Forms.Label();
            this.lbl_question = new System.Windows.Forms.Label();
            this.pnl_answer_sheet = new System.Windows.Forms.Panel();
            this.pnl_answer = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_submit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label10 = new System.Windows.Forms.Label();
            this.pnl_header.SuspendLayout();
            this.pnl_pagination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_last)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_prev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_first)).BeginInit();
            this.pnl_question_sheet.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnl_answer_sheet.SuspendLayout();
            this.pnl_answer.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_header.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_header.BorderColor = System.Drawing.Color.Gainsboro;
            this.pnl_header.Controls.Add(this.lbl_time);
            this.pnl_header.Location = new System.Drawing.Point(12, 12);
            this.pnl_header.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.PanelColor = System.Drawing.Color.Empty;
            this.pnl_header.ShadowDept = 2;
            this.pnl_header.ShadowTopLeftVisible = false;
            this.pnl_header.Size = new System.Drawing.Size(1196, 78);
            this.pnl_header.TabIndex = 0;
            // 
            // lbl_time
            // 
            this.lbl_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_time.Location = new System.Drawing.Point(683, 25);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(100, 32);
            this.lbl_time.TabIndex = 5;
            this.lbl_time.Text = "<time>";
            // 
            // pnl_pagination
            // 
            this.pnl_pagination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_pagination.Controls.Add(this.btn_last);
            this.pnl_pagination.Controls.Add(this.btn_next);
            this.pnl_pagination.Controls.Add(this.btn_prev);
            this.pnl_pagination.Controls.Add(this.btn_first);
            this.pnl_pagination.Location = new System.Drawing.Point(632, 215);
            this.pnl_pagination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_pagination.Name = "pnl_pagination";
            this.pnl_pagination.Size = new System.Drawing.Size(189, 37);
            this.pnl_pagination.TabIndex = 2;
            // 
            // btn_last
            // 
            this.btn_last.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_last.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_last.Image = ((System.Drawing.Image)(resources.GetObject("btn_last.Image")));
            this.btn_last.ImageActive = null;
            this.btn_last.Location = new System.Drawing.Point(141, 0);
            this.btn_last.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(47, 37);
            this.btn_last.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_last.TabIndex = 4;
            this.btn_last.TabStop = false;
            this.btn_last.Zoom = 0;
            this.btn_last.Click += new System.EventHandler(this.onPaginationBtnClick);
            // 
            // btn_next
            // 
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_next.Image = ((System.Drawing.Image)(resources.GetObject("btn_next.Image")));
            this.btn_next.ImageActive = null;
            this.btn_next.Location = new System.Drawing.Point(94, 0);
            this.btn_next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(47, 37);
            this.btn_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_next.TabIndex = 3;
            this.btn_next.TabStop = false;
            this.btn_next.Zoom = 0;
            this.btn_next.Click += new System.EventHandler(this.onPaginationBtnClick);
            // 
            // btn_prev
            // 
            this.btn_prev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_prev.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_prev.Image = ((System.Drawing.Image)(resources.GetObject("btn_prev.Image")));
            this.btn_prev.ImageActive = null;
            this.btn_prev.Location = new System.Drawing.Point(47, 0);
            this.btn_prev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(47, 37);
            this.btn_prev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_prev.TabIndex = 2;
            this.btn_prev.TabStop = false;
            this.btn_prev.Zoom = 0;
            this.btn_prev.Click += new System.EventHandler(this.onPaginationBtnClick);
            // 
            // btn_first
            // 
            this.btn_first.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_first.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_first.Image = ((System.Drawing.Image)(resources.GetObject("btn_first.Image")));
            this.btn_first.ImageActive = null;
            this.btn_first.Location = new System.Drawing.Point(0, 0);
            this.btn_first.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(47, 37);
            this.btn_first.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_first.TabIndex = 1;
            this.btn_first.TabStop = false;
            this.btn_first.Zoom = 0;
            this.btn_first.Click += new System.EventHandler(this.onPaginationBtnClick);
            // 
            // pnl_question_sheet
            // 
            this.pnl_question_sheet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_question_sheet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_question_sheet.Controls.Add(this.tableLayoutPanel1);
            this.pnl_question_sheet.Controls.Add(this.pnl_pagination);
            this.pnl_question_sheet.Controls.Add(this.lbl_question);
            this.pnl_question_sheet.Location = new System.Drawing.Point(12, 107);
            this.pnl_question_sheet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_question_sheet.Name = "pnl_question_sheet";
            this.pnl_question_sheet.Size = new System.Drawing.Size(1196, 270);
            this.pnl_question_sheet.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.270109F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.72989F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_ans4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ans3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ans2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ans1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 102);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1141, 90);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // lbl_ans4
            // 
            this.lbl_ans4.AutoSize = true;
            this.lbl_ans4.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_ans4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ans4.ForeColor = System.Drawing.Color.Black;
            this.lbl_ans4.Location = new System.Drawing.Point(51, 284);
            this.lbl_ans4.Name = "lbl_ans4";
            this.lbl_ans4.Padding = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.lbl_ans4.Size = new System.Drawing.Size(1071, 84);
            this.lbl_ans4.TabIndex = 14;
            this.lbl_ans4.Text = "Consequat deserunt ad duis adipisicing non minim excepteur commodo dolore adipisi" +
    "cing officia adipisicing.";
            this.lbl_ans4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ans3
            // 
            this.lbl_ans3.AutoSize = true;
            this.lbl_ans3.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_ans3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ans3.ForeColor = System.Drawing.Color.Black;
            this.lbl_ans3.Location = new System.Drawing.Point(51, 200);
            this.lbl_ans3.Name = "lbl_ans3";
            this.lbl_ans3.Padding = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.lbl_ans3.Size = new System.Drawing.Size(1071, 84);
            this.lbl_ans3.TabIndex = 13;
            this.lbl_ans3.Text = "Consequat deserunt ad duis adipisicing non minim excepteur commodo dolore adipisi" +
    "cing officia adipisicing.";
            this.lbl_ans3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ans2
            // 
            this.lbl_ans2.AutoSize = true;
            this.lbl_ans2.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_ans2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ans2.ForeColor = System.Drawing.Color.Black;
            this.lbl_ans2.Location = new System.Drawing.Point(51, 116);
            this.lbl_ans2.Name = "lbl_ans2";
            this.lbl_ans2.Padding = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.lbl_ans2.Size = new System.Drawing.Size(1071, 84);
            this.lbl_ans2.TabIndex = 12;
            this.lbl_ans2.Text = "Consequat deserunt ad duis adipisicing non minim excepteur commodo dolore adipisi" +
    "cing officia adipisicing.";
            this.lbl_ans2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.label1.Size = new System.Drawing.Size(40, 116);
            this.label1.TabIndex = 7;
            this.label1.Text = "A.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 116);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.label2.Size = new System.Drawing.Size(39, 84);
            this.label2.TabIndex = 8;
            this.label2.Text = "B.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 200);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.label3.Size = new System.Drawing.Size(40, 84);
            this.label3.TabIndex = 9;
            this.label3.Text = "C.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 284);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.label4.Size = new System.Drawing.Size(42, 84);
            this.label4.TabIndex = 10;
            this.label4.Text = "D.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ans1
            // 
            this.lbl_ans1.AutoSize = true;
            this.lbl_ans1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_ans1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ans1.ForeColor = System.Drawing.Color.Black;
            this.lbl_ans1.Location = new System.Drawing.Point(51, 0);
            this.lbl_ans1.Name = "lbl_ans1";
            this.lbl_ans1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.lbl_ans1.Size = new System.Drawing.Size(1034, 116);
            this.lbl_ans1.TabIndex = 11;
            this.lbl_ans1.Text = resources.GetString("lbl_ans1.Text");
            this.lbl_ans1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_question.ForeColor = System.Drawing.Color.Black;
            this.lbl_question.Location = new System.Drawing.Point(24, 14);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(171, 38);
            this.lbl_question.TabIndex = 6;
            this.lbl_question.Text = "<question>";
            // 
            // pnl_answer_sheet
            // 
            this.pnl_answer_sheet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_answer_sheet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_answer_sheet.Controls.Add(this.pnl_answer);
            this.pnl_answer_sheet.Controls.Add(this.panel1);
            this.pnl_answer_sheet.Controls.Add(this.label10);
            this.pnl_answer_sheet.Location = new System.Drawing.Point(12, 396);
            this.pnl_answer_sheet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_answer_sheet.Name = "pnl_answer_sheet";
            this.pnl_answer_sheet.Size = new System.Drawing.Size(1196, 377);
            this.pnl_answer_sheet.TabIndex = 2;
            // 
            // pnl_answer
            // 
            this.pnl_answer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnl_answer.ColumnCount = 1;
            this.pnl_answer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.pnl_answer.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.pnl_answer.Location = new System.Drawing.Point(29, 58);
            this.pnl_answer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_answer.Name = "pnl_answer";
            this.pnl_answer.RowCount = 2;
            this.pnl_answer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.42424F));
            this.pnl_answer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.57576F));
            this.pnl_answer.Size = new System.Drawing.Size(45, 194);
            this.pnl_answer.TabIndex = 11;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.label17, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label18, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label19, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label20, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 46);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(37, 144);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 108);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(5);
            this.label17.Size = new System.Drawing.Size(31, 36);
            this.label17.TabIndex = 4;
            this.label17.Text = "D.";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(3, 0);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(5);
            this.label18.Size = new System.Drawing.Size(31, 36);
            this.label18.TabIndex = 1;
            this.label18.Text = "A.";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(3, 36);
            this.label19.Name = "label19";
            this.label19.Padding = new System.Windows.Forms.Padding(5);
            this.label19.Size = new System.Drawing.Size(30, 36);
            this.label19.TabIndex = 0;
            this.label19.Text = "B.";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(3, 72);
            this.label20.Name = "label20";
            this.label20.Padding = new System.Windows.Forms.Padding(5);
            this.label20.Size = new System.Drawing.Size(31, 36);
            this.label20.TabIndex = 2;
            this.label20.Text = "C.";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btn_submit);
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Location = new System.Drawing.Point(29, 277);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 48);
            this.panel1.TabIndex = 10;
            // 
            // btn_submit
            // 
            this.btn_submit.Active = false;
            this.btn_submit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_submit.BorderRadius = 0;
            this.btn_submit.ButtonText = "Submit";
            this.btn_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_submit.DisabledColor = System.Drawing.Color.Gray;
            this.btn_submit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_submit.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_submit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_submit.Iconimage")));
            this.btn_submit.Iconimage_right = null;
            this.btn_submit.Iconimage_right_Selected = null;
            this.btn_submit.Iconimage_Selected = null;
            this.btn_submit.IconMarginLeft = 0;
            this.btn_submit.IconMarginRight = 0;
            this.btn_submit.IconRightVisible = true;
            this.btn_submit.IconRightZoom = 0D;
            this.btn_submit.IconVisible = true;
            this.btn_submit.IconZoom = 90D;
            this.btn_submit.IsTab = false;
            this.btn_submit.Location = new System.Drawing.Point(995, 0);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(5);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_submit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_submit.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_submit.selected = false;
            this.btn_submit.Size = new System.Drawing.Size(149, 48);
            this.btn_submit.TabIndex = 1;
            this.btn_submit.Text = "Submit";
            this.btn_submit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_submit.Textcolor = System.Drawing.Color.White;
            this.btn_submit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Cancel";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 0);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(152, 48);
            this.bunifuFlatButton1.TabIndex = 0;
            this.bunifuFlatButton1.Text = "Cancel";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label10.Location = new System.Drawing.Point(24, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 28);
            this.label10.TabIndex = 9;
            this.label10.Text = "Your answer.";
            // 
            // FrmTakingExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1220, 787);
            this.Controls.Add(this.pnl_answer_sheet);
            this.Controls.Add(this.pnl_question_sheet);
            this.Controls.Add(this.pnl_header);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmTakingExam";
            this.Text = "FrmTakingExam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTakingExam_FormClosing);
            this.Load += new System.EventHandler(this.FrmTakingExam_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmTakingExam_KeyPress);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.pnl_pagination.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_last)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_prev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_first)).EndInit();
            this.pnl_question_sheet.ResumeLayout(false);
            this.pnl_question_sheet.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnl_answer_sheet.ResumeLayout(false);
            this.pnl_answer_sheet.PerformLayout();
            this.pnl_answer.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel pnl_header;
        private Bunifu.Framework.UI.BunifuImageButton btn_first;
        private System.Windows.Forms.Panel pnl_pagination;
        private Bunifu.Framework.UI.BunifuImageButton btn_last;
        private Bunifu.Framework.UI.BunifuImageButton btn_next;
        private Bunifu.Framework.UI.BunifuImageButton btn_prev;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Panel pnl_question_sheet;
        private System.Windows.Forms.Panel pnl_answer_sheet;
        private System.Windows.Forms.Label lbl_question;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_ans1;
        private System.Windows.Forms.Label lbl_ans2;
        private System.Windows.Forms.Label lbl_ans3;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_submit;
        private System.Windows.Forms.TableLayoutPanel pnl_answer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_ans4;
    }
}