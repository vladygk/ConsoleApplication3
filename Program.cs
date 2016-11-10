using System;

namespace ComparingFloat
{
    class Comparing
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            double diff = a - b;
          double difference=  Math.Abs(diff);
            if (difference < eps)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");

            }
            
 
        }
    }
}
