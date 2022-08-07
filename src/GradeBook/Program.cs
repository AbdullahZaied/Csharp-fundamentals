using GradeBook;

var book = new Book("Akash's Grade Book");

book.AddGrade(56.1);
book.AddGrade(14.5);
book.AddGrade(87.9);
book.AddGrade(53.2);
book.AddGrade(68.9);
book.AddGrade(33.7);

var result = book.GetStatistics();

Console.WriteLine($"The highest grade is: {result.High}");
Console.WriteLine($"The lowest grade is: {result.Low}");
Console.WriteLine($"Average grade is: {result.Average:N2}");