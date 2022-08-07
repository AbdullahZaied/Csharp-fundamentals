using GradeBook;

var book = new Book("Akash's Grade Book");
while(true)
{
    Console.WriteLine("Enter grade or q to quit");
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }
    
    try
    {
        if(input is not null)
        {
            var grade = double.Parse(input);
            book.AddGrade(grade);
        }
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

var result = book.GetStatistics();

Console.WriteLine($"The highest grade is: {result.High}");
Console.WriteLine($"The lowest grade is: {result.Low}");
Console.WriteLine($"Average grade is: {result.Average:N2}");
Console.WriteLine($"Letter grade is: {result.Letter}");