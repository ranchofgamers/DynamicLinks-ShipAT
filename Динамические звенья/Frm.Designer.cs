namespace Динамические_звенья
{
    partial class Frm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TXT = new System.Windows.Forms.RichTextBox();
            this.TB5 = new System.Windows.Forms.TrackBar();
            this.lbTB5 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lbTB1 = new System.Windows.Forms.Label();
            this.TB1 = new System.Windows.Forms.TrackBar();
            this.lb0 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB0 = new System.Windows.Forms.TrackBar();
            this.lb3 = new System.Windows.Forms.Label();
            this.lbTB3 = new System.Windows.Forms.Label();
            this.TB3 = new System.Windows.Forms.TrackBar();
            this.lb2 = new System.Windows.Forms.Label();
            this.lbTB2 = new System.Windows.Forms.Label();
            this.TB2 = new System.Windows.Forms.TrackBar();
            this.lb4 = new System.Windows.Forms.Label();
            this.lbTB4 = new System.Windows.Forms.Label();
            this.TB4 = new System.Windows.Forms.TrackBar();
            this.btGraph = new System.Windows.Forms.Button();
            this.CB = new System.Windows.Forms.CheckBox();
            this.TB6 = new System.Windows.Forms.TrackBar();
            this.lb6 = new System.Windows.Forms.Label();
            this.panel0 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TB5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB6)).BeginInit();
            this.panel0.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXT
            // 
            this.TXT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXT.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TXT.Location = new System.Drawing.Point(0, 0);
            this.TXT.Name = "TXT";
            this.TXT.ReadOnly = true;
            this.TXT.Size = new System.Drawing.Size(715, 245);
            this.TXT.TabIndex = 3;
            this.TXT.Text = "";
            this.TXT.TextChanged += new System.EventHandler(this.TXT_TextChanged);
            this.TXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_KeyDown);
            // 
            // TB5
            // 
            this.TB5.BackColor = System.Drawing.SystemColors.Control;
            this.TB5.Location = new System.Drawing.Point(49, 1);
            this.TB5.Maximum = 150;
            this.TB5.Minimum = 50;
            this.TB5.Name = "TB5";
            this.TB5.Size = new System.Drawing.Size(185, 45);
            this.TB5.TabIndex = 7;
            this.TB5.TickFrequency = 25;
            this.TB5.Value = 50;
            this.TB5.Scroll += new System.EventHandler(this.TB_Scroll);
            this.TB5.ValueChanged += new System.EventHandler(this.TB_Scroll);
            this.TB5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_KeyDown);
            // 
            // lbTB5
            // 
            this.lbTB5.AutoSize = true;
            this.lbTB5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTB5.Location = new System.Drawing.Point(56, 29);
            this.lbTB5.Name = "lbTB5";
            this.lbTB5.Size = new System.Drawing.Size(176, 12);
            this.lbTB5.TabIndex = 8;
            this.lbTB5.Text = "50               75             100             120            150";
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.BackColor = System.Drawing.Color.Transparent;
            this.lb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb5.Location = new System.Drawing.Point(3, 6);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(25, 13);
            this.lb5.TabIndex = 9;
            this.lb5.Text = "Tm:";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.BackColor = System.Drawing.Color.Transparent;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1.Location = new System.Drawing.Point(3, 6);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(23, 13);
            this.lb1.TabIndex = 12;
            this.lb1.Text = "T1:";
            this.lb1.Click += new System.EventHandler(this.lb1_Click);
            // 
            // lbTB1
            // 
            this.lbTB1.AutoSize = true;
            this.lbTB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTB1.Location = new System.Drawing.Point(52, 29);
            this.lbTB1.Name = "lbTB1";
            this.lbTB1.Size = new System.Drawing.Size(170, 12);
            this.lbTB1.TabIndex = 11;
            this.lbTB1.Text = "0     2     4      6     8    10    12   14  16   18   20";
            // 
            // TB1
            // 
            this.TB1.BackColor = System.Drawing.SystemColors.Control;
            this.TB1.Location = new System.Drawing.Point(43, 1);
            this.TB1.Maximum = 20;
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(185, 45);
            this.TB1.TabIndex = 10;
            this.TB1.TickFrequency = 2;
            this.TB1.Scroll += new System.EventHandler(this.TB_Scroll);
            this.TB1.ValueChanged += new System.EventHandler(this.TB_Scroll);
            this.TB1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_KeyDown);
            // 
            // lb0
            // 
            this.lb0.AutoSize = true;
            this.lb0.BackColor = System.Drawing.Color.Transparent;
            this.lb0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb0.Location = new System.Drawing.Point(5, 6);
            this.lb0.Name = "lb0";
            this.lb0.Size = new System.Drawing.Size(23, 13);
            this.lb0.TabIndex = 15;
            this.lb0.Text = "T2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(55, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "0     2     4      6     8    10    12   14  16   18   20";
            // 
            // TB0
            // 
            this.TB0.BackColor = System.Drawing.SystemColors.Control;
            this.TB0.Location = new System.Drawing.Point(46, 1);
            this.TB0.Maximum = 20;
            this.TB0.Name = "TB0";
            this.TB0.Size = new System.Drawing.Size(185, 45);
            this.TB0.TabIndex = 13;
            this.TB0.TickFrequency = 2;
            this.TB0.Scroll += new System.EventHandler(this.TB_Scroll);
            this.TB0.ValueChanged += new System.EventHandler(this.TB_Scroll);
            this.TB0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_KeyDown);
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.BackColor = System.Drawing.Color.Transparent;
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb3.Location = new System.Drawing.Point(5, 5);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(23, 13);
            this.lb3.TabIndex = 21;
            this.lb3.Text = "K1:";
            // 
            // lbTB3
            // 
            this.lbTB3.AutoSize = true;
            this.lbTB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTB3.Location = new System.Drawing.Point(55, 29);
            this.lbTB3.Name = "lbTB3";
            this.lbTB3.Size = new System.Drawing.Size(170, 12);
            this.lbTB3.TabIndex = 20;
            this.lbTB3.Text = "0     2     4      6     8    10    12   14  16   18   20";
            // 
            // TB3
            // 
            this.TB3.BackColor = System.Drawing.SystemColors.Control;
            this.TB3.Location = new System.Drawing.Point(46, 3);
            this.TB3.Maximum = 20;
            this.TB3.Name = "TB3";
            this.TB3.Size = new System.Drawing.Size(185, 45);
            this.TB3.TabIndex = 19;
            this.TB3.TickFrequency = 2;
            this.TB3.Scroll += new System.EventHandler(this.TB_Scroll);
            this.TB3.ValueChanged += new System.EventHandler(this.TB_Scroll);
            this.TB3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_KeyDown);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.BackColor = System.Drawing.Color.Transparent;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb2.Location = new System.Drawing.Point(2, 6);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(23, 13);
            this.lb2.TabIndex = 18;
            this.lb2.Text = "K0:";
            // 
            // lbTB2
            // 
            this.lbTB2.AutoSize = true;
            this.lbTB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTB2.Location = new System.Drawing.Point(51, 25);
            this.lbTB2.Name = "lbTB2";
            this.lbTB2.Size = new System.Drawing.Size(170, 12);
            this.lbTB2.TabIndex = 17;
            this.lbTB2.Text = "0     2     4      6     8    10    12   14  16   18   20";
            // 
            // TB2
            // 
            this.TB2.BackColor = System.Drawing.SystemColors.Control;
            this.TB2.Location = new System.Drawing.Point(42, 1);
            this.TB2.Maximum = 20;
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(185, 45);
            this.TB2.TabIndex = 16;
            this.TB2.TickFrequency = 2;
            this.TB2.Scroll += new System.EventHandler(this.TB_Scroll);
            this.TB2.ValueChanged += new System.EventHandler(this.TB_Scroll);
            this.TB2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_KeyDown);
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.BackColor = System.Drawing.Color.Transparent;
            this.lb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb4.Location = new System.Drawing.Point(3, 6);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(23, 13);
            this.lb4.TabIndex = 24;
            this.lb4.Text = "K2:";
            // 
            // lbTB4
            // 
            this.lbTB4.AutoSize = true;
            this.lbTB4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTB4.Location = new System.Drawing.Point(57, 37);
            this.lbTB4.Name = "lbTB4";
            this.lbTB4.Size = new System.Drawing.Size(170, 12);
            this.lbTB4.TabIndex = 23;
            this.lbTB4.Text = "0     2     4      6     8    10    12   14  16   18   20";
            // 
            // TB4
            // 
            this.TB4.BackColor = System.Drawing.SystemColors.Control;
            this.TB4.Location = new System.Drawing.Point(48, 4);
            this.TB4.Maximum = 20;
            this.TB4.Name = "TB4";
            this.TB4.Size = new System.Drawing.Size(185, 45);
            this.TB4.TabIndex = 22;
            this.TB4.TickFrequency = 2;
            this.TB4.Scroll += new System.EventHandler(this.TB_Scroll);
            this.TB4.ValueChanged += new System.EventHandler(this.TB_Scroll);
            this.TB4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_KeyDown);
            // 
            // btGraph
            // 
            this.btGraph.Location = new System.Drawing.Point(513, 6);
            this.btGraph.Name = "btGraph";
            this.btGraph.Size = new System.Drawing.Size(186, 41);
            this.btGraph.TabIndex = 25;
            this.btGraph.Text = "Построить";
            this.btGraph.UseVisualStyleBackColor = true;
            this.btGraph.Click += new System.EventHandler(this.btGraph_Click);
            this.btGraph.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_KeyDown);
            // 
            // CB
            // 
            this.CB.AutoSize = true;
            this.CB.Location = new System.Drawing.Point(315, 30);
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(196, 17);
            this.CB.TabIndex = 26;
            this.CB.Text = "Замедленный режим построения";
            this.CB.UseVisualStyleBackColor = true;
            this.CB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_KeyDown);
            // 
            // TB6
            // 
            this.TB6.BackColor = System.Drawing.SystemColors.Control;
            this.TB6.LargeChange = 100;
            this.TB6.Location = new System.Drawing.Point(114, 4);
            this.TB6.Maximum = 300;
            this.TB6.Minimum = 120;
            this.TB6.Name = "TB6";
            this.TB6.Size = new System.Drawing.Size(185, 45);
            this.TB6.TabIndex = 27;
            this.TB6.TickFrequency = 10;
            this.TB6.Value = 120;
            this.TB6.Scroll += new System.EventHandler(this.TB_Scroll);
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.BackColor = System.Drawing.Color.Transparent;
            this.lb6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb6.Location = new System.Drawing.Point(2, 9);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(106, 13);
            this.lb6.TabIndex = 28;
            this.lb6.Text = "Сдвиг оси абсцисс:";
            // 
            // panel0
            // 
            this.panel0.Controls.Add(this.panel8);
            this.panel0.Controls.Add(this.CB);
            this.panel0.Controls.Add(this.panel7);
            this.panel0.Controls.Add(this.panel6);
            this.panel0.Controls.Add(this.panel5);
            this.panel0.Controls.Add(this.panel2);
            this.panel0.Controls.Add(this.panel3);
            this.panel0.Controls.Add(this.panel1);
            this.panel0.Controls.Add(this.panel4);
            this.panel0.Controls.Add(this.btGraph);
            this.panel0.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel0.Location = new System.Drawing.Point(0, 245);
            this.panel0.Name = "panel0";
            this.panel0.Size = new System.Drawing.Size(715, 166);
            this.panel0.TabIndex = 0;
            this.panel0.Paint += new System.Windows.Forms.PaintEventHandler(this.panel0_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbTB1);
            this.panel4.Controls.Add(this.TB1);
            this.panel4.Controls.Add(this.lb1);
            this.panel4.Location = new System.Drawing.Point(3, 112);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(230, 49);
            this.panel4.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb2);
            this.panel1.Controls.Add(this.lbTB2);
            this.panel1.Controls.Add(this.TB2);
            this.panel1.Location = new System.Drawing.Point(3, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 52);
            this.panel1.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbTB4);
            this.panel3.Controls.Add(this.lb4);
            this.panel3.Controls.Add(this.TB4);
            this.panel3.Location = new System.Drawing.Point(472, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 52);
            this.panel3.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbTB3);
            this.panel2.Controls.Add(this.TB3);
            this.panel2.Controls.Add(this.lb3);
            this.panel2.Location = new System.Drawing.Point(235, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 51);
            this.panel2.TabIndex = 33;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lb0);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.TB0);
            this.panel5.Location = new System.Drawing.Point(235, 112);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(234, 49);
            this.panel5.TabIndex = 34;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lb5);
            this.panel6.Controls.Add(this.lbTB5);
            this.panel6.Controls.Add(this.TB5);
            this.panel6.Location = new System.Drawing.Point(472, 112);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(240, 49);
            this.panel6.TabIndex = 35;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lb6);
            this.panel7.Controls.Add(this.TB6);
            this.panel7.Location = new System.Drawing.Point(3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(308, 51);
            this.panel7.TabIndex = 36;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel8.Location = new System.Drawing.Point(-2, 54);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(720, 2);
            this.panel8.TabIndex = 37;
            // 
            // Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 411);
            this.Controls.Add(this.TXT);
            this.Controls.Add(this.panel0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(731, 450);
            this.MinimumSize = new System.Drawing.Size(731, 209);
            this.Name = "Frm";
            this.Text = "Динамические звенья";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.TB5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB6)).EndInit();
            this.panel0.ResumeLayout(false);
            this.panel0.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox TXT;
        private System.Windows.Forms.Label lbTB5;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lbTB1;
        private System.Windows.Forms.Label lb0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lbTB3;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lbTB2;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lbTB4;
        private System.Windows.Forms.Button btGraph;
        public System.Windows.Forms.TrackBar TB5;
        public System.Windows.Forms.TrackBar TB1;
        public System.Windows.Forms.TrackBar TB0;
        public System.Windows.Forms.TrackBar TB3;
        public System.Windows.Forms.TrackBar TB2;
        public System.Windows.Forms.TrackBar TB4;
        public System.Windows.Forms.CheckBox CB;
        public System.Windows.Forms.TrackBar TB6;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Panel panel0;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
    }
}

