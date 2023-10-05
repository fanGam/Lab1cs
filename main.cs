using System.Diagnostics;

namespace Lab1cs
{
    internal class main
    {
        //Функция которая преобразует значение типа bool -> string
        private static string Show(bool z)
        {
            if (z)
            {
                return "идёт";
            }
            return "не идёт";
        }
        //Функция которая преобразует значение типа string -> bool
        public static bool ToBool(string n)
        {
            if (n.ToLower() == "yes" || 
                n.ToLower() == "пойдёт" || 
                n.ToLower() == "да")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Main(string[] args)
        {
            //Описание истории и инициализация переменных
            Console.WriteLine("Маша, Паша и Гоша хотят пойти погулять но есть проблема\n" +
                "Георг очень застенчив и только недавно познакомился с новыми друзьями\n" +
                "Вот несколько условий на которых он может пойти в кино:\n" +
                "1) Георг очень любит кино и готов идти хоть один, но он ботся идти с девочкой на романтику\n" +
                "2) Георг хочет сходить на Оппенгеймера, но ему скучно идти одному\n" +
                "3) Георг увидел трейлер нового \"Заклятия\" и боится идти без целой компании\n" +
                "Давайте узнаем куда Георг пойдёт а куда нет!\n");
            bool x, y;
            string Inp;

            //Запрос данных о Маше и попытка преобразовать ответ string -> bool
            Console.WriteLine("Может ли Маша пойти в кино?");
            Inp = Console.ReadLine();
            try
            {
                x = Convert.ToBoolean(Inp);
            }
            catch (System.FormatException)
            {
                x = ToBool(Inp);
            }

            //Запрос данных о Паше и попытка преобразовать ответ string -> bool
            Console.WriteLine("Можнт ли Паша пойти в кино?");
            Inp = Console.ReadLine();
            try
            {
                y = Convert.ToBoolean(Inp);
            }
            catch (System.FormatException)
            {
                y = ToBool(Inp);
            }

            //Создание класса a с вводом 2х переменных типа bool и вывод его полей
            Жанр a = new Жанр(x, y);
            Console.WriteLine(a);

            //Применение импликации к полям класса a
            bool z = a.Романтика();
            Console.WriteLine($"Георг {Show(z)} на романтику");
            if (z)
            {
                Process.Start(new ProcessStartInfo("https://tvvv.lordfilm.vision/356-barbi-2023.html") { UseShellExecute = true });
            }

            //Создание кпасса b который наследуется из класса a с использованием переменных типа bool
            //Применение операции ИЛИ (or)
            Фильм b = new Фильм(x, y);
            z = b.Оппенгеймер();
            Console.WriteLine($"Георг {Show(z)} на Оппенгеймера");
            if (z)
            {
                Process.Start(new ProcessStartInfo("https://oppenheimer.ru/") { UseShellExecute = true });
            }

            //Применение операции И (and)
            z = b.Заклятие();
            Console.WriteLine($"Георг {Show(z)} на \"Заклятие\"");
            if (z)
            {
                Process.Start(new ProcessStartInfo("https://lo29.lordfilm.lu/7926-film-zakljatie-2013.html") { UseShellExecute = true });
            }
        }
    }
}