namespace Calculus
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
            this.btExit = new System.Windows.Forms.Button();
            this.btAbout = new System.Windows.Forms.Button();
            this.k = new System.Windows.Forms.TextBox();
            this.p = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.limA = new System.Windows.Forms.TextBox();
            this.limB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.stepN = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.btCalculate = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.btGraph = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(758, 612);
            this.btExit.Margin = new System.Windows.Forms.Padding(6);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(204, 48);
            this.btExit.TabIndex = 7;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btAbout
            // 
            this.btAbout.Location = new System.Drawing.Point(758, 546);
            this.btAbout.Margin = new System.Windows.Forms.Padding(6);
            this.btAbout.Name = "btAbout";
            this.btAbout.Size = new System.Drawing.Size(204, 48);
            this.btAbout.TabIndex = 8;
            this.btAbout.Text = "О программе";
            this.btAbout.UseVisualStyleBackColor = true;
            this.btAbout.Click += new System.EventHandler(this.btAbout_Click);
            // 
            // k
            // 
            this.k.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.k.Location = new System.Drawing.Point(901, 292);
            this.k.Margin = new System.Windows.Forms.Padding(6);
            this.k.Multiline = true;
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(40, 40);
            this.k.TabIndex = 22;
            this.k.Text = "k";
            this.k.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.k.Enter += new System.EventHandler(this.k_Enter);
            this.k.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.graphA_KeyPress);
            this.k.Leave += new System.EventHandler(this.k_Leave);
            // 
            // p
            // 
            this.p.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.p.Location = new System.Drawing.Point(961, 292);
            this.p.Margin = new System.Windows.Forms.Padding(6);
            this.p.Multiline = true;
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(40, 40);
            this.p.TabIndex = 21;
            this.p.Text = "p";
            this.p.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.p.Enter += new System.EventHandler(this.p_Enter);
            this.p.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.graphB_KeyPress);
            this.p.Leave += new System.EventHandler(this.p_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(679, 297);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Коэффициенты:";
            // 
            // zedGraph
            // 
            this.zedGraph.Location = new System.Drawing.Point(15, 15);
            this.zedGraph.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(593, 645);
            this.zedGraph.TabIndex = 24;
            // 
            // limA
            // 
            this.limA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limA.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.limA.Location = new System.Drawing.Point(629, 169);
            this.limA.Margin = new System.Windows.Forms.Padding(6);
            this.limA.Multiline = true;
            this.limA.Name = "limA";
            this.limA.Size = new System.Drawing.Size(40, 40);
            this.limA.TabIndex = 27;
            this.limA.Text = "a";
            this.limA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.limA.Enter += new System.EventHandler(this.limA_Enter);
            this.limA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.limA_KeyPress);
            this.limA.Leave += new System.EventHandler(this.limA_Leave);
            // 
            // limB
            // 
            this.limB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limB.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.limB.Location = new System.Drawing.Point(629, 16);
            this.limB.Margin = new System.Windows.Forms.Padding(6);
            this.limB.Multiline = true;
            this.limB.Name = "limB";
            this.limB.Size = new System.Drawing.Size(40, 40);
            this.limB.TabIndex = 26;
            this.limB.Text = "b";
            this.limB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.limB.Enter += new System.EventHandler(this.limB_Enter);
            this.limB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.limB_KeyPress);
            this.limB.Leave += new System.EventHandler(this.limB_Leave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(618, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 111);
            this.label1.TabIndex = 25;
            this.label1.Text = "I";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(677, 67);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(132, 29);
            this.radioButton1.TabIndex = 28;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "dx / ln (x)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(677, 131);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(194, 29);
            this.radioButton2.TabIndex = 29;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "(sqrt(kx) + p) dx";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(876, 67);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(161, 29);
            this.radioButton3.TabIndex = 30;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "(kx  + px) dx";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(679, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Количество отрезков:";
            // 
            // stepN
            // 
            this.stepN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepN.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.stepN.Location = new System.Drawing.Point(960, 225);
            this.stepN.Margin = new System.Windows.Forms.Padding(6);
            this.stepN.Multiline = true;
            this.stepN.Name = "stepN";
            this.stepN.Size = new System.Drawing.Size(40, 40);
            this.stepN.TabIndex = 31;
            this.stepN.Text = "n";
            this.stepN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stepN.Enter += new System.EventHandler(this.step_Enter);
            this.stepN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.step_KeyPress);
            this.stepN.Leave += new System.EventHandler(this.step_Leave);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(829, 365);
            this.result.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(77, 25);
            this.result.TabIndex = 34;
            this.result.Text = "Ответ:";
            // 
            // btCalculate
            // 
            this.btCalculate.Location = new System.Drawing.Point(684, 353);
            this.btCalculate.Margin = new System.Windows.Forms.Padding(6);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(144, 48);
            this.btCalculate.TabIndex = 33;
            this.btCalculate.Text = "Вычислить";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(876, 134);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(190, 29);
            this.radioButton4.TabIndex = 35;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "(sin(x^k) / p) dx";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // btGraph
            // 
            this.btGraph.Location = new System.Drawing.Point(681, 432);
            this.btGraph.Margin = new System.Windows.Forms.Padding(6);
            this.btGraph.Name = "btGraph";
            this.btGraph.Size = new System.Drawing.Size(356, 46);
            this.btGraph.TabIndex = 20;
            this.btGraph.Text = "Показать график";
            this.btGraph.UseVisualStyleBackColor = true;
            this.btGraph.Click += new System.EventHandler(this.btGraph_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 675);
            this.Controls.Add(this.btGraph);
            this.Controls.Add(this.p);
            this.Controls.Add(this.k);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.result);
            this.Controls.Add(this.btCalculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stepN);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.limA);
            this.Controls.Add(this.limB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zedGraph);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btAbout);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вычисление определенных интегралов методом прямоугольников";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btAbout;
        private System.Windows.Forms.TextBox k;
        private System.Windows.Forms.TextBox p;
        private System.Windows.Forms.Label label5;
        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.TextBox limA;
        private System.Windows.Forms.TextBox limB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stepN;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button btGraph;
    }
}