using State.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Class
{
    public class CNewState : IState
    {
        public void Action(CCustomerContext customerContext, decimal amount)
        {
            Console.WriteLine($"Se le pone dinero a su saldo {amount}");
            customerContext.Residue = amount;
            customerContext.SetState(new CNotDebtorState());
        }
    }
}
