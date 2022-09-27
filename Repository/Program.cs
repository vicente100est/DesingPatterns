using Repository.Class;
using Repository.Models;
using System;
using System.Linq;

namespace Repository
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (DesignPatternsContext context = new DesignPatternsContext())
            {
                CBeer beerRepository = new CBeer(context);
                Beer beer = new Beer();

                beer.Name = "Corona";
                beer.Style = "Pilsner";

                beerRepository.Add(beer);
                beerRepository.Save();

                foreach (var b in beerRepository.Get())
                {
                    Console.WriteLine(b.Name);
                }
            }
        }
    }
}
