
namespace Differentional
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Btn = new System.Windows.Forms.Button();
            this.txt_Y = new System.Windows.Forms.TextBox();
            this.txt_A = new System.Windows.Forms.TextBox();
            this.txt_B = new System.Windows.Forms.TextBox();
            this.txt_N = new System.Windows.Forms.TextBox();
            this.label_Y = new System.Windows.Forms.Label();
            this.label_A = new System.Windows.Forms.Label();
            this.label_B = new System.Windows.Forms.Label();
            this.label_N = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart.Legends.Add(legend1);
            this.Chart.Location = new System.Drawing.Point(190, 12);
            this.Chart.Name = "Chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Эйлер";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Рунге-Кутты";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Сама функция";
            this.Chart.Series.Add(series1);
            this.Chart.Series.Add(series2);
            this.Chart.Series.Add(series3);
            this.Chart.Size = new System.Drawing.Size(638, 408);
            this.Chart.TabIndex = 0;
            this.Chart.Text = "График";
            // 
            // Btn
            // 
            this.Btn.Location = new System.Drawing.Point(430, 426);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(143, 38);
            this.Btn.TabIndex = 1;
            this.Btn.Text = "Построить график";
            this.Btn.UseVisualStyleBackColor = true;
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // txt_Y
            // 
            this.txt_Y.Location = new System.Drawing.Point(13, 60);
            this.txt_Y.Name = "txt_Y";
            this.txt_Y.Size = new System.Drawing.Size(136, 20);
            this.txt_Y.TabIndex = 2;
            // 
            // txt_A
            // 
            this.txt_A.Location = new System.Drawing.Point(13, 124);
            this.txt_A.Name = "txt_A";
            this.txt_A.Size = new System.Drawing.Size(136, 20);
            this.txt_A.TabIndex = 3;
            // 
            // txt_B
            // 
            this.txt_B.Location = new System.Drawing.Point(13, 188);
            this.txt_B.Name = "txt_B";
            this.txt_B.Size = new System.Drawing.Size(136, 20);
            this.txt_B.TabIndex = 4;
            // 
            // txt_N
            // 
            this.txt_N.Location = new System.Drawing.Point(13, 244);
            this.txt_N.Name = "txt_N";
            this.txt_N.Size = new System.Drawing.Size(136, 20);
            this.txt_N.TabIndex = 5;
            // 
            // label_Y
            // 
            this.label_Y.AutoSize = true;
            this.label_Y.Location = new System.Drawing.Point(12, 44);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(63, 13);
            this.label_Y.TabIndex = 6;
            this.label_Y.Text = "Введите y0";
            // 
            // label_A
            // 
            this.label_A.AutoSize = true;
            this.label_A.Location = new System.Drawing.Point(12, 108);
            this.label_A.Name = "label_A";
            this.label_A.Size = new System.Drawing.Size(59, 13);
            this.label_A.TabIndex = 7;
            this.label_A.Text = "Введите А";
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.Location = new System.Drawing.Point(12, 172);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(59, 13);
            this.label_B.TabIndex = 8;
            this.label_B.Text = "Введите В";
            // 
            // label_N
            // 
            this.label_N.AutoSize = true;
            this.label_N.Location = new System.Drawing.Point(12, 228);
            this.label_N.Name = "label_N";
            this.label_N.Size = new System.Drawing.Size(60, 13);
            this.label_N.TabIndex = 9;
            this.label_N.Text = "Введите N";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 488);
            this.Controls.Add(this.label_N);
            this.Controls.Add(this.label_B);
            this.Controls.Add(this.label_A);
            this.Controls.Add(this.label_Y);
            this.Controls.Add(this.txt_N);
            this.Controls.Add(this.txt_B);
            this.Controls.Add(this.txt_A);
            this.Controls.Add(this.txt_Y);
            this.Controls.Add(this.Btn);
            this.Controls.Add(this.Chart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.Button Btn;
        private System.Windows.Forms.TextBox txt_Y;
        private System.Windows.Forms.TextBox txt_A;
        private System.Windows.Forms.TextBox txt_B;
        private System.Windows.Forms.TextBox txt_N;
        private System.Windows.Forms.Label label_Y;
        private System.Windows.Forms.Label label_A;
        private System.Windows.Forms.Label label_B;
        private System.Windows.Forms.Label label_N;
    }
}

