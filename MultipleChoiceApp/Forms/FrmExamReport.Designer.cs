
namespace MultipleChoiceApp.Forms
{
    partial class FrmExamReport
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
            this.pnl_header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_exam_name = new System.Windows.Forms.Label();
            this.pnl_tabs = new System.Windows.Forms.Panel();
            this.pnl_content = new System.Windows.Forms.Panel();
            this.pnl_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_header.BackColor = System.Drawing.Color.White;
            this.pnl_header.Controls.Add(this.pnl_tabs);
            this.pnl_header.Controls.Add(this.lbl_exam_name);
            this.pnl_header.Controls.Add(this.label1);
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(800, 190);
            this.pnl_header.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report";
            // 
            // lbl_exam_name
            // 
            this.lbl_exam_name.AutoSize = true;
            this.lbl_exam_name.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exam_name.Location = new System.Drawing.Point(12, 41);
            this.lbl_exam_name.Name = "lbl_exam_name";
            this.lbl_exam_name.Size = new System.Drawing.Size(207, 38);
            this.lbl_exam_name.TabIndex = 1;
            this.lbl_exam_name.Text = "<exam_name>";
            // 
            // pnl_tabs
            // 
            this.pnl_tabs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_tabs.Location = new System.Drawing.Point(0, 90);
            this.pnl_tabs.Name = "pnl_tabs";
            this.pnl_tabs.Size = new System.Drawing.Size(800, 100);
            this.pnl_tabs.TabIndex = 2;
            // 
            // pnl_content
            // 
            this.pnl_content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_content.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_content.Location = new System.Drawing.Point(0, 190);
            this.pnl_content.Name = "pnl_content";
            this.pnl_content.Size = new System.Drawing.Size(800, 260);
            this.pnl_content.TabIndex = 1;
            // 
            // FrmExamReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_content);
            this.Controls.Add(this.pnl_header);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmExamReport";
            this.Text = "Exam Report ";
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Panel pnl_tabs;
        private System.Windows.Forms.Label lbl_exam_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_content;
    }
}