using System;

Action a = () => Console.WriteLine("Hi");
a();

Action<int> a2 = n => Console.WriteLine(n * n);
a2(22);

Action<string, string> a3 = (s1, s2) => Console.WriteLine(s1 + s2);
a3("Foo", "Bar");

Func<int> f = () => 42;
Console.WriteLine(f());
 
Func<int, int> f2 = n => n * n;
Console.WriteLine(f2(34));

// Closures 

Func<int, int> calculator = CreateCalculator();
Console.WriteLine(calculator(2));


Func<int, int> CreateCalculator()
{
    var factor = 42;
    return n => n * factor;
}



BestFriends CreateCalculatorInternal()
{
    return new BestFriends { factor = 42 };
}

class BestFriends
{
    public int factor;
    public int Calculator(int n) => n * factor;
}