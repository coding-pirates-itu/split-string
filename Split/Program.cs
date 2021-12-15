using System;

var input = Console.ReadLine();
var words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine($"Got {words.Length} words.");
foreach (var word in words)
{
    Console.WriteLine(word);
}
