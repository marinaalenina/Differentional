
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_N = new System.Windows.Forms.TextBox();
            this.text_B = new System.Windows.Forms.TextBox();
            this.text_A = new System.Windows.Forms.TextBox();
            this.text_Y1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_Y0 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart
            // 
            chartArea2.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Chart.Legends.Add(legend2);
            this.Chart.Location = new System.Drawing.Point(190, 12);
            this.Chart.Name = "Chart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Эйлер";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Рунге-Кутты";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Сама функция";
            this.Chart.Series.Add(series4);
            this.Chart.Series.Add(series5);
            this.Chart.Series.Add(series6);
            this.Chart.Size = new System.Drawing.Size(800, 600);
            this.Chart.TabIndex = 0;
            this.Chart.Text = "График";
            // 
            // Btn
            // 
            this.Btn.Location = new System.Drawing.Point(430, 700);
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
            this.label_Y.Size = new System.Drawing.Size(69, 13);
            this.label_Y.TabIndex = 6;
            this.label_Y.Text = "Введите y(0)";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 800);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Решить диффур";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Btn_Click_diffur);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 738);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Введите N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 682);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Введите В";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 618);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Введите А";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 554);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Введите y(1)";
            // 
            // text_N
            // 
            this.text_N.Location = new System.Drawing.Point(13, 754);
            this.text_N.Name = "text_N";
            this.text_N.Size = new System.Drawing.Size(136, 20);
            this.text_N.TabIndex = 14;
            // 
            // text_B
            // 
            this.text_B.Location = new System.Drawing.Point(13, 698);
            this.text_B.Name = "text_B";
            this.text_B.Size = new System.Drawing.Size(136, 20);
            this.text_B.TabIndex = 13;
            // 
            // text_A
            // 
            this.text_A.Location = new System.Drawing.Point(13, 634);
            this.text_A.Name = "text_A";
            this.text_A.Size = new System.Drawing.Size(136, 20);
            this.text_A.TabIndex = 12;
            // 
            // text_Y1
            // 
            this.text_Y1.Location = new System.Drawing.Point(13, 570);
            this.text_Y1.Name = "text_Y1";
            this.text_Y1.Size = new System.Drawing.Size(136, 20);
            this.text_Y1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Введите y(0)";
            // 
            // text_Y0
            // 
            this.text_Y0.Location = new System.Drawing.Point(13, 514);
            this.text_Y0.Name = "text_Y0";
            this.text_Y0.Size = new System.Drawing.Size(136, 20);
            this.text_Y0.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 850);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_Y0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_N);
            this.Controls.Add(this.text_B);
            this.Controls.Add(this.text_A);
            this.Controls.Add(this.text_Y1);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_N;
        private System.Windows.Forms.TextBox text_B;
        private System.Windows.Forms.TextBox text_A;
        private System.Windows.Forms.TextBox text_Y1;
        private System.Windows.Forms.TextBox text_Y0;
    }
}

