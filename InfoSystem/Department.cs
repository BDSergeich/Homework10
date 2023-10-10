using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoSystem
{
    public class Department : ICompanyUnit
    {
        protected static int count;
        static Department() { count = 0; }

        protected int id;
        public int Id { get { return id; } }
        public string Name { get; set; }
        public ObservableCollection<ICompanyUnit> CUnits { get; set; }

        public Department(string name)
        {
            CUnits = new ObservableCollection<ICompanyUnit>();
            ++count;
            id = count;
            Name = $"Департамент {id} {name}";
        }

        public Department() : this("") 
        {
        }

        public void AddUnit(ICompanyUnit unit)
        {
            if (unit is Employee)
            {
                (unit as Employee).DepId = id;
                if ((unit is Manager && !ContainsManager()) || !(unit is Manager))
                {
                    CUnits.Add(unit);
                }
            }
            else
            {
                CUnits.Add(unit);
            }
        }

        protected double GetManagerSalary()
        {
            double salary = 0;
            foreach(var unit in CUnits)
            {
                if (unit is Employee && !(unit is Manager))
                {
                    salary += (unit as Employee).Salary * 0.15;
                }
            }
            return salary < 1300 ? 1300 : salary;
        }

        protected bool ContainsManager()
        {
            foreach (var unit in CUnits) { if (unit is Manager) return true; }
            return false;
        }
    }
}
