
namespace MultipleChoiceApp.UserControls
{
    partial class QuestionControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionControl));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.drop_subject = new Bunifu.UI.WinForms.BunifuDropdown();
            this.gv_main = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl = new System.Windows.Forms.Panel();
            this.pnl_pagination_custom = new System.Windows.Forms.Panel();
            this.lbl_total_count = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_items_per_page = new System.Windows.Forms.TextBox();
            this.pnl_pagination = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_add = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_delete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_export_excel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_import_excel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label6 = new System.Windows.Forms.Label();
            this.savefiledialog_excel = new System.Windows.Forms.SaveFileDialog();
            this.openfiledialog_excel = new System.Windows.Forms.OpenFileDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.openFileDialog_question = new System.Windows.Forms.OpenFileDialog();
            this.txt_search = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gv_main)).BeginInit();
            this.pnl.SuspendLayout();
            this.pnl_pagination_custom.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // drop_subject
            // 
            this.drop_subject.BackColor = System.Drawing.SystemColors.Control;
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
            this.drop_subject.Location = new System.Drawing.Point(92, 0);
            this.drop_subject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drop_subject.Name = "drop_subject";
            this.drop_subject.Size = new System.Drawing.Size(343, 32);
            this.drop_subject.TabIndex = 1;
            this.drop_subject.Text = null;
            this.drop_subject.SelectionChangeCommitted += new System.EventHandler(this.drop_subject_SelectionChangeCommitted);
            // 
            // gv_main
            // 
            this.gv_main.AllowCustomTheming = false;
            this.gv_main.AllowUserToAddRows = false;
            this.gv_main.AllowUserToDeleteRows = false;
            this.gv_main.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.gv_main.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gv_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_main.BackgroundColor = System.Drawing.Color.White;
            this.gv_main.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_main.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gv_main.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_main.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gv_main.ColumnHeadersHeight = 40;
            this.gv_main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_main.DefaultCellStyle = dataGridViewCellStyle8;
            this.gv_main.EnableHeadersVisualStyles = false;
            this.gv_main.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gv_main.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.gv_main.HeaderBgColor = System.Drawing.Color.Empty;
            this.gv_main.HeaderForeColor = System.Drawing.Color.White;
            this.gv_main.Location = new System.Drawing.Point(0, 46);
            this.gv_main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gv_main.Name = "gv_main";
            this.gv_main.ReadOnly = true;
            this.gv_main.RowHeadersVisible = false;
            this.gv_main.RowHeadersWidth = 51;
            this.gv_main.RowTemplate.Height = 40;
            this.gv_main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_main.Size = new System.Drawing.Size(1155, 431);
            this.gv_main.TabIndex = 2;
            this.gv_main.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.gv_main.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_main_CellClick);
            this.gv_main.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_main_CellDoubleClick);
            this.gv_main.SizeChanged += new System.EventHandler(this.grid_main_SizeChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Content";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Subject Code";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Chapter";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Level";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column7.HeaderText = "Created At";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // pnl
            // 
            this.pnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl.Controls.Add(this.pnl_pagination_custom);
            this.pnl.Controls.Add(this.pnl_pagination);
            this.pnl.Controls.Add(this.flowLayoutPanel1);
            this.pnl.Location = new System.Drawing.Point(0, 481);
            this.pnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(1155, 239);
            this.pnl.TabIndex = 3;
            // 
            // pnl_pagination_custom
            // 
            this.pnl_pagination_custom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_pagination_custom.Controls.Add(this.label2);
            this.pnl_pagination_custom.Controls.Add(this.lbl_total_count);
            this.pnl_pagination_custom.Controls.Add(this.label1);
            this.pnl_pagination_custom.Controls.Add(this.txt_items_per_page);
            this.pnl_pagination_custom.Location = new System.Drawing.Point(469, 9);
            this.pnl_pagination_custom.Name = "pnl_pagination_custom";
            this.pnl_pagination_custom.Size = new System.Drawing.Size(216, 43);
            this.pnl_pagination_custom.TabIndex = 3;
            // 
            // lbl_total_count
            // 
            this.lbl_total_count.AutoSize = true;
            this.lbl_total_count.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_count.Location = new System.Drawing.Point(153, 6);
            this.lbl_total_count.Name = "lbl_total_count";
            this.lbl_total_count.Size = new System.Drawing.Size(45, 28);
            this.lbl_total_count.TabIndex = 6;
            this.lbl_total_count.Text = "120";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "/";
            // 
            // txt_items_per_page
            // 
            this.txt_items_per_page.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_items_per_page.Location = new System.Drawing.Point(61, 3);
            this.txt_items_per_page.Name = "txt_items_per_page";
            this.txt_items_per_page.Size = new System.Drawing.Size(69, 34);
            this.txt_items_per_page.TabIndex = 4;
            this.txt_items_per_page.Text = "15";
            this.txt_items_per_page.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_items_per_page.TextChanged += new System.EventHandler(this.txt_items_per_page_TextChanged);
            this.txt_items_per_page.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_items_per_page_KeyPress);
            // 
            // pnl_pagination
            // 
            this.pnl_pagination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_pagination.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_pagination.Location = new System.Drawing.Point(692, 4);
            this.pnl_pagination.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_pagination.Name = "pnl_pagination";
            this.pnl_pagination.Size = new System.Drawing.Size(454, 43);
            this.pnl_pagination.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_add);
            this.flowLayoutPanel1.Controls.Add(this.btn_delete);
            this.flowLayoutPanel1.Controls.Add(this.btn_export_excel);
            this.flowLayoutPanel1.Controls.Add(this.btn_import_excel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(459, 102);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Active = false;
            this.btn_add.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btn_add.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.BorderRadius = 0;
            this.btn_add.ButtonText = "Add";
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.DisabledColor = System.Drawing.Color.Gray;
            this.btn_add.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_add.Iconimage = null;
            this.btn_add.Iconimage_right = null;
            this.btn_add.Iconimage_right_Selected = null;
            this.btn_add.Iconimage_Selected = null;
            this.btn_add.IconMarginLeft = 0;
            this.btn_add.IconMarginRight = 0;
            this.btn_add.IconRightVisible = true;
            this.btn_add.IconRightZoom = 0D;
            this.btn_add.IconVisible = true;
            this.btn_add.IconZoom = 70D;
            this.btn_add.IsTab = false;
            this.btn_add.Location = new System.Drawing.Point(4, 6);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btn_add.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_add.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_add.selected = false;
            this.btn_add.Size = new System.Drawing.Size(221, 42);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Add";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add.Textcolor = System.Drawing.Color.White;
            this.btn_add.TextFont = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Active = false;
            this.btn_delete.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btn_delete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delete.BorderRadius = 0;
            this.btn_delete.ButtonText = "Delete";
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.DisabledColor = System.Drawing.Color.Gray;
            this.btn_delete.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_delete.Iconimage = null;
            this.btn_delete.Iconimage_right = null;
            this.btn_delete.Iconimage_right_Selected = null;
            this.btn_delete.Iconimage_Selected = null;
            this.btn_delete.IconMarginLeft = 0;
            this.btn_delete.IconMarginRight = 0;
            this.btn_delete.IconRightVisible = true;
            this.btn_delete.IconRightZoom = 0D;
            this.btn_delete.IconVisible = true;
            this.btn_delete.IconZoom = 70D;
            this.btn_delete.IsTab = false;
            this.btn_delete.Location = new System.Drawing.Point(233, 6);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btn_delete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_delete.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_delete.selected = false;
            this.btn_delete.Size = new System.Drawing.Size(221, 42);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_delete.Textcolor = System.Drawing.Color.White;
            this.btn_delete.TextFont = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_export_excel
            // 
            this.btn_export_excel.Active = false;
            this.btn_export_excel.Activecolor = System.Drawing.Color.SeaGreen;
            this.btn_export_excel.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_export_excel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_export_excel.BorderRadius = 0;
            this.btn_export_excel.ButtonText = "Export excel";
            this.btn_export_excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_export_excel.DisabledColor = System.Drawing.Color.Gray;
            this.btn_export_excel.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_export_excel.Iconimage = null;
            this.btn_export_excel.Iconimage_right = null;
            this.btn_export_excel.Iconimage_right_Selected = null;
            this.btn_export_excel.Iconimage_Selected = null;
            this.btn_export_excel.IconMarginLeft = 0;
            this.btn_export_excel.IconMarginRight = 0;
            this.btn_export_excel.IconRightVisible = true;
            this.btn_export_excel.IconRightZoom = 0D;
            this.btn_export_excel.IconVisible = true;
            this.btn_export_excel.IconZoom = 70D;
            this.btn_export_excel.IsTab = false;
            this.btn_export_excel.Location = new System.Drawing.Point(4, 58);
            this.btn_export_excel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.btn_export_excel.Name = "btn_export_excel";
            this.btn_export_excel.Normalcolor = System.Drawing.Color.SeaGreen;
            this.btn_export_excel.OnHovercolor = System.Drawing.Color.MediumAquamarine;
            this.btn_export_excel.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_export_excel.selected = false;
            this.btn_export_excel.Size = new System.Drawing.Size(221, 42);
            this.btn_export_excel.TabIndex = 16;
            this.btn_export_excel.Text = "Export excel";
            this.btn_export_excel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_export_excel.Textcolor = System.Drawing.Color.White;
            this.btn_export_excel.TextFont = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export_excel.Click += new System.EventHandler(this.btn_export_excel_Click);
            // 
            // btn_import_excel
            // 
            this.btn_import_excel.Active = false;
            this.btn_import_excel.Activecolor = System.Drawing.Color.Orange;
            this.btn_import_excel.BackColor = System.Drawing.Color.Orange;
            this.btn_import_excel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_import_excel.BorderRadius = 0;
            this.btn_import_excel.ButtonText = "Import excel";
            this.btn_import_excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_import_excel.DisabledColor = System.Drawing.Color.Gray;
            this.btn_import_excel.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_import_excel.Iconimage = null;
            this.btn_import_excel.Iconimage_right = null;
            this.btn_import_excel.Iconimage_right_Selected = null;
            this.btn_import_excel.Iconimage_Selected = null;
            this.btn_import_excel.IconMarginLeft = 0;
            this.btn_import_excel.IconMarginRight = 0;
            this.btn_import_excel.IconRightVisible = true;
            this.btn_import_excel.IconRightZoom = 0D;
            this.btn_import_excel.IconVisible = true;
            this.btn_import_excel.IconZoom = 70D;
            this.btn_import_excel.IsTab = false;
            this.btn_import_excel.Location = new System.Drawing.Point(233, 58);
            this.btn_import_excel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.btn_import_excel.Name = "btn_import_excel";
            this.btn_import_excel.Normalcolor = System.Drawing.Color.Orange;
            this.btn_import_excel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_import_excel.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_import_excel.selected = false;
            this.btn_import_excel.Size = new System.Drawing.Size(221, 42);
            this.btn_import_excel.TabIndex = 17;
            this.btn_import_excel.Text = "Import excel";
            this.btn_import_excel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_import_excel.Textcolor = System.Drawing.Color.White;
            this.btn_import_excel.TextFont = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_import_excel.Click += new System.EventHandler(this.btn_import_excel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Subject";
            // 
            // savefiledialog_excel
            // 
            this.savefiledialog_excel.Filter = "Excel 2007|*.xlsx";
            // 
            // openfiledialog_excel
            // 
            this.openfiledialog_excel.FileName = "openFileDialog1";
            this.openfiledialog_excel.Filter = "Excel|*.xlsx";
            // 
            // openFileDialog_question
            // 
            this.openFileDialog_question.FileName = "openFileDialog1";
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
            this.txt_search.Location = new System.Drawing.Point(805, 0);
            this.txt_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_search.MaxLength = 32767;
            this.txt_search.MinimumSize = new System.Drawing.Size(100, 34);
            this.txt_search.Modified = false;
            this.txt_search.Multiline = false;
            this.txt_search.Name = "txt_search";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_search.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Empty;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_search.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_search.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_search.OnIdleState = stateProperties8;
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
            this.txt_search.TabIndex = 12;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_search.TextMarginBottom = 0;
            this.txt_search.TextMarginLeft = 5;
            this.txt_search.TextMarginTop = 0;
            this.txt_search.TextPlaceholder = "Keyword";
            this.txt_search.UseSystemPasswordChar = false;
            this.txt_search.WordWrap = true;
            this.txt_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Rows";
            // 
            // QuestionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.gv_main);
            this.Controls.Add(this.drop_subject);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuestionControl";
            this.Size = new System.Drawing.Size(1155, 742);
            this.Load += new System.EventHandler(this.QuestionControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_main)).EndInit();
            this.pnl.ResumeLayout(false);
            this.pnl_pagination_custom.ResumeLayout(false);
            this.pnl_pagination_custom.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDropdown drop_subject;
        private Bunifu.UI.WinForms.BunifuDataGridView gv_main;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_search;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_add;
        private Bunifu.Framework.UI.BunifuFlatButton btn_delete;
        private Bunifu.Framework.UI.BunifuFlatButton btn_export_excel;
        private Bunifu.Framework.UI.BunifuFlatButton btn_import_excel;
        private System.Windows.Forms.Panel pnl_pagination;
        private System.Windows.Forms.SaveFileDialog savefiledialog_excel;
        private System.Windows.Forms.OpenFileDialog openfiledialog_excel;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog_question;
        private System.Windows.Forms.Panel pnl_pagination_custom;
        private System.Windows.Forms.Label lbl_total_count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_items_per_page;
        private System.Windows.Forms.Label label2;
    }
}
