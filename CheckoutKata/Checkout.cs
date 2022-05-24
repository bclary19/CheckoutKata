using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKata
{
    public class Checkout
    {
        decimal _total = 0;
        List<Item> _itemList = new List<Item>();

        public void Scan(Item item)
        {
            if(!_itemList.Contains(item))
            {
                _itemList.Add(item);
            }
            else
            {
                //item of same type has been scanned 
                int index = _itemList.FindIndex(i => i.Sku == item.Sku);
                if(index > -1)
                {
                    _itemList[index].ItemCount++;
                }

            }
        }

        public decimal calculateTotal()
        {
            decimal sum = 0;
            foreach(Item i in _itemList)
            {
                sum = Decimal.Add(i.ItemtotalCost(), sum);
            }
            _total = Decimal.Round(sum, 2, MidpointRounding.AwayFromZero);
            return _total;
        }

        public List<Item> ShowScannedItems()
        {
            return _itemList;
        }
    }
}
