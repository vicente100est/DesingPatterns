using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Earm
{
    public class CLocalEarn : IEarn
    {
        private decimal _porcentage;
        public CLocalEarn(decimal porcentage)
        {
            this._porcentage = porcentage;
        }
        public decimal Earn(decimal amount)
        {
            return amount * _porcentage;
        }
    }
}
