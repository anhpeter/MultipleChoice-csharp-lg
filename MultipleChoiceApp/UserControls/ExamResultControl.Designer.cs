
namespace MultipleChoiceApp.UserControls
{
    partial class ExamResultControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamResultControl));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_export_report = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnl_pagination = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_search = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.gv_main = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savefiledialog_excel = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_main)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btn_export_report);
            this.panel1.Controls.Add(this.pnl_pagination);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(0, 580);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 230);
            this.panel1.TabIndex = 3;
            // 
            // btn_export_report
            // 
            this.btn_export_report.Active = false;
            this.btn_export_report.Activecolor = System.Drawing.Color.BlueViolet;
            this.btn_export_report.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_export_report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_export_report.BorderRadius = 0;
            this.btn_export_report.ButtonText = "Export Report";
            this.btn_export_report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_export_report.DisabledColor = System.Drawing.Color.Gray;
            this.btn_export_report.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_export_report.Iconimage = null;
            this.btn_export_report.Iconimage_right = null;
            this.btn_export_report.Iconimage_right_Selected = null;
            this.btn_export_report.Iconimage_Selected = null;
            this.btn_export_report.IconMarginLeft = 0;
            this.btn_export_report.IconMarginRight = 0;
            this.btn_export_report.IconRightVisible = true;
            this.btn_export_report.IconRightZoom = 0D;
            this.btn_export_report.IconVisible = true;
            this.btn_export_report.IconZoom = 70D;
            this.btn_export_report.IsTab = false;
            this.btn_export_report.Location = new System.Drawing.Point(4, 11);
            this.btn_export_report.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.btn_export_report.Name = "btn_export_report";
            this.btn_export_report.Normalcolor = System.Drawing.Color.BlueViolet;
            this.btn_export_report.OnHovercolor = System.Drawing.Color.MediumOrchid;
            this.btn_export_report.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_export_report.selected = false;
            this.btn_export_report.Size = new System.Drawing.Size(221, 42);
            this.btn_export_report.TabIndex = 19;
            this.btn_export_report.Text = "Export Report";
            this.btn_export_report.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_export_report.Textcolor = System.Drawing.Color.White;
            this.btn_export_report.TextFont = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export_report.Click += new System.EventHandler(this.btn_export_report_Click);
            // 
            // pnl_pagination
            // 
            this.pnl_pagination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_pagination.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_pagination.Location = new System.Drawing.Point(595, 4);
            this.pnl_pagination.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_pagination.Name = "pnl_pagination";
            this.pnl_pagination.Size = new System.Drawing.Size(453, 43);
            this.pnl_pagination.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Location = new System.Drawing.Point(3, 59);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1045, 169);
            this.panel4.TabIndex = 4;
            // 
            // txt_search
            // 
            this.txt_search.AcceptsReturn = false;
            this.txt_search.AcceptsTab = false;
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.AnimationSpeed = 200;
            this.txt_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_search.BackColor = System.Drawing.Color.Transparent;
            this.txt_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_search.BackgroundImage")));
            this.txt_search.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_search.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txt_search.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_search.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_search.BorderRadius = 1;
            this.txt_search.BorderThickness = 1;
            this.txt_search.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txt_search.DefaultText = "";
            this.txt_search.FillColor = System.Drawing.Color.White;
            this.txt_search.HideSelection = true;
            this.txt_search.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_search.IconLeft")));
            this.txt_search.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.IconPadding = 5;
            this.txt_search.IconRight = null;
            this.txt_search.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.Lines = new string[0];
            this.txt_search.Location = new System.Drawing.Point(704, 0);
            this.txt_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_search.MaxLength = 32767;
            this.txt_search.MinimumSize = new System.Drawing.Size(100, 34);
            this.txt_search.Modified = false;
            this.txt_search.Multiline = false;
            this.txt_search.Name = "txt_search";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_search.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_search.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_search.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_search.OnIdleState = stateProperties4;
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_search.PlaceholderText = "Keyword";
            this.txt_search.ReadOnly = false;
            this.txt_search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_search.SelectedText = "";
            this.txt_search.SelectionLength = 0;
            this.txt_search.SelectionStart = 0;
            this.txt_search.ShortcutsEnabled = true;
            this.txt_search.Size = new System.Drawing.Size(348, 34);
            this.txt_search.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txt_search.TabIndex = 14;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_search.TextMarginBottom = 0;
            this.txt_search.TextMarginLeft = 5;
            this.txt_search.TextMarginTop = 0;
            this.txt_search.TextPlaceholder = "Keyword";
            this.txt_search.UseSystemPasswordChar = false;
            this.txt_search.WordWrap = true;
            this.txt_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyUp);
            // 
            // gv_main
            // 
            this.gv_main.AllowCustomTheming = false;
            this.gv_main.AllowUserToAddRows = false;
            this.gv_main.AllowUserToDeleteRows = false;
            this.gv_main.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gv_main.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_main.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_main.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gv_main.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_main.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gv_main.ColumnHeadersHeight = 40;
            this.gv_main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column7,
            this.Column2,
            this.Column4,
            this.Column5});
            this.gv_main.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gv_main.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gv_main.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gv_main.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gv_main.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gv_main.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.gv_main.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gv_main.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.gv_main.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.gv_main.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gv_main.CurrentTheme.Name = null;
            this.gv_main.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gv_main.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gv_main.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gv_main.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gv_main.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_main.DefaultCellStyle = dataGridViewCellStyle5;
            this.gv_main.EnableHeadersVisualStyles = false;
            this.gv_main.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gv_main.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.gv_main.HeaderBgColor = System.Drawing.Color.Empty;
            this.gv_main.HeaderForeColor = System.Drawing.Color.White;
            this.gv_main.Location = new System.Drawing.Point(0, 38);
            this.gv_main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gv_main.Name = "gv_main";
            this.gv_main.ReadOnly = true;
            this.gv_main.RowHeadersVisible = false;
            this.gv_main.RowHeadersWidth = 51;
            this.gv_main.RowTemplate.Height = 40;
            this.gv_main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_main.Size = new System.Drawing.Size(1052, 538);
            this.gv_main.TabIndex = 13;
            this.gv_main.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.gv_main.SelectionChanged += new System.EventHandler(this.gv_main_SelectionChanged);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Id";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Exam Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column7
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column7.HeaderText = "Start At";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.HeaderText = "End At";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Status";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "No. Of Student";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // savefiledialog_excel
            // 
            this.savefiledialog_excel.Filter = "Excel 2007|*.xlsx";
            // 
            // ExamResultControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.gv_main);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ExamResultControl";
            this.Size = new System.Drawing.Size(1052, 828);
            this.Load += new System.EventHandler(this.ExamResultControl_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_search;
        private Bunifu.UI.WinForms.BunifuDataGridView gv_main;
        private System.Windows.Forms.Panel pnl_pagination;
        private System.Windows.Forms.SaveFileDialog savefiledialog_excel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton btn_export_report;
    }
}
