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
       

        public frmMain()
        {
            InitializeComponent();
            Data_pointsList = new PointPairList();
        }

        private void btn_trining_Click(object sender, EventArgs e)
        {
            Thread TH = new System.Threading.Thread(new ThreadStart(fn));
            TH.Start();
        }

        void fn(){
            LnrReg lr = new LnrReg(Data_pointsList);
            CntGrph.Function = lr.ErrCost;
            double[] tetas=lr.GradientDescent(0.00005);
           // MessageBox.Show( tetas[0].ToString()+","+tetas[1].ToString());
            Line_pointsList = new PointPairList();
            Line_pointsList.Add(-100, lr.Hypothesis(tetas[0], tetas[1], -100));
            Line_pointsList.Add(100, lr.Hypothesis(tetas[0], tetas[1], 100));
            LineItem myCurve = Trining_Graph.GraphPane.AddCurve("", Line_pointsList, Color.Red, SymbolType.Diamond);
            
            // MessageBox.Show(x.ToString() + " -- " + y.ToString());
            Trining_Graph.Invalidate();
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





    }
}
