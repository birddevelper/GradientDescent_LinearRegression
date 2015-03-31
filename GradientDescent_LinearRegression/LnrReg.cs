using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZedGraph;
namespace GradientDescent_LinearRegression
{
    class LnrReg
    {

        public PointPairList Data_pointsList;

        public LnrReg(PointPairList ppl)
        {
            Data_pointsList = ppl;
        }

        public float ErrCost(float t0,float t1){
            double sum=0;
            int Point_numbers=Data_pointsList.Count;
            for (int i = 0; i < Data_pointsList.Count; i++)
            {
                sum += Math.Pow((Hypothesis(t0, t1, Data_pointsList[i].X) - Data_pointsList[i].Y),2);
            }
            return (float)(sum / (2 * Point_numbers));
        }

        private double Deff_t0_Cost(double t0, double t1)
        {
            double sum = 0;
            int Point_numbers = Data_pointsList.Count;
            for (int i = 0; i < Data_pointsList.Count; i++)
            {
                sum += (Hypothesis(t0, t1, Data_pointsList[i].X) - Data_pointsList[i].Y);
            }
            return (float)(sum / ( Point_numbers));
        }

        private double Deff_t1_Cost(double t0, double t1)
        {
            double sum = 0;
            int Point_numbers = Data_pointsList.Count;
            for (int i = 0; i < Data_pointsList.Count; i++)
            {
                sum += (Hypothesis(t0, t1, Data_pointsList[i].X) - Data_pointsList[i].Y) * Data_pointsList[i].X;
            }
            return (float)(sum / (Point_numbers));
        }

        public double Hypothesis(double t0, double t1, double x)
        {
            return (t0 + t1 * x);
        }


        public PointPair getRandomPoint()
        {
            Random r = new Random();
            return Data_pointsList[r.Next(0, Data_pointsList.Count - 1)];

        }

        private double getSlope(PointPair p1, PointPair p2)
        {
            return (p2.Y - p1.Y) / (p2.X - p1.X);
        }

        public double[] GradientDescent(double Alpha)
        {
            PointPair p = getRandomPoint();
            double Slp = getSlope(new PointPair(0, 0), p);
            double t0=0, t1=Slp,temp0=0,temp1=Slp;
            Boolean converged=false;
            while(!converged)
            {
                temp0 = t0 - Alpha * Deff_t0_Cost(t0, t1);
                temp1 = t1 - Alpha * Deff_t1_Cost(t0, t1);
                if (t0 == temp0 && t1 == temp1) converged = true;
                t0 = temp0;
                t1 = temp1;
            }

            return new double[] {t0,t1};
        }


    }
}
