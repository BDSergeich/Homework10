using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoSystem
{
    public class Company : Department
    {
        public Company(string name) : base(name)
        {
            Name = $"Компания {name}";
        }

        public Company() : this("") 
        {
        }
    }
}
