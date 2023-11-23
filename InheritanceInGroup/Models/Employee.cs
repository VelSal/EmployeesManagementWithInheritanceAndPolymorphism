using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInGroup.Models
{
    public class Employee:Person
    {
        public string  Department { get; set; }
        public double Salary { get; set; }

        public Employee(int personnaleNumber, string name):base(personnaleNumber, name)
        {
            this.PersonnalNumber = personnaleNumber;
            this.Name = name;
        }

        public virtual void PrintEmployee()
        {
            Console.WriteLine("Personnal Number {0}", PersonnalNumber);
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Address: {0}", Address);
            Console.WriteLine("Department: {0}", Department);
            Console.WriteLine("Salary: {0}", Salary);
        }
    }
}
