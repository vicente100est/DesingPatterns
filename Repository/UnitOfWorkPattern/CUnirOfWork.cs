using Repository.Class;
using Repository.Interface;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.UnitOfWorkPattern
{
    public class CUnirOfWork : IUnitOfWork
    {
        private DesignPatternsContext _context;
        public IRepository<Beer> _beers;
        public IRepository<Brand> _brands;

        public CUnirOfWork(DesignPatternsContext context)
        {
            this._context = context;
        }

        public IRepository<Beer> Beers
        {
            get
            {
                return _beers == null ?
                    _beers = new CRepository<Beer>(_context) :
                    _beers;
            }
        }

        public IRepository<Brand> Brands
        {
            get
            {
                return _brands == null ?
                    _brands = new CRepository<Brand>(_context) :
                    _brands;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
