using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKata
{
    public class Item
    {
        string _sku;
        decimal _unitprice;
        int _itemcount = 1;

        public Item(string sku, decimal unitprice)
        {
            Sku = sku;
            UnitPrice = unitprice;
        }
        public string Sku { get; set; }

        public decimal UnitPrice { get; set; }

        public int ItemCount { get; set; }

        public decimal ItemtotalCost()
        {
            decimal totcost = Decimal.Multiply(_itemcount, _unitprice);
            totcost = decimal.Round(totcost, 2, MidpointRounding.AwayFromZero);
            return totcost;
        }

    }
}
