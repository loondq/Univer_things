using System;
using Associations;

namespace Associations
{
    class Program
    {
        static void Main()
        {

            DeliveryService ds = new();
            ds.Init();
            bool exit = false;

            while (!exit)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("***********************************");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Выберите пункт меню:");
                Console.WriteLine("1. Просмотреть товары.");
                Console.WriteLine("2. Просмотреть покупателей");
                Console.WriteLine("3. Просмотреть корзину");
                Console.WriteLine("4. Просмотреть доставки");
                Console.WriteLine("5. Добавить заказ");
                Console.WriteLine("6. Убрать все заказы");
                Console.WriteLine("7. Заказать доставку");
                Console.WriteLine("8. Выйти");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("***********************************");
                Console.ResetColor();
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Пункт: ");
                var k = int.Parse(Console.ReadLine());
                Console.ResetColor();
                Console.Clear();

                switch (k)
                {
                    case 1:
                        {
                            ds.PrintItems();
                            break;
                        }
                    case 2:
                        {
                            ds.PrintCustomers();
                            break;
                        }
                    case 3:
                        {
                            ds.PrintOrders();
                            break;
                        }
                    case 4:
                        {
                            ds.PrintDeliveries();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Введите номер товара");
                            var itemId = int.Parse(Console.ReadLine());
                            if (!ds.ExistProduct(itemId))
                            {
                                Console.WriteLine("Такого товара нет");
                                break;
                            }
                            Console.WriteLine("Введите кол-во");
                            var count = int.Parse(Console.ReadLine());
                            ds.AddNewOrder(itemId, count);
                            break;
                        }
                    case 6:
                        {
                            ds.RemoveAllOrders();
                            Console.WriteLine("Ваша корзина очищена");
                            break;
                        }
                    case 7:
                        {
                            if (ds.NotEmptyOrders() == false)
                            {
                                Console.WriteLine("У вас еще нет заказов!");
                                break;
                            }
                            Console.WriteLine("Введите номер покупаетеля");
                            var cId = int.Parse(Console.ReadLine());
                            if (!ds.ExistCustomer(cId))
                            {
                                Console.WriteLine("Такого покупателя нет");
                                break;
                            }
                            Console.WriteLine("Доставка срочная?");
                            var request = Console.ReadLine();
                            bool express;
                            if (request == "да" || request == "ДА" || request == "Да" || request == "yes" || request == "Yes" || request == "YES")
                            {
                                express = true;
                                Console.WriteLine("К стоимости добавлено 25%");
                            }
                            else if (request == "нет" || request == "Нет" || request == "НЕТ" || request == "no" || request == "No" || request == "NO")
                                express = false;
                            else
                            {
                                Console.WriteLine("Вы не указали срочность (либо указали неправильно - напишите да/нет");
                                break;
                            }
                            Console.WriteLine("Введите адресс");
                            var address = Console.ReadLine();
                            ds.AddNewDelivery(cId, express, address);
                            ds.RemoveAllOrders();
                            break;
                        }
                    case 8:
                        {
                            exit = true;
                            break;
                        }
                    default:
                        break;

                }
            }
        }
    }
}