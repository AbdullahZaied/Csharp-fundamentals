// See https://aka.ms/new-console-template for more information
if(args.Length > 0){
    Console.WriteLine($"Hello, Zadu! {args[0]}.");
}
else{
    Console.WriteLine("Hello there!");
}

var result = 0.0;
var numbers = new[] {12.7, 10.3, 9.1, 13.5};
var grades = new List<double>(){12.7, 10.3, 9.1, 13.5, 18.1};
grades.Add(56.1);

foreach(var number in grades){
    result += number;
}
result /= grades.Count;
Console.WriteLine($"Average score is {result:N2}");


foreach(double number in numbers){
    result += number;
}
Console.WriteLine($"Total Number: {result:N2}");