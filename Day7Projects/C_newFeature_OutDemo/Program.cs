namespace C_newFeature_OutDemo
{
    internal class Program
    {
        public static void swap(out int x, out int y)
        {

            int temp;
            x = 10;
            y = 20;
            Console.WriteLine("\nBefore swapping");
            Console.WriteLine($"X={x} \n Y={y}");
            temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            // int x = 10; int y = 20;

            int x, y;

            //Console.WriteLine("\nBefore swapping");
            //Console.WriteLine($"X={x} \n Y={y}");
            Program.swap(out x, out y);
            Console.WriteLine("\nafter swapping");

            Console.WriteLine($"X={x} \n Y={y}");
            Console.ReadLine();
        }
    }
}
