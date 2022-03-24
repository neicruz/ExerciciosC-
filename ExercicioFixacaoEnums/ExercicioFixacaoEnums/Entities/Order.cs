using System;
using ExercicioFixacaoEnums.Entities.Enums;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoEnums.Entities
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
            foreach (OrderItem varrer in Items)
            {
                sum += varrer.SubTotal();
            }
            
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("");
            sb.AppendLine("ORDER SUMMARY");
            sb.AppendLine("Order Moment: "+Moment.ToString());
            sb.AppendLine("Order Status: "+Status.ToString());
            sb.AppendLine("Client: "+Client.Name+" ("+Client.BirthDate.ToString("dd/MM/yyyy")+") - "+ Client.Email);
            sb.AppendLine("");
            sb.AppendLine("ORDER ITEMS");
            //sb.AppendLine(
            foreach (OrderItem varrer in Items) {
                sb.Append(varrer.Product.Name.ToString()+", $");
                sb.Append(varrer.Price.ToString("F2", CultureInfo.InvariantCulture) +", Quantity: ");
                sb.Append(varrer.Quantity.ToString()+" Subtotal: ");
                sb.Append(varrer.SubTotal().ToString("F2", CultureInfo.InvariantCulture)+" ");
                sb.AppendLine("");
            }
            sb.AppendLine("");
            sb.AppendLine("Total Price: " + Total().ToString("F2", CultureInfo.InvariantCulture));
            /*sb.Append(Client.BirthDate.ToString());
            sb.Append(Client.Email);*/

            /*return Moment.ToString()
                + Status
                + Client.Name
                + Client.BirthDate
                + Client.Email;*/
            return sb.ToString();
                
        }
        
    }
}
