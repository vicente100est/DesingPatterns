using State.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Class
{
    public class CDebtorState : IState
    {
        public void Action(CCustomerContext customerContext, decimal amount)
        {
            Console.WriteLine("No puedes comprar, por deudor");
        }
    }
}
