using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearRegression
{
    class Program
    {
        static void Main(string[] args)
        {
            var xValues = new double[]
                        {
                            1990, 1991, 1992, 1993, 1994, 1995, 1996, 1997, 1998, 1999, 2000, 2001, 2002, 2003, 2004,
                            2005, 2006, 2007, 2008, 2009
                        };
            var yValues = new double[]
                        {
                            8669269, 8595500, 8484900, 8459800, 8427400, 8384700, 8340900, 8283200, 8230400, 8190900,
                            8149468, 7932984, 7845841, 7801273, 7761049, 7720000, 7679290, 7640238, 7606551,
                            7563710
                        };


            //sum of x-axis values
            var xValuesSum = xValues.Sum();
            //sum of x-axis values
            var yValuesSum = yValues.Sum();

            //mean of x-axis values
            var xMean = xValues.Average();
            //mean of y-axis values
            var yMean = yValues.Average();

            // (x- xMean)
            var _x = 0.0;
            // _x^2
            var _xPOW = 0.0;
            // _x^2 sum
            var _xPOWSUM = 0.0;
            List<object> _xrr = new List<object>();
            foreach (var xVal in xValues)
            {
                _x = xVal - xMean;
                _xrr.Add(_x);
                _xPOW = Math.Pow(_x, 2);
                _xPOWSUM += _xPOW;

            }

            List<object> _yrr = new List<object>();
            foreach (var yVal in yValues)
            {
                _yrr.Add(yVal - yMean);
            }

            var _xy = 0.0;
            for (int i = 0; i < _xrr.Count(); i++)
            {

                _xy += Convert.ToDouble(_xrr[i]) * Convert.ToDouble(_yrr[i]);
            }
            // y = b+mx
            var slope = _xy / _xPOWSUM;
            var b = yMean - (slope*(_x));

            Console.WriteLine(b);


        }
    }
}
