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
        int _itemcount;

        public string Sku { get; set; }

        public decimal UnitPrice { get; set; }

        public int ItemCount { get; set; }

        public decimal ItemtotalCost()
        {

        }

    }
}
