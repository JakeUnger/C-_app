using System;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        
          {
                Console.WriteLine(CompoundInterest(5000, 0.0251, 1, 1));
            }

            static double CompoundInterest(double principal, double interestRate, int timesPerYear, double years)
            {

                double body = 1 + (interestRate / timesPerYear);

                double exponent = timesPerYear * years;

                return principal * Math.Pow(body, exponent);




            }
        }
}
