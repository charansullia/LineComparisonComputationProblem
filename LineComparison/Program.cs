using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            LineComparisonComputation Line1 = new LineComparisonComputation(8, 9, 6, 8);
            double Length1 = Line1.LineComputation();
            LineComparisonComputation Line2 = new LineComparisonComputation(8, 9, 6, 8);
            double Length2 = Line2.LineComputation();
            if(Length1>Length2)
            {
                Console.WriteLine("Line1 is greater than Line2");
            }
            else if(Length1==Length2)
            {
                Console.WriteLine("Lines are equal");
            }
            else
            {
                Console.WriteLine("Line2 is greater than Line1");
            }
        }
    }
}
