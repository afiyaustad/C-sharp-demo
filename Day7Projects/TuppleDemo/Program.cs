using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuppleDemo
{
    internal class Program
    {
        //Create Tupple
            public static (string Name, int Age, bool IsActive) GetPersonInfo()
        {
            return ("Jane Doe", 25, false);
        }
        static void Main(string[] args)
        {
            //create a tuple it is a variable which will have multiple types 
            (string Name, int Age, bool IsActive) person = ("John doe", 30, true);

            //accessing person data 

            Console.WriteLine($"Name:{person.Name} ,Age:{person.Age},IsActive:{person.IsActive}");
            // like this below i cannot print 

            //   Console.WriteLine($"Name:{Name} ,Age:{Age},IsActive:{IsActive}");

            // Using tuple deconstruction to unpack the tuple into variables
            var (name, age, isActive) = person;

            // Accessing the deconstructed values
            Console.WriteLine($"Deconstructed - Name: {name}, Age: {age}, IsActive: {isActive}");

            // Returning a tuple from a function
            var personInfo = GetPersonInfo();
            Console.WriteLine($"From Function - Name: {personInfo.Name}, Age: {personInfo.Age}, IsActive: {personInfo.IsActive}");

            // Deconstructing tuple returned from a function
            var (personName, personAge, personIsActive) = GetPersonInfo();
            Console.WriteLine($"From Deconstruction - Name: {personName}, Age: {personAge}, IsActive: {personIsActive}");



            Console.ReadLine();
        }
    }
}
