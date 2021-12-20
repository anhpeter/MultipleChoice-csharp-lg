
namespace MultipleChoiceApp.UserControls.ExamReportControls
{
    partial class SummaryControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.chart_correct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bunifuShadowPanel2 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuShadowPanel3 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_correct)).BeginInit();
            this.bunifuShadowPanel2.SuspendLayout();
            this.bunifuShadowPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BackColor = System.Drawing.Color.White;
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuShadowPanel1.Controls.Add(this.chart_correct);
            this.bunifuShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(10, 10);
            this.bunifuShadowPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.Empty;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(335, 218);
            this.bunifuShadowPanel1.TabIndex = 0;
            // 
            // chart_correct
            // 
            this.chart_correct.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart_correct.ChartAreas.Add(chartArea1);
            this.chart_correct.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_correct.Legends.Add(legend1);
            this.chart_correct.Location = new System.Drawing.Point(0, 0);
            this.chart_correct.Name = "chart_correct";
            this.chart_correct.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "s1";
            this.chart_correct.Series.Add(series1);
            this.chart_correct.Size = new System.Drawing.Size(335, 218);
            this.chart_correct.TabIndex = 0;
            this.chart_correct.Text = "chart1";
            // 
            // bunifuShadowPanel2
            // 
            this.bunifuShadowPanel2.BackColor = System.Drawing.Color.White;
            this.bunifuShadowPanel2.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuShadowPanel2.Controls.Add(this.label2);
            this.bunifuShadowPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuShadowPanel2.Location = new System.Drawing.Point(365, 10);
            this.bunifuShadowPanel2.Margin = new System.Windows.Forms.Padding(10);
            this.bunifuShadowPanel2.Name = "bunifuShadowPanel2";
            this.bunifuShadowPanel2.PanelColor = System.Drawing.Color.Empty;
            this.bunifuShadowPanel2.ShadowDept = 2;
            this.bunifuShadowPanel2.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel2.Size = new System.Drawing.Size(335, 218);
            this.bunifuShadowPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 218);
            this.label2.TabIndex = 1;
            this.label2.Text = "Practise make perfect!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuShadowPanel3
            // 
            this.bunifuShadowPanel3.BackColor = System.Drawing.Color.White;
            this.bunifuShadowPanel3.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuShadowPanel3.Controls.Add(this.label3);
            this.bunifuShadowPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuShadowPanel3.Location = new System.Drawing.Point(720, 10);
            this.bunifuShadowPanel3.Margin = new System.Windows.Forms.Padding(10);
            this.bunifuShadowPanel3.Name = "bunifuShadowPanel3";
            this.bunifuShadowPanel3.PanelColor = System.Drawing.Color.Empty;
            this.bunifuShadowPanel3.ShadowDept = 2;
            this.bunifuShadowPanel3.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel3.Size = new System.Drawing.Size(336, 218);
            this.bunifuShadowPanel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 218);
            this.label3.TabIndex = 1;
            this.label3.Text = "Practise make perfect!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.bunifuShadowPanel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.bunifuShadowPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bunifuShadowPanel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1066, 477);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SummaryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SummaryControl";
            this.Size = new System.Drawing.Size(1066, 691);
            this.Load += new System.EventHandler(this.SummaryControl_Load);
            this.bunifuShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_correct)).EndInit();
            this.bunifuShadowPanel2.ResumeLayout(false);
            this.bunifuShadowPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel bunifuShadowPanel1;
        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel bunifuShadowPanel2;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel bunifuShadowPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_correct;
    }
}
