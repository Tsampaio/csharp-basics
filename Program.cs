// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
namespace Grade_Book
{ 

    class Program
    {
        static void Main(string[] args)
        {
            //Book book2 = new Book();
            //book2.AddGrade(90.1);

            var book = new Book("Telmo grade book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);

            List<double> grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);

            //var numbers = new[] { 12.7, 10.3, 6.11, 4.1 };
            //var result = numbers[0];
            //result += numbers[1];
            //result += numbers[2];

            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach (var number in grades)
            {
                //if(number > highGrade)
                //{
                //    highGrade = number;
                //}

                lowGrade = Math.Min(number, lowGrade);
                highGrade = Math.Max(number, highGrade);

                result += number;
            }

            result /= grades.Count;
            Console.WriteLine($"The lowest grade is {lowGrade}");
            Console.WriteLine($"The highest grade is {highGrade}");
            Console.WriteLine($"The average grade is {result:N3}");
        }
    }
}