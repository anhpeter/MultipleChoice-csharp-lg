
namespace MultipleChoiceApp.Common.UtilForms
{
    partial class frm_error_msg
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.btn_close2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_msg);
            this.panel2.Location = new System.Drawing.Point(33, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 213);
            this.panel2.TabIndex = 1;
            // 
            // lbl_msg
            // 
            this.lbl_msg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_msg.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.lbl_msg.Location = new System.Drawing.Point(0, 0);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(545, 213);
            this.lbl_msg.TabIndex = 0;
            this.lbl_msg.Text = "Error mesage";
            // 
            // btn_close2
            // 
            this.btn_close2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_close2.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_close2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close2.Location = new System.Drawing.Point(448, 271);
            this.btn_close2.Name = "btn_close2";
            this.btn_close2.Size = new System.Drawing.Size(130, 47);
            this.btn_close2.TabIndex = 2;
            this.btn_close2.Text = "Close";
            this.btn_close2.UseVisualStyleBackColor = false;
            this.btn_close2.Click += new System.EventHandler(this.btn_close2_Click);
            // 
            // frm_error_msg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 331);
            this.Controls.Add(this.btn_close2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_error_msg";
            this.Text = "Form Error Message";
            this.Load += new System.EventHandler(this.FormErrorMessages_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_close2;
        private System.Windows.Forms.Label lbl_msg;
    }
}