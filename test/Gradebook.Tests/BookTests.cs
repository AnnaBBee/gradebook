using System;
using Xunit;

namespace GradeBook.Tests
{
  public class BookTests
  {
    [Fact]
    public void BookCalculatesAnAverageGrade()
    {
      var book = new Book("");
      book.AddGrade(89.1);
      book.AddGrade(60.2);
      book.AddGrade(75.2);
      var result = book.GetStatistics();

      Assert.Equal(74.8, result.Average, 1);
      Assert.Equal(89.1, result.High, 1);
      Assert.Equal(60.2, result.Low, 1);
    }
  }
}
