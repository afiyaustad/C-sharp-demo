namespace IndexerDemo
{
    class abcd
    {
        public int[] _numbers = new int[5];
        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < _numbers.Length)
                {
                    return _numbers[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
            }
            set
            {
                if (index >= 0 && index < _numbers.Length)
                {
                    _numbers[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }

            }


        }
        public void displaynumbers()
        {
            for (int i = 0; i < _numbers.Length; i++)
            {
                Console.WriteLine($"Index {i}:{_numbers[i]}");
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            abcd abcdobj = new abcd();
            abcdobj[0] = 12;
            abcdobj[1] = 23;
            abcdobj[2] = 56;
            abcdobj[3] = 67;
            abcdobj[4] = 121;
            //  abcdobj[12] = 123;errror can assig also 
            // Console.WriteLine($"{abcdobj[12]}");out of bound exception//cant diaplay aso 
            Console.WriteLine($"{abcdobj[0]}");
            abcdobj.displaynumbers();

            Console.ReadLine();
        }
    }
}

