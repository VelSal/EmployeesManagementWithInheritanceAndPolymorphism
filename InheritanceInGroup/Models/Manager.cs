using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInGroup.Models
{
    public class Manager:Employee
    {

        public Manager(int personnalNumber, string name):base(personnalNumber, name) 
        {
            this.PersonnalNumber = personnalNumber;
            this.Name = name;
        }

        public override void PrintEmployee()
        {
            Console.WriteLine("No information can be given to the manager.");
        }
    }
}
