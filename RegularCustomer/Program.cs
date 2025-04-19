using RegularCustomer.Classes;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace RegularCustomer
{
    internal class Program
    {
        static public void ShowMessage(string Message)
        {
            Console.WriteLine(Message);
        }

        static void Main(string[] args)
        {
            var shop = new Shop();

            shop.Subscribe(new Customer("Test Customer 1", ShowMessage));
            shop.Add(1, "Товар 1");
            shop.Add(2, "Товар 2");

            shop.Subscribe(new Customer("Test Customer 2", ShowMessage));
            shop.Remove(1);
            shop.Add(3, "Товар 3");
            shop.Add(4, "Товар 4");
        }
    }
}
