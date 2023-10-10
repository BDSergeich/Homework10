using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_3
{
    public class Owner
    {
        public static readonly string Cst;
        public static readonly string Mng;

        static Owner()
        {
            Cst = "Консультант";
            Mng = "Менеджер";
        }
    }
}
