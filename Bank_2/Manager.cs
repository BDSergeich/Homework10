using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Bank_1;

namespace Bank_2
{
    public class Manager : Consultant
    {
        public Manager(string filename) : base(filename)
        {
        }

        protected override void Load()
        {
            using (StreamReader sr = new StreamReader(FileName))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split('\t');
                    Clients.Add(new Client(line[0], line[1], line[2], line[3], line[4]));
                }
            }
        }

        public void AddClient(string lname, string fName, string patron, string phoneNum, string passNum)
        {
            Clients.Add(new Client(lname, fName, patron, phoneNum, passNum));
        }

        public override void Save()
        {
            File.Delete(FileName);
            foreach (Client c in Clients)
            {
                using (StreamWriter sw = new StreamWriter(FileName, true))
                {
                    sw.WriteLine($"{c.Lastname}\t{c.Firstname}\t{c.Patronymic}\t{c.PhoneNumber}\t{c.PassNumber}");
                }
            }
        }


    }
}
