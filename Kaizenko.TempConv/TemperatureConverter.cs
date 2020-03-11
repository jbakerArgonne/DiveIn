using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaizenko.TempConv
{
    public class TemperatureConverter
    {
        public double ConvertCtoF(double tempInC)
        {
            double tempInF = tempInC * 9 / 5 + 32;
            return tempInF;
        }
    }
}
