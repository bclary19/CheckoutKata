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
        IDictionary<int, decimal> _quantityoffers = new Dictionary<int, decimal>();

        public Item(string sku, decimal unitprice)
        {
            Sku = sku;
            UnitPrice = unitprice;
        }
        public string Sku 
        { 
            get { return _sku; } 
            set { _sku = value; }
        }

        public decimal UnitPrice 
        {
            get { return _unitprice; }
            set { _unitprice = value; }
        }

        public int ItemCount 
        {
            get { return _itemcount; }
            set { _itemcount = value; }
        }

        public void AddQuantityOffers(int count,decimal price)
        {
            _quantityoffers.Add(count, price);
        }

        public decimal ItemtotalCost()
        {
            decimal totcost;

            if (_quantityoffers.ContainsKey(ItemCount))
            {
                totcost = _quantityoffers[ItemCount];
            }
            else
            {
                totcost = Decimal.Multiply(_itemcount, _unitprice);
            }

            totcost = decimal.Round(totcost, 2, MidpointRounding.AwayFromZero);
            return totcost;
        }

    }
}
