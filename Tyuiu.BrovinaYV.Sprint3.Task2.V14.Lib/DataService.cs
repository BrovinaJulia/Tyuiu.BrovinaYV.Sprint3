using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BrovinaYV.Sprint3.Task2.V14.Lib
{
    public class DataService : ISprint3Task2V14
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multSeries = 1;
            int r = startValue;
            do
            {
                
                multSeries *= (Math.Pow(value, 3)/ Math.Pow(r, 3));
                r++; 
            } while (r <= stopValue);
           
            return Math.Round(multSeries, 3);
        }
    }
}
