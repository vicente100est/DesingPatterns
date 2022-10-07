using State.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Class
{
    public class CNotDebtorState : IState
    {
        public void Action(CCustomerContext customerContext, decimal amount)
        {
            if (amount <= customerContext.Residue)
            {
                customerContext.Discount(amount);
                Console.WriteLine($"Solicitud premitida, gasta {amount} y le queda de saldo {customerContext.Residue}");
                if (customerContext.Residue <= 0)
                    customerContext.SetState(new CDebtorState());
            }
            else
            {
                Console.WriteLine($"No ajusta a lo solicitado" +
                    $"ya que tienes {customerContext.Residue}" +
                    $"y quieres gastar {amount}");
            }
        }
    }
}
