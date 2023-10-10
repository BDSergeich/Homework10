using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoSystem
{
    internal class Intern : Employee
    {
        public Intern(int depId, string name, int age) : 
            base(depId, name, age, "Интерн", 500)
        {

        }
    }
}
