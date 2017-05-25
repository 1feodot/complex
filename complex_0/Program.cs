using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complex_0
{
    class complex //создание класса
    {
        double rel; //реальная часть
        double vesh; // вещественная часть
        public complex(double rel = 0, double vesh = 0)//пишем конструктор
        {
            // квалификация членов класса
            this.rel = rel;
            this.vesh = vesh;
        }
        public void Show()//метод вывода на консоль
        {
            Console.WriteLine("{0}+{1}*i", rel, vesh);//результат на консоли
        }
        public static complex operator +(complex rel, complex vesh)//перегрузка оператора
        {
            return new complex(rel.rel + vesh.rel, rel.vesh + vesh.vesh);// результат суммы 
        }
        public complex mult(complex vesh)
        {
            return new complex(this.rel * vesh.rel - this.vesh * vesh.vesh, this.rel * vesh.vesh + this.vesh * vesh.rel);//результат умножения
        }
        public static complex subs(complex rel, complex vesh)
        {
            return new complex(rel.rel - vesh.rel, rel.vesh - vesh.vesh);// результат вычитания
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            complex x = new complex(2, 4);// комплексное число
            complex y = new complex(1, 3);
            complex sum = x + y;//перегрузка
            Console.Write("Сумма:  ");
            sum.Show();// 
            complex umn = x.mult(y);// метод умножения
            Console.Write("Произведение:  ");
            umn.Show();//результат умножения
            complex otn = complex.subs(x, y);// метод вычитания
            Console.Write("Разница:  ");
            otn.Show();// результат вычитания
            Console.ReadKey();// задержка консоли

        }
    }
}
