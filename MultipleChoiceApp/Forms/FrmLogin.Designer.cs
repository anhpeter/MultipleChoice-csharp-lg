
namespace MultipleChoiceApp.Forms
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_login = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdo_student = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rdo_manager = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_password = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txt_id = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(443, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 451);
            this.panel1.TabIndex = 0;
            // 
            // btn_login
            // 
            this.btn_login.ActiveBorderThickness = 1;
            this.btn_login.ActiveCornerRadius = 20;
            this.btn_login.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_login.ActiveForecolor = System.Drawing.Color.White;
            this.btn_login.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_login.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_login.BackgroundImage")));
            this.btn_login.ButtonText = "Login";
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_login.IdleBorderThickness = 1;
            this.btn_login.IdleCornerRadius = 20;
            this.btn_login.IdleFillColor = System.Drawing.Color.White;
            this.btn_login.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_login.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_login.Location = new System.Drawing.Point(31, 341);
            this.btn_login.Margin = new System.Windows.Forms.Padding(5);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(303, 57);
            this.btn_login.TabIndex = 5;
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdo_student);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.rdo_manager);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(31, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 43);
            this.panel2.TabIndex = 4;
            // 
            // rdo_student
            // 
            this.rdo_student.Checked = false;
            this.rdo_student.Location = new System.Drawing.Point(266, 8);
            this.rdo_student.Name = "rdo_student";
            this.rdo_student.OutlineColor = System.Drawing.Color.Purple;
            this.rdo_student.RadioColor = System.Drawing.Color.Purple;
            this.rdo_student.Size = new System.Drawing.Size(25, 25);
            this.rdo_student.TabIndex = 8;
            this.rdo_student.Text = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(181, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Student";
            // 
            // rdo_manager
            // 
            this.rdo_manager.Checked = true;
            this.rdo_manager.Location = new System.Drawing.Point(88, 8);
            this.rdo_manager.Name = "rdo_manager";
            this.rdo_manager.OutlineColor = System.Drawing.Color.Purple;
            this.rdo_manager.RadioColor = System.Drawing.Color.Purple;
            this.rdo_manager.Size = new System.Drawing.Size(25, 25);
            this.rdo_manager.TabIndex = 6;
            this.rdo_manager.Text = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Manager";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txt_password, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_id, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(31, 182);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(303, 87);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // txt_password
            // 
            this.txt_password.AcceptsReturn = false;
            this.txt_password.AcceptsTab = false;
            this.txt_password.AnimationSpeed = 200;
            this.txt_password.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_password.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_password.BackColor = System.Drawing.Color.Transparent;
            this.txt_password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_password.BackgroundImage")));
            this.txt_password.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_password.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txt_password.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_password.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_password.BorderRadius = 1;
            this.txt_password.BorderThickness = 1;
            this.txt_password.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txt_password.DefaultText = "";
            this.txt_password.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_password.FillColor = System.Drawing.Color.White;
            this.txt_password.HideSelection = true;
            this.txt_password.IconLeft = null;
            this.txt_password.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.IconPadding = 10;
            this.txt_password.IconRight = null;
            this.txt_password.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.Lines = new string[0];
            this.txt_password.Location = new System.Drawing.Point(3, 46);
            this.txt_password.MaxLength = 32767;
            this.txt_password.MinimumSize = new System.Drawing.Size(100, 35);
            this.txt_password.Modified = false;
            this.txt_password.Multiline = false;
            this.txt_password.Name = "txt_password";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_password.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_password.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_password.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_password.OnIdleState = stateProperties4;
            this.txt_password.PasswordChar = '●';
            this.txt_password.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_password.PlaceholderText = "Password";
            this.txt_password.ReadOnly = false;
            this.txt_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_password.SelectedText = "";
            this.txt_password.SelectionLength = 0;
            this.txt_password.SelectionStart = 0;
            this.txt_password.ShortcutsEnabled = true;
            this.txt_password.Size = new System.Drawing.Size(297, 35);
            this.txt_password.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txt_password.TabIndex = 1;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_password.TextMarginBottom = 0;
            this.txt_password.TextMarginLeft = 5;
            this.txt_password.TextMarginTop = 0;
            this.txt_password.TextPlaceholder = "Password";
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.WordWrap = true;
            // 
            // txt_id
            // 
            this.txt_id.AcceptsReturn = false;
            this.txt_id.AcceptsTab = false;
            this.txt_id.AnimationSpeed = 200;
            this.txt_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_id.BackColor = System.Drawing.Color.Transparent;
            this.txt_id.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_id.BackgroundImage")));
            this.txt_id.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_id.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txt_id.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_id.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_id.BorderRadius = 1;
            this.txt_id.BorderThickness = 1;
            this.txt_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txt_id.DefaultText = "";
            this.txt_id.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_id.FillColor = System.Drawing.Color.White;
            this.txt_id.HideSelection = true;
            this.txt_id.IconLeft = null;
            this.txt_id.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id.IconPadding = 10;
            this.txt_id.IconRight = null;
            this.txt_id.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id.Lines = new string[0];
            this.txt_id.Location = new System.Drawing.Point(3, 3);
            this.txt_id.MaxLength = 32767;
            this.txt_id.MinimumSize = new System.Drawing.Size(100, 35);
            this.txt_id.Modified = false;
            this.txt_id.Multiline = false;
            this.txt_id.Name = "txt_id";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_id.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Empty;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_id.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_id.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_id.OnIdleState = stateProperties8;
            this.txt_id.PasswordChar = '\0';
            this.txt_id.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_id.PlaceholderText = "ID";
            this.txt_id.ReadOnly = false;
            this.txt_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_id.SelectedText = "";
            this.txt_id.SelectionLength = 0;
            this.txt_id.SelectionStart = 0;
            this.txt_id.ShortcutsEnabled = true;
            this.txt_id.Size = new System.Drawing.Size(297, 35);
            this.txt_id.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txt_id.TabIndex = 0;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_id.TextMarginBottom = 0;
            this.txt_id.TextMarginLeft = 5;
            this.txt_id.TextMarginTop = 0;
            this.txt_id.TextPlaceholder = "ID";
            this.txt_id.UseSystemPasswordChar = false;
            this.txt_id.WordWrap = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(156, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(116, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(44, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(350, 308);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(-1, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(448, 455);
            this.panel3.TabIndex = 7;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuRadioButton rdo_student;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuRadioButton rdo_manager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_password;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_id;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_login;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
    }
}