using System;
// using System.Collections.Generic;

namespace GradeBook
{

  class Program
  {
    static void Main(string[] args)
    {
      var book = new Book("Scott's Grade Book");
      book.GradeAdded += OnGradeAdded;

      while (true)
      {
        Console.WriteLine("Enter a grade or 'q' to exit");
        var input = Console.ReadLine();
        if (input == "q")
        {
          break;
        }
        try
        {
          var grade = double.Parse(input);
          book.AddGrade(grade);
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.Message);
        }
        // catch (FormatException ex)
        // {
        //   Console.WriteLine(ex.Message);
        // }
        finally
        {
          Console.WriteLine("***");
        }
      }
      var stats = book.GetStatistics();
      Console.WriteLine($"Lowest grade is {stats.Low}");
      Console.WriteLine($"Highest grade is {stats.High}");
      Console.WriteLine($"Average grade is {stats.Average:N1}");
      Console.WriteLine($"The letter grade is {stats.Letter}");
    }
    static void OnGradeAdded(object sender, EventArgs e)
    {
      Console.WriteLine("A grade was added");
    }
  }
}
