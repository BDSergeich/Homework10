using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_3
{
    public class FieldsNames
    {
        public static readonly string LastName;
        public static readonly string FirstName;
        public static readonly string Patronymic;
        public static readonly string PhoneNumber;
        public static readonly string PassNumber;

        static FieldsNames()
        {
        LastName = "Фамилия";
        FirstName = "Имя";
        Patronymic = "Отчество";
        PhoneNumber = "Номер телефона";
        PassNumber = "Номер паспорта";

    }

}
}
