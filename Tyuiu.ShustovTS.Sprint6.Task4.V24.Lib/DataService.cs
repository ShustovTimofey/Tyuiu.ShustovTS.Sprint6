using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShustovTS.Sprint6.Task4.V24.Lib
{
    public class DataService : ISprint6Task4V24
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];
            double y;
            for (int x = startValue, count = 0; x <= stopValue; x++, count++)
            {
                y = Math.Round(((Math.Sin(x)) / (x + 1.2)) - Math.Sin(x) * 2 - 2 * x, 2);
                valueArray[count] = y;

            }
            return valueArray;
        }
    }
}
