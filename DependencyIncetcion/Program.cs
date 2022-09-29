using System;

namespace DependencyIncetcion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var beer = new Beer("Pikantus", "Erdiger");
            var drinWhithBeer = new DrinkWithBeer(10, 1, beer);
            drinWhithBeer.Build();
        }
    }
}
