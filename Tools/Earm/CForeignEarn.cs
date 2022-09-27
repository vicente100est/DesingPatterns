using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Earm
{
    public class CForeignEarn : IEarn
    {
        private decimal _porcentage;
        private decimal _extra;

        public CForeignEarn(decimal porcentage, decimal extra)
        {
            this._porcentage = porcentage;
            this._extra = extra;
        }

        public decimal Earn(decimal amount)
        {
            return (amount * _porcentage) + _extra;
        }
    }
}
