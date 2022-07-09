using System;
using System.Diagnostics;

MeasureTime(CoundToNearlyInfinity);

Console.WriteLine($"The result is {MeasureTimeFunc(CalculateSameResult)}");


static void MeasureTime(Action a)
{
    var watch = Stopwatch.StartNew();
    a();
    Console.WriteLine(watch.Elapsed);
}

static int MeasureTimeFunc(Func<int> f)
{
    var watch = Stopwatch.StartNew();
    var result = f();
    Console.WriteLine(watch.Elapsed);
    return result;
}


static void CountToNearlyInfinity()
{
    for (var i = 0; i < 1000000000; i++) ;
}

static int CalculateSameResult()
{
    // Simulate some interesting calculation
    for (var i = 0; i < 1000000000; i++) ;

    // Return the result
    return 42;
}