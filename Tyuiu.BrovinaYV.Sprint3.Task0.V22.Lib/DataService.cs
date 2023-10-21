using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BrovinaYV.Sprint3.Task0.V22.Lib
{
    public class DataService : ISprint3Task0V22
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double p = 1;

            for (int k = startValue; k <= stopValue; k++)
            {
                p *= ((Math.Pow(value, k) + 4) * Math.Cos(value));
            }

            return Math.Round(p, 3);
        }
    }
}
