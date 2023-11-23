using InheritanceInGroup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager(01, "John");
            manager.Address = "Brussel";
            manager.Age = 30;
            manager.Department = "IT";
            manager.Salary = 10000;
            manager.PrintEmployee();

            Developper developper = new Developper(02, "Rik");
            developper.Address = "Gent";
            developper.Age = 25;
            developper.Department = "IT";
            developper.Salary = 5000;
            developper.Bonus = 3000;
            developper.PrintEmployee();

            Console.ReadLine();
        }
    }
}
