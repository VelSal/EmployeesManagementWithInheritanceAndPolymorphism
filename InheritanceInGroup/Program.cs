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
            List<Person> people = new List<Person>();
            
            Person manager = new Manager(01, "John");
            manager.Address = "Brussel";
            manager.Age = 30;
            ((Manager)manager).Department = "IT";       //Casting from Person to Manager
            ((Manager)manager).Salary = 10000;

            Person developper = new Developper(02, "Rik");
            developper.Address = "Gent";
            developper.Age = 25;
            ((Developper)developper).Department = "IT";
            ((Developper)developper).Salary = 5000;
            ((Developper)developper).Bonus = 3000;

            people.Add(developper); 
            people.Add(manager);

            foreach (var person in people)
            {
                if (person is Manager m)
                {
                    m.PrintEmployee();
                }
                else if (person is Developper d )
                {
                    d.PrintEmployee();
                }
            }

            Console.ReadLine();
        }
    }
}
