﻿string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}

for(var i=1;i<101; i++)
{
    if ((i%3==0) && (i%5==0))
    {
        Console.WriteLine($"{i} - FizzBuzz");
    }
    else if (i%3==0)
    {
        Console.WriteLine($"{i} - Fizz");
    }
    else if (i%5==0)
    {
        Console.WriteLine($"{i} - Buzz");
    }
    else
    Console.WriteLine(i);
}