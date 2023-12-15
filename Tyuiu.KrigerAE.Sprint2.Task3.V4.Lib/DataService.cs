using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KrigerAE.Sprint2.Task3.V4.Lib
{
    public class DataService : ISprint2Task3V4
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x > 1)
            {
                y = x+ Math.Pow(((x+1)/(x-1)),x);
            }
            else
            {
                if (x == 0)
                {
                    y = (x*x+Math.Cos(x*x))/(x*x-Math.Sin(x*x)+12);
                }
                else
                {
                    if ((-8 < x) && (x < 0))
                    {
                        y = Math.Pow(x-(1/x*x), x);
                    }
                    else
                    {
                        if (x<-8)
                        {
                            y = x + 10 * x - (1 / x);
                        }
                    }
                }
            }
            return Math.Round(y, 3);
        }
    }
}
