using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class CContext
    {
        private IStrategy _strategy;

        public IStrategy strategy1
        {
            set
            {
                _strategy = value;
            }
        }

        public CContext(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void Run()
        {
            _strategy.Run();
        }
    }
}
