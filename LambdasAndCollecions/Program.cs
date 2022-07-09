using System;
using System.Collections.Generic;

var heros = new List<Hero>
{
    new("Waide", "Wilson", "Deadpool", false),
    new(string.Empty, string.Empty, "Homelander", true),
    new("Bruce", "Wayne", "Batman", true),
    new(string.Empty, string.Empty, "Superman", true)
};


var result = Filter(heros, h => string.IsNullOrEmpty(h.LastName));
var heroesWhoCanFly = string.Join(", ", result);
Console.WriteLine(heroesWhoCanFly);

Filter(new[] { "Superman", "Batman", "Homelander" }, h => h.StartsWith("H"));

IEnumerable<T> Filter<T>(IEnumerable<T> items, Func<T, bool> f)
{
    foreach (var item in items)
    {
        if (f(item))
        {
            yield return item;
        }
    }
}


record Hero(string FirstName, string LastName, string HeroName, bool CanFly);

