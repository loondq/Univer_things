using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associations
{
    public class DeliveryService
    {
        public List<Customer> Customers { get; set; } = new List<Customer>();
        public List<Item> Items { get; set; } = new List<Item>();
        public List<OrderLine> Orders { get; set; } = new List<OrderLine>();
        public List<Order> Deliveries { get; set; } = new List<Order>();

        public void Init()
        {
            Orders.Clear();
            Customers.Add(new Customer()
            {
                Code = 1,
                FullName = "Скворцов Олег",
                ContactPhone = "89393071522",
                Priveleged = false
            });
            Customers.Add(new Customer()
            {
                Code = 2,
                FullName = "Гайфиев Эмиль",
                ContactPhone = "89178963196",
                Priveleged = true
            });
            Customers.Add(new Customer()
            {
                Code = 3,
                FullName = "Волкова Яна",
                ContactPhone = "89053886372",
                Priveleged = true
            });
            Customers.Add(new Customer()
            {
                Code = 4,
                FullName = "Шестаков Михаил",
                ContactPhone = "89863121043",
                Priveleged = false,
            });
            Items.Add(new Item()
            {
                Name = "Роза",
                Article = 272,
                UnitPrice = 149.99m
            });
            Items.Add(new Item()
            {
                Name = "Кошелек",
                Article = 82,
                UnitPrice = 319.99m
            });
            Items.Add(new Item()
            {
                Name = "Коврик",
                Article = 975,
                UnitPrice = 719.99m
            });
            Items.Add(new Item()
            {
                Name = "Энергетик",
                Article = 59,
                UnitPrice = 99.99m
            });
        }
        public void PrintItems()
        {
            Console.WriteLine("Список товаров;");
            foreach (var item in Items)
            {
                Console.WriteLine(item);
            }
        }
        public void PrintCustomers()
        {
            Console.WriteLine("Список заказчиков;");
            foreach (var cust in Customers)
            {
                Console.WriteLine(cust);
            }
        }
        public void PrintOrders()
        {
            Console.WriteLine("Ваша корзина:");
                if (Orders.Count == 0)
                    Console.WriteLine("Заказов нет...");
            foreach (var order in Orders)
            {
                Console.WriteLine(order);
            }
        }
        public void PrintDeliveries()
        {
            Console.WriteLine("Список доставок:");
            if (Deliveries.Count == 0)
                Console.WriteLine("Доставок нет...");
            foreach (var deliv in Deliveries)
            {
                Console.WriteLine(deliv);
            }
        }
        public bool ExistCustomer(int id)
        {
            foreach (var cust in Customers)
            {
                if (cust.Code == id)
                    return true;
            }
            return false;
        }
        public bool ExistProduct(int id)
        {
            foreach (var prod in Items)
            {
                if (prod.Article == id)
                    return true;
            }
            return false;
        }
        public bool NotEmptyOrders()
        {
            if (Orders.Count >= 1)
                return true;
            return false;
        }
        public void AddNewOrder(int itemId, int count)
        {
            Item item = null;
            foreach (var it in Items)
            {           
                if (it.Article == itemId)
                    item = it;
            }
            var order = new OrderLine(item, count);
            Orders.Add(order);
            Console.WriteLine("Заказ добавлен в корзину");
            Console.WriteLine(order);
        }

        public void RemoveAllOrders()
        {   
            Orders.Clear();
        }
        public void AddNewDelivery(int custId, bool express, string address)
        {
            decimal totalCost = 0;
            Customer cust = null;

            foreach (var c in Customers)
                if (c.Code == custId)
                    cust = c;

            foreach(var order in Orders)
                totalCost += order.Cost;
            
            if (express == true)
                totalCost += (totalCost / 100 * 25);

            if (cust.Priveleged == true && totalCost >= 1500)
                totalCost -= (totalCost / 100 * 15);

            var deliv = new Order(cust, express, address, totalCost);
            Deliveries.Add(deliv);
            Console.WriteLine("Добавлена доставка:");
            Console.WriteLine(deliv);
        }
    }
}
