using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associations
{
    public class Item
    {
        public int Article { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public override string ToString()
        {
            return $"Товар {Article} - {Name}, цена за штуку: {UnitPrice}";
        }

    }
}
