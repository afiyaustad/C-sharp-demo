using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumrationDemo
{
    class Program
    {

        enum weekdays { sun, mon, tue, wed = 23, thu, fri, sat };//by default intial value is 0


        static void Main(string[] args)
        {


            Console.WriteLine($"{(int)weekdays.tue}");
            Console.WriteLine($"{(int)weekdays.thu}");


            // Get the current day of the week
            DayOfWeek currentDay = DateTime.Now.DayOfWeek;

            // Convert the current day to our Weekdays enum
            weekdays today = (weekdays)currentDay;

            Console.WriteLine($"Today is: {today}");

            // Check if today is a weekday or weekend
            if (today == weekdays.sat || today == weekdays.sun)
            {
                Console.WriteLine("It's the weekend! Enjoy your day off.");
            }
            else
            {
                Console.WriteLine("It's a weekday. Time to work!");
            }
            Console.ReadLine();
        }
    }
}
