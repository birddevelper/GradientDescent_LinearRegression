namespace GradientDescent_LinearRegression
{
    partial class frmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_adddata = new System.Windows.Forms.Button();
            this.txt_ydata = new System.Windows.Forms.TextBox();
            this.txt_xdata = new System.Windows.Forms.TextBox();
            this.Trining_Graph = new ZedGraph.ZedGraphControl();
            this.btn_trining = new System.Windows.Forms.Button();
            this.txt_x = new System.Windows.Forms.TextBox();
            this.txt_y = new System.Windows.Forms.TextBox();
            this.btn_predict = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.txt_alpha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CntGrph = new GradientDescent_LinearRegression.FunctionGraph();
            this.btn_clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CntGrph);
            this.groupBox1.Location = new System.Drawing.Point(620, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 544);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cost Function Contour Graph";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_clear);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_alpha);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_adddata);
            this.groupBox2.Controls.Add(this.txt_ydata);
            this.groupBox2.Controls.Add(this.txt_xdata);
            this.groupBox2.Controls.Add(this.Trining_Graph);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 544);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Training Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "x :";
            // 
            // btn_adddata
            // 
            this.btn_adddata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_adddata.Location = new System.Drawing.Point(199, 17);
            this.btn_adddata.Name = "btn_adddata";
            this.btn_adddata.Size = new System.Drawing.Size(140, 22);
            this.btn_adddata.TabIndex = 3;
            this.btn_adddata.Text = "Add To Training Data";
            this.btn_adddata.UseVisualStyleBackColor = true;
            this.btn_adddata.Click += new System.EventHandler(this.btn_adddata_Click);
            // 
            // txt_ydata
            // 
            this.txt_ydata.Location = new System.Drawing.Point(136, 18);
            this.txt_ydata.Name = "txt_ydata";
            this.txt_ydata.Size = new System.Drawing.Size(55, 20);
            this.txt_ydata.TabIndex = 2;
            // 
            // txt_xdata
            // 
            this.txt_xdata.Location = new System.Drawing.Point(47, 18);
            this.txt_xdata.Name = "txt_xdata";
            this.txt_xdata.Size = new System.Drawing.Size(57, 20);
            this.txt_xdata.TabIndex = 1;
            // 
            // Trining_Graph
            // 
            this.Trining_Graph.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trining_Graph.Location = new System.Drawing.Point(6, 45);
            this.Trining_Graph.Name = "Trining_Graph";
            this.Trining_Graph.ScrollGrace = 0;
            this.Trining_Graph.ScrollMaxX = 0;
            this.Trining_Graph.ScrollMaxY = 0;
            this.Trining_Graph.ScrollMaxY2 = 0;
            this.Trining_Graph.ScrollMinX = 0;
            this.Trining_Graph.ScrollMinY = 0;
            this.Trining_Graph.ScrollMinY2 = 0;
            this.Trining_Graph.Size = new System.Drawing.Size(566, 493);
            this.Trining_Graph.TabIndex = 0;
            this.Trining_Graph.MouseDownEvent += new ZedGraph.ZedGraphControl.ZedMouseEventHandler(this.Trining_Graph_MouseDownEvent);
            this.Trining_Graph.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Trining_Graph_MouseClick);
            // 
            // btn_trining
            // 
            this.btn_trining.Location = new System.Drawing.Point(12, 562);
            this.btn_trining.Name = "btn_trining";
            this.btn_trining.Size = new System.Drawing.Size(109, 23);
            this.btn_trining.TabIndex = 4;
            this.btn_trining.Text = "Start Training";
            this.btn_trining.UseVisualStyleBackColor = true;
            this.btn_trining.Click += new System.EventHandler(this.btn_trining_Click);
            // 
            // txt_x
            // 
            this.txt_x.Location = new System.Drawing.Point(275, 564);
            this.txt_x.Name = "txt_x";
            this.txt_x.Size = new System.Drawing.Size(100, 20);
            this.txt_x.TabIndex = 5;
            // 
            // txt_y
            // 
            this.txt_y.Location = new System.Drawing.Point(484, 564);
            this.txt_y.Name = "txt_y";
            this.txt_y.Size = new System.Drawing.Size(100, 20);
            this.txt_y.TabIndex = 6;
            // 
            // btn_predict
            // 
            this.btn_predict.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_predict.Location = new System.Drawing.Point(381, 562);
            this.btn_predict.Name = "btn_predict";
            this.btn_predict.Size = new System.Drawing.Size(97, 23);
            this.btn_predict.TabIndex = 7;
            this.btn_predict.Text = "Predict y  >>";
            this.btn_predict.UseVisualStyleBackColor = true;
            this.btn_predict.Click += new System.EventHandler(this.btn_predict_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(248, 567);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "x :";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_status.ForeColor = System.Drawing.Color.Blue;
            this.lbl_status.Location = new System.Drawing.Point(128, 567);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 13);
            this.lbl_status.TabIndex = 9;
            // 
            // txt_alpha
            // 
            this.txt_alpha.Location = new System.Drawing.Point(534, 17);
            this.txt_alpha.Name = "txt_alpha";
            this.txt_alpha.Size = new System.Drawing.Size(47, 20);
            this.txt_alpha.TabIndex = 6;
            this.txt_alpha.Text = "0.001";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Learning rate :";
            // 
            // CntGrph
            // 
            this.CntGrph.Area = new System.Drawing.Rectangle(-10, -10, 20, 20);
            this.CntGrph.Function = null;
            this.CntGrph.Location = new System.Drawing.Point(18, 18);
            this.CntGrph.Name = "CntGrph";
            this.CntGrph.Size = new System.Drawing.Size(522, 520);
            this.CntGrph.TabIndex = 1;
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_clear.Location = new System.Drawing.Point(345, 16);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(88, 23);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 591);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_predict);
            this.Controls.Add(this.txt_y);
            this.Controls.Add(this.txt_x);
            this.Controls.Add(this.btn_trining);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gradient Descent for two variable linear regression";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_trining;
        private FunctionGraph CntGrph;
        private ZedGraph.ZedGraphControl Trining_Graph;
        private System.Windows.Forms.TextBox txt_x;
        private System.Windows.Forms.TextBox txt_y;
        private System.Windows.Forms.Button btn_predict;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_adddata;
        private System.Windows.Forms.TextBox txt_ydata;
        private System.Windows.Forms.TextBox txt_xdata;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_alpha;
        private System.Windows.Forms.Button btn_clear;
    }
}

