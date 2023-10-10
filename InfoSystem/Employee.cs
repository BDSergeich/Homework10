using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoSystem
{
    /*
        сотрудники - рабочие
        интерны
        У интернов оплата труда фиксированная и определяется при приёме (например $500 в месяц)
        У сотрудников - рабочих оплата труда почасовая и определяется при приёме (например $12 в час)
        У сотрудников - управленцев оплата труда составляет 15% от общей выплаченной суммы всем сотрудникам 
        числящихся в его отделе, но не менее $1300. 
     */

    public abstract class Employee : ICompanyUnit
    {
        protected static int count;
        static Employee() { count = 0; }

        protected int id;
        public int Id { get { return id; } }


        public int DepId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string JobTitle { get; set; }
        public double Salary { get; set; }

        public Employee(int depId, string name, int age, string jobTitle, double salary)
        {
            DepId = depId;
            JobTitle = jobTitle;
            Salary = salary;
            Name = name;
            Age = age;
            ++count;
            id = count;

        }
    }
}
