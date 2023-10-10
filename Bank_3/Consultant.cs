using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Bank_3
{
    public class Consultant : IEmployee
    {
        protected string FileName;
        public ObservableCollection<Client> Clients { get; private set; }

        private List<string> passNumbers = new List<string>(); //Запомним номера паспортов, чтоб их потом вернуть

        //Конструкторы
        public Consultant(string filename)
        {
            FileName = filename;
            Clients = new ObservableCollection<Client>();
            Load();
        }

        /// <summary>
        /// Загрузка данных из файла
        /// </summary>
        public virtual void Load()
        {
            using (StreamReader sr = new StreamReader(FileName))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split('\t');
                    passNumbers.Add(fields[4]);
                    fields[4] = "************";
                    Clients.Add(new Client(fields));
                    
                }
            }
        }


        public virtual void Edit(Client client, params string[] fields)
        {
            if (fields[3] != "" && !fields[3].Contains(" ") && !client.PhoneNumber.Equals(fields[3]))
            {
                foreach (Client c in Clients)
                {
                    if (c.Id == client.Id) 
                    {
                        c.PhoneNumber = fields[3];
                        client.ChangeType = TypeOfChange.TypeEdit;
                        client.ChangingDateTime = DateTime.Now.ToString("G");
                        client.ChangedFields = FieldsNames.PhoneNumber;
                        client.Owner = Owner.Cst;

                        break; 
                    }
                }
            }
        }

        /// <summary>
        /// Сохранение данных на диск
        /// </summary>
        public virtual void Save()
        {
            File.Delete(FileName);
            for (int i = 0; i < Clients.Count; i++)
            {
                Clients[i].PassNumber = passNumbers[i];
                using (StreamWriter sw = new StreamWriter(FileName, true))
                {
                    sw.WriteLine
                        (
                        $"{Clients[i].Lastname}\t" +
                        $"{Clients[i].Firstname}\t" +
                        $"{Clients[i].Patronymic}\t" +
                        $"{Clients[i].PhoneNumber}\t" +
                        $"{Clients[i].PassNumber}\t" +
                        $"{Clients[i].ChangingDateTime}\t" +
                        $"{Clients[i].ChangedFields}\t" +
                        $"{Clients[i].ChangeType}\t" +
                        $"{Clients[i].Owner}"
                        );
                }
            }
        }

    }
}
