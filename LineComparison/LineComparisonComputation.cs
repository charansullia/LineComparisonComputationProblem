using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    class LineComparisonComputation
    {
        int x1, x2, y1, y2;
        public  LineComparisonComputation(int x1, int x2, int y1, int y2)
        {
            this.x1 = x1;
            Console.WriteLine("value of x1 is:" + x1);
            this.x2 = x2;
            Console.WriteLine("value of x2 is:" + x2);
            this.y1 = y1;
            Console.WriteLine("value of y1 is:" + y1);
            this.y2 = y2;
            Console.WriteLine("value of y2 is:" + y2);
        }
        public  double LineComputation()
        {
            double Length = Math.Sqrt((x2 - x1) + (y2 - y1));
            Console.WriteLine("Length of line is:" + Length);
            return Length;
        }
        
    }
}
