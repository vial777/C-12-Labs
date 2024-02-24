using System.Reflection;

namespace Module_07
{
    public class Example 
    {
        ~Example()
        {
            Console.WriteLine("class Example");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "12345";
            Type type = str.GetType();

            MethodInfo[] minf = type.GetMethods();
            foreach (MethodInfo mi in minf) 
            {
                Console.WriteLine($"{mi.ReturnType.Name} {mi.Name}()");
            }

            int num = 48;
            bool flag = Convert.ToBoolean(num);
            Console.WriteLine(flag);

            Example example = new Example();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Thread.Sleep(1000);
            Console.WriteLine("-------End class Program----------");
        }
    }
}
