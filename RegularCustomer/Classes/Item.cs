using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularCustomer.Classes
{
    internal class Item
    {
        public Item(int AId, string AName) 
        { 
            Id = AId;
            Name = AName;   
        }
        public int? Id { get; set; }
        public string? Name { get; set; }

        public override string ToString()
        {
            // Формируем строку, представляющую объект
            return $"Товар {{ Код = {Id}, Наименование = {Name} }}";
        }
    }
}
