using System;
// using System.Collections.Generic;

namespace GradeBook
{

  class Program
  {
    static void Main(string[] args)
    {
      var book = new Book("Scott's Grade Book");
      book.AddGrade(89.1);
      book.AddGrade(22.7);
      book.AddGrade(40.5);
      var stats = book.GetStatistics();
      Console.WriteLine($"Lowest grade is {stats.Low}");
      Console.WriteLine($"Highest grade is {stats.High}");
      Console.WriteLine($"Average grade is {stats.Average:N1}");
    }
  }

}
