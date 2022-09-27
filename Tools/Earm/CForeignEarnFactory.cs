using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Earm
{
    public class CForeignEarnFactory : CEarnFactory
    {
        private decimal _porcentage;
        private decimal _extra;

        public CForeignEarnFactory(decimal porcentage, decimal extra)
        {
            this._porcentage = porcentage;
            this._extra = extra;
        }
        public override IEarn GetEarn()
        {
            return new CForeignEarn(_porcentage, _extra);
        }
    }
}
