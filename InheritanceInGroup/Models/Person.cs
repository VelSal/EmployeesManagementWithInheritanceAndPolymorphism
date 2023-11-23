using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInGroup.Models
{
    public class Person
    {
        public int  PersonnalNumber { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public Person(int personnalNumber, string Name)
        {
            this.PersonnalNumber = personnalNumber;
            this.Name = Name;
            this.Age = 0;
            this.Address = "";
        }
    }
}
