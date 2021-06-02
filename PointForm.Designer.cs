
namespace регистрация
{
    partial class PointForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.workFormEXIT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.Maximum = 24D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "Временной промежуток";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.Title = "Нагруженность, %";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Unscaled;
            chartArea1.BorderColor = System.Drawing.Color.Silver;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 84F;
            chartArea1.Position.Width = 94F;
            chartArea1.Position.X = 2F;
            chartArea1.Position.Y = 13F;
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 12.70903F;
            legend1.Position.Width = 29F;
            legend1.Position.X = 71F;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 30);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.LegendText = "Покрываемая нагруженность";
            series1.MarkerBorderWidth = 5;
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.LegendText = "Планируемая нагруженность";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(750, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "title";
            title1.Position.Auto = false;
            title1.Position.Height = 8.827274F;
            title1.Position.Width = 80F;
            title1.Position.Y = 3F;
            title1.Text = "НАГРУЖЕННОСТЬ, % ОТ МАКСИМАЛЬНОЙ";
            this.chart1.Titles.Add(title1);
            this.chart1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.chart1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // workFormEXIT
            // 
            this.workFormEXIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.workFormEXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.workFormEXIT.FlatAppearance.BorderSize = 0;
            this.workFormEXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workFormEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workFormEXIT.ForeColor = System.Drawing.SystemColors.Control;
            this.workFormEXIT.Location = new System.Drawing.Point(720, 0);
            this.workFormEXIT.Name = "workFormEXIT";
            this.workFormEXIT.Size = new System.Drawing.Size(30, 30);
            this.workFormEXIT.TabIndex = 28;
            this.workFormEXIT.Text = "Х";
            this.workFormEXIT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.workFormEXIT.UseVisualStyleBackColor = false;
            this.workFormEXIT.Click += new System.EventHandler(this.workFormEXIT_Click);
            // 
            // PointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(750, 330);
            this.Controls.Add(this.workFormEXIT);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PointForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PointForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button workFormEXIT;
    }
}