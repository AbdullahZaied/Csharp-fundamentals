// See https://aka.ms/new-console-template for more information
if(args.Length > 0){
    Console.WriteLine($"Hello, Zadu! {args[0]}.");
}
else{
    Console.WriteLine("Hello there!");
}

var numbers = new[] {12.7, 10.3, 9.1, 13.5};
var result = 0.0;
foreach(double number in numbers){
    result += number;
}
Console.WriteLine(result);