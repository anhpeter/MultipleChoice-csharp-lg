
namespace MultipleChoiceApp.Forms
{
    partial class FrmQuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuestionForm));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnl_question_pic = new System.Windows.Forms.Panel();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_submit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnl_answers = new System.Windows.Forms.Panel();
            this.txt_chapter = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.drop_level = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_question = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.pic_progress = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_progress)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.pnl_question_pic);
            this.panel4.Controls.Add(this.lbl_id);
            this.panel4.Controls.Add(this.btn_submit);
            this.panel4.Controls.Add(this.pnl_answers);
            this.panel4.Controls.Add(this.txt_chapter);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.drop_level);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txt_question);
            this.panel4.Location = new System.Drawing.Point(67, 35);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1153, 555);
            this.panel4.TabIndex = 5;
            // 
            // pnl_question_pic
            // 
            this.pnl_question_pic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_question_pic.Location = new System.Drawing.Point(959, 3);
            this.pnl_question_pic.Name = "pnl_question_pic";
            this.pnl_question_pic.Size = new System.Drawing.Size(191, 150);
            this.pnl_question_pic.TabIndex = 20;
            // 
            // lbl_id
            // 
            this.lbl_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(3, 3);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(79, 23);
            this.lbl_id.TabIndex = 16;
            this.lbl_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_submit
            // 
            this.btn_submit.Active = false;
            this.btn_submit.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btn_submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_submit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_submit.BorderRadius = 0;
            this.btn_submit.ButtonText = "Save";
            this.btn_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_submit.DisabledColor = System.Drawing.Color.Gray;
            this.btn_submit.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_submit.Iconimage = null;
            this.btn_submit.Iconimage_right = null;
            this.btn_submit.Iconimage_right_Selected = null;
            this.btn_submit.Iconimage_Selected = null;
            this.btn_submit.IconMarginLeft = 0;
            this.btn_submit.IconMarginRight = 0;
            this.btn_submit.IconRightVisible = true;
            this.btn_submit.IconRightZoom = 0D;
            this.btn_submit.IconVisible = true;
            this.btn_submit.IconZoom = 70D;
            this.btn_submit.IsTab = false;
            this.btn_submit.Location = new System.Drawing.Point(928, 439);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btn_submit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_submit.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_submit.selected = false;
            this.btn_submit.Size = new System.Drawing.Size(221, 42);
            this.btn_submit.TabIndex = 19;
            this.btn_submit.Text = "Save";
            this.btn_submit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_submit.Textcolor = System.Drawing.Color.White;
            this.btn_submit.TextFont = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // pnl_answers
            // 
            this.pnl_answers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_answers.Location = new System.Drawing.Point(0, 210);
            this.pnl_answers.Name = "pnl_answers";
            this.pnl_answers.Size = new System.Drawing.Size(1153, 220);
            this.pnl_answers.TabIndex = 17;
            // 
            // txt_chapter
            // 
            this.txt_chapter.AcceptsReturn = false;
            this.txt_chapter.AcceptsTab = false;
            this.txt_chapter.AnimationSpeed = 200;
            this.txt_chapter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_chapter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_chapter.BackColor = System.Drawing.Color.Transparent;
            this.txt_chapter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_chapter.BackgroundImage")));
            this.txt_chapter.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_chapter.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txt_chapter.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_chapter.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_chapter.BorderRadius = 1;
            this.txt_chapter.BorderThickness = 1;
            this.txt_chapter.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_chapter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_chapter.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txt_chapter.DefaultText = "";
            this.txt_chapter.FillColor = System.Drawing.Color.White;
            this.txt_chapter.HideSelection = true;
            this.txt_chapter.IconLeft = null;
            this.txt_chapter.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_chapter.IconPadding = 10;
            this.txt_chapter.IconRight = null;
            this.txt_chapter.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_chapter.Lines = new string[0];
            this.txt_chapter.Location = new System.Drawing.Point(441, 446);
            this.txt_chapter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_chapter.MaxLength = 32767;
            this.txt_chapter.MinimumSize = new System.Drawing.Size(100, 34);
            this.txt_chapter.Modified = false;
            this.txt_chapter.Multiline = false;
            this.txt_chapter.Name = "txt_chapter";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_chapter.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_chapter.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_chapter.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_chapter.OnIdleState = stateProperties4;
            this.txt_chapter.PasswordChar = '\0';
            this.txt_chapter.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_chapter.PlaceholderText = "";
            this.txt_chapter.ReadOnly = false;
            this.txt_chapter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_chapter.SelectedText = "";
            this.txt_chapter.SelectionLength = 0;
            this.txt_chapter.SelectionStart = 0;
            this.txt_chapter.ShortcutsEnabled = true;
            this.txt_chapter.Size = new System.Drawing.Size(179, 34);
            this.txt_chapter.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txt_chapter.TabIndex = 7;
            this.txt_chapter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_chapter.TextMarginBottom = 0;
            this.txt_chapter.TextMarginLeft = 5;
            this.txt_chapter.TextMarginTop = 0;
            this.txt_chapter.TextPlaceholder = "";
            this.txt_chapter.UseSystemPasswordChar = false;
            this.txt_chapter.WordWrap = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(347, 448);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Chapter";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Level";
            // 
            // drop_level
            // 
            this.drop_level.BackColor = System.Drawing.SystemColors.Control;
            this.drop_level.BorderRadius = 1;
            this.drop_level.Color = System.Drawing.Color.Black;
            this.drop_level.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.drop_level.DisabledColor = System.Drawing.Color.White;
            this.drop_level.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.drop_level.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.drop_level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drop_level.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.drop_level.FillDropDown = false;
            this.drop_level.FillIndicator = true;
            this.drop_level.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drop_level.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drop_level.ForeColor = System.Drawing.Color.Black;
            this.drop_level.FormattingEnabled = true;
            this.drop_level.Icon = null;
            this.drop_level.IndicatorColor = System.Drawing.Color.DimGray;
            this.drop_level.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.drop_level.ItemBackColor = System.Drawing.Color.White;
            this.drop_level.ItemBorderColor = System.Drawing.Color.White;
            this.drop_level.ItemForeColor = System.Drawing.Color.Black;
            this.drop_level.ItemHeight = 26;
            this.drop_level.ItemHighLightColor = System.Drawing.Color.WhiteSmoke;
            this.drop_level.Location = new System.Drawing.Point(77, 448);
            this.drop_level.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drop_level.Name = "drop_level";
            this.drop_level.Size = new System.Drawing.Size(179, 32);
            this.drop_level.TabIndex = 6;
            this.drop_level.Text = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Question";
            // 
            // txt_question
            // 
            this.txt_question.AcceptsReturn = false;
            this.txt_question.AcceptsTab = false;
            this.txt_question.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_question.AnimationSpeed = 200;
            this.txt_question.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_question.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_question.BackColor = System.Drawing.Color.Transparent;
            this.txt_question.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_question.BackgroundImage")));
            this.txt_question.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_question.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txt_question.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_question.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_question.BorderRadius = 1;
            this.txt_question.BorderThickness = 1;
            this.txt_question.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_question.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_question.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txt_question.DefaultText = "";
            this.txt_question.FillColor = System.Drawing.Color.White;
            this.txt_question.HideSelection = true;
            this.txt_question.IconLeft = null;
            this.txt_question.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_question.IconPadding = 10;
            this.txt_question.IconRight = null;
            this.txt_question.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_question.Lines = new string[0];
            this.txt_question.Location = new System.Drawing.Point(113, 79);
            this.txt_question.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_question.MaxLength = 32767;
            this.txt_question.MinimumSize = new System.Drawing.Size(100, 34);
            this.txt_question.Modified = false;
            this.txt_question.Multiline = false;
            this.txt_question.Name = "txt_question";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_question.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Empty;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_question.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_question.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_question.OnIdleState = stateProperties8;
            this.txt_question.PasswordChar = '\0';
            this.txt_question.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_question.PlaceholderText = "";
            this.txt_question.ReadOnly = false;
            this.txt_question.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_question.SelectedText = "";
            this.txt_question.SelectionLength = 0;
            this.txt_question.SelectionStart = 0;
            this.txt_question.ShortcutsEnabled = true;
            this.txt_question.Size = new System.Drawing.Size(840, 34);
            this.txt_question.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txt_question.TabIndex = 1;
            this.txt_question.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_question.TextMarginBottom = 0;
            this.txt_question.TextMarginLeft = 5;
            this.txt_question.TextMarginTop = 0;
            this.txt_question.TextPlaceholder = "";
            this.txt_question.UseSystemPasswordChar = false;
            this.txt_question.WordWrap = true;
            // 
            // pic_progress
            // 
            this.pic_progress.BackColor = System.Drawing.Color.DodgerBlue;
            this.pic_progress.Location = new System.Drawing.Point(0, 0);
            this.pic_progress.Name = "pic_progress";
            this.pic_progress.Size = new System.Drawing.Size(0, 5);
            this.pic_progress.TabIndex = 6;
            this.pic_progress.TabStop = false;
            // 
            // FrmQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 601);
            this.Controls.Add(this.pic_progress);
            this.Controls.Add(this.panel4);
            this.MinimizeBox = false;
            this.Name = "FrmQuestionForm";
            this.Text = "Question Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmQuestionForm_FormClosing);
            this.Load += new System.EventHandler(this.FrmQuestionForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_progress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_id;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_chapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Bunifu.UI.WinForms.BunifuDropdown drop_level;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_question;
        private System.Windows.Forms.Panel pnl_answers;
        private Bunifu.Framework.UI.BunifuFlatButton btn_submit;
        private System.Windows.Forms.Panel pnl_question_pic;
        private System.Windows.Forms.PictureBox pic_progress;
    }
}