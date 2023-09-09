using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Model
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }
        public Customer(int id, string name, List<Order> orders)
        {
            Name = name;
            Id = id;
            Orders = orders;
        }
        public void PrintCustomerDetails()
        {
            Console.WriteLine($"Customer Id: {Id}\n" +
                $"Customer Name: {Name}\n" +
                $"Order Count: {Orders.Count}");
            int orderNumber = 1;
            foreach (var order in Orders)
            {
                Console.WriteLine($"\nOrder No. {orderNumber++}\n" +
                    $"Order Id: {order.Id}\n" +
                    $"Order Date: {order.Date}");
                Console.WriteLine("\nLineItemId  ProductId  ProductName  Quantity  UnitPrice  Discount%  UnitCostAfterDiscout  TotalLineItemCost");
                foreach (var item in order.Items)
                {
                    Product product = item.Product;
                    double totalLineItemCost = item.CalculateLineItemCost();
                    Console.WriteLine($"{item.Id}\t\t{product.Id}\t{product.Name}\t{item.Quantity}\t{product.Price}\t\t{product.DiscountPercent}%\t{product.CalculateDiscountedPrice()}\t\t\t{totalLineItemCost} ");
                }
                double totalOrderCost = order.CalculateOrderPrice();
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t-----------------------------");
                Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\tOrder Cost: {totalOrderCost}");
            }
        }
    }
}
