using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_04
{
    enum Options
    {
        Aggregate = 1,

        MinMark = 2,

        MaximumMark = 3,

        Grade = 4
    }
    public class Student
    {
        public string Name { get; set; }
        public decimal[] Marks { get; set; } = new decimal[5];
        public static decimal AverageMarks;

        /// <summary>
        /// Calculates the average marks of the student.
        /// </summary>
        /// <returns>Average marks as a decimal value.</returns>
        public decimal CalculateAverageMarks()
        {
            decimal total = 0;
            foreach (var mark in Marks)
            {
                total += mark;
            }
            AverageMarks = total / Marks.Length;
            return AverageMarks;
        }

        /// <summary>
        /// Determines the grade based on the given marks.
        /// </summary>
        /// <param name="marks">The marks for which the grade is to be calculated.</param>
        /// <returns>A string representing the grade.</returns>
        public string CalculateGrade(decimal marks)
        {
            switch (marks)
            {
                case decimal m when m > 90:
                    return "A";
                case decimal m when m > 80:
                    return "B";
                case decimal m when m > 70:
                    return "C";
                default:
                    return "D";
            }
        }
    }
}
