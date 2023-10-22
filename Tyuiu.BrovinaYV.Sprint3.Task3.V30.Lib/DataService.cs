using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BrovinaYV.Sprint3.Task3.V30.Lib
{
    public class DataService : ISprint3Task3V30
    {
        public int GetMaxCharCount(string value, char item)
        {
            int count = 0;
            int maxCount = 0;
            char previoiusItem = '0';
            foreach (char chr in value)
            {
                if (chr==item)
                {
                    { if (previoiusItem == item)
                        { count++; } 
                else { count = 1; }
                
                if (count > maxCount)
                {
                    maxCount = count;
                }}
                   
                }
                
                else { count = 0; }

                previoiusItem = chr;

            }
            return maxCount;
        }
    }
}
