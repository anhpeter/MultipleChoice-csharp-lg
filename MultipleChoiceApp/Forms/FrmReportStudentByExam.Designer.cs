
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportStudentByExam));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.report = new Microsoft.Reporting.WinForms.ReportViewer();
            this.drop_exam = new Bunifu.UI.WinForms.BunifuDropdown();
            this.drop_sort = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_email = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btn_send_mail = new System.Windows.Forms.Button();
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
            this.report.Size = new System.Drawing.Size(1016, 734);
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
            this.drop_sort.Location = new System.Drawing.Point(404, 11);
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
            this.label2.Location = new System.Drawing.Point(353, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sort";
            // 
            // txt_email
            // 
            this.txt_email.AcceptsReturn = false;
            this.txt_email.AcceptsTab = false;
            this.txt_email.AnimationSpeed = 200;
            this.txt_email.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_email.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_email.BackColor = System.Drawing.Color.Transparent;
            this.txt_email.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_email.BackgroundImage")));
            this.txt_email.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_email.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txt_email.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_email.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_email.BorderRadius = 1;
            this.txt_email.BorderThickness = 1;
            this.txt_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txt_email.DefaultText = "";
            this.txt_email.FillColor = System.Drawing.Color.White;
            this.txt_email.HideSelection = true;
            this.txt_email.IconLeft = null;
            this.txt_email.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.IconPadding = 10;
            this.txt_email.IconRight = null;
            this.txt_email.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.Lines = new string[0];
            this.txt_email.Location = new System.Drawing.Point(621, 8);
            this.txt_email.MaxLength = 32767;
            this.txt_email.MinimumSize = new System.Drawing.Size(100, 35);
            this.txt_email.Modified = false;
            this.txt_email.Multiline = false;
            this.txt_email.Name = "txt_email";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_email.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_email.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_email.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_email.OnIdleState = stateProperties4;
            this.txt_email.PasswordChar = '\0';
            this.txt_email.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_email.PlaceholderText = "Email";
            this.txt_email.ReadOnly = false;
            this.txt_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_email.SelectedText = "";
            this.txt_email.SelectionLength = 0;
            this.txt_email.SelectionStart = 0;
            this.txt_email.ShortcutsEnabled = true;
            this.txt_email.Size = new System.Drawing.Size(309, 35);
            this.txt_email.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txt_email.TabIndex = 6;
            this.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_email.TextMarginBottom = 0;
            this.txt_email.TextMarginLeft = 5;
            this.txt_email.TextMarginTop = 0;
            this.txt_email.TextPlaceholder = "Email";
            this.txt_email.UseSystemPasswordChar = false;
            this.txt_email.WordWrap = true;
            // 
            // btn_send_mail
            // 
            this.btn_send_mail.Location = new System.Drawing.Point(936, 8);
            this.btn_send_mail.Name = "btn_send_mail";
            this.btn_send_mail.Size = new System.Drawing.Size(97, 34);
            this.btn_send_mail.TabIndex = 7;
            this.btn_send_mail.Text = "Send mail";
            this.btn_send_mail.UseVisualStyleBackColor = true;
            this.btn_send_mail.Click += new System.EventHandler(this.btn_send_mail_Click);
            // 
            // FrmReportStudentByExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 796);
            this.Controls.Add(this.btn_send_mail);
            this.Controls.Add(this.txt_email);
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
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_email;
        private System.Windows.Forms.Button btn_send_mail;
    }
}