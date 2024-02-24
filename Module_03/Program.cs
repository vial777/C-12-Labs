namespace Module_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Voron1();
            //Voron2();
            //FibonacciNumbers();

            Console.WriteLine("Введите число:");
            int n = int.Parse(Console.ReadLine());
            long res = ffactorial(n);
            Console.WriteLine($"Факториал числа {n} = {res}");

            Console.WriteLine("Введите число:");
            n = int.Parse(Console.ReadLine());
            res = rfactorial(n);
            Console.WriteLine($"Факториал числа {n} = {res}");
        }
        //--------------------------------------------------------------
        static void Voron1()
        {
            Console.WriteLine("Введите число ворон на ветке:");
            int n = int.Parse(Console.ReadLine());
            string v;
            int n2 = n % 100;
            if (n2 >= 11 && n2 <= 14)
                v = "ворон";
            else
                switch (n % 10)
                {
                    case 1: v = "ворона"; break;
                    case 2:
                    case 3:
                    case 4: v = "вороны"; break;
                    default: v = "ворон"; break;
                }
            Console.WriteLine($"На ветке {n} {v}");
        }
        //----------------------------------------------------------------
        //switch statement
        static void Voron2()
        {
            Console.WriteLine("Введите число ворон на ветке:");
            int n = int.Parse(Console.ReadLine());
            string v;
            int n2 = n % 100;
            if (n2 >= 11 && n2 <= 14)
                v = "ворон";
            else
                v = (n % 10) switch
                {
                    1 => "ворона",
                   // >= 2 and <= 4 => "вороны",
                    2 or 3 or 4 => "вороны",
                    _ => "ворон"
                };
            Console.WriteLine($"На ветке {n} {v}");
        }
        //----------------------------------------------------------------
        static void FibonacciNumbers()
        {
            int k1 = 0, k2 = 1, k3;
            Console.WriteLine($"{k1}\n{k2}");
            while((k3 = k1 + k2) < 1000)
            {
                Console.WriteLine(k3);
                k1 = k2; k2 = k3;   
            }
        }
        //-----------------------------------------------------------------
        static long ffactorial(int n)
        {
            long res = 1;
            for(int i = 1; i <= n; i++)
            {
                res *= i;   
            }
            return res; 
        }
        //-----------------------------------------------------------------
        static long rfactorial(int n)
        {
            return n < 1 ? 1 : n * rfactorial(n - 1);
        }
        
        }
}
