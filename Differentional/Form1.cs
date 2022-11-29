using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Differentional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double f(double x, double y)
        {
            return (x * x * y);
        }

        double f1(double x)
        {
            return (Math.Pow(Math.E, (x * x * x / 3)));
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            double y0 = double.Parse(txt_Y.Text);
            double a = double.Parse(txt_A.Text);
            double b = double.Parse(txt_B.Text);
            int n = Int32.Parse(txt_N.Text);
            double step = (b - a) / n;

            this.Chart.Series[0].Points.Clear();
            double y_next = y0, y_prev = y0, x = a;
            for (int i = 0; i < n; i++)
            {
                y_prev = y_next;
                y_next = y_prev + step * f(x, y_prev);
                this.Chart.Series[0].Points.AddXY(x, y_next);
                x += step;
            }

            y_next = y0;
            y_prev = y0;
            x = a;

            this.Chart.Series[1].Points.Clear();
            double y, k1, k2, k3, k4;
            for (int i = 0; i < n; i++)
            {
                y_prev = y_next;
                k1 = step * f(x, y_prev);
                k2 = step * f(x + step / 2, y_prev + k1 / 2);
                k3 = step * f(x + step / 2, y_prev + k2 / 2);
                k4 = step * f(x + step, y_prev + k3);
                y = (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                y_next = y_prev + y;
                this.Chart.Series[1].Points.AddXY(x, y_next);
                x += step;
            }

            double X = a;
            double Y = 0;
            this.Chart.Series[2].Points.Clear();
            while (X <= b)
            {
                Y = f1(X);
                this.Chart.Series[2].Points.AddXY(X, Y);
                X += step;
            }
        }

        private void Btn_Click_diffur(object sender, EventArgs e) {
            // y'' + y' - y * sin(x) = 0   y(0) = 1, y(1) = 1
            double y0 = double.Parse(text_Y0.Text);
            double y1 = double.Parse(text_Y1.Text);
            double A = double.Parse(text_A.Text);
            double B = double.Parse(text_B.Text);
            int n = Int32.Parse(text_N.Text);
            double step = (B - A) / n;
            double[] a = new double[n];
            double[] b = new double[n];
            double[] c = new double[n];

            for (int i = 0; i < n; i++) {
                a[i] = 1.0 / n * n;
                b[i] = ((-2.0) / n * n - 1.0 / n - Math.Sin(i));
                c[i] = 1.0 / n * n + 1.0 / n;
            }
            double[] s = new double[n];
            double[] t = new double[n];
            s[0] = 0; t[0] = 1;
            for (int i = 1; i < n; i++) {
                s[i] = (-c[i]) / (a[i] * s[i - 1] + b[i]);
                t[i] = ((-a[i]) * t[i - 1]) / (a[i] * s[i - 1] + b[i]);
            }
            double[] y = new double[n];
            y[y.Length - 1] = s[n - 1] * y1 + t[n - 1];
            for (int i = n - 2; i >= 0; i--) {
                y[i] = s[i] * y[i + 1] + t[i];
                Console.WriteLine(y[i].ToString());
            }
        }
    }
}
