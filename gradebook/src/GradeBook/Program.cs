using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // var x = 34.1;
            // var y = 10.3;
            // var result = x + y;
            // var numbers = new[] {12.7, 10.3, 6.11, 4.1};
            var  grades = new List<double>() {12.7, 10.3, 6.11, 4.1};;
            grades.Add(56.1);
            var result = 0.0;
            foreach ( var number in grades )
            {
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The average grade is: {result:N3}");
            if ( args.Length > 0 )
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
