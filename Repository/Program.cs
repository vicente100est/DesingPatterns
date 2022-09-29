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
                var beerRepository = new CRepository<Beer>(context);
                beerRepository.Delete(4);
                //var beer = new Beer() { Name = "Fuller", Style = "Strong Ale" };
                //beerRepository.Add(beer);
                beerRepository.Save();

                foreach (var b in beerRepository.Get())
                {
                    Console.WriteLine($"{b.BeerId} {b.Name}");
                }

                var barndRepository = new CRepository<Brand>(context);

                var brand = new Brand();
                brand.Name = "Fuller";
                barndRepository.Add(brand);
                barndRepository.Save();

                foreach (var br in barndRepository.Get())
                {
                    Console.WriteLine(br.Name);
                }
            }
        }
    }
}
