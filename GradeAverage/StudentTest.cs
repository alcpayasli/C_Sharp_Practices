using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StudentTest
{
    static void Main()
    {
        Student std1 = new Student("James Green", 92);
        Student std2 = new Student("Ashley Cole", 45);
        Student std3 = new Student("Janner Mans", 77);
        Console.WriteLine(
            $"{std1.Name}'s average {std1.Average} and lettergrade {std1.LetterGrade}");
        Console.WriteLine(
            $"{std2.Name}'s average {std2.Average} and lettergrade {std2.LetterGrade}");
        Console.WriteLine(
            $"{std3.Name}'s average {std3.Average} and lettergrade {std3.LetterGrade}");

    }
}