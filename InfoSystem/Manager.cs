using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoSystem
{
    internal class Manager : Employee
    {
        public Manager(int depId, string name, int age, double salary) : 
            base (depId, name, age, "Начальник", salary < 1300 ? 1300 : salary)
        {
        }
    }
}
