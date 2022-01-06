
namespace MultipleChoiceApp.Forms.Utils
{
    partial class FrmExamSheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExamSheet));
            this.report = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnl_pagi = new System.Windows.Forms.Panel();
            this.txt_sheet_code = new System.Windows.Forms.TextBox();
            this.btn_next = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_last = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_prev = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_first = new Bunifu.Framework.UI.BunifuImageButton();
            this.label6 = new System.Windows.Forms.Label();
            this.pnl_pagi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_last)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_prev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_first)).BeginInit();
            this.SuspendLayout();
            // 
            // report
            // 
            this.report.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.report.Location = new System.Drawing.Point(12, 59);
            this.report.Name = "report";
            this.report.ServerReport.BearerToken = null;
            this.report.Size = new System.Drawing.Size(1099, 725);
            this.report.TabIndex = 0;
            // 
            // pnl_pagi
            // 
            this.pnl_pagi.Controls.Add(this.txt_sheet_code);
            this.pnl_pagi.Controls.Add(this.btn_next);
            this.pnl_pagi.Controls.Add(this.btn_last);
            this.pnl_pagi.Controls.Add(this.btn_prev);
            this.pnl_pagi.Controls.Add(this.btn_first);
            this.pnl_pagi.Location = new System.Drawing.Point(94, 8);
            this.pnl_pagi.Name = "pnl_pagi";
            this.pnl_pagi.Size = new System.Drawing.Size(246, 31);
            this.pnl_pagi.TabIndex = 1;
            // 
            // txt_sheet_code
            // 
            this.txt_sheet_code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_sheet_code.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sheet_code.Location = new System.Drawing.Point(94, 0);
            this.txt_sheet_code.Name = "txt_sheet_code";
            this.txt_sheet_code.ReadOnly = true;
            this.txt_sheet_code.Size = new System.Drawing.Size(58, 30);
            this.txt_sheet_code.TabIndex = 6;
            this.txt_sheet_code.Text = "1";
            this.txt_sheet_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_next
            // 
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_next.Image = ((System.Drawing.Image)(resources.GetObject("btn_next.Image")));
            this.btn_next.ImageActive = null;
            this.btn_next.Location = new System.Drawing.Point(152, 0);
            this.btn_next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(47, 31);
            this.btn_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_next.TabIndex = 9;
            this.btn_next.TabStop = false;
            this.btn_next.Zoom = 0;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_last
            // 
            this.btn_last.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_last.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_last.Image = ((System.Drawing.Image)(resources.GetObject("btn_last.Image")));
            this.btn_last.ImageActive = null;
            this.btn_last.Location = new System.Drawing.Point(199, 0);
            this.btn_last.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(47, 31);
            this.btn_last.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_last.TabIndex = 8;
            this.btn_last.TabStop = false;
            this.btn_last.Zoom = 0;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_prev.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_prev.Enabled = false;
            this.btn_prev.Image = ((System.Drawing.Image)(resources.GetObject("btn_prev.Image")));
            this.btn_prev.ImageActive = null;
            this.btn_prev.Location = new System.Drawing.Point(47, 0);
            this.btn_prev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(47, 31);
            this.btn_prev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_prev.TabIndex = 7;
            this.btn_prev.TabStop = false;
            this.btn_prev.Zoom = 0;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_first
            // 
            this.btn_first.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_first.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_first.Enabled = false;
            this.btn_first.Image = ((System.Drawing.Image)(resources.GetObject("btn_first.Image")));
            this.btn_first.ImageActive = null;
            this.btn_first.Location = new System.Drawing.Point(0, 0);
            this.btn_first.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(47, 31);
            this.btn_first.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_first.TabIndex = 6;
            this.btn_first.TabStop = false;
            this.btn_first.Zoom = 0;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 8);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label6.Size = new System.Drawing.Size(80, 30);
            this.label6.TabIndex = 3;
            this.label6.Text = "Test";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmExamSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 796);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnl_pagi);
            this.Controls.Add(this.report);
            this.Name = "FrmExamSheet";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.FrmExamSheet_Load);
            this.pnl_pagi.ResumeLayout(false);
            this.pnl_pagi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_last)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_prev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_first)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer report;
        private System.Windows.Forms.Panel pnl_pagi;
        private System.Windows.Forms.TextBox txt_sheet_code;
        private Bunifu.Framework.UI.BunifuImageButton btn_prev;
        private Bunifu.Framework.UI.BunifuImageButton btn_first;
        private Bunifu.Framework.UI.BunifuImageButton btn_next;
        private Bunifu.Framework.UI.BunifuImageButton btn_last;
        private System.Windows.Forms.Label label6;
    }
}