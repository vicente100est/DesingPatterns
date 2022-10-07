using State.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Class
{
    public class CCustomerContext
    {
        private IState _state;

        private decimal _residue;

        public decimal Residue
        {
            get
            {
                return _residue;
            }
            set
            {
                _residue = value;
            }
        }

        public CCustomerContext()
        {
            _state = new CNewState();
        }

        public void SetState(IState state) => _state = state;
        public IState GetState() => _state;

        public void Request(decimal amount) => _state.Action(this, amount);

        public void Discount(decimal amount) => _residue -= amount;
    }
}
