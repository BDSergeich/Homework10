using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_3
{
    public class TypeOfChange
    {
        public static readonly string TypeNew;
        public static readonly string TypeEdit;

        static TypeOfChange()
        {
            TypeNew = "Новая запись";
            TypeEdit = "Отредактировано";
        }
    }
}
