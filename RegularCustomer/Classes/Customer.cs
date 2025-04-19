using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularCustomer.Classes
{
    public delegate void DShowMessage(string Message);
    internal class Customer
    {
        private string _name;
        private DShowMessage _showMessage;
        public Customer(string AName, DShowMessage AShowMessage) 
        {
            _name = AName;
            _showMessage = AShowMessage;
        }


        public void OnItemChanged(string Message)
        {
            if (_showMessage is not null)
            {
                _showMessage($"{_name}: {Message}");
            }
        }
    }
}
