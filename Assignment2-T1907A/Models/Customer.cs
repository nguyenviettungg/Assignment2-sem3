using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_T1907A.Models
{
    class Customer
    {
        private string name;
        private string phone;
        private string typeContact;

        public Customer(string name, string phone, string typeContact)
        {
            this.name = name;
            this.phone = phone;
            this.typeContact = typeContact;
        }

        public string Name { get => name; set=> name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string TypeContact { get => typeContact; set => typeContact = value; }
    }
}
