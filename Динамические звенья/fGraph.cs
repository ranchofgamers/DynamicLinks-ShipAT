using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
//using System.Linq;
//using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Динамические_звенья
{
    public partial class fGraph : Form
    {
        Frm f;
        Error errorWindow;
        public fGraph(Frm f)
        {
            InitializeComponent();
            this.f = f;
            PB.Image = new Bitmap(PB.Width, PB.Height);

        }
        public void ReDraw(Frm f)
        {
            this.f = f;
            Picture(true);
        }
        private void Picture(bool Slow)
        {
            float T2 = f.TB0.Value;
            float T1 = f.TB1.Value;
            float k0 = f.TB2.Value;
            float k1 = f.TB3.Value;
            float k2 = f.TB4.Value * 0.1f;
            float Tmax = f.TB5.Value;
            int dd = 25;
            int n = PB.Width - 2 * dd;
            float Mt = n / Tmax;
            float My = 11;
            float Mdy = 110;
            float Md2y = 110;
            float zoom = f.TB6.Value / 100f;
            float y0 = PB.Height / zoom;

            using (Graphics g = Graphics.FromImage(PB.Image))
            {
                float dTmax = Tmax / 5f;
                float dX = n / 5f;
                float dY = (PB.Height - 2 * dd) / 5f;
                g.Clear(Color.SkyBlue);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                for (int i = 1; i <= 5; i++)
                {
                    float x = dd + i * dX;
                    g.DrawLine(Pens.Gray, x, 0, x, PB.Height);
                    g.DrawLine(Pens.Black, x, y0 - 2, x, y0 + 2);
                    g.DrawString(string.Format("{0:F0}", i * dTmax), Font, Brushes.Black, x - 10, y0 + 2);
                }
                g.DrawString("Tm", Font, Brushes.Black, PB.Width - 20, y0 - 15);
                for (int i = 0; i <= 10; i++)
                {
                    float y = y0 +(3- i) * dY;
                    g.DrawLine(Pens.Gray, 0, y, PB.Width, y);
                }
                g.DrawLine(Pens.Black, dd, 0, dd, PB.Height);
                g.DrawLine(Pens.Black, 0, y0, PB.Width, y0);
                float yT = 5;
                float B = 0;
                string[] aN = new string[0];
                Brush[] aB = new Brush[0];
                float[] aY = new float[0];
                int nn = 0;
                if (T1 != 0 & T2 == 0)
                {
                    float dt = Tmax / n;
                    if (T1 < dt) dt = T1;
                    float t = 0;
                    float x = 1;
                    float dx = 1 / dt;
                    float y = 0;
                    float dy = (k0 * x + k1 * dx) / T1;
                    float tc = t;
                    float yc = y;
                    float dyc = dy;
                    dx = 0;
                    float ww = 0;
                    aN = new string[] { "dY", "Y" };
                    aB = new Brush[] { Brushes.Blue, Brushes.Magenta };
                    aY = new float[aN.Length];
                    do
                    {
                        t += dt;
                        y += dy * dt;
                        dy = (k0 * x + k2 * t - y) / T1;
                        float a = dd + tc * Mt;
                        B = dd + t * Mt;
                        g.DrawLine(Pens.Blue, a, y0 - Mdy * dyc, B, y0 - Mdy * dy);
                        aY[0] = y0 - Mdy * dy;
                        g.DrawLine(Pens.Magenta, a, y0 - My * yc, B, y0 - My * y);
                        aY[1] = y0 - My * y;
                        ww = 1;
                        tc = t;
                        yc = y;
                        dyc = dy;
                        if (f.CB.Checked && Slow && ++nn % 1 == 0) PB.Refresh();
                    } while (t + dt <= Tmax);
                    if (f.TB0.Value == 0 & f.TB1.Value != 0 & f.TB2.Value != 0 & f.TB3.Value == 0 & f.TB4.Value == 0)
                        g.DrawString(string.Format("Инерционное звено 1-ого порядка"), Font, Brushes.Black, dd + 5, yT);
                    if (f.TB0.Value == 0 & f.TB1.Value != 0 & f.TB2.Value == 0 & f.TB3.Value != 0 & f.TB4.Value == 0)
                        g.DrawString(string.Format("Реальное дифференцирующее звено"), Font, Brushes.Black, dd + 5, yT);
                    if (f.TB0.Value == 0 & f.TB1.Value != 0 & f.TB2.Value == 0 & f.TB3.Value == 0 & f.TB4.Value != 0)
                        g.DrawString(string.Format("Реальное интегрирующее звено"), Font, Brushes.Black, dd + 5, yT);
                }
                if (T1 != 0 & T2 != 0)
                {
                    float T22 = T2 * T2;
                    float dt;
                    if (T1 < T2) dt = 0.2f * T1;
                    else dt = 0.2f * T22 / T1;
                    if (k1 != 0) dt *= 0.1f;
                    float t = 0;
                    float x = 1;
                    float dx = 1 / dt;
                    float y = 0;
                    float dy = 0;
                    float d2y = (k0 * x + k1 * dx) / T22;
                    float tc = t;
                    float yc = y;
                    float dyc = dy;
                    float d2yc = d2y;
                    float ww = 0;
                    float ww1 = 0;
                    aN = new string[] { "d2Y", "dY", "Y" };
                    aB = new Brush[] { Brushes.Red, Brushes.Blue, Brushes.Magenta };
                    aY = new float[aN.Length];
                    do
                    {
                        t += dt;
                        y += dy * dt;
                        dy += d2y * dt;
                        d2y = (k0 + k2 * t - y - T1 * dy) / T22;
                        float a = dd + tc * Mt;
                        B = dd + t * Mt;
                        g.DrawLine(Pens.Red, a, y0 - Md2y * d2yc, B, y0 - Md2y * d2y);
                        aY[0] = y0 - Md2y * d2y;
                        g.DrawLine(Pens.Blue, a, y0 - Mdy * dyc, B, y0 - Mdy * dy);
                        aY[1] = y0 - Mdy * dy;
                        g.DrawLine(Pens.Magenta, a, y0 - My * yc, B, y0 - My * y);
                        aY[2] = y0 - My * y;
                        tc = t;
                        yc = y;
                        dyc = dy;
                        d2yc = d2y;
                        if (f.CB.Checked && Slow && ++nn % 1 == 0) PB.Refresh();
                    } while (t + dt <= Tmax);                  
                    if (T1<2*T2)
                        g.DrawString(string.Format("Колебательное звено"), Font, Brushes.Black, dd + 5, yT);
                    else g.DrawString(string.Format("Инерционное звено 2-ого порядка"), Font, Brushes.Black, dd + 5, yT);
                }
                if (T1 == 0 & T2 == 0)
                {
                    float dt = Tmax / n;
                    float t = 0;
                    float x = 1;
                    float dx = 1 / dt;
                    float y = k0 * x + k1 * dx;
                    float dy = (k0 + k1) * dx + k2;
                    float tc = t;
                    float yc = y;
                    float dyc = dy;
                    //float d2yc = d2y;
                    float ww = 0;
                    aN = new string[] { "Y", "dY" };
                    aB = new Brush[] { Brushes.Magenta, Brushes.Blue };
                    aY = new float[aN.Length];
                    do
                    {
                        t += dt;
                        y = k0 * x + k2 * t;
                        dy = k2;
                        float a = dd + tc * Mt;
                        B = dd + t * Mt;
                        g.DrawLine(Pens.Magenta, a, y0 - My * yc, B, y0 - My * y);
                        aY[0] = y0 - My * y;
                        g.DrawLine(Pens.Blue, a, y0 - Mdy * dyc, B, y0 - Mdy * dy);
                        aY[1] = y0 - Mdy * dy;
                        tc = t;
                        yc = y;
                        dyc = dy;
                        //float d2yc = d2y;
                        if (f.CB.Checked && Slow && ++nn % 1 == 0) PB.Refresh();
                    } while (t + dt <= Tmax);
                    if (f.TB0.Value == 0 & f.TB1.Value == 0 & f.TB2.Value != 0 & f.TB3.Value == 0 & f.TB4.Value == 0)
                        g.DrawString(string.Format("Безынерционное звено"), Font, Brushes.Black, dd + 5, yT);
                    if (f.TB0.Value == 0 & f.TB1.Value == 0 & f.TB2.Value == 0  & f.TB3.Value != 0 & f.TB4.Value == 0)
                        g.DrawString(string.Format("Идеальное дифференцирующее звено"), Font, Brushes.Black, dd + 5, yT);
                    if (f.TB0.Value == 0 & f.TB1.Value == 0 & f.TB2.Value == 0 & f.TB3.Value == 0 & f.TB4.Value != 0)
                        g.DrawString(string.Format("Идеальное интегрирующее звено"), Font, Brushes.Black, dd + 5, yT);

                }
                if (T1 == 0 & T2 != 0)
                {
                    try
                    {
                        float T22 = T2 * T2;
                        float dt = 0.1f * T2;
                        if (dt > 1) dt = Tmax / n;
                        float t = 0;
                        float x = 1;
                        float dx = 1 / dt;
                        float y = 0;
                        float dy = 0;
                        float d2y = (k0 * x + k1 * dx) / T22;
                        float tc = t;
                        float yc = y;
                        float dyc = dy;
                        float d2yc = d2y;
                        float ww = 0;
                        aN = new string[] { "d2Y", "dY", "Y" };
                        aB = new Brush[] { Brushes.Red, Brushes.Blue, Brushes.Magenta };
                        aY = new float[aN.Length];
                        do
                        {
                            t += dt;
                            y += dy * dt;
                            dy += d2y * dt;
                            d2y = (k0 * x + k2 * t - y) / T22;
                            float a = dd + tc * Mt;
                            B = dd + t * Mt;
                            g.DrawLine(Pens.Red, a, y0 - Md2y * d2yc, B, y0 - Md2y * d2y);
                            aY[0] = y0 - Md2y * d2y;
                            g.DrawLine(Pens.Blue, a, y0 - Mdy * dyc, B, y0 - Mdy * dy);
                            aY[1] = y0 - Mdy * dy;
                            g.DrawLine(Pens.Magenta, a, y0 - My * yc, B, y0 - My * y);
                            aY[2] = y0 - My * y;
                            tc = t;
                            yc = y;
                            dyc = dy;
                            d2yc = d2y;
                            if (f.CB.Checked && Slow && ++nn % 1 == 0) PB.Refresh();
                        } while (t + dt <= Tmax);
                        g.DrawString(string.Format("Колебательное звено при T1 = 0 (Незатухающие колебания)"), Font, Brushes.Black, dd + 5, yT);
                    }
                    catch
                    {
                        if (errorWindow == null)
                            errorWindow = new Error();
                        if (errorWindow.Visible == false)
                            errorWindow.ShowDialog();
                        f.TB5.Value = f.TB5.Minimum;
                    }
                    }
                for (int i = 0; i < aN.Length; i++)
                    g.DrawString(aN[i], Font, aB[i], B - dd, aY[i] - 15);
            }
            PB.Refresh();
        }

        private void fGraph_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Close();
        }

        private void fGraph_Resize(object sender, EventArgs e)
        {
            if (PB.Width > 0 && PB.Height > 0)
            {
                PB.Image.Dispose();
                PB.Image = new Bitmap(PB.Width, PB.Height);
                Picture(false);
            }
        }

        private void fGraph_Shown(object sender, EventArgs e)
        {
            Picture(true);
        }

        private void fGraph_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.fG = null;
        }

        private void PB_Click(object sender, EventArgs e)
        {

        }
    }
}
