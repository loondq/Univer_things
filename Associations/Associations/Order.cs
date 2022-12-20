using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Associations
{
    public class Order
    {
        public int Number { get; set; }
        public DateTime CreationDate { get; set; }
        public bool ExpressionDelivery { get; set; }
        public string Address { get; set; }
        public Customer Customer { get; set; }
        public OrderLine Line { get; set; }
        public decimal TotalCost {get; set; }
        private static int CurrentId { get; set; } = 1;

        public Order(Customer cust, bool express, string address, decimal cost)
        {
            Address = address;
            ExpressionDelivery = express;
            Number = CurrentId++;
            Customer = cust;    
            CreationDate = DateTime.Now;
            TotalCost = cost;
        }
            
        public override string ToString()
        {
            if (ExpressionDelivery == true)
                return $"Доставка {Number} - {CreationDate:g} {Customer.FullName} заказал доставку за {TotalCost} - срочный заказ на {Address}";
            else
                return $"Доставка {Number} - {CreationDate:g} {Customer.FullName} заказал доставку за {TotalCost} - несрочный заказ на {Address}";

        }
    }
}
