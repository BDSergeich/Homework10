using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bank_1
{
    public class Consultant
    {
        protected string FileName;
        public ObservableCollection<Client> Clients { get; private set;  }

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
        protected virtual void Load()
        {
            using (StreamReader sr = new StreamReader(FileName))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split('\t');
                    Clients.Add(new Client(line[0], line[1], line[2], line[3], "************"));
                    passNumbers.Add(line[4]);
                }
            }
        }


        public virtual void SetClientsData(Client client, string phoneNum)
        {
            if (phoneNum != "" && !phoneNum.Contains(" "))
            {
                foreach (Client c in Clients)
                {
                    if (c.Id == client.Id) { c.PhoneNumber = phoneNum; break; }
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
                using(StreamWriter sw = new StreamWriter(FileName, true))
                {
                    sw.WriteLine($"{Clients[i].Lastname}\t{Clients[i].Firstname}\t{Clients[i].Patronymic}\t{Clients[i].PhoneNumber}\t{Clients[i].PassNumber}");
                }
            }
        }

    }
}
