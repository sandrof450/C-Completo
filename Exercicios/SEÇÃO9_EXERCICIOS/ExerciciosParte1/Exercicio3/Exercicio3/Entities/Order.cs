using Exercicio3.Entities.Enums;
using System.Globalization;
using System.Text;


namespace Exercicio3.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double sum = 0;
            foreach(OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            double sum = 0;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("ORDER SUMARY:");
            sb.AppendLine($"Order moment: {Moment}");
            sb.AppendLine($"Order status: {Status}");
            sb.AppendLine($"Client: {Client.Name} ({Client.BirthDate.ToString("dd/MM/yyyy")}) - {Client.Email}");
            sb.AppendLine("Order items:");
            foreach(OrderItem item in Items)
            {
                sb.AppendLine($"{item.Product.Name}, ${item.Price.ToString("F2", CultureInfo.InvariantCulture)}, Quantity: {item.Quantity}, subtotal: ${item.SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");
                sum += item.SubTotal();
            }
            sb.AppendLine($"Total price: ${sum.ToString("F2", CultureInfo.InvariantCulture)}");

            return sb.ToString();    
        }
    }
}
