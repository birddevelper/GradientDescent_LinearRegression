using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;
using System.Threading;

namespace GradientDescent_LinearRegression
{
    public partial class frmMain : Form
    {
       
        PointPairList Data_pointsList;
        PointPairList Line_pointsList;
        Thread Training_Thread;
        double t0, t1;

        public frmMain()
        {
            InitializeComponent();
            Data_pointsList = new PointPairList();
        }

        private void btn_trining_Click(object sender, EventArgs e)
        {
            if (btn_trining.Text == "Start Training")
            {
                if (txt_alpha.Text != "" && Data_pointsList.Count > 0)
                {
                    lbl_status.Text = "Working...";
                    Training_Thread = new System.Threading.Thread(new ThreadStart(fn));
                    Training_Thread.Start();
                    btn_trining.Text = "Stop Training";
                }
                else
                {
                    MessageBox.Show("Please insert atleast one point and also enter the learning rate.");
                }
            }
            else
            {
                Training_Thread.Abort();
                btn_trining.Text = "Start Training";
            }
        }

        void fn(){
            LnrReg lr = new LnrReg(Data_pointsList);
            CntGrph.Function = lr.ErrCost;
            double[] tetas=lr.GradientDescent(Double.Parse(txt_alpha.Text));
            t0 = tetas[0];
            t1 = tetas[1];
            Line_pointsList = new PointPairList();
            Line_pointsList.Add(-100, lr.Hypothesis(tetas[0], tetas[1], -100));
            Line_pointsList.Add(100, lr.Hypothesis(tetas[0], tetas[1], 100));
            LineItem myCurve = Trining_Graph.GraphPane.AddCurve("", Line_pointsList, Color.Red, SymbolType.Diamond);
            
            MessageBox.Show("tetha0= "+t0.ToString() + " -- tetha1= " + t1.ToString());
            Trining_Graph.Invalidate();
            btn_trining.Text = "Start Training";
            lbl_status.Text = "";
            }


        private bool Trining_Graph_MouseDownEvent(ZedGraph.ZedGraphControl sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                double x, y;
                Trining_Graph.GraphPane.ReverseTransform(new PointF(e.X, e.Y), out x, out y);
                Data_pointsList.Add(new PointPair(x, y));
                Trining_Graph.GraphPane.CurveList.Clear();
                LineItem myCurve = Trining_Graph.GraphPane.AddCurve("", Data_pointsList, Color.Blue, SymbolType.Star);
                myCurve.Line.IsVisible = false;
                // MessageBox.Show(x.ToString() + " -- " + y.ToString());
                Trining_Graph.Invalidate();
            }
            return true;
        }

        private void Trining_Graph_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmMain.CheckForIllegalCrossThreadCalls = false;
            Trining_Graph.GraphPane.YAxis.Scale.Min = 0;
            Trining_Graph.GraphPane.YAxis.Scale.Max = 20;
            Trining_Graph.GraphPane.XAxis.Scale.Min = 0;
            Trining_Graph.GraphPane.XAxis.Scale.Max = 20;
        }




        private void btn_predict_Click(object sender, EventArgs e)
        {
            double x=Double.Parse(txt_x.Text);
            double y = t0 + t1 * x;
            txt_y.Text = y.ToString();
            PointPairList predicted_point = new PointPairList();
            predicted_point.Add(x, y);
            LineItem myCurve = Trining_Graph.GraphPane.AddCurve("", predicted_point, Color.Green, SymbolType.Square);
            myCurve.Line.IsVisible = false;
            // MessageBox.Show(x.ToString() + " -- " + y.ToString());
            Trining_Graph.Invalidate();


        }
        // add a single point to the graph pane. 
        private void btn_adddata_Click(object sender, EventArgs e)
        {
            double x = Double.Parse(txt_xdata.Text);
            double y = Double.Parse(txt_ydata.Text);
           // Trining_Graph.GraphPane.ReverseTransform(new PointF(e.X, e.Y), out x, out y);
            Data_pointsList.Add(new PointPair(x, y));
            Trining_Graph.GraphPane.CurveList.Clear();
            LineItem myCurve = Trining_Graph.GraphPane.AddCurve("", Data_pointsList, Color.Blue, SymbolType.Star);
            myCurve.Line.IsVisible = false;
            
            Trining_Graph.Invalidate();
        }

         // clear the points list and also graph pane
        private void btn_clear_Click(object sender, EventArgs e)
        {
             Data_pointsList.Clear();
             Trining_Graph.GraphPane.CurveList.Clear();
             Trining_Graph.Invalidate();
        }





    }
}
