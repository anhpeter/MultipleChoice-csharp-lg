
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
            this.drop_level = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.lbl_class = new System.Windows.Forms.Label();
            this.lbl_duration = new System.Windows.Forms.Label();
            this.lbl_question_qty = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(53, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 344);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.drop_level, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_dob, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_class, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_duration, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_question_qty, 3, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(247, 58);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(655, 134);
            this.tableLayoutPanel1.TabIndex = 7;
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
            this.drop_level.Location = new System.Drawing.Point(467, 3);
            this.drop_level.Name = "drop_level";
            this.drop_level.Size = new System.Drawing.Size(179, 32);
            this.drop_level.TabIndex = 8;
            this.drop_level.Text = null;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(3, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Class:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Day of birth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(355, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Subject:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(355, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Duration:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(355, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Question qty:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(72, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student Information";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_name.Location = new System.Drawing.Point(108, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(66, 19);
            this.lbl_name.TabIndex = 10;
            this.lbl_name.Text = "<name>";
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dob.ForeColor = System.Drawing.Color.Black;
            this.lbl_dob.Location = new System.Drawing.Point(108, 43);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(56, 19);
            this.lbl_dob.TabIndex = 10;
            this.lbl_dob.Text = "<dob>";
            // 
            // lbl_class
            // 
            this.lbl_class.AutoSize = true;
            this.lbl_class.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_class.ForeColor = System.Drawing.Color.Black;
            this.lbl_class.Location = new System.Drawing.Point(108, 86);
            this.lbl_class.Name = "lbl_class";
            this.lbl_class.Size = new System.Drawing.Size(60, 19);
            this.lbl_class.TabIndex = 10;
            this.lbl_class.Text = "<class>";
            // 
            // lbl_duration
            // 
            this.lbl_duration.AutoSize = true;
            this.lbl_duration.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_duration.ForeColor = System.Drawing.Color.Black;
            this.lbl_duration.Location = new System.Drawing.Point(467, 43);
            this.lbl_duration.Name = "lbl_duration";
            this.lbl_duration.Size = new System.Drawing.Size(86, 19);
            this.lbl_duration.TabIndex = 10;
            this.lbl_duration.Text = "<duration>";
            // 
            // lbl_question_qty
            // 
            this.lbl_question_qty.AutoSize = true;
            this.lbl_question_qty.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_question_qty.ForeColor = System.Drawing.Color.Black;
            this.lbl_question_qty.Location = new System.Drawing.Point(467, 86);
            this.lbl_question_qty.Name = "lbl_question_qty";
            this.lbl_question_qty.Size = new System.Drawing.Size(112, 19);
            this.lbl_question_qty.TabIndex = 10;
            this.lbl_question_qty.Text = "<question qty>";
            // 
            // FrmExamStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 556);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmExamStart";
            this.Text = "FrmExamStart";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private Bunifu.UI.WinForms.BunifuDropdown drop_level;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.Label lbl_class;
        private System.Windows.Forms.Label lbl_duration;
        private System.Windows.Forms.Label lbl_question_qty;
    }
}