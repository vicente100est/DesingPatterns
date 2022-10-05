using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models.Data
{
    public partial class Brand
    {
        public Brand()
        {
            Beers = new HashSet<Beer>();
        }

        public int BrandId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Beer> Beers { get; set; }
    }
}
