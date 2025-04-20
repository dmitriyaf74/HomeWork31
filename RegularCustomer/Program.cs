using RegularCustomer.Classes;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace RegularCustomer
{
    internal class Program
    {

        static void RunProgram(Shop shop)
        {
            ConsoleKeyInfo keyInfo;
            int goodIndex = 0;
            int custIndex = 0;
            shop.Subscribe(new Customer($"Test Customer {++custIndex}", x => Console.WriteLine(x)));
            Console.WriteLine($"Подписался 'Test Customer {custIndex}'");

            do
            {
                keyInfo = Console.ReadKey(true);
                switch(keyInfo.Key)
                {
                    case ConsoleKey.S:
                        shop.Subscribe(new Customer($"Test Customer {++custIndex}", x => Console.WriteLine(x)));
                        Console.WriteLine($"Подписался 'Test Customer {custIndex}'");
                        break;
                    case ConsoleKey.A:
                        shop.Add(++goodIndex, $"Товар от<{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}>");
                        break;
                    case ConsoleKey.D:
                        Console.WriteLine("Укажите Id товара для удаления и нажмите Enter:");
                        foreach (var item in shop.Items)
                        {
                            Console.WriteLine($"Id={item.Id}, Name={item.Name}");
                        }
                        string skey = Console.ReadLine();
                        int key;
                        if (int.TryParse(skey, out key))
                            shop.Remove(key);
                        break;
                    case ConsoleKey.X:
                        return;
                }

            } while (true); 

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Текущая дата и время: " + DateTime.Now);
            var shop = new Shop();


            RunProgram(shop);
        }
    }
}
