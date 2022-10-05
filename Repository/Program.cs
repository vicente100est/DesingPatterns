using Repository.Class;
using Repository.Models;
using Repository.UnitOfWorkPattern;
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
                var unitOfWork = new CUnirOfWork(context);

                var beers = unitOfWork.Beers;
                var beer = new Beer()
                {
                    Name = "Fuller",
                    Style = "Porter"
                };

                beers.Add(beer);

                var brands = unitOfWork.Brands;
                var brand = new Brand() { Name = "Fuller" };
                brands.Add(brand);

                unitOfWork.Save();

                //Repository
                //var beerRepository = new CRepository<Beer>(context);
                //beerRepository.Delete(4);
                ////var beer = new Beer() { Name = "Fuller", Style = "Strong Ale" };
                ////beerRepository.Add(beer);
                //beerRepository.Save();

                //foreach (var b in beerRepository.Get())
                //{
                //    Console.WriteLine($"{b.BeerId} {b.Name}");
                //}

                //var barndRepository = new CRepository<Brand>(context);

                //var brand = new Brand();
                //brand.Name = "Fuller";
                //barndRepository.Add(brand);
                //barndRepository.Save();

                //foreach (var br in barndRepository.Get())
                //{
                //    Console.WriteLine(br.Name);
                //}
            }
        }
    }
}
