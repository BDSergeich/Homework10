using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Bank_3
{
    public class Manager : Consultant, IEmployee
    {
        public Manager(string filename) : base(filename)
        {
        }

        public override void Load()
        {
            using (StreamReader sr = new StreamReader(FileName))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split('\t');
                    Clients.Add(new Client(fields));
                }
            }
        }

        public void AddClient(params string[] fields)
        {
            Client client = new Client(fields[0], fields[1], fields[2], fields[3], fields[4]);
            client.ChangedFields = "Все";
            client.ChangeType = TypeOfChange.TypeNew;
            client.Owner = Owner.Mng;
            client.ChangingDateTime = DateTime.Now.ToString("G");
            Clients.Add(client);
        }

        public override void Save()
        {
            File.Delete(FileName);
            foreach (Client c in Clients)
            {
                using (StreamWriter sw = new StreamWriter(FileName, true))
                {
                    sw.WriteLine
                        (
                        $"{c.Lastname}\t" +
                        $"{c.Firstname}\t" +
                        $"{c.Patronymic}\t" +
                        $"{c.PhoneNumber}\t" +
                        $"{c.PassNumber}\t" +
                        $"{c.ChangingDateTime}\t" +
                        $"{c.ChangedFields}\t" +
                        $"{c.ChangeType}\t" +
                        $"{c.Owner}"
                        );
                }
            }
        }

        public override void Edit(Client client, params string[] fields)
        {
            bool isEdited = false;
            string changedfields = "";
            if (fields[0] != "" && !client.Lastname.Equals(fields[0]))
            {
                changedfields = $"{FieldsNames.LastName}\n";
                client.Lastname = fields[0];
                isEdited = true;
            }

            if (fields[1] != "" && !client.Firstname.Equals(fields[1]))
            {
                changedfields = $"{changedfields} {FieldsNames.FirstName}\n";
                client.Firstname = fields[1];
                isEdited = true;
            }

            if (fields[2] != "" && !client.Patronymic.Equals(fields[2]))
            {
                changedfields = $"{changedfields} {FieldsNames.Patronymic}\n";
                client.Patronymic = fields[2];
                isEdited = true;
            }

            if (fields[3] != "" && !client.PhoneNumber.Equals(fields[3]))
            {
                changedfields = $"{changedfields} {FieldsNames.PhoneNumber}\n";
                client.PhoneNumber = fields[3];
                isEdited = true;
            }

            if (fields[4] != "" && !client.PassNumber.Equals(fields[4]))
            {
                changedfields = $"{changedfields} {FieldsNames.PassNumber}\n";
                client.PassNumber = fields[4];
                isEdited = true;
            }

            if (isEdited)
            {
                client.ChangingDateTime = DateTime.Now.ToString("G");
                client.ChangeType = TypeOfChange.TypeEdit;
                client.Owner = Owner.Mng;
                client.ChangedFields = changedfields;
            }
        }

    }
}
