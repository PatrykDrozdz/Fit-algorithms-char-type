namespace form_sim
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.generator = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.worst = new System.Windows.Forms.RadioButton();
            this.best = new System.Windows.Forms.RadioButton();
            this.first = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.numbers = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // generator
            // 
            this.generator.Location = new System.Drawing.Point(23, 13);
            this.generator.Name = "generator";
            this.generator.Size = new System.Drawing.Size(107, 54);
            this.generator.TabIndex = 0;
            this.generator.Text = "generuj wykres";
            this.generator.UseVisualStyleBackColor = true;
            this.generator.Click += new System.EventHandler(this.generator_Click);
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Location = new System.Drawing.Point(23, 93);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
            series1.Name = "Series";
            series1.YValuesPerPoint = 6;
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(523, 411);
            this.chart.TabIndex = 1;
            this.chart.Text = "chart";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.worst);
            this.groupBox1.Controls.Add(this.best);
            this.groupBox1.Controls.Add(this.first);
            this.groupBox1.Location = new System.Drawing.Point(304, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 54);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "typy";
            // 
            // worst
            // 
            this.worst.AutoSize = true;
            this.worst.Location = new System.Drawing.Point(181, 20);
            this.worst.Name = "worst";
            this.worst.Size = new System.Drawing.Size(61, 17);
            this.worst.TabIndex = 2;
            this.worst.TabStop = true;
            this.worst.Text = "worst-fit";
            this.worst.UseVisualStyleBackColor = true;
            // 
            // best
            // 
            this.best.AutoSize = true;
            this.best.Location = new System.Drawing.Point(106, 20);
            this.best.Name = "best";
            this.best.Size = new System.Drawing.Size(56, 17);
            this.best.TabIndex = 1;
            this.best.TabStop = true;
            this.best.Text = "best-fit";
            this.best.UseVisualStyleBackColor = true;
            // 
            // first
            // 
            this.first.AutoSize = true;
            this.first.Location = new System.Drawing.Point(20, 20);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(52, 17);
            this.first.TabIndex = 0;
            this.first.TabStop = true;
            this.first.Text = "first-fit";
            this.first.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liczba procesów i pamięci:";
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // numbers
            // 
            this.numbers.Location = new System.Drawing.Point(147, 47);
            this.numbers.Name = "numbers";
            this.numbers.Size = new System.Drawing.Size(131, 20);
            this.numbers.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 516);
            this.Controls.Add(this.numbers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.generator);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(587, 554);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(587, 554);
            this.Name = "Form1";
            this.Text = "Fit algorithms";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generator;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton worst;
        private System.Windows.Forms.RadioButton best;
        private System.Windows.Forms.RadioButton first;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox numbers;
    }
}

