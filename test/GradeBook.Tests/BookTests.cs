namespace GradeBook.Tests;

public class BookTests
{
    [Fact]
    public void Test1()
    {
        //Arrange
        var book = new Book("");
        book.AddGrade(56.1);
        book.AddGrade(14.5);
        book.AddGrade(87.9);
        book.AddGrade(53.2);
        book.AddGrade(68.9);
        book.AddGrade(33.7);
        //Act
        var score = book.GetStatistics();
        //Assert
        Assert.Equal(52.38, score.Average, 2);
        Assert.Equal(14.5, score.Low, 1);
        Assert.Equal(87.9, score.High, 1);
    }
}