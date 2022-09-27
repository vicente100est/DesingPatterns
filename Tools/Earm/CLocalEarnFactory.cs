using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Earm
{
    public class CLocalEarnFactory : CEarnFactory
    {
        private decimal _porcentage;
        public CLocalEarnFactory(decimal porcentage)
        {
            this._porcentage = porcentage;
        }

        public override IEarn GetEarn()
        {
            return new CLocalEarn(_porcentage);
        }
    }
}
