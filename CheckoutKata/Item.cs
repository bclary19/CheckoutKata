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

            //check if quantity is multiple of a offers key
            int multiplechk = CheckForMultipleOffers();
            if (multiplechk > 0)
            {
                int sum = ItemCount / multiplechk;
                totcost = Decimal.Multiply(sum, _quantityoffers[multiplechk]);
            }
            else if (_quantityoffers.ContainsKey(ItemCount))
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

        //Check if the total amount of items is a multiple of any special offers
        // return the key for the offer if it is, 0 if there isn't
        public int CheckForMultipleOffers()
        {
            int retvalue = 0;

            foreach(var entry in _quantityoffers)
            {
                if (ItemCount > entry.Key)
                {
                    if (ItemCount % entry.Key == 0) { retvalue = entry.Key; }
                }
            }

            return retvalue;
        }
    }
}
