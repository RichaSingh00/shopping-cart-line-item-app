using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Model
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<LineItem> Items { get; set; }
        public Order(int id, DateTime date, List<LineItem> items)
        {
            Id = id;
            Date = date;
            Items = items;
        }
        public double CalculateOrderPrice()
        {
            double orderPrice = 0;
            foreach (var item in Items)
            {
                orderPrice += item.CalculateLineItemCost();
            }
            return orderPrice;
        }
    }
}
