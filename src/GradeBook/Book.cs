using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach(var grade in grades)
            {
                lowGrade = Math.Min(grade, lowGrade);
                highGrade = Math.Max(grade, highGrade);
                result += grade;
            }
            result /= grades.Count;
            Console.WriteLine($"The highest grade is: {highGrade}");
            Console.WriteLine($"The lowest grade is: {lowGrade}");
            Console.WriteLine($"Average grade is: {result:N2}");
        }

        List<double> grades;
        string name;
    }
}