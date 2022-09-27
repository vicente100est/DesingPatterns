﻿using System;

namespace FactoryMethodTheory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SaleFactory storeSaleFactory = new StoreSaleFactory(10);
            SaleFactory internetSaleFactory = new IntrernetSaleFactory(10);

            ISale sale1 = storeSaleFactory.GetSale();
            sale1.Sell(15);

            ISale sale2 = internetSaleFactory.GetSale();
            sale2.Sell(15);
        }
    }
}
