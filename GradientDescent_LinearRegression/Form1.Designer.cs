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
            this.Trining_Graph = new ZedGraph.ZedGraphControl();
            this.btn_trining = new System.Windows.Forms.Button();
            this.CntGrph = new GradientDescent_LinearRegression.FunctionGraph();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CntGrph);
            this.groupBox1.Location = new System.Drawing.Point(620, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 518);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cost Function";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Trining_Graph);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 518);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Training Data";
            // 
            // Trining_Graph
            // 
            this.Trining_Graph.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trining_Graph.Location = new System.Drawing.Point(6, 19);
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
            this.btn_trining.Location = new System.Drawing.Point(12, 536);
            this.btn_trining.Name = "btn_trining";
            this.btn_trining.Size = new System.Drawing.Size(109, 23);
            this.btn_trining.TabIndex = 4;
            this.btn_trining.Text = "Start Training";
            this.btn_trining.UseVisualStyleBackColor = true;
            this.btn_trining.Click += new System.EventHandler(this.btn_trining_Click);
            // 
            // CntGrph
            // 
            this.CntGrph.Area = new System.Drawing.Rectangle(-5, -5, 20, 20);
            this.CntGrph.Function = null;
            this.CntGrph.Location = new System.Drawing.Point(18, 19);
            this.CntGrph.Name = "CntGrph";
            this.CntGrph.Size = new System.Drawing.Size(522, 493);
            this.CntGrph.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 569);
            this.Controls.Add(this.btn_trining);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_trining;
        private FunctionGraph CntGrph;
        private ZedGraph.ZedGraphControl Trining_Graph;
    }
}

