using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularCustomer.Classes
{

    internal class ObsCol : ObservableCollection<Item>;
    internal class Shop
    {
        public ObsCol Items = new ObsCol();

        private readonly List<Customer> Customers = new();
        public void Subscribe(Customer newSubscriber)
        {
            if (!Customers.Contains(newSubscriber))
            {
                Customers.Add(newSubscriber);
            }
        }

        public Shop() 
        {
            Items.CollectionChanged += Items_CollectionChanged;
        }

        private void NotifyCustomers(string Message)
        {
            foreach (var Customer in Customers)
            {
                Customer.OnItemChanged(Message);
            }
        }

        private void Items_CollectionChanged(
            object? sender,
            NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    NotifyCustomers($"ADDED: new items = {Formatted(e.NewItems)}");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    NotifyCustomers($"REMOVE: deleted items = {Formatted(e.OldItems)}");
                    break;
                case NotifyCollectionChangedAction.Replace:
                    NotifyCustomers($"REPLACE: from = {Formatted(e.OldItems)}, to from = {Formatted(e.NewItems)}");
                    break;
                case NotifyCollectionChangedAction.Reset:
                    NotifyCustomers("CLEAR");
                    break;
            }

        }

        private static string Formatted(IList? values)
        {
            if (values == null)
            {
                return "[]";
            }
            var a = new object[values.Count];
            values.CopyTo(a, 0);
            return $"[{string.Join(",", a)}]";
        }



        public void Add(int _Id, string _Name)
        {
            Items.Add(new Item(_Id, _Name));
        }
        public void Remove(int _Id)
        {
            var items = Items.Where(p => p.Id == _Id).ToList();
            if (items.Count() > 0)
            {
                Items.Remove(items[0]);
            }
        }
    }
}
