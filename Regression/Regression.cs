using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regression
{
    public class Regression
    {
        double sum_x = 249.80, sum_y = 1200.60, sum_xsqrd = 4200.56, sum_xy = 20127.47, n = 15;
        double a, b, y;
        public Regression(){}

        public double Calculate(double x)
        {
            a = ((sum_y * sum_xsqrd) - (sum_x * sum_xy)) / n * ((sum_xsqrd) - (sum_x * sum_x));
            b = (n * (sum_xy)) - ((sum_x * sum_y)) / n * ((sum_xsqrd) - (sum_x * sum_x));

            y = a + (b * x);
            
            return y;
        }
    }
}
