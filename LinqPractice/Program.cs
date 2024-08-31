List<int> numbers = new List<int> { -4, -3, -2, -1, 0, 1, 2, 3, 4 };

var evenNumbers = numbers.Where(x => x % 2 == 0); 

foreach (var number in evenNumbers)
{
    Console.WriteLine(number);
}
Console.WriteLine("----------------------------");

var oddNumbers = numbers.Where(x => x % 2 != 0);

foreach (var number in oddNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("------------------------------");

var positiveNumbers = numbers.Where(x => x > 0);  

foreach (var number in positiveNumbers)
{
    Console.WriteLine(number);
}
   
Console.WriteLine("----------------------------");


var negativeNumbers = numbers.Where(x => x < 0);


foreach (var number in negativeNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("-----------------------------");

var otherNumbers = numbers.Where(x => x > 15 && x < 22);

foreach (var number in otherNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("-----------------------------");

var squaredNumber = numbers.Select(x => x * x).ToList();

foreach (var number in squaredNumber)
{
    Console.WriteLine(number);
}

Console.WriteLine("-----------------------------");


