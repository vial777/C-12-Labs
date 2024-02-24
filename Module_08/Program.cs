using System.Numerics;

namespace Module_08
{
    internal class Program
    {
        public static bool factorial(int n, out long fac)
        {
            fac = 1;

            try
            {
                for (int i = 1; i <= n; ++i)
                    checked
                    {
                        fac *= i;
                    }
                return true;
            }
            catch (OverflowException ex) 
            { 
                return false; 
            }
        }

        public static BigInteger factorial(int n)
        {
            BigInteger res = 1;
            for (int i = 1; i <= n; res *= i, ++i) ;
            return res;
        }
        static void Main(string[] args)
        {
            long fac;
            int num = 20;
            bool res = factorial(num, out fac);
            if (res) Console.WriteLine($"{num}! = {fac}");
            else
            {
                Console.WriteLine($"{num}! = {factorial(num)}");
            }

           
        }
    }
}
