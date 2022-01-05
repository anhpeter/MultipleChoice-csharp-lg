
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
            this.report = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // report
            // 
            this.report.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.report.Location = new System.Drawing.Point(12, 12);
            this.report.Name = "report";
            this.report.ServerReport.BearerToken = null;
            this.report.Size = new System.Drawing.Size(1099, 772);
            this.report.TabIndex = 0;
            // 
            // FrmExamSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 796);
            this.Controls.Add(this.report);
            this.Name = "FrmExamSheet";
            this.Text = "FrmExamSheet";
            this.Load += new System.EventHandler(this.FrmExamSheet_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer report;
    }
}