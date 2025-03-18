using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace AttributeCunsumeDemo
{
    public class Calaculator
    {
        [AddNumbers(5, 3)]
        public void operation()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Type calctype = typeof(Calaculator);
            MethodInfo method = calctype.GetMethod(nameof(Calaculator.operation));
            AddNumbers attribute = (AddNumbers)method.GetCustomAttribute(typeof(AddNumbers));
            if (attribute != null)
            {
                int result = attribute.Add();
                int result2 = attribute.Substract();
                Console.WriteLine($"The result of addition is {result}");
                Console.WriteLine($"The result of substraction is {result2}");

            }
            Console.ReadLine();
        }
    }
}
