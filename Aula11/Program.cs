using System;
using Aula11.Entities;
using Aula11.Entities.Enums;

namespace Aula11
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order { Id = 1080, Moment = DateTime.Now, Status =  OrderStatus.PendingPayment};

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
        }
    }
}