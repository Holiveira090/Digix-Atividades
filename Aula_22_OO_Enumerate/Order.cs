using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_22_OO_Enumerate
{
    public class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; }
        public Order(DateTime date, OrderStatus status, Client client)
        {
            Date = date;
            Status = status;
            Items = new List<OrderItem>();
        }
        public void addItems(OrderItem item)
        {
            Items.Add(item);
        }
        public void removeItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double total()
        {
            return Items.Sum(item => item.SubTotal());
        }
    }
}