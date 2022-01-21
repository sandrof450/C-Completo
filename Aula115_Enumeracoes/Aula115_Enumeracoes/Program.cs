using System;
using Aula115_Enumeracoes.Entities;
using Aula115_Enumeracoes.Entities.Enums;

namespace Aula115_Enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PedingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PedingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);
            
        }
    }
}