using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bank_3
{
    public interface IEmployee
    {
        void Edit(Client client, params string[] fields);
    }
}
