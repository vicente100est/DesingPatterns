﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodTheory
{
    //Creador
    public abstract class SaleFactory
    {
        public abstract ISale GetSale();
    }

    //Concrete Creator
    public class StoreSaleFactory : SaleFactory
    {
        private decimal _extra;

        public StoreSaleFactory(decimal extra)
        {
            this._extra = extra;
        }
        public override ISale GetSale()
        {
            return new StoreSale(_extra);
        }
    }

    public class IntrernetSaleFactory : SaleFactory
    {
        private decimal _discount;

        public IntrernetSaleFactory(decimal discount)
        {
            this._discount = discount;
        }

        public override ISale GetSale()
        {
            return new InternetSale(_discount);
        }
    }

    //Concret Product
    public class StoreSale : ISale
    {
        private decimal _extra;

        public StoreSale(decimal extra)
        {
            this._extra = extra;
        }

        public void Sell(decimal total)
        {
            Console.WriteLine($"La venta en TIENDA tiene un total de {total + _extra}");
        }
    }

    public class InternetSale : ISale
    {
        private decimal _discount;
        public InternetSale(decimal discount)
        {
            this._discount = discount;
        }
        public void Sell(decimal total)
        {
            Console.WriteLine($"La venta en INTERNET tiene un total de {total - _discount}");
        }
    }

    //Product
    public interface ISale
    {
        public void Sell(decimal total);
    }
}
