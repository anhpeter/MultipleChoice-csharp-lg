
namespace MultipleChoiceApp.Forms
{
    partial class FrmExamFinish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExamFinish));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_correct_qty = new System.Windows.Forms.Label();
            this.lbl_incorrect_qty = new System.Windows.Forms.Label();
            this.lbl_mark = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_done = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(99, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 338);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 330F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_correct_qty, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_incorrect_qty, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_mark, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(267, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.04527F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.15638F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.23412F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.23412F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(537, 243);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_name.Location = new System.Drawing.Point(210, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(130, 56);
            this.lbl_name.TabIndex = 12;
            this.lbl_name.Text = "<name>";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Right;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(62, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 56);
            this.label8.TabIndex = 5;
            this.label8.Text = "Exam result of";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(51, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 83);
            this.label1.TabIndex = 6;
            this.label1.Text = "Correct answer:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(67)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(36, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 51);
            this.label2.TabIndex = 7;
            this.label2.Text = "Incorrect answer:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(140, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 53);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mark:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lbl_correct_qty
            // 
            this.lbl_correct_qty.AutoSize = true;
            this.lbl_correct_qty.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_correct_qty.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correct_qty.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbl_correct_qty.Location = new System.Drawing.Point(210, 56);
            this.lbl_correct_qty.Name = "lbl_correct_qty";
            this.lbl_correct_qty.Size = new System.Drawing.Size(199, 83);
            this.lbl_correct_qty.TabIndex = 9;
            this.lbl_correct_qty.Text = "<correct qty>";
            this.lbl_correct_qty.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbl_incorrect_qty
            // 
            this.lbl_incorrect_qty.AutoSize = true;
            this.lbl_incorrect_qty.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_incorrect_qty.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_incorrect_qty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(67)))), ((int)(((byte)(55)))));
            this.lbl_incorrect_qty.Location = new System.Drawing.Point(210, 139);
            this.lbl_incorrect_qty.Name = "lbl_incorrect_qty";
            this.lbl_incorrect_qty.Size = new System.Drawing.Size(224, 51);
            this.lbl_incorrect_qty.TabIndex = 10;
            this.lbl_incorrect_qty.Text = "<incorrect qty>";
            this.lbl_incorrect_qty.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbl_mark
            // 
            this.lbl_mark.AutoSize = true;
            this.lbl_mark.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_mark.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mark.ForeColor = System.Drawing.Color.Black;
            this.lbl_mark.Location = new System.Drawing.Point(210, 190);
            this.lbl_mark.Name = "lbl_mark";
            this.lbl_mark.Size = new System.Drawing.Size(125, 53);
            this.lbl_mark.TabIndex = 11;
            this.lbl_mark.Text = "<mark>";
            this.lbl_mark.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 243);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.pictureBox1.Size = new System.Drawing.Size(201, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_done);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 243);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 95);
            this.panel2.TabIndex = 1;
            // 
            // btn_done
            // 
            this.btn_done.Active = false;
            this.btn_done.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_done.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_done.BorderRadius = 0;
            this.btn_done.ButtonText = "Done";
            this.btn_done.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_done.DisabledColor = System.Drawing.Color.Gray;
            this.btn_done.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_done.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_done.Iconimage")));
            this.btn_done.Iconimage_right = null;
            this.btn_done.Iconimage_right_Selected = null;
            this.btn_done.Iconimage_Selected = null;
            this.btn_done.IconMarginLeft = 0;
            this.btn_done.IconMarginRight = 0;
            this.btn_done.IconRightVisible = true;
            this.btn_done.IconRightZoom = 0D;
            this.btn_done.IconVisible = true;
            this.btn_done.IconZoom = 90D;
            this.btn_done.IsTab = false;
            this.btn_done.Location = new System.Drawing.Point(350, 41);
            this.btn_done.Margin = new System.Windows.Forms.Padding(5);
            this.btn_done.Name = "btn_done";
            this.btn_done.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_done.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_done.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_done.selected = false;
            this.btn_done.Size = new System.Drawing.Size(144, 49);
            this.btn_done.TabIndex = 0;
            this.btn_done.Text = "Done";
            this.btn_done.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_done.Textcolor = System.Drawing.Color.White;
            this.btn_done.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // FrmExamFinish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(988, 398);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmExamFinish";
            this.Text = "FrmExamFinish";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_done;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_correct_qty;
        private System.Windows.Forms.Label lbl_incorrect_qty;
        private System.Windows.Forms.Label lbl_mark;
        private System.Windows.Forms.Label lbl_name;
    }
}