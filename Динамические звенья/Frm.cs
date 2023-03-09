using System;
using System.Drawing;
using System.Windows.Forms;

namespace Динамические_звенья
{
    public partial class Frm : Form
    {
        public fGraph fG = null;
        public Frm()
        {
            InitializeComponent();
            string[] str ={
"                                Исследование типовых динамических звеньев                             ",
"",
"   Целью работы является изучение переходных процессов в типовых динамических звеньях систем ",
"автоматического управления, исследование влияния параметров звеньев на характер переходных процессов.",
"   В процессе выполнения работы необходимо:",
"   1. Исследовать инерционное звено первого порядка при различных значениях постоянной времени Т1. ",
"Выяснить влияние производной входного параметра dx/dt на характеристики звена, определить, при каком",
"соотношении T1, K0, K1 звено становится практически безинерционным.",
"   2. Исследовать реальное дифференцирующее звено при различных значениях постоянной времени Т1 .",
"   3. Исследовать реальное интегрирующее звено при различных значениях постоянной времени Т1. ",
"   4. Исследовать инерционное звено второго порядка и колебательное звено при различных значениях",
"постоянных времени Т1 и Т2. ",
"",
"Примечание: если отклик программы увеличился или она работает не стабильно, пожалуйста, используйте",
"функцию - 'замедленный режим построения'."
};

            for (int i = 0; i < str.Length; i++)
                TXT.Text += str[i] + "\n";
            TB5.Value = 50;
        }

        private void Frm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Close();
        }

        private void TB_Scroll(object sender, EventArgs e)
        {
            lb0.Text = "T2 = " + TB0.Value + ":";
            lb1.Text = "T1 = " + TB1.Value + ":";
            lb2.Text = "K0 = " + TB2.Value + ":";
            lb3.Text = "K1 = " + TB3.Value + ":";
            lb4.Text = "K2 = " + TB4.Value + ":";
            lb5.Text = "Tm = " + TB5.Value + ":";
            if (fG != null && !CB.Checked)
                fG.ReDraw(this);
        }

        private void btGraph_Click(object sender, EventArgs e)
        {
            if (fG == null || !fG.Enabled)
            {
                fG = new fGraph(this);
                fG.Show();
            }
            else
            {
                if (fG.WindowState == FormWindowState.Minimized)
                    fG.WindowState = FormWindowState.Normal;
                fG.BringToFront();
                fG.ReDraw(this);
            }
        }

        private void lb1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel0_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TXT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
