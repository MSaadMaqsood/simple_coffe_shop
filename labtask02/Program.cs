using System;
using System.Collections.Generic;

namespace labtask02
{
    class Program
    {
        static void Main(string[] args)
        {
            int orderCounts = 0;
            Queue<CustomerOrder> queueCusOrders = new Queue<CustomerOrder>();
            while (true)
            {
                Console.WriteLine("Coffe Ordering System");
                Console.WriteLine("1. Add Customer Order");
                Console.WriteLine("2. View All Customer Order");
                Console.WriteLine("3. View Current Customer Order in processing");
                Console.WriteLine("4. Release Current Customer Order");
                Console.WriteLine("Select option:");
                int opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        CustomerOrder cus = new CustomerOrder();
                        orderCounts++;
                        cus.Id = orderCounts;
                        Console.WriteLine("Enter Customer Name:");
                        cus.name = Console.ReadLine();
                        Console.WriteLine("Enter Number of Cups:");
                        cus.TotalCups = Convert.ToInt32(Console.ReadLine());
                        queueCusOrders.Enqueue(cus);
                        Console.WriteLine("Order Added!");
                        break;
                    case 2:
                        if (queueCusOrders.Count > 0)
                        {
                            foreach (var ele in queueCusOrders)
                            {
                                Console.WriteLine($"Ticket Number# {ele.Id}, {ele.name} ordered {ele.TotalCups} cups.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No Order yet.");
                        }
                        break;
                    case 3:
                        if (queueCusOrders.Count > 0)
                        {
                            Console.WriteLine($"Ticket Number# {queueCusOrders.Peek().Id}, {queueCusOrders.Peek().name} ordered {queueCusOrders.Peek().TotalCups} cups.");
                        }
                        else
                        {
                            Console.WriteLine("No Order yet.");
                        }
                        break;
                    case 4:
                        if (queueCusOrders.Count > 0)
                        {
                            Console.WriteLine($"Released Ticket Number# {queueCusOrders.Peek().Id}, {queueCusOrders.Peek().name} ordered {queueCusOrders.Peek().TotalCups} cups.");
                            queueCusOrders.Dequeue();
                        }
                        else
                        {
                            Console.WriteLine("No Order yet.");
                        }
                        break;

                    default:
                        Console.WriteLine("Wrong Option.");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
    public class CustomerOrder
    {
        public int Id { get; set; }
        public int TotalCups { get; set; }

        public string name { get; set; }

    }
}
