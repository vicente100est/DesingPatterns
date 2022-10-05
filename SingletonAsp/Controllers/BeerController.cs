using DesignPatterns.Repository;
using DesignPatternsAsp.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatternsAsp.Controllers
{
    public class BeerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public BeerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<BeerViewModels> beers = from d in _unitOfWork.Beers.Get()
                                                select new BeerViewModels
                                                {
                                                    Id = d.BeerId,
                                                    Name = d.Name,
                                                    Style = d.Style
                                                };
            return View("Index", beers);
        }
    }
}
