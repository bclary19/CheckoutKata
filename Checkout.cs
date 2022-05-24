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
        
        public decimal Total()
        {
            return _total;
        }

        public void Scan(Item item)
        {

        }

        public List<Item> ShowScannedItems()
        {

        }
    }
}
