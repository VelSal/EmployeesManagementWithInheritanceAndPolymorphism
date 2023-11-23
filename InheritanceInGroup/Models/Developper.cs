using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInGroup.Models
{
    public class Developper:Employee
    {
        public decimal Bonus { get; set; }
        public Developper(int personnalNumber, string name) : base(personnalNumber, name)
        {
            this.PersonnalNumber = personnalNumber;
            this.Name = name;
        }

        public override void PrintEmployee()
        {
            base.PrintEmployee();
            Console.WriteLine($"Bonus: {this.Bonus}");
        }
    }
}
