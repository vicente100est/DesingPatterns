using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyIncetcion
{
    public class Beer
    {
        private string _name;
        private string _brand;

        public Beer(string name, string brand)
        {
            this._name = name;
            this._brand = brand;
        }

        public string Name
        {
            get { return _name; }
        }
    }
}
