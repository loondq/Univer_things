using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Associations
{
    public class OrderLine
    {
        public int Quantity { get; set; }
        public Item Item { get; set; }
        public decimal Cost { get; set; }

        public OrderLine(Item item, int count)
        {
            Quantity = count;
            Item = item;
            Cost = item.UnitPrice * count;
        }
        public override string ToString()
        {
            return $"Заказ: {Item.Name} - кол-во: {Quantity}, цена - {Cost}";
        }
    }
}
