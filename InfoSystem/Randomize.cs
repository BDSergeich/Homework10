using System;
using System.Linq;

namespace InfoSystem
{
    public class Randomize : Random
    {
        private static readonly string[] lnMale;
        private static readonly string[] fnMale;
        private static readonly string[] patronMale;

        private static readonly string[] lnFem;
        private static readonly string[] fnFem;
        private static readonly string[] patronFem;

        private static Random rnd;

        static Randomize()
        {
            //Мужские
            lnMale = new string[]
            {
                "Одинцов",
                "Макаров",
                "Щербаков",
                "Фокин",
                "Соколов",
                "Князев",
                "Никонов",
                "Семенов",
                "Фирсов",
                "Никитин",
                "Александров",
                "Куликов",
                "Тарасов",
                "Новиков",
                "Орлов",
                "Ковалев",
                "Егоров",
                "Афанасьев",
                "Поляков",
                "Волков",
                "Баранов",
                "Морозов",
                "Верещагин",
                "Сидоров",
                "Иванов",
                "Зайцев",
                "Булгаков",
            };
            fnMale = new string[] 
            {
                "Константин",
                "Николай",
                "Евгений",
                "Александр",
                "Дмитрий",
                "Степан",
                "Демид",
                "Лев",
                "Ярослав",
                "Матвей",
                "Марк",
                "Адам",
                "Али",
                "Денис",
                "Владимир",
                "Даниил",
                "Павел",
                "Тимур",
                "Дамир",
                "Максим",
                "Богдан",
                "Никита",
            };
            patronMale = new string[] 
            {
                "Арсентьевич",
                "Робертович",
                "Андреевич",
                "Маркович",
                "Владиславович",
                "Михайлович",
                "Кириллович",
                "Артемьевич",
                "Всеволодович",
                "Егорович",
                "Константинович",
                "Никитич",
                "Иванович",
                "Павлович",
                "Даниэльевич",
                "Романович",
                "Фёдорович",
                "Алексеевич",
                "Сергеевич",
                "Германович",
                "Васильевич",
                "Владимирович",
                "Филиппович",
                "Артёмович",
                "Ильич",
            };
            //Женские 
            lnFem = new string[] 
            {
                "Маслова", 
                "Федотова",
                "Прохорова",
                "Дегтярева",
                "Казакова",
                "Ефремова",
                "Горячева",
                "Михайлова",
                "Жданова",
                "Горшкова",
                "Кузьмина",
                "Лобанова",
                "Кочеткова",
                "Миронова",
                "Сухарева",
                "Сергеева",
                "Васильева",
                "Субботина",
                "Долгова",
                "Гусева",
                "Пахомова",
                "Смирнова",
                "Кузина",
                "Покровская",
                "Федорова",
                "Полякова",
                "Ковалева",
                "Нечаева",
                "Воронова",
                "Андрианова",
            };
            fnFem = new string[] 
            {
                "Камилла",
                "Ксения",
                "Мадина",
                "Анастасия",
                "Юлия",
                "Ульяна",
                "Серафима",
                "Алёна",
                "Полина",
                "Елизавета",
                "Василиса",
                "Мария",
                "Анна",
                "Марьям",
                "София",
                "Варвара",
                "Софья",
                "Виктория",
                "Дарья",
                "Арина",
                "Алиса",
                "Александра",
            };
            patronFem = new string[] 
            {
                "Мироновна",
                "Вадимовна",
                "Матвеевна",
                "Фёдоровна",
                "Захаровна",
                "Ибрагимовна",
                "Владимировна",
                "Константиновна",
                "Дмитриевна",
                "Павловна",
                "Георгиевна",
                "Демидовна",
                "Львовна",
                "Алексеевна",
                "Романовна",
                "Ивановна",
                "Максимовна",
                "Марковна",
                "Данииловна",
                "Александровна",
                "Артёмовна",
                "Макаровна",
                "Михайловна",
            };
         
            rnd = new Random();
        }
        /// <summary>
        /// Возвращает случайную фамилию заданного пола
        /// </summary>
        /// <param name="isMale">Пол true - мужской, false - женский</param>
        /// <returns></returns>
        public string NextLName(bool isMale) 
        {
            if(isMale) return lnMale[rnd.Next(0, lnMale.Count() - 1)]; 
            return lnFem[rnd.Next(lnFem.Count() - 1)];
        }

        /// <summary>
        /// Возвращает случайную фамилию любого пола
        /// </summary>
        /// <returns></returns>
        public string NextLName()
        {
            bool isMale = Convert.ToBoolean(rnd.Next(0, 2));
            if (isMale) return lnMale[rnd.Next(0, lnMale.Count() - 1)];
            return lnFem[rnd.Next(lnFem.Count() - 1)];
        }

        /// <summary>
        /// Возвращает случайное имя заданного пола
        /// </summary>
        /// <param name="isMale">Пол true - мужской, false - женский</param>
        /// <returns></returns>
        public string NextFName(bool isMale) 
        {
            if (isMale) return fnMale[rnd.Next(0, fnMale.Count() - 1)]; 
            return fnFem[rnd.Next(fnFem.Count() - 1)];
        }

        /// <summary>
        /// Возвращает случайное имя любого пола
        /// </summary>
        /// <returns></returns>
        public string NextFName()
        {
            bool isMale = Convert.ToBoolean(rnd.Next(0, 2));
            if (isMale) return fnMale[rnd.Next(0, fnMale.Count() - 1)];
            return fnFem[rnd.Next(fnFem.Count() - 1)];
        }

        /// <summary>
        /// Возвращает случаное отчество заданного пола
        /// </summary>
        /// <param name="isMale">Пол true - мужской, false - женский</param>
        /// <returns></returns>
        public string NextPatron(bool isMale) 
        {
            if (isMale) return patronMale[rnd.Next(0, patronMale.Count() - 1)]; 
            return patronFem[rnd.Next(0, patronFem.Count() - 1)];
        }

        /// <summary>
        /// Возвращает случайное отчество любого пола
        /// </summary>
        /// <returns></returns>
        public string NextPatron()
        {
            bool isMale = Convert.ToBoolean(rnd.Next(0, 2));
            if (isMale) return patronMale[rnd.Next(0, patronMale.Count() - 1)];
            return patronFem[rnd.Next(0, patronFem.Count() - 1)];
        }

        /// <summary>
        /// Возвращает случайное полное ФИО заданного пола
        /// </summary>
        /// <param name="isMale">Пол true - мужской, false - женский</param>
        /// <returns></returns>
        public string NextFullName(bool isMale)
        {
            return $"{NextLName(isMale)} {NextFName(isMale)} {NextPatron(isMale)}";
        }

        /// <summary>
        /// Возвращает случайное полное ФИО любого пола
        /// </summary>
        /// <returns></returns>
        public string NextFullName()
        {
            bool isMale = Convert.ToBoolean(rnd.Next(0, 2));
            return $"{NextLName(isMale)} {NextFName(isMale)} {NextPatron(isMale)}";
        }

    }
}
