namespace Module_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int num = 0;

            foreach(string s in args)
            {
                if(int.TryParse(s, out num)) sum += num;
            }
            Console.WriteLine($"Сумма = {sum}");
        }
    }
}
