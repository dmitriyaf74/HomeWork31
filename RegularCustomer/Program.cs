using RegularCustomer.Classes;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace RegularCustomer
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var shop = new Shop();

            shop.Subscribe(new Customer("Test Customer 1", x => Console.WriteLine(x)));
            shop.Add(1, "Товар 1");
            shop.Add(2, "Товар 2");

            shop.Subscribe(new Customer("Test Customer 2", x => Console.WriteLine(x)));
            shop.Remove(1);
            shop.Add(3, "Товар 3");
            shop.Add(4, "Товар 4");
        }
    }
}
