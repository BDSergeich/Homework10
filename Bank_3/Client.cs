using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_3
{
    public class Client
    {
        static int count;
        static Client() { count = 0; }

        private int id;
        public int Id { get { return id; } }

        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Patronymic { get; set; }

        private string phoneNumber;
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                if (value != "" && !value.Contains(" "))
                {
                    phoneNumber = value;
                }
                else if (phoneNumber == "" || phoneNumber.Contains(" ")) phoneNumber = "+7(000)0000000";

            }
        }
        public string PassNumber { get; set; }


        public string ChangingDateTime { get; set; }
        public string ChangedFields { get; set; }
        public string ChangeType { get; set; }
        public string Owner { get; set; }


        public Client(params string[] fields)
        {
            Lastname = fields[0];
            Firstname = fields[1];
            Patronymic = fields[2];
            PhoneNumber = fields[3];
            PassNumber = fields[4];
            ++count;
            id = count;
            if(fields.Length == 9)
            {
                ChangingDateTime = fields[5];
                ChangedFields = fields[6];
                ChangeType = fields[7];
                Owner = fields[8];
            }
        }

        public Client(string ln, string fn, string pat, string phone, string pass)
        {
            Lastname = ln;
            Firstname = fn;
            Patronymic = pat;
            PhoneNumber = phone;
            PassNumber = pass;
            ++count;
            id = count;
        }

    }
}
