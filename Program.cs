using ShoppingApp.Model;

namespace ShoppingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders= new List<Order>
            {
                new Order(11,DateTime.Now,new List<LineItem>
                {
                    new LineItem(1,1,new Product(1, "Milkbikies", 50, 5)),
                    new LineItem(2,2,new Product(2,"Dairy Milk",100,20))
                }),
                new Order(12,DateTime.Now,new List<LineItem>
                {
                    new LineItem(3,2,new Product(3,"Fiction book",100,8)),
                    new LineItem(4,1,new Product(4,"Brush Pen",30,0))
                })
            };
            Customer customer = new Customer(1, "John", orders);
            customer.PrintCustomerDetails();
        }
    }
}