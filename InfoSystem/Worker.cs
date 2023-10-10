using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoSystem
{
    internal class Worker : Employee
    {
        public Worker(int depId, string name, int age) :
            base(depId, name, age, "Рабочий", 12 * 8)
        {
        }
    }
}
