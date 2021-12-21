using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleChoiceApp.UserControls.Utilities
{
    public partial class CorrectChartControl : UserControl
    {
        int correct;
        int incorrect;
        bool showLegends;
        public CorrectChartControl(int correct, int incorrect, bool showLegends = false)
        {
            InitializeComponent();
            this.correct = correct;
            this.incorrect = incorrect;
            this.showLegends = showLegends;
        }
        public CorrectChartControl(Double points, bool showLegends = false)
        {
            InitializeComponent();
            int correct = Convert.ToInt32(Math.Floor(points * 10));
            int incorrect = 100 - correct;
            this.correct = correct;
            this.incorrect = incorrect;
            this.showLegends = showLegends;
        }

        private void CorrectChartControl_Load(object sender, EventArgs e)
        {
            my_chart.Series["s1"].Points.AddXY($"{correct}%", correct);
            my_chart.Series["s1"].Points.AddXY($"{incorrect}%", incorrect);
            my_chart.Series["s1"].Points[0].Color = Color.FromArgb(38, 137, 12);
            my_chart.Series["s1"].Points[0].LegendText = "Correct";
            my_chart.Series["s1"].Points[0].LabelForeColor = Color.White;
            my_chart.Series["s1"].Points[1].Color = Color.FromArgb(226, 27, 60);
            my_chart.Series["s1"].Points[1].LegendText = "Incorrect";
            my_chart.Series["s1"].Points[1].LabelForeColor = Color.White;
            if (!showLegends) my_chart.Legends.Clear();
        }
    }
}
