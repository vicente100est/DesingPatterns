using State.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Interface
{
    public interface IState
    {
        public void Action(CCustomerContext customerContext, decimal amount);
    }
}
