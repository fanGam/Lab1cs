using System;
namespace Lab1cs
{
    class Жанр
    {
        //Создание полей класса Жанр
        protected bool a, b;

        //Описание конструкторов на разные типы входных данных (ничего, bool, string, Жанр)
        public Жанр()
        {
            this.a = true;
            this.b = false;
        }
        public Жанр(bool x, bool y)
        {
            this.a = x;
            this.b = y;
        }
        public Жанр(string x, string y)
        {
            if (x.ToLower() == "yes" ||
                x.ToLower() == "пойдёт" ||
                x.ToLower() == "да")
            {
                this.a = true;
            }
            else
            {
                this.a = false;
            }
            if (y.ToLower() == "yes" ||
                y.ToLower() == "пойдёт" ||
                y.ToLower() == "да")
            {
                this.b = true;
            }
            else
            {
                this.b = false;
            }
        }
        public Жанр(Жанр q)
        {
            this.a = q.a;
            this.b = q.b;
        }
        //Описание метода Романтика (операция импликация)
        public bool Романтика()
        {
            return (!a || b);
        }
        //Описание внутреннего метода Show который переводит bool -> string
        private string Show(bool z)
        {
            if (z)
            {
                return "идёт";
            }
            return "не идёт";
        }
        //Описание модификатора который заменяет ToString()
        public override string ToString()
        {
            return $"\nМаша {Show(a)} в кино\nПаша {Show(b)} в кино";
        }
    }
}
